using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Card;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AssetManager
{
    public partial class frmControlContract : Form
    {
        Service obj = new Service();
        DataTable dtContract = new DataTable("Contract");
        DataTable dtContractMember = new DataTable("ContractMember");
        DataTable dtMember = new DataTable("Member");
        DataTable dtStatus = new DataTable("Status");

        LogWriter Log = new LogWriter(DateTime.Now.ToString() + "\r\n" + "เปิดโปรแกรม");

        public frmControlContract()
        {
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
        }

        private void frmEditContract_Load(object sender, EventArgs e)
        {
            //GridView gridView2 = new GridView(gridControl1);
            //PopupAlert();
        }


        private void gridControl1_Load(object sender, EventArgs e)
        {
            InitialGrid();            
        }

        private void PopupAlert()
        {
            try
            {
                DataTable dtAlert = new DataTable();
                dtAlert = obj.getSignDateAlert();
                string warnMsg = "";
                if (dtAlert.Rows.Count > 0)
                {
                    foreach (DataRow dr in dtAlert.Rows)
                    {
                        warnMsg += "รหัส: " + dr["ID"].ToString() + " (" + dr["Title"].ToString() + ") " + dr["REMARK"].ToString() + "\n";
                    }

                    MessageBox.Show(warnMsg, "แจ้งเตือนวันต่อสัญญา", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (InvalidCastException e)
            {
                MessageBox.Show("Error - PopupAlert" + e.InnerException.ToString());
            }
        }

        private void InitialGrid()
        {
            try
            {
                //Combobox
                dtMember = obj.getAllMember();
                dtStatus = obj.getStatus();
                DataSet dsCombo = new DataSet();
                dsCombo.Tables.Add(dtMember);
                dsCombo.Tables.Add(dtStatus);

                BindGrid();
                BindSummaryGrid();
                BindAlertGrid();
                gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
                gridView1.OptionsSelection.EnableAppearanceFocusedRow = false;
                gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
                gridView2.OptionsSelection.EnableAppearanceFocusedRow = false;

                gridView1.SetMasterRowExpanded(0, true);
            }
            catch (InvalidCastException e)
            {
                MessageBox.Show("Error - InitialGrid" + e.InnerException.ToString());
            }
        }

        private void BindGrid()
        {
            try
            {
                //Main Detail
                dtContract = obj.getAllContract();
                dtContractMember = obj.getAllContractMember();
                DataSet dataSet = new DataSet();
                //Create DataTable objects for representing database's tables
                dataSet.Tables.Add(dtContract);
                dataSet.Tables.Add(dtContractMember);

                //Set up a master-detail relationship between the DataTables
                DataColumn keyColumn = dataSet.Tables["Contract"].Columns["ID"];
                DataColumn foreignKeyColumn = dataSet.Tables["ContractMember"].Columns["CONTRACTID"];
                dataSet.Relations.Add("ContractAll", keyColumn, foreignKeyColumn);

                //Bind the grid control to the data source
                gridControl1.DataSource = dataSet.Tables["Contract"];
                gridControl1.ForceInitialize();

                //Setting Master Grid Style
                SetGridCaption();
                SetGridSize();
                SetGridFormat();
                SetGridAlign();
                SetGridFooter();

                GridDetailMemberSetup(dataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show("โปรแกรมพบข้อผิดพลาด", "พบข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log.LogWrite(DateTime.Now.ToString() + "\r\n" + ex.ToString());
                Application.Exit();
            }

        }

        private void BindSummaryGrid()
        {
            DataTable dtSummary = new DataTable();
            dtSummary = obj.getSummaryMemberValue();
            gridControl3.DataSource = dtSummary;
            gridControl3.ForceInitialize();
        }

        private void BindAlertGrid()
        {
            DataTable dtAlert = new DataTable();
            dtAlert = obj.getSignDateAlert();
            gridControl2.DataSource = dtAlert;
            gridControl2.ForceInitialize();
        }

        private void GridDetailMemberSetup(DataSet ds)
        {
            //Assign a CardView to the relationship
            gridView2.GridControl = gridControl1;
            gridControl1.LevelTree.Nodes.Add("ContractAll", gridView2);
            //Specify text to be displayed within detail tabs.
            gridView2.OptionsView.ShowGroupPanel = false;
            gridView2.OptionsView.ShowViewCaption = false;
            gridView2.OptionsView.ShowColumnHeaders = false;
            gridView2.ViewCaption = "รายชื่อ";


            //Create columns for the detail pattern View
            gridView2.PopulateColumns(ds.Tables["ContractMember"]);
            //Hide the CategoryID column for the detail View
            gridView2.Columns["CONTRACTID"].VisibleIndex = -1;
            gridView2.Columns["NAME"].Width = 1000;
            gridView2.Columns["VALUE"].Width = 210;
            gridView2.Columns["NAME"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            gridView2.Columns["VALUE"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            //Format UnitPrice column values as currency
            gridView2.Columns["VALUE"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            gridView2.Columns["VALUE"].DisplayFormat.FormatString = "c2";

        }

        #region Set Grid
        private void SetGridCaption()
        {
            gridView1.Columns["ID"].Caption = "รหัส";
            gridView1.Columns["STATUSNAME"].Caption = "สถานะ";
            gridView1.Columns["Title"].Caption = "รายการ";
            gridView1.Columns["ContractDate"].Caption = "ทำสัญญา";
            gridView1.Columns["RedeemDate"].Caption = "วันไถ่ถอน";
            gridView1.Columns["SignDate"].Caption = "นัดต่อสัญญา";
            gridView1.Columns["CONTRACTTYPENAME"].Caption = "ชนิด";
            gridView1.Columns["Value"].Caption = "มูลค่า";

        }

        private void SetGridAlign()
        {
            gridView1.Columns["ID"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView1.Columns["STATUSNAME"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView1.Columns["Title"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView1.Columns["ContractDate"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView1.Columns["RedeemDate"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView1.Columns["SignDate"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView1.Columns["CONTRACTTYPENAME"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView1.Columns["Value"].AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;

            gridView1.Columns["ID"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView1.Columns["STATUSNAME"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            gridView1.Columns["Title"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            gridView1.Columns["ContractDate"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView1.Columns["RedeemDate"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView1.Columns["SignDate"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView1.Columns["CONTRACTTYPENAME"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            gridView1.Columns["Value"].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
        }

        private void SetGridSize()
        {
            gridView1.RowHeight = 25;

            gridView1.Columns["ID"].Width = 120;
            gridView1.Columns["STATUSNAME"].Width = 120;
            gridView1.Columns["Title"].Width = 500;
            gridView1.Columns["ContractDate"].Width = 180;
            gridView1.Columns["RedeemDate"].Width = 180;
            gridView1.Columns["SignDate"].Width = 180;
            gridView1.Columns["CONTRACTTYPENAME"].Width = 170;
            gridView1.Columns["Value"].Width = 200;

        }

        private void SetGridFormat()
        {
            gridView1.Columns["ContractDate"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            gridView1.Columns["ContractDate"].DisplayFormat.FormatString = "dd/MMM/yy";
            gridView1.Columns["RedeemDate"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            gridView1.Columns["RedeemDate"].DisplayFormat.FormatString = "dd/MMM/yy";
            gridView1.Columns["SignDate"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            gridView1.Columns["SignDate"].DisplayFormat.FormatString = "dd/MMM/yy";
            gridView1.Columns["Value"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            gridView1.Columns["Value"].DisplayFormat.FormatString = "c2";

            Font smallFont = new Font("Courier New", 16);
            gridView1.Columns["ContractDate"].AppearanceCell.Font = smallFont;
            gridView1.Columns["RedeemDate"].AppearanceCell.Font = smallFont;
            gridView1.Columns["SignDate"].AppearanceCell.Font = smallFont;

        }

        private void SetGridFooter()
        {
            gridView1.Columns["Title"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count;
            gridView1.Columns["Title"].SummaryItem.DisplayFormat = "จำนวน: {0} แปลง";

            gridView1.Columns["Value"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            gridView1.Columns["Value"].SummaryItem.DisplayFormat = "รวม {0:n2}";
        }
        #endregion 

        #region Grid Event
        private void gridView1_RowStyle_1(object sender, RowStyleEventArgs e)
        {
            GridView View = sender as GridView;
            if (e.RowHandle >= 0)
            {
                string statusName = View.GetRowCellDisplayText(e.RowHandle, View.Columns["STATUSNAME"]);
                if (statusName == "เสร็จ")
                {
                    e.Appearance.BackColor = Color.Salmon;
                    e.Appearance.BackColor2 = Color.SeaShell;
                }
                else if (statusName == "ทำ")
                {
                    e.Appearance.BackColor = Color.SpringGreen;
                    e.Appearance.BackColor2 = Color.SeaShell;
                }
            }
            if (e.RowHandle == View.FocusedRowHandle)
            {
                //Apply the appearance of the SelectedRow
                //e.Appearance.Assign(View.PaintAppearance.SelectedRow);
                //Just to illustrate how the code works. Remove the following lines to see the desired appearance.
                e.Appearance.Font = new System.Drawing.Font(e.Appearance.Font, System.Drawing.FontStyle.Underline);
            }
        }

        private void gridView1_RowCellStyle_1(object sender, RowCellStyleEventArgs e)
        {
            GridView View = sender as GridView;
            if (e.Column.FieldName == "CONTRACTTYPENAME")
            {
                string category = View.GetRowCellDisplayText(e.RowHandle, View.Columns["CONTRACTTYPENAME"]);
                if (category == "ขายฝาก")
                    e.Appearance.ForeColor = Color.DarkBlue;
                else if (category == "จำนอง")
                    e.Appearance.ForeColor = Color.Purple;
                else if (category == "เงินกู้")
                    e.Appearance.ForeColor = Color.DarkSlateGray;
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            GridView View = sender as GridView;
            if (e.PrevFocusedRowHandle >= 0)
            {
                View.SetMasterRowExpanded(e.PrevFocusedRowHandle, false);
                View.SetMasterRowExpanded(e.FocusedRowHandle, true);
            }

        }
        #endregion

        #region Button Event
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var formEditContact = new frmEditContract(this, "New", 0);
            formEditContact.Show(this);
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            int id;
            try{

                id =  Convert.ToInt32(gridView1.GetRowCellValue(gridView1.GetSelectedRows()[0], gridView1.Columns[0]));
            }
            catch{
                   id = 0;
                   MessageBox.Show("Error.");
                    return;
            }

            var formEditContact = new frmEditContract(this, "View", id);
            formEditContact.Show(this);
        }

        public void PerformRefresh()
        {
            this.label1.Text = "Form Refreshed @ " + DateTime.Now.ToLongTimeString();
            InitialGrid();
        }
        
        private void btnEdit_Click(object sender, EventArgs e)
        {
            int id;
            try
            {
                id = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.GetSelectedRows()[0], gridView1.Columns[0]));
            }
            catch
            {
                id = 0;
                MessageBox.Show("Error. btnEdit_Click");
                return;
            }

            var formEditContact = new frmEditContract(this, "Edit", id);
            formEditContact.Show(this);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id;
            string title;
            try
            {
                id = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.GetSelectedRows()[0], gridView1.Columns[0]));
                title = Convert.ToString(gridView1.GetRowCellValue(gridView1.GetSelectedRows()[0], gridView1.Columns[2]));
            }
            catch
            {
                title = "";
                MessageBox.Show("Error. btnDelete_Click");
                return;
            }

            DialogResult dialogResult = MessageBox.Show("คุณแน่ใจว่าต้องการลบรายการ '" + title + "'", "ลบรายการ", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (dialogResult == DialogResult.Yes)
            {                
                obj.deleteContractDate(id);
                obj.deleteContractMember(id);
                obj.deleteContract(id);
                BindGrid();
                BindSummaryGrid();
                BindAlertGrid();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            int id;
            string title;
            try
            {
                id = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.GetSelectedRows()[0], gridView1.Columns[0]));
                title = Convert.ToString(gridView1.GetRowCellValue(gridView1.GetSelectedRows()[0], gridView1.Columns[2]));
            }
            catch
            {
                title = "";
                MessageBox.Show("Error. btnDelete_Click");
                return;
            }

            DialogResult dialogResult = MessageBox.Show("คุณแน่ใจว่าต้องปิดรายการ '" + title + "'", "ปิดรายการ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                obj.updateContractStatus(id);

                BindGrid();
                BindSummaryGrid();
                BindAlertGrid();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }
        #endregion

        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            
        }





    }

}
