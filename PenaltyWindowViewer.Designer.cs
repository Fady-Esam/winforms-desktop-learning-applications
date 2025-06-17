namespace WFs
{
    partial class PenaltyWindowViewer
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
            this.SplitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.LayoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.lueBranch = new DevExpress.XtraEditors.LookUpEdit();
            this.btnPrintPenalty = new DevExpress.XtraEditors.SimpleButton();
            this.btnDeletePenalty = new DevExpress.XtraEditors.SimpleButton();
            this.btnNewPenalty = new DevExpress.XtraEditors.SimpleButton();
            this.LayoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.LayoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.EmptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.LayoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.LayoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.LayoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.LayoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.LayoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.GridControl1 = new DevExpress.XtraGrid.GridControl();
            this.GridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ContactName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DeductionName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DeductionAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DateFrom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DateTo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Details = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.LayoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
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
            ((System.ComponentModel.ISupportInitialize)(this.EmptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayoutControl1)).BeginInit();
            this.LayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayoutControlItem1)).BeginInit();
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
            this.SplitContainerControl1.Size = new System.Drawing.Size(1317, 704);
            this.SplitContainerControl1.SplitterPosition = 213;
            this.SplitContainerControl1.TabIndex = 1;
            // 
            // LayoutControl2
            // 
            this.LayoutControl2.Controls.Add(this.btnRefresh);
            this.LayoutControl2.Controls.Add(this.lueBranch);
            this.LayoutControl2.Controls.Add(this.btnPrintPenalty);
            this.LayoutControl2.Controls.Add(this.btnDeletePenalty);
            this.LayoutControl2.Controls.Add(this.btnNewPenalty);
            this.LayoutControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LayoutControl2.Location = new System.Drawing.Point(0, 0);
            this.LayoutControl2.Name = "LayoutControl2";
            this.LayoutControl2.OptionsView.RightToLeftMirroringApplied = true;
            this.LayoutControl2.Root = this.LayoutControlGroup1;
            this.LayoutControl2.Size = new System.Drawing.Size(213, 704);
            this.LayoutControl2.TabIndex = 0;
            this.LayoutControl2.Text = "LayoutControl2";
            // 
            // btnRefresh
            // 
            this.btnRefresh.ImageOptions.SvgImageSize = new System.Drawing.Size(30, 30);
            this.btnRefresh.Location = new System.Drawing.Point(3, 123);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(207, 34);
            this.btnRefresh.StyleController = this.LayoutControl2;
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "اعادة تحميل";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click_1);
            // 
            // lueBranch
            // 
            this.lueBranch.Location = new System.Drawing.Point(3, 667);
            this.lueBranch.Name = "lueBranch";
            this.lueBranch.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueBranch.Properties.NullText = "";
            this.lueBranch.Size = new System.Drawing.Size(207, 34);
            this.lueBranch.StyleController = this.LayoutControl2;
            this.lueBranch.TabIndex = 4;
            this.lueBranch.EditValueChanged += new System.EventHandler(this.lueBranch_EditValueChanged_1);
            // 
            // btnPrintPenalty
            // 
            this.btnPrintPenalty.ImageOptions.SvgImageSize = new System.Drawing.Size(25, 25);
            this.btnPrintPenalty.Location = new System.Drawing.Point(3, 83);
            this.btnPrintPenalty.Name = "btnPrintPenalty";
            this.btnPrintPenalty.Size = new System.Drawing.Size(207, 34);
            this.btnPrintPenalty.StyleController = this.LayoutControl2;
            this.btnPrintPenalty.TabIndex = 3;
            this.btnPrintPenalty.Text = "طباعة";
            // 
            // btnDeletePenalty
            // 
            this.btnDeletePenalty.ImageOptions.SvgImageSize = new System.Drawing.Size(25, 25);
            this.btnDeletePenalty.Location = new System.Drawing.Point(3, 43);
            this.btnDeletePenalty.Name = "btnDeletePenalty";
            this.btnDeletePenalty.Size = new System.Drawing.Size(207, 34);
            this.btnDeletePenalty.StyleController = this.LayoutControl2;
            this.btnDeletePenalty.TabIndex = 2;
            this.btnDeletePenalty.Text = "حذف";
            this.btnDeletePenalty.Click += new System.EventHandler(this.btnDeletePenalty_Click_1);
            // 
            // btnNewPenalty
            // 
            this.btnNewPenalty.ImageOptions.SvgImageSize = new System.Drawing.Size(25, 25);
            this.btnNewPenalty.Location = new System.Drawing.Point(3, 3);
            this.btnNewPenalty.Name = "btnNewPenalty";
            this.btnNewPenalty.Size = new System.Drawing.Size(207, 34);
            this.btnNewPenalty.StyleController = this.LayoutControl2;
            this.btnNewPenalty.TabIndex = 0;
            this.btnNewPenalty.Text = "اضافة جديد";
            this.btnNewPenalty.Click += new System.EventHandler(this.btnNewPenalty_Click_1);
            // 
            // LayoutControlGroup1
            // 
            this.LayoutControlGroup1.GroupBordersVisible = false;
            this.LayoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.LayoutControlItem2,
            this.EmptySpaceItem1,
            this.LayoutControlItem3,
            this.LayoutControlItem4,
            this.LayoutControlItem6,
            this.LayoutControlItem7});
            this.LayoutControlGroup1.Name = "Root";
            this.LayoutControlGroup1.Size = new System.Drawing.Size(213, 704);
            this.LayoutControlGroup1.TextVisible = false;
            // 
            // LayoutControlItem2
            // 
            this.LayoutControlItem2.Control = this.btnNewPenalty;
            this.LayoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.LayoutControlItem2.Name = "LayoutControlItem2";
            this.LayoutControlItem2.Size = new System.Drawing.Size(213, 40);
            this.LayoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.LayoutControlItem2.TextVisible = false;
            // 
            // EmptySpaceItem1
            // 
            this.EmptySpaceItem1.AllowHotTrack = false;
            this.EmptySpaceItem1.Location = new System.Drawing.Point(0, 160);
            this.EmptySpaceItem1.Name = "EmptySpaceItem1";
            this.EmptySpaceItem1.Size = new System.Drawing.Size(213, 504);
            this.EmptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // LayoutControlItem3
            // 
            this.LayoutControlItem3.Control = this.btnDeletePenalty;
            this.LayoutControlItem3.Location = new System.Drawing.Point(0, 40);
            this.LayoutControlItem3.Name = "LayoutControlItem3";
            this.LayoutControlItem3.Size = new System.Drawing.Size(213, 40);
            this.LayoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.LayoutControlItem3.TextVisible = false;
            // 
            // LayoutControlItem4
            // 
            this.LayoutControlItem4.Control = this.btnPrintPenalty;
            this.LayoutControlItem4.Location = new System.Drawing.Point(0, 80);
            this.LayoutControlItem4.Name = "LayoutControlItem4";
            this.LayoutControlItem4.Size = new System.Drawing.Size(213, 40);
            this.LayoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.LayoutControlItem4.TextVisible = false;
            // 
            // LayoutControlItem6
            // 
            this.LayoutControlItem6.Control = this.lueBranch;
            this.LayoutControlItem6.Location = new System.Drawing.Point(0, 664);
            this.LayoutControlItem6.Name = "LayoutControlItem6";
            this.LayoutControlItem6.Size = new System.Drawing.Size(213, 40);
            this.LayoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.LayoutControlItem6.TextVisible = false;
            // 
            // LayoutControlItem7
            // 
            this.LayoutControlItem7.Control = this.btnRefresh;
            this.LayoutControlItem7.Location = new System.Drawing.Point(0, 120);
            this.LayoutControlItem7.Name = "LayoutControlItem7";
            this.LayoutControlItem7.Size = new System.Drawing.Size(213, 40);
            this.LayoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.LayoutControlItem7.TextVisible = false;
            // 
            // LayoutControl1
            // 
            this.LayoutControl1.Controls.Add(this.GridControl1);
            this.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.LayoutControl1.Name = "LayoutControl1";
            this.LayoutControl1.OptionsView.RightToLeftMirroringApplied = true;
            this.LayoutControl1.Root = this.Root;
            this.LayoutControl1.Size = new System.Drawing.Size(1084, 704);
            this.LayoutControl1.TabIndex = 0;
            this.LayoutControl1.Text = "LayoutControl1";
            // 
            // GridControl1
            // 
            this.GridControl1.Location = new System.Drawing.Point(3, 3);
            this.GridControl1.MainView = this.GridView1;
            this.GridControl1.Name = "GridControl1";
            this.GridControl1.Size = new System.Drawing.Size(1078, 698);
            this.GridControl1.TabIndex = 4;
            this.GridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridView1});
            this.GridControl1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GridControl1_KeyDown);
            // 
            // GridView1
            // 
            this.GridView1.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Gray;
            this.GridView1.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.GridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.ContactName,
            this.DeductionName,
            this.DeductionAmount,
            this.DateFrom,
            this.DateTo,
            this.Details});
            this.GridView1.DetailHeight = 329;
            this.GridView1.GridControl = this.GridControl1;
            this.GridView1.Name = "GridView1";
            // 
            // ID
            // 
            this.ID.AppearanceCell.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 8F);
            this.ID.AppearanceCell.Options.UseFont = true;
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            this.ID.OptionsColumn.AllowEdit = false;
            this.ID.OptionsColumn.FixedWidth = true;
            this.ID.Visible = true;
            this.ID.VisibleIndex = 0;
            this.ID.Width = 62;
            // 
            // ContactName
            // 
            this.ContactName.Caption = "اسم الموظف";
            this.ContactName.FieldName = "ContactName";
            this.ContactName.Name = "ContactName";
            this.ContactName.Visible = true;
            this.ContactName.VisibleIndex = 1;
            this.ContactName.Width = 356;
            // 
            // DeductionName
            // 
            this.DeductionName.Caption = "نوع الخصم";
            this.DeductionName.FieldName = "DeductionName";
            this.DeductionName.Name = "DeductionName";
            // 
            // DeductionAmount
            // 
            this.DeductionAmount.Caption = "كمية الخصم";
            this.DeductionAmount.FieldName = "DeductionAmount";
            this.DeductionAmount.Name = "DeductionAmount";
            this.DeductionAmount.OptionsColumn.FixedWidth = true;
            this.DeductionAmount.Visible = true;
            this.DeductionAmount.VisibleIndex = 2;
            this.DeductionAmount.Width = 142;
            // 
            // DateFrom
            // 
            this.DateFrom.Caption = "التاريخ من";
            this.DateFrom.DisplayFormat.FormatString = "dd-MM-yyy";
            this.DateFrom.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.DateFrom.FieldName = "DateFrom";
            this.DateFrom.Name = "DateFrom";
            this.DateFrom.OptionsColumn.FixedWidth = true;
            this.DateFrom.Visible = true;
            this.DateFrom.VisibleIndex = 3;
            this.DateFrom.Width = 90;
            // 
            // DateTo
            // 
            this.DateTo.Caption = "التاريخ الي";
            this.DateTo.DisplayFormat.FormatString = "dd-MM-yyy";
            this.DateTo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.DateTo.FieldName = "DateTo";
            this.DateTo.Name = "DateTo";
            this.DateTo.Visible = true;
            this.DateTo.VisibleIndex = 4;
            // 
            // Details
            // 
            this.Details.Caption = "السبب";
            this.Details.FieldName = "Details";
            this.Details.Name = "Details";
            this.Details.Visible = true;
            this.Details.VisibleIndex = 5;
            this.Details.Width = 259;
            // 
            // Root
            // 
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.LayoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1084, 704);
            this.Root.TextVisible = false;
            // 
            // LayoutControlItem1
            // 
            this.LayoutControlItem1.Control = this.GridControl1;
            this.LayoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.LayoutControlItem1.Name = "LayoutControlItem1";
            this.LayoutControlItem1.Size = new System.Drawing.Size(1084, 704);
            this.LayoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.LayoutControlItem1.TextVisible = false;
            // 
            // PenaltyWindowViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 704);
            this.Controls.Add(this.SplitContainerControl1);
            this.Name = "PenaltyWindowViewer";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "PenaltyWindowViewer";
            this.Load += new System.EventHandler(this.PenaltyWindowViewer_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.EmptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayoutControl1)).EndInit();
            this.LayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal DevExpress.XtraEditors.SplitContainerControl SplitContainerControl1;
        internal DevExpress.XtraLayout.LayoutControl LayoutControl2;
        internal DevExpress.XtraEditors.SimpleButton btnRefresh;
        internal DevExpress.XtraEditors.LookUpEdit lueBranch;
        internal DevExpress.XtraEditors.SimpleButton btnPrintPenalty;
        internal DevExpress.XtraEditors.SimpleButton btnDeletePenalty;
        internal DevExpress.XtraEditors.SimpleButton btnNewPenalty;
        internal DevExpress.XtraLayout.LayoutControlGroup LayoutControlGroup1;
        internal DevExpress.XtraLayout.LayoutControlItem LayoutControlItem2;
        internal DevExpress.XtraLayout.EmptySpaceItem EmptySpaceItem1;
        internal DevExpress.XtraLayout.LayoutControlItem LayoutControlItem3;
        internal DevExpress.XtraLayout.LayoutControlItem LayoutControlItem4;
        internal DevExpress.XtraLayout.LayoutControlItem LayoutControlItem6;
        internal DevExpress.XtraLayout.LayoutControlItem LayoutControlItem7;
        internal DevExpress.XtraLayout.LayoutControl LayoutControl1;
        internal DevExpress.XtraGrid.GridControl GridControl1;
        internal DevExpress.XtraGrid.Views.Grid.GridView GridView1;
        internal DevExpress.XtraGrid.Columns.GridColumn ID;
        internal DevExpress.XtraGrid.Columns.GridColumn ContactName;
        internal DevExpress.XtraGrid.Columns.GridColumn DeductionName;
        internal DevExpress.XtraGrid.Columns.GridColumn DeductionAmount;
        internal DevExpress.XtraGrid.Columns.GridColumn DateFrom;
        internal DevExpress.XtraGrid.Columns.GridColumn DateTo;
        internal DevExpress.XtraGrid.Columns.GridColumn Details;
        internal DevExpress.XtraLayout.LayoutControlGroup Root;
        internal DevExpress.XtraLayout.LayoutControlItem LayoutControlItem1;
    }
}