namespace WFs
{
    partial class ContractRateFrm
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.hbContractChildID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ContractRateID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ChildString = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ChildValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Apply = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ContractsRatesLue = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.hbContractRateID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RoomCategoryID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TravelPeriodsID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AdultRate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ExtraAdultRate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SGLSuppl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ApplyAs = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ContractsLue = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContractsRatesLue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContractsLue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.simpleButton3);
            this.layoutControl1.Controls.Add(this.gridControl2);
            this.layoutControl1.Controls.Add(this.simpleButton2);
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1022, 535);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(859, 496);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(151, 27);
            this.simpleButton3.StyleController = this.layoutControl1;
            this.simpleButton3.TabIndex = 8;
            this.simpleButton3.Text = "Save";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // gridControl2
            // 
            this.gridControl2.Location = new System.Drawing.Point(12, 270);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ContractsRatesLue});
            this.gridControl2.Size = new System.Drawing.Size(998, 222);
            this.gridControl2.TabIndex = 7;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.gridControl2.Click += new System.EventHandler(this.gridControl2_Click);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.hbContractChildID,
            this.ContractRateID,
            this.ChildString,
            this.ChildValue,
            this.Apply});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.NewItemRowText = "Add New Row";
            this.gridView2.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            // 
            // hbContractChildID
            // 
            this.hbContractChildID.Caption = "ID";
            this.hbContractChildID.FieldName = "hbContractChildID";
            this.hbContractChildID.MinWidth = 25;
            this.hbContractChildID.Name = "hbContractChildID";
            this.hbContractChildID.OptionsColumn.AllowEdit = false;
            this.hbContractChildID.Visible = true;
            this.hbContractChildID.VisibleIndex = 0;
            this.hbContractChildID.Width = 94;
            // 
            // ContractRateID
            // 
            this.ContractRateID.Caption = "Contract Rate ID";
            this.ContractRateID.FieldName = "hbContractRateID";
            this.ContractRateID.MinWidth = 25;
            this.ContractRateID.Name = "ContractRateID";
            this.ContractRateID.OptionsColumn.AllowEdit = false;
            this.ContractRateID.Visible = true;
            this.ContractRateID.VisibleIndex = 1;
            this.ContractRateID.Width = 94;
            // 
            // ChildString
            // 
            this.ChildString.Caption = "Child String";
            this.ChildString.FieldName = "ChildString";
            this.ChildString.MinWidth = 25;
            this.ChildString.Name = "ChildString";
            this.ChildString.Visible = true;
            this.ChildString.VisibleIndex = 2;
            this.ChildString.Width = 94;
            // 
            // ChildValue
            // 
            this.ChildValue.Caption = "Child Value";
            this.ChildValue.FieldName = "ChildValue";
            this.ChildValue.MinWidth = 25;
            this.ChildValue.Name = "ChildValue";
            this.ChildValue.Visible = true;
            this.ChildValue.VisibleIndex = 3;
            this.ChildValue.Width = 94;
            // 
            // Apply
            // 
            this.Apply.Caption = "Apply As";
            this.Apply.FieldName = "ApplyAs";
            this.Apply.MinWidth = 25;
            this.Apply.Name = "Apply";
            this.Apply.Visible = true;
            this.Apply.VisibleIndex = 4;
            this.Apply.Width = 94;
            // 
            // ContractsRatesLue
            // 
            this.ContractsRatesLue.AutoHeight = false;
            this.ContractsRatesLue.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ContractsRatesLue.Name = "ContractsRatesLue";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(830, 239);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(180, 27);
            this.simpleButton2.StyleController = this.layoutControl1;
            this.simpleButton2.TabIndex = 6;
            this.simpleButton2.Text = "Save";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ContractsLue});
            this.gridControl1.Size = new System.Drawing.Size(998, 223);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.hbContractRateID,
            this.RoomCategoryID,
            this.TravelPeriodsID,
            this.AdultRate,
            this.ExtraAdultRate,
            this.SGLSuppl,
            this.ApplyAs});
            this.gridView1.DetailTabHeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Left;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.NewItemRowText = "Add New Row";
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridView1.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView1_RowCellClick);
            // 
            // hbContractRateID
            // 
            this.hbContractRateID.Caption = "ID";
            this.hbContractRateID.FieldName = "hbContractRateID";
            this.hbContractRateID.MinWidth = 25;
            this.hbContractRateID.Name = "hbContractRateID";
            this.hbContractRateID.OptionsColumn.AllowEdit = false;
            this.hbContractRateID.Visible = true;
            this.hbContractRateID.VisibleIndex = 0;
            this.hbContractRateID.Width = 94;
            // 
            // RoomCategoryID
            // 
            this.RoomCategoryID.Caption = "Room Category ID";
            this.RoomCategoryID.FieldName = "RoomCategoryID";
            this.RoomCategoryID.MinWidth = 25;
            this.RoomCategoryID.Name = "RoomCategoryID";
            this.RoomCategoryID.Visible = true;
            this.RoomCategoryID.VisibleIndex = 1;
            this.RoomCategoryID.Width = 94;
            // 
            // TravelPeriodsID
            // 
            this.TravelPeriodsID.Caption = "Travel Periods ID";
            this.TravelPeriodsID.FieldName = "TravelPeriodsID";
            this.TravelPeriodsID.MinWidth = 25;
            this.TravelPeriodsID.Name = "TravelPeriodsID";
            this.TravelPeriodsID.Visible = true;
            this.TravelPeriodsID.VisibleIndex = 2;
            this.TravelPeriodsID.Width = 94;
            // 
            // AdultRate
            // 
            this.AdultRate.Caption = "Adult Rate";
            this.AdultRate.FieldName = "AdultRate";
            this.AdultRate.MinWidth = 25;
            this.AdultRate.Name = "AdultRate";
            this.AdultRate.Visible = true;
            this.AdultRate.VisibleIndex = 3;
            this.AdultRate.Width = 94;
            // 
            // ExtraAdultRate
            // 
            this.ExtraAdultRate.Caption = "Extra Adult Rate";
            this.ExtraAdultRate.FieldName = "ExtraAdultRate";
            this.ExtraAdultRate.MinWidth = 25;
            this.ExtraAdultRate.Name = "ExtraAdultRate";
            this.ExtraAdultRate.Visible = true;
            this.ExtraAdultRate.VisibleIndex = 4;
            this.ExtraAdultRate.Width = 94;
            // 
            // SGLSuppl
            // 
            this.SGLSuppl.Caption = "SGL Suppl";
            this.SGLSuppl.FieldName = "SGLSuppl";
            this.SGLSuppl.MinWidth = 25;
            this.SGLSuppl.Name = "SGLSuppl";
            this.SGLSuppl.Visible = true;
            this.SGLSuppl.VisibleIndex = 5;
            this.SGLSuppl.Width = 94;
            // 
            // ApplyAs
            // 
            this.ApplyAs.Caption = "Apply As";
            this.ApplyAs.FieldName = "ApplyAs";
            this.ApplyAs.MinWidth = 25;
            this.ApplyAs.Name = "ApplyAs";
            this.ApplyAs.Visible = true;
            this.ApplyAs.VisibleIndex = 6;
            this.ApplyAs.Width = 94;
            // 
            // ContractsLue
            // 
            this.ContractsLue.AutoHeight = false;
            this.ContractsLue.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ContractsLue.Name = "ContractsLue";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.emptySpaceItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1022, 535);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1002, 227);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 227);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(818, 31);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.simpleButton2;
            this.layoutControlItem3.Location = new System.Drawing.Point(818, 227);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(184, 31);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.gridControl2;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 258);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(1002, 226);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.simpleButton3;
            this.layoutControlItem5.Location = new System.Drawing.Point(847, 484);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(155, 31);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 484);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(847, 31);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // ContractRateFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 535);
            this.Controls.Add(this.layoutControl1);
            this.Name = "ContractRateFrm";
            this.Text = "ContractRateFrm";
            this.Load += new System.EventHandler(this.ContractRateFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContractsRatesLue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContractsLue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraGrid.Columns.GridColumn hbContractRateID;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ContractsLue;
        private DevExpress.XtraGrid.Columns.GridColumn RoomCategoryID;
        private DevExpress.XtraGrid.Columns.GridColumn TravelPeriodsID;
        private DevExpress.XtraGrid.Columns.GridColumn AdultRate;
        private DevExpress.XtraGrid.Columns.GridColumn ExtraAdultRate;
        private DevExpress.XtraGrid.Columns.GridColumn SGLSuppl;
        private DevExpress.XtraGrid.Columns.GridColumn ApplyAs;
        private DevExpress.XtraGrid.Columns.GridColumn hbContractChildID;
        private DevExpress.XtraGrid.Columns.GridColumn ContractRateID;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ContractsRatesLue;
        private DevExpress.XtraGrid.Columns.GridColumn ChildString;
        private DevExpress.XtraGrid.Columns.GridColumn ChildValue;
        private DevExpress.XtraGrid.Columns.GridColumn Apply;
    }
}