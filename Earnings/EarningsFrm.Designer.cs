namespace WFs
{
    partial class EarningsFrm
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
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.printBtn = new DevExpress.XtraEditors.SimpleButton();
            this.lueBranches = new DevExpress.XtraEditors.LookUpEdit();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EmpID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lueEmployeesNames = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.EarningID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lueEarnings = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.EarningAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DateFrom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DateTo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Details = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueBranches.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueEmployeesNames)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueEarnings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.layoutControl2);
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsView.RightToLeftMirroringApplied = true;
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1226, 625);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this.printBtn);
            this.layoutControl2.Controls.Add(this.lueBranches);
            this.layoutControl2.Controls.Add(this.btnDelete);
            this.layoutControl2.Controls.Add(this.btnSave);
            this.layoutControl2.Location = new System.Drawing.Point(941, 12);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.OptionsView.RightToLeftMirroringApplied = true;
            this.layoutControl2.Root = this.layoutControlGroup1;
            this.layoutControl2.Size = new System.Drawing.Size(273, 601);
            this.layoutControl2.TabIndex = 5;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // printBtn
            // 
            this.printBtn.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.printBtn.Appearance.Options.UseBackColor = true;
            this.printBtn.Location = new System.Drawing.Point(12, 74);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(249, 27);
            this.printBtn.StyleController = this.layoutControl2;
            this.printBtn.TabIndex = 7;
            this.printBtn.Text = "طباعة";
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
            // 
            // lueBranches
            // 
            this.lueBranches.Location = new System.Drawing.Point(13, 566);
            this.lueBranches.Name = "lueBranches";
            this.lueBranches.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueBranches.Size = new System.Drawing.Size(206, 22);
            this.lueBranches.StyleController = this.layoutControl2;
            this.lueBranches.TabIndex = 6;
            this.lueBranches.EditValueChanged += new System.EventHandler(this.lueBranches_EditValueChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger;
            this.btnDelete.Appearance.Options.UseBackColor = true;
            this.btnDelete.Location = new System.Drawing.Point(12, 43);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(249, 27);
            this.btnDelete.StyleController = this.layoutControl2;
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "حذف";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question;
            this.btnSave.Appearance.Options.UseBackColor = true;
            this.btnSave.Location = new System.Drawing.Point(12, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(249, 27);
            this.btnSave.StyleController = this.layoutControl2;
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "حفظ";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.emptySpaceItem1,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(273, 601);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnSave;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(253, 31);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 93);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(253, 460);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnDelete;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 31);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(253, 31);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.lueBranches;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 553);
            this.layoutControlItem5.MinSize = new System.Drawing.Size(109, 28);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 5, 3, 3);
            this.layoutControlItem5.Size = new System.Drawing.Size(253, 28);
            this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem5.Text = "الفرع";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(27, 16);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.printBtn;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 62);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(253, 31);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.lueEmployeesNames,
            this.lueEarnings});
            this.gridControl1.Size = new System.Drawing.Size(925, 601);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.EmpID,
            this.EarningID,
            this.EarningAmount,
            this.DateFrom,
            this.DateTo,
            this.Details});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.NewItemRowText = "اضف سطر جديد من هنا";
            this.gridView1.OptionsEditForm.PopupEditFormWidth = 700;
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridView1_KeyDown);
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.MinWidth = 22;
            this.ID.Name = "ID";
            this.ID.OptionsColumn.AllowEdit = false;
            this.ID.Visible = true;
            this.ID.VisibleIndex = 0;
            this.ID.Width = 47;
            // 
            // EmpID
            // 
            this.EmpID.Caption = "اسم الموظف";
            this.EmpID.ColumnEdit = this.lueEmployeesNames;
            this.EmpID.FieldName = "EmpID";
            this.EmpID.MinWidth = 22;
            this.EmpID.Name = "EmpID";
            this.EmpID.Visible = true;
            this.EmpID.VisibleIndex = 1;
            this.EmpID.Width = 164;
            // 
            // lueEmployeesNames
            // 
            this.lueEmployeesNames.AutoHeight = false;
            this.lueEmployeesNames.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueEmployeesNames.Name = "lueEmployeesNames";
            // 
            // EarningID
            // 
            this.EarningID.Caption = "المكافأة";
            this.EarningID.ColumnEdit = this.lueEarnings;
            this.EarningID.FieldName = "EarningID";
            this.EarningID.MinWidth = 22;
            this.EarningID.Name = "EarningID";
            this.EarningID.Visible = true;
            this.EarningID.VisibleIndex = 2;
            // 
            // lueEarnings
            // 
            this.lueEarnings.AutoHeight = false;
            this.lueEarnings.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueEarnings.Name = "lueEarnings";
            // 
            // EarningAmount
            // 
            this.EarningAmount.Caption = "قيمة المكافأة";
            this.EarningAmount.DisplayFormat.FormatString = "n0";
            this.EarningAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.EarningAmount.FieldName = "EarningAmount";
            this.EarningAmount.MinWidth = 22;
            this.EarningAmount.Name = "EarningAmount";
            this.EarningAmount.Visible = true;
            this.EarningAmount.VisibleIndex = 3;
            // 
            // DateFrom
            // 
            this.DateFrom.Caption = "من";
            this.DateFrom.DisplayFormat.FormatString = "dd-MM-yyy";
            this.DateFrom.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.DateFrom.FieldName = "DateFrom";
            this.DateFrom.MinWidth = 22;
            this.DateFrom.Name = "DateFrom";
            this.DateFrom.Visible = true;
            this.DateFrom.VisibleIndex = 4;
            this.DateFrom.Width = 80;
            // 
            // DateTo
            // 
            this.DateTo.Caption = "الي";
            this.DateTo.DisplayFormat.FormatString = "dd-MM-yyy";
            this.DateTo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.DateTo.FieldName = "DateTo";
            this.DateTo.MinWidth = 22;
            this.DateTo.Name = "DateTo";
            this.DateTo.Visible = true;
            this.DateTo.VisibleIndex = 5;
            this.DateTo.Width = 82;
            // 
            // Details
            // 
            this.Details.Caption = "التفاصيل";
            this.Details.FieldName = "Details";
            this.Details.MinWidth = 22;
            this.Details.Name = "Details";
            this.Details.Visible = true;
            this.Details.VisibleIndex = 6;
            this.Details.Width = 82;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1226, 625);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(929, 605);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.layoutControl2;
            this.layoutControlItem2.Location = new System.Drawing.Point(929, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(277, 605);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // EarningsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 625);
            this.Controls.Add(this.layoutControl1);
            this.Name = "EarningsFrm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "EarningsFrm";
            this.Load += new System.EventHandler(this.EarningsFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lueBranches.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueEmployeesNames)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueEarnings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.LookUpEdit lueBranches;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn EmpID;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lueEmployeesNames;
        private DevExpress.XtraGrid.Columns.GridColumn EarningID;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lueEarnings;
        private DevExpress.XtraGrid.Columns.GridColumn EarningAmount;
        private DevExpress.XtraGrid.Columns.GridColumn DateFrom;
        private DevExpress.XtraGrid.Columns.GridColumn DateTo;
        private DevExpress.XtraGrid.Columns.GridColumn Details;
        private DevExpress.XtraEditors.SimpleButton printBtn;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
    }
}