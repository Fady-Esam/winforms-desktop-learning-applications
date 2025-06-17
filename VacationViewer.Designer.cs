namespace WFs
{
    partial class VacationViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VacationViewer));
            this.SplitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.LayoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.lueBranch = new DevExpress.XtraEditors.LookUpEdit();
            this.btnPrintVacation = new DevExpress.XtraEditors.SimpleButton();
            this.btnDeleteVacation = new DevExpress.XtraEditors.SimpleButton();
            this.btnNewVacation = new DevExpress.XtraEditors.SimpleButton();
            this.LayoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.LayoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.LayoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.LayoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.LayoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.LayoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.EmptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.LayoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EmpID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lueEmployeesNames = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.AttendTypeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lueAttendType = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.startDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ReturnToWork = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Amount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Currency = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lueCurrency = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.Reason = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainerControl1.Panel1)).BeginInit();
            this.SplitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainerControl1.Panel2)).BeginInit();
            this.SplitContainerControl1.Panel2.SuspendLayout();
            this.SplitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LayoutControl2)).BeginInit();
            this.LayoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueBranch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmptySpaceItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayoutControl1)).BeginInit();
            this.LayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueEmployeesNames)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueAttendType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueCurrency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // SplitContainerControl1
            // 
            this.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainerControl1.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.None;
            this.SplitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.SplitContainerControl1.Name = "SplitContainerControl1";
            // 
            // SplitContainerControl1.Panel1
            // 
            this.SplitContainerControl1.Panel1.Controls.Add(this.LayoutControl2);
            this.SplitContainerControl1.Panel1.Text = "Panel1";
            // 
            // SplitContainerControl1.Panel2
            // 
            this.SplitContainerControl1.Panel2.Controls.Add(this.LayoutControl1);
            this.SplitContainerControl1.Panel2.Text = "Panel2";
            this.SplitContainerControl1.ShowSplitGlyph = DevExpress.Utils.DefaultBoolean.True;
            this.SplitContainerControl1.Size = new System.Drawing.Size(1292, 703);
            this.SplitContainerControl1.SplitterPosition = 208;
            this.SplitContainerControl1.TabIndex = 1;
            // 
            // LayoutControl2
            // 
            this.LayoutControl2.Controls.Add(this.btnRefresh);
            this.LayoutControl2.Controls.Add(this.lueBranch);
            this.LayoutControl2.Controls.Add(this.btnPrintVacation);
            this.LayoutControl2.Controls.Add(this.btnDeleteVacation);
            this.LayoutControl2.Controls.Add(this.btnNewVacation);
            this.LayoutControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LayoutControl2.Location = new System.Drawing.Point(0, 0);
            this.LayoutControl2.Name = "LayoutControl2";
            this.LayoutControl2.OptionsView.RightToLeftMirroringApplied = true;
            this.LayoutControl2.Root = this.LayoutControlGroup1;
            this.LayoutControl2.Size = new System.Drawing.Size(208, 703);
            this.LayoutControl2.TabIndex = 0;
            this.LayoutControl2.Text = "LayoutControl2";
            // 
            // btnRefresh
            // 
            this.btnRefresh.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRefresh.ImageOptions.SvgImage")));
            this.btnRefresh.ImageOptions.SvgImageSize = new System.Drawing.Size(30, 30);
            this.btnRefresh.Location = new System.Drawing.Point(12, 117);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(184, 35);
            this.btnRefresh.StyleController = this.LayoutControl2;
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "اعادة تحميل";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click_1);
            // 
            // lueBranch
            // 
            this.lueBranch.Location = new System.Drawing.Point(12, 669);
            this.lueBranch.Name = "lueBranch";
            this.lueBranch.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueBranch.Properties.NullText = "";
            this.lueBranch.Size = new System.Drawing.Size(184, 22);
            this.lueBranch.StyleController = this.LayoutControl2;
            this.lueBranch.TabIndex = 4;
            this.lueBranch.EditValueChanged += new System.EventHandler(this.lueBranch_EditValueChanged_1);
            // 
            // btnPrintVacation
            // 
            this.btnPrintVacation.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPrintVacation.ImageOptions.SvgImage")));
            this.btnPrintVacation.ImageOptions.SvgImageSize = new System.Drawing.Size(25, 25);
            this.btnPrintVacation.Location = new System.Drawing.Point(12, 82);
            this.btnPrintVacation.Name = "btnPrintVacation";
            this.btnPrintVacation.Size = new System.Drawing.Size(184, 31);
            this.btnPrintVacation.StyleController = this.LayoutControl2;
            this.btnPrintVacation.TabIndex = 3;
            this.btnPrintVacation.Text = "طباعة";
            this.btnPrintVacation.Click += new System.EventHandler(this.btnPrintVacation_Click_1);
            // 
            // btnDeleteVacation
            // 
            this.btnDeleteVacation.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDeleteVacation.ImageOptions.SvgImage")));
            this.btnDeleteVacation.ImageOptions.SvgImageSize = new System.Drawing.Size(25, 25);
            this.btnDeleteVacation.Location = new System.Drawing.Point(12, 47);
            this.btnDeleteVacation.Name = "btnDeleteVacation";
            this.btnDeleteVacation.Size = new System.Drawing.Size(184, 31);
            this.btnDeleteVacation.StyleController = this.LayoutControl2;
            this.btnDeleteVacation.TabIndex = 2;
            this.btnDeleteVacation.Text = "حذف";
            this.btnDeleteVacation.Click += new System.EventHandler(this.btnDeleteVacation_Click_1);
            // 
            // btnNewVacation
            // 
            this.btnNewVacation.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnNewVacation.ImageOptions.SvgImage")));
            this.btnNewVacation.ImageOptions.SvgImageSize = new System.Drawing.Size(25, 25);
            this.btnNewVacation.Location = new System.Drawing.Point(12, 12);
            this.btnNewVacation.Name = "btnNewVacation";
            this.btnNewVacation.Size = new System.Drawing.Size(184, 31);
            this.btnNewVacation.StyleController = this.LayoutControl2;
            this.btnNewVacation.TabIndex = 0;
            this.btnNewVacation.Text = "حفظ";
            this.btnNewVacation.Click += new System.EventHandler(this.btnNewVacation_Click_1);
            // 
            // LayoutControlGroup1
            // 
            this.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.LayoutControlGroup1.GroupBordersVisible = false;
            this.LayoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.LayoutControlItem2,
            this.LayoutControlItem3,
            this.LayoutControlItem4,
            this.LayoutControlItem6,
            this.LayoutControlItem7,
            this.EmptySpaceItem5});
            this.LayoutControlGroup1.Name = "Root";
            this.LayoutControlGroup1.Size = new System.Drawing.Size(208, 703);
            this.LayoutControlGroup1.TextVisible = false;
            // 
            // LayoutControlItem2
            // 
            this.LayoutControlItem2.Control = this.btnNewVacation;
            this.LayoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.LayoutControlItem2.MaxSize = new System.Drawing.Size(0, 35);
            this.LayoutControlItem2.MinSize = new System.Drawing.Size(61, 35);
            this.LayoutControlItem2.Name = "LayoutControlItem2";
            this.LayoutControlItem2.Size = new System.Drawing.Size(188, 35);
            this.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.LayoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.LayoutControlItem2.TextVisible = false;
            // 
            // LayoutControlItem3
            // 
            this.LayoutControlItem3.Control = this.btnDeleteVacation;
            this.LayoutControlItem3.Location = new System.Drawing.Point(0, 35);
            this.LayoutControlItem3.MaxSize = new System.Drawing.Size(0, 35);
            this.LayoutControlItem3.MinSize = new System.Drawing.Size(71, 35);
            this.LayoutControlItem3.Name = "LayoutControlItem3";
            this.LayoutControlItem3.Size = new System.Drawing.Size(188, 35);
            this.LayoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.LayoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.LayoutControlItem3.TextVisible = false;
            // 
            // LayoutControlItem4
            // 
            this.LayoutControlItem4.Control = this.btnPrintVacation;
            this.LayoutControlItem4.Location = new System.Drawing.Point(0, 70);
            this.LayoutControlItem4.MaxSize = new System.Drawing.Size(0, 35);
            this.LayoutControlItem4.MinSize = new System.Drawing.Size(63, 35);
            this.LayoutControlItem4.Name = "LayoutControlItem4";
            this.LayoutControlItem4.Size = new System.Drawing.Size(188, 35);
            this.LayoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.LayoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.LayoutControlItem4.TextVisible = false;
            // 
            // LayoutControlItem6
            // 
            this.LayoutControlItem6.Control = this.lueBranch;
            this.LayoutControlItem6.Location = new System.Drawing.Point(0, 657);
            this.LayoutControlItem6.Name = "LayoutControlItem6";
            this.LayoutControlItem6.Size = new System.Drawing.Size(188, 26);
            this.LayoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.LayoutControlItem6.TextVisible = false;
            // 
            // LayoutControlItem7
            // 
            this.LayoutControlItem7.Control = this.btnRefresh;
            this.LayoutControlItem7.Location = new System.Drawing.Point(0, 105);
            this.LayoutControlItem7.MaxSize = new System.Drawing.Size(0, 39);
            this.LayoutControlItem7.MinSize = new System.Drawing.Size(1, 39);
            this.LayoutControlItem7.Name = "LayoutControlItem7";
            this.LayoutControlItem7.Size = new System.Drawing.Size(188, 39);
            this.LayoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.LayoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.LayoutControlItem7.TextVisible = false;
            // 
            // EmptySpaceItem5
            // 
            this.EmptySpaceItem5.AllowHotTrack = false;
            this.EmptySpaceItem5.Location = new System.Drawing.Point(0, 144);
            this.EmptySpaceItem5.Name = "EmptySpaceItem5";
            this.EmptySpaceItem5.Size = new System.Drawing.Size(188, 513);
            this.EmptySpaceItem5.TextSize = new System.Drawing.Size(0, 0);
            // 
            // LayoutControl1
            // 
            this.LayoutControl1.Controls.Add(this.gridControl1);
            this.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.LayoutControl1.Name = "LayoutControl1";
            this.LayoutControl1.OptionsView.RightToLeftMirroringApplied = true;
            this.LayoutControl1.Root = this.Root;
            this.LayoutControl1.Size = new System.Drawing.Size(1072, 703);
            this.LayoutControl1.TabIndex = 0;
            this.LayoutControl1.Text = "LayoutControl1";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.lueEmployeesNames,
            this.lueAttendType,
            this.lueCurrency});
            this.gridControl1.Size = new System.Drawing.Size(1048, 679);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.EmpID,
            this.AttendTypeID,
            this.startDate,
            this.ReturnToWork,
            this.Amount,
            this.Currency,
            this.Reason});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.NewItemRowText = "اضافة سطر جديد هنا";
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
            this.ID.Width = 115;
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
            this.EmpID.Width = 161;
            // 
            // lueEmployeesNames
            // 
            this.lueEmployeesNames.AutoHeight = false;
            this.lueEmployeesNames.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueEmployeesNames.Name = "lueEmployeesNames";
            // 
            // AttendTypeID
            // 
            this.AttendTypeID.Caption = "نوع الاجازة";
            this.AttendTypeID.ColumnEdit = this.lueAttendType;
            this.AttendTypeID.FieldName = "AttendTypeID";
            this.AttendTypeID.MinWidth = 22;
            this.AttendTypeID.Name = "AttendTypeID";
            this.AttendTypeID.Visible = true;
            this.AttendTypeID.VisibleIndex = 2;
            this.AttendTypeID.Width = 128;
            // 
            // lueAttendType
            // 
            this.lueAttendType.AutoHeight = false;
            this.lueAttendType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueAttendType.Name = "lueAttendType";
            // 
            // startDate
            // 
            this.startDate.Caption = "بداية الاجازة";
            this.startDate.DisplayFormat.FormatString = "dd-MM-yyy";
            this.startDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.startDate.FieldName = "startDate";
            this.startDate.MinWidth = 22;
            this.startDate.Name = "startDate";
            this.startDate.Visible = true;
            this.startDate.VisibleIndex = 3;
            this.startDate.Width = 112;
            // 
            // ReturnToWork
            // 
            this.ReturnToWork.Caption = "نهاية الاجازة";
            this.ReturnToWork.DisplayFormat.FormatString = "dd-MM-yyy";
            this.ReturnToWork.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.ReturnToWork.FieldName = "ReturnToWork";
            this.ReturnToWork.MinWidth = 22;
            this.ReturnToWork.Name = "ReturnToWork";
            this.ReturnToWork.Visible = true;
            this.ReturnToWork.VisibleIndex = 4;
            this.ReturnToWork.Width = 72;
            // 
            // Amount
            // 
            this.Amount.Caption = "القيمة";
            this.Amount.FieldName = "Amount";
            this.Amount.MinWidth = 22;
            this.Amount.Name = "Amount";
            this.Amount.Visible = true;
            this.Amount.VisibleIndex = 5;
            this.Amount.Width = 106;
            // 
            // Currency
            // 
            this.Currency.Caption = "العملة";
            this.Currency.ColumnEdit = this.lueCurrency;
            this.Currency.FieldName = "Currency";
            this.Currency.MinWidth = 22;
            this.Currency.Name = "Currency";
            this.Currency.Visible = true;
            this.Currency.VisibleIndex = 6;
            this.Currency.Width = 67;
            // 
            // lueCurrency
            // 
            this.lueCurrency.AutoHeight = false;
            this.lueCurrency.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueCurrency.Name = "lueCurrency";
            // 
            // Reason
            // 
            this.Reason.Caption = "السبب";
            this.Reason.FieldName = "Reason";
            this.Reason.MinWidth = 22;
            this.Reason.Name = "Reason";
            this.Reason.Visible = true;
            this.Reason.VisibleIndex = 7;
            this.Reason.Width = 159;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem5});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1072, 703);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.gridControl1;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(1052, 683);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // VacationViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 703);
            this.Controls.Add(this.SplitContainerControl1);
            this.Name = "VacationViewer";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "VacationViewer";
            this.Load += new System.EventHandler(this.VacationViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainerControl1.Panel1)).EndInit();
            this.SplitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainerControl1.Panel2)).EndInit();
            this.SplitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainerControl1)).EndInit();
            this.SplitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LayoutControl2)).EndInit();
            this.LayoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lueBranch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmptySpaceItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayoutControl1)).EndInit();
            this.LayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueEmployeesNames)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueAttendType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueCurrency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal DevExpress.XtraEditors.SplitContainerControl SplitContainerControl1;
        internal DevExpress.XtraLayout.LayoutControl LayoutControl2;
        internal DevExpress.XtraEditors.SimpleButton btnRefresh;
        internal DevExpress.XtraEditors.LookUpEdit lueBranch;
        internal DevExpress.XtraEditors.SimpleButton btnPrintVacation;
        internal DevExpress.XtraEditors.SimpleButton btnDeleteVacation;
        internal DevExpress.XtraEditors.SimpleButton btnNewVacation;
        internal DevExpress.XtraLayout.LayoutControlGroup LayoutControlGroup1;
        internal DevExpress.XtraLayout.LayoutControlItem LayoutControlItem2;
        internal DevExpress.XtraLayout.LayoutControlItem LayoutControlItem3;
        internal DevExpress.XtraLayout.LayoutControlItem LayoutControlItem4;
        internal DevExpress.XtraLayout.LayoutControlItem LayoutControlItem6;
        internal DevExpress.XtraLayout.LayoutControlItem LayoutControlItem7;
        internal DevExpress.XtraLayout.EmptySpaceItem EmptySpaceItem5;
        internal DevExpress.XtraLayout.LayoutControl LayoutControl1;
        internal DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn EmpID;
        private DevExpress.XtraGrid.Columns.GridColumn AttendTypeID;
        private DevExpress.XtraGrid.Columns.GridColumn startDate;
        private DevExpress.XtraGrid.Columns.GridColumn ReturnToWork;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lueEmployeesNames;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lueAttendType;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn Amount;
        private DevExpress.XtraGrid.Columns.GridColumn Currency;
        private DevExpress.XtraGrid.Columns.GridColumn Reason;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lueCurrency;
    }
}