namespace WFs
{
    partial class TaxesRules
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
            this.LayoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.saveBtn = new DevExpress.XtraEditors.SimpleButton();
            this.GridControl1 = new DevExpress.XtraGrid.GridControl();
            this.GridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colRuleID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMinSalary = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaxSalary = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTaxRate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateFrom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateTo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.LayoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.LayoutControl1)).BeginInit();
            this.LayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // LayoutControl1
            // 
            this.LayoutControl1.Controls.Add(this.saveBtn);
            this.LayoutControl1.Controls.Add(this.GridControl1);
            this.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.LayoutControl1.Name = "LayoutControl1";
            this.LayoutControl1.OptionsView.RightToLeftMirroringApplied = true;
            this.LayoutControl1.Root = this.Root;
            this.LayoutControl1.Size = new System.Drawing.Size(852, 540);
            this.LayoutControl1.TabIndex = 1;
            this.LayoutControl1.Text = "LayoutControl1";
            // 
            // saveBtn
            // 
            this.saveBtn.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question;
            this.saveBtn.Appearance.Options.UseBackColor = true;
            this.saveBtn.Location = new System.Drawing.Point(653, 503);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(196, 34);
            this.saveBtn.StyleController = this.LayoutControl1;
            this.saveBtn.TabIndex = 6;
            this.saveBtn.Text = "حفظ";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // GridControl1
            // 
            this.GridControl1.Location = new System.Drawing.Point(13, 13);
            this.GridControl1.MainView = this.GridView1;
            this.GridControl1.Name = "GridControl1";
            this.GridControl1.Size = new System.Drawing.Size(826, 474);
            this.GridControl1.TabIndex = 4;
            this.GridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridView1});
            // 
            // GridView1
            // 
            this.GridView1.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Gray;
            this.GridView1.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.GridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRuleID,
            this.colMinSalary,
            this.colMaxSalary,
            this.colTaxRate,
            this.colDateFrom,
            this.colDateTo});
            this.GridView1.DetailHeight = 329;
            this.GridView1.GridControl = this.GridControl1;
            this.GridView1.Name = "GridView1";
            this.GridView1.NewItemRowText = "اضافة سطر جديد من هنا";
            this.GridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.GridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GridView1_KeyDown);
            // 
            // colRuleID
            // 
            this.colRuleID.AppearanceCell.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8F);
            this.colRuleID.AppearanceCell.Options.UseFont = true;
            this.colRuleID.Caption = "Rule ID";
            this.colRuleID.FieldName = "RuleID";
            this.colRuleID.Name = "colRuleID";
            this.colRuleID.OptionsColumn.AllowEdit = false;
            this.colRuleID.OptionsColumn.FixedWidth = true;
            this.colRuleID.Visible = true;
            this.colRuleID.VisibleIndex = 0;
            this.colRuleID.Width = 62;
            // 
            // colMinSalary
            // 
            this.colMinSalary.Caption = "الحد الادني للراتب";
            this.colMinSalary.FieldName = "MinSalary";
            this.colMinSalary.Name = "colMinSalary";
            this.colMinSalary.Visible = true;
            this.colMinSalary.VisibleIndex = 1;
            this.colMinSalary.Width = 118;
            // 
            // colMaxSalary
            // 
            this.colMaxSalary.Caption = "الحد الاقصي للراتب";
            this.colMaxSalary.FieldName = "MaxSalary";
            this.colMaxSalary.Name = "colMaxSalary";
            this.colMaxSalary.Visible = true;
            this.colMaxSalary.VisibleIndex = 2;
            this.colMaxSalary.Width = 118;
            // 
            // colTaxRate
            // 
            this.colTaxRate.Caption = "معدل الضريبة";
            this.colTaxRate.FieldName = "TaxRate";
            this.colTaxRate.Name = "colTaxRate";
            this.colTaxRate.Visible = true;
            this.colTaxRate.VisibleIndex = 3;
            this.colTaxRate.Width = 118;
            // 
            // colDateFrom
            // 
            this.colDateFrom.Caption = "من";
            this.colDateFrom.DisplayFormat.FormatString = "dd-MM-yyy";
            this.colDateFrom.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDateFrom.FieldName = "DateFrom";
            this.colDateFrom.Name = "colDateFrom";
            this.colDateFrom.Visible = true;
            this.colDateFrom.VisibleIndex = 4;
            this.colDateFrom.Width = 118;
            // 
            // colDateTo
            // 
            this.colDateTo.Caption = "الي";
            this.colDateTo.DisplayFormat.FormatString = "dd-MM-yyy";
            this.colDateTo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDateTo.FieldName = "DateTo";
            this.colDateTo.Name = "colDateTo";
            this.colDateTo.Visible = true;
            this.colDateTo.VisibleIndex = 5;
            this.colDateTo.Width = 124;
            // 
            // Root
            // 
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.LayoutControlItem1,
            this.layoutControlItem3,
            this.emptySpaceItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(852, 540);
            this.Root.TextVisible = false;
            // 
            // LayoutControlItem1
            // 
            this.LayoutControlItem1.Control = this.GridControl1;
            this.LayoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.LayoutControlItem1.Name = "LayoutControlItem1";
            this.LayoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(13, 13, 13, 13);
            this.LayoutControlItem1.Size = new System.Drawing.Size(852, 500);
            this.LayoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.LayoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.saveBtn;
            this.layoutControlItem3.Location = new System.Drawing.Point(650, 500);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(202, 40);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 500);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(650, 40);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // TaxesRules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 540);
            this.Controls.Add(this.LayoutControl1);
            this.Name = "TaxesRules";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "TaxesRules";
            this.Load += new System.EventHandler(this.TaxesRules_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LayoutControl1)).EndInit();
            this.LayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal DevExpress.XtraLayout.LayoutControl LayoutControl1;
        internal DevExpress.XtraGrid.GridControl GridControl1;
        internal DevExpress.XtraGrid.Views.Grid.GridView GridView1;
        internal DevExpress.XtraGrid.Columns.GridColumn colRuleID;
        internal DevExpress.XtraGrid.Columns.GridColumn colMinSalary;
        internal DevExpress.XtraGrid.Columns.GridColumn colMaxSalary;
        internal DevExpress.XtraGrid.Columns.GridColumn colTaxRate;
        internal DevExpress.XtraGrid.Columns.GridColumn colDateFrom;
        internal DevExpress.XtraGrid.Columns.GridColumn colDateTo;
        internal DevExpress.XtraLayout.LayoutControlGroup Root;
        internal DevExpress.XtraLayout.LayoutControlItem LayoutControlItem1;
        private DevExpress.XtraEditors.SimpleButton saveBtn;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
    }
}