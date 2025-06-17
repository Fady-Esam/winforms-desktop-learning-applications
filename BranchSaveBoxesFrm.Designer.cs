namespace WFs
{
    partial class BranchSaveBoxesFrm
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
            this.saveChangesBtn = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.BranchSaveBoxRelID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SaveBoxID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.saveBoxesLue = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.BranchID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.branchesLue = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveBoxesLue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchesLue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.saveChangesBtn);
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsView.RightToLeftMirroringApplied = true;
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(870, 497);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // saveChangesBtn
            // 
            this.saveChangesBtn.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question;
            this.saveChangesBtn.Appearance.Options.UseBackColor = true;
            this.saveChangesBtn.Location = new System.Drawing.Point(692, 458);
            this.saveChangesBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveChangesBtn.Name = "saveChangesBtn";
            this.saveChangesBtn.Size = new System.Drawing.Size(166, 27);
            this.saveChangesBtn.StyleController = this.layoutControl1;
            this.saveChangesBtn.TabIndex = 30;
            this.saveChangesBtn.Text = "حفظ";
            this.saveChangesBtn.Click += new System.EventHandler(this.saveChangesBtn_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.gridControl1.Location = new System.Drawing.Point(12, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.saveBoxesLue,
            this.branchesLue});
            this.gridControl1.Size = new System.Drawing.Size(846, 442);
            this.gridControl1.TabIndex = 29;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.BranchSaveBoxRelID,
            this.SaveBoxID,
            this.BranchID});
            this.gridView1.DetailHeight = 255;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.NewItemRowText = "إضافة سطر جديد من هنا";
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridView1_KeyDown_1);
            // 
            // BranchSaveBoxRelID
            // 
            this.BranchSaveBoxRelID.Caption = "ID";
            this.BranchSaveBoxRelID.FieldName = "BranchSaveBoxRelID";
            this.BranchSaveBoxRelID.MinWidth = 17;
            this.BranchSaveBoxRelID.Name = "BranchSaveBoxRelID";
            this.BranchSaveBoxRelID.OptionsColumn.AllowEdit = false;
            this.BranchSaveBoxRelID.Visible = true;
            this.BranchSaveBoxRelID.VisibleIndex = 0;
            this.BranchSaveBoxRelID.Width = 66;
            // 
            // SaveBoxID
            // 
            this.SaveBoxID.Caption = "اسم الصندوق";
            this.SaveBoxID.ColumnEdit = this.saveBoxesLue;
            this.SaveBoxID.FieldName = "SaveBoxID";
            this.SaveBoxID.MinWidth = 17;
            this.SaveBoxID.Name = "SaveBoxID";
            this.SaveBoxID.Visible = true;
            this.SaveBoxID.VisibleIndex = 1;
            this.SaveBoxID.Width = 152;
            // 
            // saveBoxesLue
            // 
            this.saveBoxesLue.AutoHeight = false;
            this.saveBoxesLue.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.saveBoxesLue.Name = "saveBoxesLue";
            this.saveBoxesLue.NullText = "";
            // 
            // BranchID
            // 
            this.BranchID.Caption = "الفرع";
            this.BranchID.ColumnEdit = this.branchesLue;
            this.BranchID.FieldName = "BranchID";
            this.BranchID.MinWidth = 17;
            this.BranchID.Name = "BranchID";
            this.BranchID.Visible = true;
            this.BranchID.VisibleIndex = 2;
            this.BranchID.Width = 208;
            // 
            // branchesLue
            // 
            this.branchesLue.AutoHeight = false;
            this.branchesLue.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.branchesLue.Name = "branchesLue";
            this.branchesLue.NullText = "";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.emptySpaceItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(870, 497);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(850, 446);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.saveChangesBtn;
            this.layoutControlItem2.Location = new System.Drawing.Point(680, 446);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(170, 31);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 446);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(680, 31);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // BranchSaveBoxesFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 497);
            this.Controls.Add(this.layoutControl1);
            this.Name = "BranchSaveBoxesFrm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "BranchSaveBoxesFrm";
            this.Load += new System.EventHandler(this.BranchSaveBoxesFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveBoxesLue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchesLue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn BranchSaveBoxRelID;
        private DevExpress.XtraGrid.Columns.GridColumn SaveBoxID;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit saveBoxesLue;
        private DevExpress.XtraGrid.Columns.GridColumn BranchID;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit branchesLue;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SimpleButton saveChangesBtn;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
    }
}