using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssetManager
{
    public partial class frmEditContract : Form
    {
        frmControlContract _owner;
        String _mode;
        int _id;
        Service obj = new Service();

        DataTable dtContractDate = new DataTable("ContractDate");
        DataTable dtContractAlert = new DataTable("ContractAlert");   //1.0.3
        DataTable dtContractMember = new DataTable("ContractMember");
        DataTable dtStatus = new DataTable("Status");
        LogWriter Log = new LogWriter(DateTime.Now.ToString() + "\r\n" + "เปิดหน้า Form");

        public frmEditContract(frmControlContract owner, String mode, int id)
        {
            _owner = owner;
            _mode = mode;
            _id = id;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEditContract_FormClosing);
            InitializeComponent();
            InitForm();
        }

        private void frmEditContract_FormClosing(object sender, FormClosingEventArgs e) {
            _owner.PerformRefresh();
        }

        private void InitForm()
        {
            BindContractType();

            BindContractDateGrid();
            BindContractMemberGrid();
            BindAssetType();
            BindTextValue();

            if (_mode.Equals("New"))
            {
                this.Text = "เพิ่มสัญญาใหม่ (New)";
                rdStatus1.Checked = true;
            }
            else if (_mode.Equals("View"))
            {
                this.Text = "ตรวจสอบสัญญา (View)";
                SetDatatoForm();
                DisableControl(true);
                btnSave.Enabled = false;
            }
            else if (_mode.Equals("Edit"))
            {
                this.Text = "แก้ไขสัญญา (Edit)";
                SetDatatoForm();
            }
        }

        private void SetDatatoForm()
        {
            DataTable dtContract = new DataTable("Contract");
            DataTable dtContractDate = new DataTable("ContractDate");
            DataTable dtContractAlert = new DataTable("ContractAlert");
            DataTable dtContractMember = new DataTable("ContractMember");

            dtContract = obj.getContractbyId(_id);
            dtContractDate = obj.getContractDatebyId(_id);
            dtContractAlert = obj.getContractAlertbyId(_id);
            dtContractMember = obj.getContractMemberbyId(_id);

            lblContractID.Text = dtContract.Rows[0]["ID"].ToString();
            if (Convert.ToInt32(dtContract.Rows[0]["StatusID"]) == 1)
            {
                rdStatus1.Checked = true;
                rdStatus2.Checked = false;
            }
            else
            {
                rdStatus1.Checked = false;
                rdStatus2.Checked = true;
            }

            string[] strTitle = dtContract.Rows[0]["Title"].ToString().Split(new char[] { ' ' }, 2);
            cboAssetType.SelectedIndex = cboAssetType.FindStringExact(strTitle.First());
            if (cboAssetType.FindStringExact(strTitle.First()) < 0)
                txtTitle.Text = dtContract.Rows[0]["Title"].ToString();
            else
                txtTitle.Text = strTitle.Last();

            txtValue.Text = dtContract.Rows[0]["Value"].ToString();

            cboContractType.SelectedValue = Convert.ToInt32(dtContract.Rows[0]["ContractTypeId"]);

            dtpContractDate.Value = (dtContract.Rows[0]["ContractDate"].ToString().Equals("")) ? dtpContractDate.MinDate : (DateTime)dtContract.Rows[0]["ContractDate"];
            if (dtpContractDate.Value == dtpContractDate.MinDate)
            {
                //if user ไม่กรอก ให้โชว์กล่องว่าง
                txtContractDate.Visible = true;
                txtContractDate.Enabled = false;
            }

            //Bind the grid control to the data source
            gridControlDate.DataSource = dtContractDate;
            gridControlDate.ForceInitialize();

            //1.0.3
            //Bind the grid control to the data source
            gridControlAlert.DataSource = dtContractAlert;
            gridControlAlert.ForceInitialize();

            //Bind the grid control to the data source
            gridControlMember.DataSource = dtContractMember;
            gridControlMember.ForceInitialize();
        }

        

        #region Bind Control
        private void BindContractDateGrid()
        {
            dtContractDate.Columns.Add("No", typeof(Int32));
            dtContractDate.Columns.Add("RedeemDate", typeof(DateTime));
            dtContractDate.Columns.Add("SignDate", typeof(DateTime));
            gridControlDate.DataSource = dtContractDate;

            dtContractAlert.Columns.Add("No", typeof(Int32));
            dtContractAlert.Columns.Add("AlertType", typeof(string));
            dtContractAlert.Columns.Add("AlertDate", typeof(DateTime));
            gridControlAlert.DataSource = dtContractAlert;

            dtContractMember.Columns.Add("MemberId", typeof(Int32));
            dtContractMember.Columns.Add("Value", typeof(Decimal));
            gridControlMember.DataSource = dtContractMember;
        }

        private void BindContractMemberGrid()
        {
            DataTable dtMember = new DataTable("Member");
            DataSet dsCombo = new DataSet();
            dtMember = obj.getAllMember();
            dsCombo.Tables.Add(dtMember);

            RepositoryItemLookUpEdit LookupMember = new RepositoryItemLookUpEdit();
            LookupMember.NullText = "<--กรุณาเพิ่มรายชื่อ-->";
            LookupMember.DisplayMember = "MemberName";
            LookupMember.ValueMember = "MemberId";
            LookupMember.Columns.Add(new LookUpColumnInfo("MemberName", 0, "รายชื่อ"));
            LookupMember.DataSource = dtMember;
            gridView2.Columns["MemberId"].ColumnEdit = LookupMember;
        }

        private void BindContractType()
        {
            dtStatus.Columns.Add("CONTRACTTYPEID", typeof(Int32));
            dtStatus.Columns.Add("CONTRACTTYPENAME", typeof(Decimal));
            cboContractType.DataSource = obj.getContractType();
            cboContractType.ValueMember = "CONTRACTTYPEID";
            cboContractType.DisplayMember = "CONTRACTTYPENAME";
            cboContractType.SelectedValue = 0;
        }

        private void BindAssetType()
        {
            dtStatus.Columns.Add("ASSETTYPE", typeof(string));
            cboAssetType.DataSource = obj.getAssetType();
            cboAssetType.ValueMember = "ASSETTYPE";
            cboAssetType.DisplayMember = "ASSETTYPE";
            cboAssetType.SelectedValue = 0;
        }

        private void BindTextValue()
        {
            txtValue.Properties.Mask.MaskType = MaskType.Numeric;
            txtValue.Properties.Mask.EditMask = "N0";
            txtValue.Properties.Mask.UseMaskAsDisplayFormat = true;
        }

        private void DisableControl(bool isDisableAll)
        {
            if (isDisableAll)
            {
                rdStatus1.Enabled = false;
                rdStatus2.Enabled = false;
            }

            cboAssetType.Enabled = false;
            txtTitle.ReadOnly = true;
            txtValue.ReadOnly = true;
            cboContractType.Enabled = false;
            dtpContractDate.Enabled = false;

            gridView1.OptionsBehavior.Editable = false;
            gridView2.OptionsBehavior.Editable = false;
            gridView3.OptionsBehavior.Editable = false;
        }

        private void EnableControl()
        {
            rdStatus1.Enabled = true;
            rdStatus2.Enabled = true;
            cboAssetType.Enabled = true;
            txtTitle.ReadOnly = false;
            txtValue.ReadOnly = false;
            cboContractType.Enabled = true;
            dtpContractDate.Enabled = true;

            gridView1.OptionsBehavior.Editable = true;
            gridView2.OptionsBehavior.Editable = true;
            gridView3.OptionsBehavior.Editable = true;
        }
        #endregion

        #region Button Event
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                bool resultContract;
                int signCount = 0;
                int alertCount = 0;

                if (!validateForm()) return;

                int ID = _mode == "Edit" ? _id : Convert.ToInt32(obj.getLastContractID().Rows[0][0]) + 1;
                Contract contract = new Contract();
                ContractDate contractDate = new ContractDate();
                ContractAlert contractAlert = new ContractAlert();    //1.0.3
                ContractMember contractMember = new ContractMember();

                if (_mode == "Edit")
                {
                    obj.deleteContractDate(ID);
                    obj.deleteContractAlert(ID); //1.0.3
                    obj.deleteContractMember(ID);
                }

                //Insert Contract Date
                DataTable dtContractDate = new DataTable();
                dtContractDate = (DataTable)gridControlDate.DataSource;
                DataView dv = dtContractDate.DefaultView;
                dv.Sort = "RedeemDate";
                dtContractDate = dv.ToTable();
                foreach (DataRow row in dtContractDate.Rows) // Loop over the rows.
                {
                    contractDate.ContractID = ID;
                    //contractDate.No = Convert.ToInt32(row["No"]);
                    contractDate.No = signCount + 1;
                    if (row["RedeemDate"].ToString().Equals(""))
                    {
                        contractDate.RedeemDate = null;
                    }
                    else
                    {
                        contractDate.RedeemDate = Convert.ToDateTime(row["RedeemDate"]);
                    }
                    if (row["SignDate"].ToString().Equals(""))
                    {
                        contractDate.SignDate = null;
                    }
                    else
                    {
                        contractDate.SignDate = Convert.ToDateTime(row["SignDate"]);
                    }
                    signCount++;
                    bool resultContractDate = obj.InsertContractDate(contractDate);
                }

                //Insert Contract Member
                DataTable dtContractMember = new DataTable();
                dtContractMember = (DataTable)gridControlMember.DataSource;
                foreach (DataRow row in dtContractMember.Rows) // Loop over the rows.
                {
                    contractMember.ContractID = ID;
                    contractMember.MemberID = Convert.ToInt32(row["MemberId"]);
                    contractMember.Value = Convert.ToDecimal(row["Value"]);
                    bool resultContractMember = obj.InsertContractMember(contractMember);
                }

                //1.0.3
                //Insert Contract Alert
                DataTable dtContractAlert = new DataTable();
                dtContractAlert = (DataTable)gridControlAlert.DataSource;
                DataView dv2 = dtContractAlert.DefaultView;
                dv2.Sort = "AlertDate";
                dtContractAlert = dv2.ToTable();
                foreach (DataRow row in dtContractAlert.Rows) // Loop over the rows.
                {
                    contractAlert.ContractID = ID;
                    //contractDate.No = Convert.ToInt32(row["No"]);
                    contractAlert.No = alertCount + 1;
                    contractAlert.AlertType = row["AlertType"].ToString();
   
                    if (row["AlertDate"].ToString().Equals(""))
                    { 
                        contractAlert.AlertDate = null;
                    }
                    else
                    {
                        contractAlert.AlertDate = Convert.ToDateTime(row["AlertDate"]);
                    }
                    alertCount++;
                    bool resultContractDate = obj.InsertContractAlert(contractAlert);
                }

                if (_mode == "Edit")
                {
                    //Update Contract            
                    contract.ContractID = ID;
                    contract.Title = cboAssetType.Text.ToString() + " " + txtTitle.Text.ToString();
                    contract.StatusID = Convert.ToInt32(rdStatus1.Checked ? 1 : 2);
                    contract.ContracTypeID = Convert.ToInt32(cboContractType.SelectedValue);
                    contract.TotalValue = Convert.ToDecimal(txtValue.Text);
                    contract.ContractDate = ((dtpContractDate.Value != DateTime.MinValue) ? (DateTime?)dtpContractDate.Value : null);
                    contract.SignCount = signCount;
                    resultContract = obj.UpdateContract(contract);

                    if (resultContract)
                    {
                        obj.dbFullBackUp();
                        this.Close();
                        MessageBox.Show("แก้ไขเรียบร้อย", "ผลการบันทึก", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //System.Diagnostics.Process.Start("Chrome.exe", "https://www.google.com/calendar/");
                    }
                    else
                    {
                        MessageBox.Show("พบข้อบกพร่อง ไม่สามารถแก้ไขได้", "ผลการบันทึก", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (_mode == "New")
                {
                    //Insert Contract            
                    contract.ContractID = ID;
                    contract.Title = cboAssetType.Text.ToString() + " " + txtTitle.Text.ToString();
                    contract.StatusID = Convert.ToInt32(rdStatus1.Checked ? 1 : 2);
                    contract.ContracTypeID = Convert.ToInt32(cboContractType.SelectedValue);
                    contract.TotalValue = Convert.ToDecimal(txtValue.Text);
                    contract.ContractDate = ((dtpContractDate.Value != DateTime.MinValue) ? (DateTime?)dtpContractDate.Value : null);
                    contract.SignCount = signCount;
                    resultContract = obj.InsertContract(contract);

                    if (resultContract)
                    {
                        obj.dbFullBackUp();
                        this.Close();
                        MessageBox.Show("บันทึกเรียบร้อย", "ผลการบันทึก", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //System.Diagnostics.Process.Start("Chrome.exe", "https://www.google.com/calendar/");
                    }
                    else
                    {
                        MessageBox.Show("พบข้อบกพร่อง ไม่สามารถบันทึกได้", "ผลการบันทึก", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("โปรแกรมพบข้อผิดพลาด", "พบข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log.LogWrite(DateTime.Now.ToString() + "\r\n" + ex.ToString());
                Application.Exit();
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdStatus1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdStatus1.Checked)
                EnableControl();
            else
                DisableControl(false);
        }

        private void rdStatus2_CheckedChanged(object sender, EventArgs e)
        {
            if (rdStatus1.Checked)
                EnableControl();
            else
                DisableControl(false);
        }
        #endregion

        #region Grid Event
        private void gridView1_ShowingEditor(object sender, CancelEventArgs e)
        {
            GridView view = sender as GridView;
            //if (view.FocusedColumn.FieldName == "No")
            //    e.Cancel = true;
        }

        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                GridView view = sender as GridView;
                view.DeleteRow(view.FocusedRowHandle);
            }
        }

        private void gridView2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                GridView view = sender as GridView;
                view.DeleteRow(view.FocusedRowHandle);
            }
        }

        private void gridView3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                GridView view = sender as GridView;
                view.DeleteRow(view.FocusedRowHandle);
            }
        }

        private void gridView1_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            GridColumn Col = e.Column;
            if (Col.Name == "No" && e.ListSourceRowIndex >= 0){
                e.DisplayText = (e.ListSourceRowIndex + 1).ToString();
            }
            else if (Col.Name == "No")
            {
                e.DisplayText = "0";
            }
        }

        private void gridView3_CustomColumnDisplayText(object sender,DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            GridColumn Col = e.Column;
            if (Col.Name == "AlertNo" && e.ListSourceRowIndex >= 0)
            {
                e.DisplayText = (e.ListSourceRowIndex + 1).ToString();
            }
            else if (Col.Name == "AlertNo")
            {
                e.DisplayText = "0";
            }
        }

        private void gridView3_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = sender as GridView;
            view.SetRowCellValue(e.RowHandle, view.Columns["AlertType"], "ทวงถามดอกเบี้ย");
        }
        #endregion

        #region Validate
        private Boolean validateForm()
        {
            DataTable dtDate = (DataTable)gridControlDate.DataSource;
            DataTable dtMember = (DataTable)gridControlMember.DataSource;

            if (txtTitle.Text == "") 
            {
                MessageBox.Show("กรุณากรอก ชิ่อสัญญา", "กรอกข้อมูลไม่ครบถ้วน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTitle.Focus();
                return false;
            }
            else if (Convert.ToDecimal(txtValue.Text) < 1) 
            {
                MessageBox.Show("กรุณากรอก 'มูลค่า' ให้ถูกต้อง", "กรอกข้อมูลไม่ครบถ้วน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtValue.Focus();
                return false;
            }
            else if (cboContractType.SelectedIndex == -1)
            {
                MessageBox.Show("กรุณากรอก 'ชนิดสัญญา' ให้ถูกต้อง", "กรอกข้อมูลไม่ครบถ้วน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboContractType.Focus();
                return false;
            }
            //else if (dtDate.Rows.Count == 0)
            //{                
            //    MessageBox.Show("กรุณากรอกข้อมูลในตารางให้ครบถ้วน", "กรอกข้อมูลไม่ครบถ้วน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    tabControl1.SelectedIndex = 1;
            //    gridView1.Focus();
            //    return false;
            //}
            else if (dtMember.Rows.Count == 0)
            {
                MessageBox.Show("กรุณากรอกข้อมูลในตาราง 'รายชื่อ' ให้ครบถ้วน", "กรอกข้อมูลไม่ครบถ้วน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tabControl1.SelectedIndex = 1;
                gridView2.Focus();
                return false;
            }
            else if (Convert.ToDecimal(gridView2.Columns["Value"].SummaryItem.SummaryValue) != Convert.ToDecimal(txtValue.Text))
            {
                MessageBox.Show("กรุณากรอก 'มูลค่า' ให้เท่ากับ 'มูลค่ารวม'", "กรอกข้อมูลผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                tabControl1.SelectedIndex = 1;
                gridView2.Focus();
                return false;
            }
            
            return true;
        }

        #endregion

    }
}
