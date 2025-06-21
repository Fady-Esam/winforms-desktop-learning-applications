namespace WFs
{
    partial class CustomersInfoFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomersInfoFrm));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.AddNewCstBtn = new DevExpress.XtraEditors.SimpleButton();
            this.allChBox = new DevExpress.XtraEditors.CheckEdit();
            this.excelBtn = new DevExpress.XtraEditors.SimpleButton();
            this.cstMainGroupLue = new DevExpress.XtraEditors.LookUpEdit();
            this.showBtn = new DevExpress.XtraEditors.SimpleButton();
            this.saveBtn = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.CustomerID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ContactNu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.customerNameLue = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.RegistrationTaxNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ReceiverTyp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Country = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Governate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RegionCity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ChartAccount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PriceProfileID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.customerPriceListLue = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.GroupID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.customerGroupLue = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.SalesPersonID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.salesPersonLue = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.LimitationAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.excelLayOut = new DevExpress.XtraLayout.LayoutControlItem();
            this.allGroupsLayOut = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allChBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cstMainGroupLue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerNameLue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerPriceListLue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerGroupLue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesPersonLue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.excelLayOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allGroupsLayOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.AddNewCstBtn);
            this.layoutControl1.Controls.Add(this.allChBox);
            this.layoutControl1.Controls.Add(this.excelBtn);
            this.layoutControl1.Controls.Add(this.cstMainGroupLue);
            this.layoutControl1.Controls.Add(this.showBtn);
            this.layoutControl1.Controls.Add(this.saveBtn);
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsView.RightToLeftMirroringApplied = true;
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1173, 646);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // AddNewCstBtn
            // 
            this.AddNewCstBtn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("AddNewCstBtn.ImageOptions.SvgImage")));
            this.AddNewCstBtn.Location = new System.Drawing.Point(16, 16);
            this.AddNewCstBtn.Name = "AddNewCstBtn";
            this.AddNewCstBtn.Size = new System.Drawing.Size(126, 58);
            this.AddNewCstBtn.StyleController = this.layoutControl1;
            this.AddNewCstBtn.TabIndex = 10;
            this.AddNewCstBtn.Text = "اضافة عميل جديد";
            this.AddNewCstBtn.Click += new System.EventHandler(this.AddNewCstBtn_Click);
            // 
            // allChBox
            // 
            this.allChBox.Location = new System.Drawing.Point(921, 52);
            this.allChBox.Name = "allChBox";
            this.allChBox.Properties.Caption = "الكل";
            this.allChBox.Size = new System.Drawing.Size(88, 22);
            this.allChBox.StyleController = this.layoutControl1;
            this.allChBox.TabIndex = 9;
            // 
            // excelBtn
            // 
            this.excelBtn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("excelBtn.ImageOptions.SvgImage")));
            this.excelBtn.Location = new System.Drawing.Point(281, 16);
            this.excelBtn.Name = "excelBtn";
            this.excelBtn.Size = new System.Drawing.Size(40, 52);
            this.excelBtn.StyleController = this.layoutControl1;
            this.excelBtn.TabIndex = 8;
            this.excelBtn.Click += new System.EventHandler(this.excelBtn_Click);
            // 
            // cstMainGroupLue
            // 
            this.cstMainGroupLue.Location = new System.Drawing.Point(799, 16);
            this.cstMainGroupLue.Name = "cstMainGroupLue";
            this.cstMainGroupLue.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cstMainGroupLue.Properties.NullText = "";
            this.cstMainGroupLue.Size = new System.Drawing.Size(154, 30);
            this.cstMainGroupLue.StyleController = this.layoutControl1;
            this.cstMainGroupLue.TabIndex = 7;
            // 
            // showBtn
            // 
            this.showBtn.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question;
            this.showBtn.Appearance.Options.UseBackColor = true;
            this.showBtn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("showBtn.ImageOptions.SvgImage")));
            this.showBtn.Location = new System.Drawing.Point(1015, 16);
            this.showBtn.Name = "showBtn";
            this.showBtn.Size = new System.Drawing.Size(142, 58);
            this.showBtn.StyleController = this.layoutControl1;
            this.showBtn.TabIndex = 6;
            this.showBtn.Text = "استعراض العملاء";
            this.showBtn.Click += new System.EventHandler(this.showBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success;
            this.saveBtn.Appearance.Options.UseBackColor = true;
            this.saveBtn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("saveBtn.ImageOptions.SvgImage")));
            this.saveBtn.Location = new System.Drawing.Point(148, 16);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(127, 58);
            this.saveBtn.StyleController = this.layoutControl1;
            this.saveBtn.TabIndex = 5;
            this.saveBtn.Text = "حفظ التعديلات";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(16, 80);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.customerNameLue,
            this.customerGroupLue,
            this.customerPriceListLue,
            this.salesPersonLue});
            this.gridControl1.Size = new System.Drawing.Size(1141, 550);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.CustomerID,
            this.ContactNu,
            this.RegistrationTaxNumber,
            this.ReceiverTyp,
            this.Country,
            this.Governate,
            this.RegionCity,
            this.ChartAccount,
            this.PriceProfileID,
            this.GroupID,
            this.SalesPersonID,
            this.LimitationAmount});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridView1_KeyDown);
            // 
            // CustomerID
            // 
            this.CustomerID.Caption = "كود العميل";
            this.CustomerID.FieldName = "CustomerID";
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.OptionsColumn.AllowEdit = false;
            this.CustomerID.Visible = true;
            this.CustomerID.VisibleIndex = 0;
            // 
            // ContactNu
            // 
            this.ContactNu.Caption = "العميل";
            this.ContactNu.ColumnEdit = this.customerNameLue;
            this.ContactNu.FieldName = "ContactNu";
            this.ContactNu.Name = "ContactNu";
            this.ContactNu.OptionsColumn.AllowEdit = false;
            this.ContactNu.Visible = true;
            this.ContactNu.VisibleIndex = 1;
            // 
            // customerNameLue
            // 
            this.customerNameLue.AutoHeight = false;
            this.customerNameLue.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.customerNameLue.Name = "customerNameLue";
            // 
            // RegistrationTaxNumber
            // 
            this.RegistrationTaxNumber.Caption = "التسجيل الضريبى";
            this.RegistrationTaxNumber.FieldName = "RegistrationTaxNumber";
            this.RegistrationTaxNumber.Name = "RegistrationTaxNumber";
            this.RegistrationTaxNumber.Visible = true;
            this.RegistrationTaxNumber.VisibleIndex = 2;
            // 
            // ReceiverTyp
            // 
            this.ReceiverTyp.Caption = "نوع العميل";
            this.ReceiverTyp.FieldName = "ReceiverTyp";
            this.ReceiverTyp.Name = "ReceiverTyp";
            this.ReceiverTyp.Visible = true;
            this.ReceiverTyp.VisibleIndex = 3;
            // 
            // Country
            // 
            this.Country.Caption = "البلد";
            this.Country.FieldName = "Country";
            this.Country.Name = "Country";
            this.Country.Visible = true;
            this.Country.VisibleIndex = 4;
            // 
            // Governate
            // 
            this.Governate.Caption = "المحافظة";
            this.Governate.FieldName = "Governate";
            this.Governate.Name = "Governate";
            this.Governate.Visible = true;
            this.Governate.VisibleIndex = 5;
            // 
            // RegionCity
            // 
            this.RegionCity.Caption = "المدينة";
            this.RegionCity.FieldName = "RegionCity";
            this.RegionCity.Name = "RegionCity";
            this.RegionCity.Visible = true;
            this.RegionCity.VisibleIndex = 6;
            // 
            // ChartAccount
            // 
            this.ChartAccount.Caption = "كود الحساب";
            this.ChartAccount.FieldName = "ChartAccount";
            this.ChartAccount.Name = "ChartAccount";
            this.ChartAccount.Visible = true;
            this.ChartAccount.VisibleIndex = 7;
            // 
            // PriceProfileID
            // 
            this.PriceProfileID.Caption = "قائمة التسعير";
            this.PriceProfileID.ColumnEdit = this.customerPriceListLue;
            this.PriceProfileID.FieldName = "PriceProfileID";
            this.PriceProfileID.Name = "PriceProfileID";
            this.PriceProfileID.Visible = true;
            this.PriceProfileID.VisibleIndex = 8;
            // 
            // customerPriceListLue
            // 
            this.customerPriceListLue.AutoHeight = false;
            this.customerPriceListLue.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.customerPriceListLue.Name = "customerPriceListLue";
            // 
            // GroupID
            // 
            this.GroupID.Caption = "المجموعة";
            this.GroupID.ColumnEdit = this.customerGroupLue;
            this.GroupID.FieldName = "GroupID";
            this.GroupID.Name = "GroupID";
            this.GroupID.Visible = true;
            this.GroupID.VisibleIndex = 10;
            // 
            // customerGroupLue
            // 
            this.customerGroupLue.AutoHeight = false;
            this.customerGroupLue.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.customerGroupLue.Name = "customerGroupLue";
            // 
            // SalesPersonID
            // 
            this.SalesPersonID.Caption = "مسؤول البيع";
            this.SalesPersonID.ColumnEdit = this.salesPersonLue;
            this.SalesPersonID.FieldName = "SalesPersonID";
            this.SalesPersonID.Name = "SalesPersonID";
            this.SalesPersonID.Visible = true;
            this.SalesPersonID.VisibleIndex = 11;
            // 
            // salesPersonLue
            // 
            this.salesPersonLue.AutoHeight = false;
            this.salesPersonLue.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.salesPersonLue.Name = "salesPersonLue";
            // 
            // LimitationAmount
            // 
            this.LimitationAmount.Caption = "حد المديونية";
            this.LimitationAmount.FieldName = "LimitationAmount";
            this.LimitationAmount.Name = "LimitationAmount";
            this.LimitationAmount.Visible = true;
            this.LimitationAmount.VisibleIndex = 9;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.emptySpaceItem1,
            this.layoutControlItem3,
            this.emptySpaceItem2,
            this.layoutControlItem4,
            this.excelLayOut,
            this.allGroupsLayOut,
            this.layoutControlItem5});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1173, 646);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 64);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1147, 556);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.saveBtn;
            this.layoutControlItem2.Location = new System.Drawing.Point(132, 0);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(133, 64);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(133, 64);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(133, 64);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(311, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(472, 36);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.showBtn;
            this.layoutControlItem3.Location = new System.Drawing.Point(999, 0);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(148, 64);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(148, 64);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(148, 64);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(311, 36);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(594, 28);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.cstMainGroupLue;
            this.layoutControlItem4.Location = new System.Drawing.Point(783, 0);
            this.layoutControlItem4.MaxSize = new System.Drawing.Size(216, 36);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(216, 36);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(216, 36);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.Text = "المجموعة";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(40, 15);
            // 
            // excelLayOut
            // 
            this.excelLayOut.Control = this.excelBtn;
            this.excelLayOut.Location = new System.Drawing.Point(265, 0);
            this.excelLayOut.MaxSize = new System.Drawing.Size(46, 58);
            this.excelLayOut.MinSize = new System.Drawing.Size(46, 58);
            this.excelLayOut.Name = "excelLayOut";
            this.excelLayOut.Size = new System.Drawing.Size(46, 64);
            this.excelLayOut.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.excelLayOut.TextSize = new System.Drawing.Size(0, 0);
            this.excelLayOut.TextVisible = false;
            // 
            // allGroupsLayOut
            // 
            this.allGroupsLayOut.Control = this.allChBox;
            this.allGroupsLayOut.Location = new System.Drawing.Point(905, 36);
            this.allGroupsLayOut.MaxSize = new System.Drawing.Size(94, 28);
            this.allGroupsLayOut.MinSize = new System.Drawing.Size(94, 28);
            this.allGroupsLayOut.Name = "allGroupsLayOut";
            this.allGroupsLayOut.Size = new System.Drawing.Size(94, 28);
            this.allGroupsLayOut.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.allGroupsLayOut.TextSize = new System.Drawing.Size(0, 0);
            this.allGroupsLayOut.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.AddNewCstBtn;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem5.MinSize = new System.Drawing.Size(94, 34);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(132, 64);
            this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // CustomersInfoFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 646);
            this.Controls.Add(this.layoutControl1);
          
            this.Name = "CustomersInfoFrm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "بيانات العملاء";
            this.Load += new System.EventHandler(this.CustomersInfoFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.allChBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cstMainGroupLue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerNameLue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerPriceListLue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerGroupLue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesPersonLue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.excelLayOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allGroupsLayOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton showBtn;
        private DevExpress.XtraEditors.SimpleButton saveBtn;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraEditors.LookUpEdit cstMainGroupLue;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraGrid.Columns.GridColumn CustomerID;
        private DevExpress.XtraGrid.Columns.GridColumn ContactNu;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit customerNameLue;
        private DevExpress.XtraGrid.Columns.GridColumn RegistrationTaxNumber;
        private DevExpress.XtraGrid.Columns.GridColumn ReceiverTyp;
        private DevExpress.XtraGrid.Columns.GridColumn Country;
        private DevExpress.XtraGrid.Columns.GridColumn Governate;
        private DevExpress.XtraGrid.Columns.GridColumn RegionCity;
        private DevExpress.XtraGrid.Columns.GridColumn ChartAccount;
        private DevExpress.XtraGrid.Columns.GridColumn PriceProfileID;
        private DevExpress.XtraGrid.Columns.GridColumn GroupID;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit customerGroupLue;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit customerPriceListLue;
        private DevExpress.XtraGrid.Columns.GridColumn SalesPersonID;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit salesPersonLue;
        private DevExpress.XtraEditors.SimpleButton excelBtn;
        private DevExpress.XtraLayout.LayoutControlItem excelLayOut;
        private DevExpress.XtraEditors.CheckEdit allChBox;
        private DevExpress.XtraLayout.LayoutControlItem allGroupsLayOut;
        private DevExpress.XtraGrid.Columns.GridColumn LimitationAmount;
        private DevExpress.XtraEditors.SimpleButton AddNewCstBtn;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    }
}