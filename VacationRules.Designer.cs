namespace WFs
{
    partial class VacationRules
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
            this.lueBranches = new DevExpress.XtraEditors.LookUpEdit();
            this.saveBtn = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.VacationRulesID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EmpID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lueEmployeesNames = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.VacationDays = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ApplyAs = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Year = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AttendTypeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lueAttendTypes = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.Carryover = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tsCarryOver = new DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueBranches.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueEmployeesNames)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueAttendTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsCarryOver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.lueBranches);
            this.layoutControl1.Controls.Add(this.saveBtn);
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsView.RightToLeftMirroringApplied = true;
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(939, 542);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // lueBranches
            // 
            this.lueBranches.Location = new System.Drawing.Point(16, 492);
            this.lueBranches.Name = "lueBranches";
            this.lueBranches.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueBranches.Size = new System.Drawing.Size(665, 34);
            this.lueBranches.StyleController = this.layoutControl1;
            this.lueBranches.TabIndex = 6;
            this.lueBranches.EditValueChanged += new System.EventHandler(this.lueBranches_EditValueChanged);
            // 
            // saveBtn
            // 
            this.saveBtn.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question;
            this.saveBtn.Appearance.Options.UseBackColor = true;
            this.saveBtn.Location = new System.Drawing.Point(733, 492);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(190, 34);
            this.saveBtn.StyleController = this.layoutControl1;
            this.saveBtn.TabIndex = 5;
            this.saveBtn.Text = "حفظ";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(16, 16);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.lueEmployeesNames,
            this.lueAttendTypes,
            this.tsCarryOver});
            this.gridControl1.Size = new System.Drawing.Size(907, 470);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.VacationRulesID,
            this.EmpID,
            this.VacationDays,
            this.ApplyAs,
            this.Year,
            this.AttendTypeID,
            this.Carryover});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.NewItemRowText = "اضافة سطر جديد من هنا";
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridView1_KeyDown);
            // 
            // VacationRulesID
            // 
            this.VacationRulesID.Caption = "ID";
            this.VacationRulesID.FieldName = "VacationRulesID";
            this.VacationRulesID.MinWidth = 25;
            this.VacationRulesID.Name = "VacationRulesID";
            this.VacationRulesID.OptionsColumn.AllowEdit = false;
            this.VacationRulesID.Visible = true;
            this.VacationRulesID.VisibleIndex = 0;
            this.VacationRulesID.Width = 94;
            // 
            // EmpID
            // 
            this.EmpID.Caption = "اسم الموظف";
            this.EmpID.ColumnEdit = this.lueEmployeesNames;
            this.EmpID.FieldName = "EmpID";
            this.EmpID.MinWidth = 25;
            this.EmpID.Name = "EmpID";
            this.EmpID.Visible = true;
            this.EmpID.VisibleIndex = 1;
            this.EmpID.Width = 94;
            // 
            // lueEmployeesNames
            // 
            this.lueEmployeesNames.AutoHeight = false;
            this.lueEmployeesNames.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueEmployeesNames.Name = "lueEmployeesNames";
            // 
            // VacationDays
            // 
            this.VacationDays.Caption = "ايام الاجازات";
            this.VacationDays.FieldName = "VacationDays";
            this.VacationDays.MinWidth = 25;
            this.VacationDays.Name = "VacationDays";
            this.VacationDays.Visible = true;
            this.VacationDays.VisibleIndex = 2;
            this.VacationDays.Width = 94;
            // 
            // ApplyAs
            // 
            this.ApplyAs.Caption = "Apply As";
            this.ApplyAs.FieldName = "ApplyAs";
            this.ApplyAs.MinWidth = 25;
            this.ApplyAs.Name = "ApplyAs";
            this.ApplyAs.Visible = true;
            this.ApplyAs.VisibleIndex = 3;
            this.ApplyAs.Width = 94;
            // 
            // Year
            // 
            this.Year.Caption = "السنة";
            this.Year.FieldName = "Year";
            this.Year.MinWidth = 25;
            this.Year.Name = "Year";
            this.Year.Visible = true;
            this.Year.VisibleIndex = 4;
            this.Year.Width = 94;
            // 
            // AttendTypeID
            // 
            this.AttendTypeID.Caption = "نوع الاجازة";
            this.AttendTypeID.ColumnEdit = this.lueAttendTypes;
            this.AttendTypeID.FieldName = "AttendTypeID";
            this.AttendTypeID.MinWidth = 25;
            this.AttendTypeID.Name = "AttendTypeID";
            this.AttendTypeID.Visible = true;
            this.AttendTypeID.VisibleIndex = 5;
            this.AttendTypeID.Width = 94;
            // 
            // lueAttendTypes
            // 
            this.lueAttendTypes.AcceptEditorTextAsNewValue = DevExpress.Utils.DefaultBoolean.True;
            this.lueAttendTypes.AutoHeight = false;
            this.lueAttendTypes.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueAttendTypes.Name = "lueAttendTypes";
            // 
            // Carryover
            // 
            this.Carryover.Caption = "الترحيل";
            this.Carryover.ColumnEdit = this.tsCarryOver;
            this.Carryover.FieldName = "Carryover";
            this.Carryover.MinWidth = 25;
            this.Carryover.Name = "Carryover";
            this.Carryover.Visible = true;
            this.Carryover.VisibleIndex = 6;
            this.Carryover.Width = 94;
            // 
            // tsCarryOver
            // 
            this.tsCarryOver.AutoHeight = false;
            this.tsCarryOver.Name = "tsCarryOver";
            this.tsCarryOver.NullText = "False";
            this.tsCarryOver.OffText = "Off";
            this.tsCarryOver.OnText = "On";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(939, 542);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(913, 476);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.saveBtn;
            this.layoutControlItem2.Location = new System.Drawing.Point(717, 476);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(196, 40);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.lueBranches;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 476);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 8, 3, 3);
            this.layoutControlItem3.Size = new System.Drawing.Size(717, 40);
            this.layoutControlItem3.Text = "الفرع";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(25, 16);
            // 
            // VacationRules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 542);
            this.Controls.Add(this.layoutControl1);
            this.Name = "VacationRules";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "VacationRules";
            this.Load += new System.EventHandler(this.VacationRules_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lueBranches.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueEmployeesNames)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueAttendTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsCarryOver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn VacationRulesID;
        private DevExpress.XtraGrid.Columns.GridColumn EmpID;
        private DevExpress.XtraGrid.Columns.GridColumn VacationDays;
        private DevExpress.XtraGrid.Columns.GridColumn ApplyAs;
        private DevExpress.XtraGrid.Columns.GridColumn Year;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lueEmployeesNames;
        private DevExpress.XtraGrid.Columns.GridColumn AttendTypeID;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lueAttendTypes;
        private DevExpress.XtraGrid.Columns.GridColumn Carryover;
        private DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch tsCarryOver;
        private DevExpress.XtraEditors.LookUpEdit lueBranches;
        private DevExpress.XtraEditors.SimpleButton saveBtn;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    }
}