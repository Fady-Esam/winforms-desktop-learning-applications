namespace WFs
{
    partial class SalariesFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalariesFrm));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.lueBranches = new DevExpress.XtraEditors.LookUpEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ContactName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DepName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.JobTitle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Salary = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Currency = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GeneName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IsTaxable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tsTaxable = new DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch();
            this.Description = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DueSalary = new DevExpress.XtraGrid.Columns.GridColumn();
            this.totalDeduct = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IncomeTax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TaxIndication = new DevExpress.XtraGrid.Columns.GridColumn();
            this.InsIndication = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueBranches.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsTaxable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnPrint);
            this.layoutControl1.Controls.Add(this.lueBranches);
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsView.RightToLeftMirroringApplied = true;
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1074, 574);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnPrint
            // 
            this.btnPrint.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPrint.ImageOptions.SvgImage")));
            this.btnPrint.Location = new System.Drawing.Point(775, 12);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(49, 48);
            this.btnPrint.StyleController = this.layoutControl1;
            this.btnPrint.TabIndex = 6;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // lueBranches
            // 
            this.lueBranches.Location = new System.Drawing.Point(829, 13);
            this.lueBranches.Name = "lueBranches";
            this.lueBranches.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueBranches.Size = new System.Drawing.Size(191, 22);
            this.lueBranches.StyleController = this.layoutControl1;
            this.lueBranches.TabIndex = 5;
            this.lueBranches.EditValueChanged += new System.EventHandler(this.lueBranches_EditValueChanged);
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 64);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.tsTaxable});
            this.gridControl1.Size = new System.Drawing.Size(1050, 498);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ContactName,
            this.DepName,
            this.JobTitle,
            this.Salary,
            this.Currency,
            this.GeneName,
            this.IsTaxable,
            this.Description,
            this.DueSalary,
            this.totalDeduct,
            this.IncomeTax,
            this.TaxIndication,
            this.InsIndication});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsEditForm.PopupEditFormWidth = 700;
            // 
            // ContactName
            // 
            this.ContactName.Caption = "اسم الموظف";
            this.ContactName.FieldName = "ContactName";
            this.ContactName.MinWidth = 22;
            this.ContactName.Name = "ContactName";
            this.ContactName.OptionsColumn.AllowEdit = false;
            this.ContactName.Visible = true;
            this.ContactName.VisibleIndex = 0;
            this.ContactName.Width = 76;
            // 
            // DepName
            // 
            this.DepName.Caption = "القسم";
            this.DepName.FieldName = "DepName";
            this.DepName.MinWidth = 22;
            this.DepName.Name = "DepName";
            this.DepName.OptionsColumn.AllowEdit = false;
            this.DepName.Visible = true;
            this.DepName.VisibleIndex = 1;
            this.DepName.Width = 76;
            // 
            // JobTitle
            // 
            this.JobTitle.Caption = "المسمي الوظيفي";
            this.JobTitle.FieldName = "JobTitle";
            this.JobTitle.MinWidth = 22;
            this.JobTitle.Name = "JobTitle";
            this.JobTitle.OptionsColumn.AllowEdit = false;
            this.JobTitle.Visible = true;
            this.JobTitle.VisibleIndex = 2;
            this.JobTitle.Width = 76;
            // 
            // Salary
            // 
            this.Salary.Caption = "المرتب";
            this.Salary.FieldName = "Salary";
            this.Salary.MinWidth = 22;
            this.Salary.Name = "Salary";
            this.Salary.OptionsColumn.AllowEdit = false;
            this.Salary.Visible = true;
            this.Salary.VisibleIndex = 3;
            this.Salary.Width = 76;
            // 
            // Currency
            // 
            this.Currency.Caption = "العملة";
            this.Currency.FieldName = "Currency";
            this.Currency.MinWidth = 22;
            this.Currency.Name = "Currency";
            this.Currency.OptionsColumn.AllowEdit = false;
            this.Currency.Visible = true;
            this.Currency.VisibleIndex = 4;
            this.Currency.Width = 76;
            // 
            // GeneName
            // 
            this.GeneName.Caption = "النوع";
            this.GeneName.FieldName = "GeneName";
            this.GeneName.MinWidth = 22;
            this.GeneName.Name = "GeneName";
            this.GeneName.OptionsColumn.AllowEdit = false;
            this.GeneName.Visible = true;
            this.GeneName.VisibleIndex = 5;
            this.GeneName.Width = 76;
            // 
            // IsTaxable
            // 
            this.IsTaxable.Caption = "تطبيق الضريبة";
            this.IsTaxable.ColumnEdit = this.tsTaxable;
            this.IsTaxable.FieldName = "IsTaxable";
            this.IsTaxable.MinWidth = 22;
            this.IsTaxable.Name = "IsTaxable";
            this.IsTaxable.OptionsColumn.AllowEdit = false;
            this.IsTaxable.Visible = true;
            this.IsTaxable.VisibleIndex = 6;
            this.IsTaxable.Width = 76;
            // 
            // tsTaxable
            // 
            this.tsTaxable.AutoHeight = false;
            this.tsTaxable.Name = "tsTaxable";
            this.tsTaxable.OffText = "Off";
            this.tsTaxable.OnText = "On";
            // 
            // Description
            // 
            this.Description.Caption = "الوصف";
            this.Description.FieldName = "Description";
            this.Description.MinWidth = 22;
            this.Description.Name = "Description";
            this.Description.OptionsColumn.AllowEdit = false;
            this.Description.Visible = true;
            this.Description.VisibleIndex = 7;
            this.Description.Width = 59;
            // 
            // DueSalary
            // 
            this.DueSalary.Caption = "الراتب المستحق";
            this.DueSalary.FieldName = "DueSalary";
            this.DueSalary.MinWidth = 22;
            this.DueSalary.Name = "DueSalary";
            this.DueSalary.OptionsColumn.AllowEdit = false;
            this.DueSalary.Visible = true;
            this.DueSalary.VisibleIndex = 8;
            this.DueSalary.Width = 79;
            // 
            // totalDeduct
            // 
            this.totalDeduct.Caption = "مجموع الخصومات";
            this.totalDeduct.FieldName = "totalDeduct";
            this.totalDeduct.MinWidth = 22;
            this.totalDeduct.Name = "totalDeduct";
            this.totalDeduct.OptionsColumn.AllowEdit = false;
            this.totalDeduct.Visible = true;
            this.totalDeduct.VisibleIndex = 9;
            this.totalDeduct.Width = 79;
            // 
            // IncomeTax
            // 
            this.IncomeTax.Caption = "ضريبة الدخل";
            this.IncomeTax.FieldName = "IncomeTax";
            this.IncomeTax.MinWidth = 22;
            this.IncomeTax.Name = "IncomeTax";
            this.IncomeTax.OptionsColumn.AllowEdit = false;
            this.IncomeTax.Visible = true;
            this.IncomeTax.VisibleIndex = 10;
            this.IncomeTax.Width = 79;
            // 
            // TaxIndication
            // 
            this.TaxIndication.Caption = "دلالة الضريبة";
            this.TaxIndication.FieldName = "TaxIndication";
            this.TaxIndication.MinWidth = 22;
            this.TaxIndication.Name = "TaxIndication";
            this.TaxIndication.OptionsColumn.AllowEdit = false;
            this.TaxIndication.Visible = true;
            this.TaxIndication.VisibleIndex = 11;
            this.TaxIndication.Width = 79;
            // 
            // InsIndication
            // 
            this.InsIndication.Caption = "دلالة التأمين";
            this.InsIndication.FieldName = "InsIndication";
            this.InsIndication.MinWidth = 22;
            this.InsIndication.Name = "InsIndication";
            this.InsIndication.OptionsColumn.AllowEdit = false;
            this.InsIndication.Visible = true;
            this.InsIndication.VisibleIndex = 12;
            this.InsIndication.Width = 89;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.emptySpaceItem1,
            this.layoutControlItem3});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1074, 574);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 52);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1054, 502);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.lueBranches;
            this.layoutControlItem2.Location = new System.Drawing.Point(816, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 5, 3, 3);
            this.layoutControlItem2.Size = new System.Drawing.Size(238, 52);
            this.layoutControlItem2.Text = "الفرع";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(27, 16);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(763, 52);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnPrint;
            this.layoutControlItem3.Location = new System.Drawing.Point(763, 0);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(47, 52);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(53, 52);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // SalariesFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 574);
            this.Controls.Add(this.layoutControl1);
            this.Name = "SalariesFrm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "SalariesFrm";
            this.Load += new System.EventHandler(this.SalariesFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lueBranches.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsTaxable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn ContactName;
        private DevExpress.XtraGrid.Columns.GridColumn DepName;
        private DevExpress.XtraGrid.Columns.GridColumn JobTitle;
        private DevExpress.XtraGrid.Columns.GridColumn Salary;
        private DevExpress.XtraGrid.Columns.GridColumn Currency;
        private DevExpress.XtraGrid.Columns.GridColumn GeneName;
        private DevExpress.XtraGrid.Columns.GridColumn IsTaxable;
        private DevExpress.XtraGrid.Columns.GridColumn Description;
        private DevExpress.XtraGrid.Columns.GridColumn DueSalary;
        private DevExpress.XtraGrid.Columns.GridColumn totalDeduct;
        private DevExpress.XtraGrid.Columns.GridColumn IncomeTax;
        private DevExpress.XtraEditors.LookUpEdit lueBranches;
        private DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch tsTaxable;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraGrid.Columns.GridColumn TaxIndication;
        private DevExpress.XtraGrid.Columns.GridColumn InsIndication;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    }
}