namespace AssetManager
{
    partial class frmEditContract
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditContract));
            this.label1 = new System.Windows.Forms.Label();
            this.lblContractID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cboAssetType = new System.Windows.Forms.ComboBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.cboContractType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpContractDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.rdStatus1 = new System.Windows.Forms.RadioButton();
            this.rdStatus2 = new System.Windows.Forms.RadioButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabDate = new System.Windows.Forms.TabPage();
            this.gridControlDate = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.No = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RedeemDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.SignDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.tabAlert = new System.Windows.Forms.TabPage();
            this.gridControlAlert = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.AlertNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AlertDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.AlertType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.tabMember = new System.Windows.Forms.TabPage();
            this.gridControlMember = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MemberId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Value = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtValue = new DevExpress.XtraEditors.TextEdit();
            this.txtContractDate = new System.Windows.Forms.TextBox();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.tabControl1.SuspendLayout();
            this.tabDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            this.tabAlert.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAlert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit4.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit3.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).BeginInit();
            this.tabMember.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMember)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValue.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(463, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "รหัส :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblContractID
            // 
            this.lblContractID.AutoSize = true;
            this.lblContractID.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblContractID.Location = new System.Drawing.Point(512, 66);
            this.lblContractID.Name = "lblContractID";
            this.lblContractID.Size = new System.Drawing.Size(40, 18);
            this.lblContractID.TabIndex = 1;
            this.lblContractID.Text = "0000";
            this.lblContractID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(29, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "ชื่อรายการ* :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label5.Location = new System.Drawing.Point(51, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "สัญญา* :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label6.Location = new System.Drawing.Point(57, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "มูลค่า* :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label7.Location = new System.Drawing.Point(21, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "เริ่มทำสัญญา :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboAssetType
            // 
            this.cboAssetType.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.cboAssetType.FormattingEnabled = true;
            this.cboAssetType.Location = new System.Drawing.Point(123, 62);
            this.cboAssetType.Name = "cboAssetType";
            this.cboAssetType.Size = new System.Drawing.Size(98, 26);
            this.cboAssetType.TabIndex = 7;
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.txtTitle.Location = new System.Drawing.Point(227, 63);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(219, 26);
            this.txtTitle.TabIndex = 8;
            // 
            // cboContractType
            // 
            this.cboContractType.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.cboContractType.FormattingEnabled = true;
            this.cboContractType.Location = new System.Drawing.Point(123, 99);
            this.cboContractType.Name = "cboContractType";
            this.cboContractType.Size = new System.Drawing.Size(98, 26);
            this.cboContractType.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.Location = new System.Drawing.Point(278, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "บาท";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpContractDate
            // 
            this.dtpContractDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.dtpContractDate.Location = new System.Drawing.Point(123, 171);
            this.dtpContractDate.Name = "dtpContractDate";
            this.dtpContractDate.Size = new System.Drawing.Size(149, 24);
            this.dtpContractDate.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label8.Location = new System.Drawing.Point(44, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 19);
            this.label8.TabIndex = 13;
            this.label8.Text = "สถานะ* :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rdStatus1
            // 
            this.rdStatus1.AutoSize = true;
            this.rdStatus1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.rdStatus1.Location = new System.Drawing.Point(136, 14);
            this.rdStatus1.Name = "rdStatus1";
            this.rdStatus1.Size = new System.Drawing.Size(46, 23);
            this.rdStatus1.TabIndex = 15;
            this.rdStatus1.TabStop = true;
            this.rdStatus1.Text = "ทำ";
            this.rdStatus1.UseVisualStyleBackColor = true;
            this.rdStatus1.CheckedChanged += new System.EventHandler(this.rdStatus1_CheckedChanged);
            // 
            // rdStatus2
            // 
            this.rdStatus2.AutoSize = true;
            this.rdStatus2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.rdStatus2.Location = new System.Drawing.Point(200, 14);
            this.rdStatus2.Name = "rdStatus2";
            this.rdStatus2.Size = new System.Drawing.Size(58, 23);
            this.rdStatus2.TabIndex = 16;
            this.rdStatus2.TabStop = true;
            this.rdStatus2.Text = "เสร็จ";
            this.rdStatus2.UseVisualStyleBackColor = true;
            this.rdStatus2.CheckedChanged += new System.EventHandler(this.rdStatus2_CheckedChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabDate);
            this.tabControl1.Controls.Add(this.tabAlert);
            this.tabControl1.Controls.Add(this.tabMember);
            this.tabControl1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tabControl1.Location = new System.Drawing.Point(67, 216);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(433, 232);
            this.tabControl1.TabIndex = 17;
            // 
            // tabDate
            // 
            this.tabDate.Controls.Add(this.gridControlDate);
            this.tabDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tabDate.Location = new System.Drawing.Point(4, 27);
            this.tabDate.Name = "tabDate";
            this.tabDate.Padding = new System.Windows.Forms.Padding(3);
            this.tabDate.Size = new System.Drawing.Size(425, 201);
            this.tabDate.TabIndex = 0;
            this.tabDate.Text = "วันไถ่ถอน/นัดต่อสัญญา";
            this.tabDate.UseVisualStyleBackColor = true;
            // 
            // gridControlDate
            // 
            this.gridControlDate.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.gridControlDate.Location = new System.Drawing.Point(3, 5);
            this.gridControlDate.MainView = this.gridView1;
            this.gridControlDate.Name = "gridControlDate";
            this.gridControlDate.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1,
            this.repositoryItemDateEdit2,
            this.repositoryItemTextEdit1});
            this.gridControlDate.Size = new System.Drawing.Size(416, 195);
            this.gridControlDate.TabIndex = 0;
            this.gridControlDate.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.No,
            this.RedeemDate,
            this.SignDate});
            this.gridView1.GridControl = this.gridControlDate;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsCustomization.AllowSort = false;
            this.gridView1.OptionsNavigation.AutoMoveRowFocus = false;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.gridView1_ShowingEditor);
            this.gridView1.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.gridView1_CustomColumnDisplayText);
            this.gridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridView1_KeyDown);
            // 
            // No
            // 
            this.No.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.No.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.No.AppearanceCell.Options.UseBackColor = true;
            this.No.AppearanceCell.Options.UseFont = true;
            this.No.AppearanceCell.Options.UseTextOptions = true;
            this.No.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.No.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.No.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.No.AppearanceHeader.Options.UseBackColor = true;
            this.No.AppearanceHeader.Options.UseFont = true;
            this.No.Caption = "ลำดับ";
            this.No.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.No.FieldName = "No";
            this.No.Name = "No";
            this.No.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.No.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.No.Visible = true;
            this.No.VisibleIndex = 0;
            this.No.Width = 61;
            // 
            // RedeemDate
            // 
            this.RedeemDate.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.RedeemDate.AppearanceCell.Options.UseFont = true;
            this.RedeemDate.AppearanceCell.Options.UseTextOptions = true;
            this.RedeemDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.RedeemDate.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.RedeemDate.AppearanceHeader.Options.UseFont = true;
            this.RedeemDate.AppearanceHeader.Options.UseTextOptions = true;
            this.RedeemDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.RedeemDate.Caption = "วันไถ่ถอน";
            this.RedeemDate.ColumnEdit = this.repositoryItemDateEdit1;
            this.RedeemDate.DisplayFormat.FormatString = "dd/MMM/yyyy";
            this.RedeemDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.RedeemDate.FieldName = "RedeemDate";
            this.RedeemDate.Name = "RedeemDate";
            this.RedeemDate.UnboundType = DevExpress.Data.UnboundColumnType.DateTime;
            this.RedeemDate.Visible = true;
            this.RedeemDate.VisibleIndex = 1;
            this.RedeemDate.Width = 140;
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            // 
            // SignDate
            // 
            this.SignDate.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.SignDate.AppearanceCell.Options.UseFont = true;
            this.SignDate.AppearanceCell.Options.UseTextOptions = true;
            this.SignDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SignDate.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.SignDate.AppearanceHeader.Options.UseFont = true;
            this.SignDate.AppearanceHeader.Options.UseTextOptions = true;
            this.SignDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.SignDate.Caption = "นัดต่อสัญญา";
            this.SignDate.ColumnEdit = this.repositoryItemDateEdit2;
            this.SignDate.DisplayFormat.FormatString = "dd/MMM/yyyy";
            this.SignDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.SignDate.FieldName = "SignDate";
            this.SignDate.Name = "SignDate";
            this.SignDate.UnboundType = DevExpress.Data.UnboundColumnType.DateTime;
            this.SignDate.Visible = true;
            this.SignDate.VisibleIndex = 2;
            this.SignDate.Width = 137;
            // 
            // repositoryItemDateEdit2
            // 
            this.repositoryItemDateEdit2.AutoHeight = false;
            this.repositoryItemDateEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit2.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit2.Name = "repositoryItemDateEdit2";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // tabAlert
            // 
            this.tabAlert.Controls.Add(this.gridControlAlert);
            this.tabAlert.Location = new System.Drawing.Point(4, 27);
            this.tabAlert.Name = "tabAlert";
            this.tabAlert.Size = new System.Drawing.Size(425, 201);
            this.tabAlert.TabIndex = 2;
            this.tabAlert.Text = "การแจ้งเตือน อื่นๆ";
            this.tabAlert.UseVisualStyleBackColor = true;
            // 
            // gridControlAlert
            // 
            this.gridControlAlert.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            gridLevelNode1.RelationName = "Level1";
            this.gridControlAlert.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControlAlert.Location = new System.Drawing.Point(4, 3);
            this.gridControlAlert.MainView = this.gridView3;
            this.gridControlAlert.Name = "gridControlAlert";
            this.gridControlAlert.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit3,
            this.repositoryItemDateEdit4,
            this.repositoryItemTextEdit2});
            this.gridControlAlert.Size = new System.Drawing.Size(416, 195);
            this.gridControlAlert.TabIndex = 1;
            this.gridControlAlert.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.AlertNo,
            this.AlertDate,
            this.AlertType});
            this.gridView3.GridControl = this.gridControlAlert;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsCustomization.AllowSort = false;
            this.gridView3.OptionsNavigation.AutoMoveRowFocus = false;
            this.gridView3.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gridView3.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            this.gridView3.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gridView3_InitNewRow);
            this.gridView3.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.gridView3_CustomColumnDisplayText);
            this.gridView3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridView3_KeyDown);
            // 
            // AlertNo
            // 
            this.AlertNo.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.AlertNo.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlertNo.AppearanceCell.Options.UseBackColor = true;
            this.AlertNo.AppearanceCell.Options.UseFont = true;
            this.AlertNo.AppearanceCell.Options.UseTextOptions = true;
            this.AlertNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.AlertNo.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.AlertNo.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.AlertNo.AppearanceHeader.Options.UseBackColor = true;
            this.AlertNo.AppearanceHeader.Options.UseFont = true;
            this.AlertNo.Caption = "ลำดับ";
            this.AlertNo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.AlertNo.FieldName = "No";
            this.AlertNo.Name = "AlertNo";
            this.AlertNo.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.AlertNo.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.AlertNo.Visible = true;
            this.AlertNo.VisibleIndex = 0;
            this.AlertNo.Width = 50;
            // 
            // AlertDate
            // 
            this.AlertDate.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.AlertDate.AppearanceCell.Options.UseFont = true;
            this.AlertDate.AppearanceCell.Options.UseTextOptions = true;
            this.AlertDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.AlertDate.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.AlertDate.AppearanceHeader.Options.UseFont = true;
            this.AlertDate.AppearanceHeader.Options.UseTextOptions = true;
            this.AlertDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.AlertDate.Caption = "วันแจ้งเตือน";
            this.AlertDate.ColumnEdit = this.repositoryItemDateEdit4;
            this.AlertDate.DisplayFormat.FormatString = "dd/MMM/yyyy";
            this.AlertDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.AlertDate.FieldName = "AlertDate";
            this.AlertDate.Name = "AlertDate";
            this.AlertDate.UnboundType = DevExpress.Data.UnboundColumnType.DateTime;
            this.AlertDate.Visible = true;
            this.AlertDate.VisibleIndex = 1;
            this.AlertDate.Width = 191;
            // 
            // repositoryItemDateEdit4
            // 
            this.repositoryItemDateEdit4.AutoHeight = false;
            this.repositoryItemDateEdit4.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit4.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit4.Name = "repositoryItemDateEdit4";
            // 
            // AlertType
            // 
            this.AlertType.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.AlertType.AppearanceCell.Options.UseFont = true;
            this.AlertType.AppearanceCell.Options.UseTextOptions = true;
            this.AlertType.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.AlertType.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.AlertType.AppearanceHeader.Options.UseFont = true;
            this.AlertType.AppearanceHeader.Options.UseTextOptions = true;
            this.AlertType.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.AlertType.Caption = "ประเภท";
            this.AlertType.FieldName = "AlertType";
            this.AlertType.Name = "AlertType";
            this.AlertType.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.AlertType.Visible = true;
            this.AlertType.VisibleIndex = 2;
            this.AlertType.Width = 157;
            // 
            // repositoryItemDateEdit3
            // 
            this.repositoryItemDateEdit3.AutoHeight = false;
            this.repositoryItemDateEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit3.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit3.Name = "repositoryItemDateEdit3";
            // 
            // repositoryItemTextEdit2
            // 
            this.repositoryItemTextEdit2.AutoHeight = false;
            this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
            // 
            // tabMember
            // 
            this.tabMember.Controls.Add(this.gridControlMember);
            this.tabMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tabMember.Location = new System.Drawing.Point(4, 27);
            this.tabMember.Name = "tabMember";
            this.tabMember.Padding = new System.Windows.Forms.Padding(3);
            this.tabMember.Size = new System.Drawing.Size(425, 201);
            this.tabMember.TabIndex = 1;
            this.tabMember.Text = "รายชื่อ";
            this.tabMember.UseVisualStyleBackColor = true;
            // 
            // gridControlMember
            // 
            this.gridControlMember.Location = new System.Drawing.Point(6, 6);
            this.gridControlMember.MainView = this.gridView2;
            this.gridControlMember.Name = "gridControlMember";
            this.gridControlMember.Size = new System.Drawing.Size(414, 189);
            this.gridControlMember.TabIndex = 1;
            this.gridControlMember.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView2.Appearance.FooterPanel.Options.UseFont = true;
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MemberId,
            this.Value});
            this.gridView2.GridControl = this.gridControlMember;
            this.gridView2.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SumValue", this.Value, "Numeric \"c2\"")});
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsCustomization.AllowSort = false;
            this.gridView2.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView2.OptionsView.ShowFooter = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridView2_KeyDown);
            // 
            // MemberId
            // 
            this.MemberId.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberId.AppearanceCell.Options.UseFont = true;
            this.MemberId.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberId.AppearanceHeader.Options.UseFont = true;
            this.MemberId.AppearanceHeader.Options.UseTextOptions = true;
            this.MemberId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.MemberId.Caption = "รายชื่อ";
            this.MemberId.FieldName = "MemberId";
            this.MemberId.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.MemberId.Name = "MemberId";
            this.MemberId.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.MemberId.Visible = true;
            this.MemberId.VisibleIndex = 0;
            this.MemberId.Width = 160;
            // 
            // Value
            // 
            this.Value.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Value.AppearanceCell.Options.UseFont = true;
            this.Value.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Value.AppearanceHeader.Options.UseFont = true;
            this.Value.AppearanceHeader.Options.UseTextOptions = true;
            this.Value.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Value.Caption = "จำนวนเงิน (บาท)";
            this.Value.DisplayFormat.FormatString = "c2";
            this.Value.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Value.FieldName = "Value";
            this.Value.Name = "Value";
            this.Value.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Value", "รวม {0:c2}")});
            this.Value.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.Value.Visible = true;
            this.Value.VisibleIndex = 1;
            this.Value.Width = 234;
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(10, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(548, 2);
            this.label9.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(364, 469);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(91, 42);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "บันทึก";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnCancel.Location = new System.Drawing.Point(461, 469);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 42);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "ยกเลิก";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(123, 137);
            this.txtValue.Name = "txtValue";
            this.txtValue.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValue.Properties.Appearance.Options.UseFont = true;
            this.txtValue.Properties.Appearance.Options.UseTextOptions = true;
            this.txtValue.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtValue.Properties.NullText = "0.00";
            this.txtValue.Size = new System.Drawing.Size(149, 24);
            this.txtValue.TabIndex = 20;
            // 
            // txtContractDate
            // 
            this.txtContractDate.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.txtContractDate.Location = new System.Drawing.Point(123, 169);
            this.txtContractDate.Name = "txtContractDate";
            this.txtContractDate.Size = new System.Drawing.Size(149, 26);
            this.txtContractDate.TabIndex = 21;
            this.txtContractDate.Visible = false;
            // 
            // frmEditContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(570, 523);
            this.Controls.Add(this.txtContractDate);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.rdStatus2);
            this.Controls.Add(this.rdStatus1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtpContractDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboContractType);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.cboAssetType);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblContractID);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(586, 562);
            this.MinimumSize = new System.Drawing.Size(586, 562);
            this.Name = "frmEditContract";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "เพิ่มสัญญาจำนอง/ขายฝาก";
            this.tabControl1.ResumeLayout(false);
            this.tabDate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            this.tabAlert.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAlert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit4.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit3.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).EndInit();
            this.tabMember.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMember)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValue.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblContractID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboAssetType;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.ComboBox cboContractType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpContractDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rdStatus1;
        private System.Windows.Forms.RadioButton rdStatus2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabDate;
        private DevExpress.XtraGrid.GridControl gridControlDate;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.TabPage tabMember;
        private DevExpress.XtraGrid.GridControl gridControlMember;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private DevExpress.XtraGrid.Columns.GridColumn No;
        private DevExpress.XtraGrid.Columns.GridColumn RedeemDate;
        private DevExpress.XtraGrid.Columns.GridColumn SignDate;
       
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn MemberId;
        private DevExpress.XtraGrid.Columns.GridColumn Value;
        private DevExpress.XtraEditors.TextEdit txtValue;
        private System.Windows.Forms.TextBox txtContractDate;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.TabPage tabAlert;
        private DevExpress.XtraGrid.GridControl gridControlAlert;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn AlertNo;
        private DevExpress.XtraGrid.Columns.GridColumn AlertType;
        private DevExpress.XtraGrid.Columns.GridColumn AlertDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit4;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit3;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit2;
    }
}