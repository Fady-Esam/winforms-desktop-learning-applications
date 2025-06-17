namespace resGUI
{
    partial class ExtractsFrm
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ProjectName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CustomerID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.StartDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IsActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemToggleSwitch1 = new DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch();
            this.Status = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IsFinished = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemToggleSwitch2 = new DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch();
            this.ExtractSerial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ExtractType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Qty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ItemPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DonePerc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GuaranteeDiscountPerc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GuaranteeDiscountAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ItemPackage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemToggleSwitch1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemToggleSwitch2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridControl2);
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsView.RightToLeftMirroringApplied = true;
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1180, 537);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemToggleSwitch1,
            this.repositoryItemToggleSwitch2});
            this.gridControl1.Size = new System.Drawing.Size(1156, 252);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ProjectName,
            this.CustomerID,
            this.StartDate,
            this.IsActive,
            this.Status,
            this.IsFinished,
            this.ExtractSerial,
            this.ExtractType,
            this.Qty,
            this.ItemPrice,
            this.DonePerc,
            this.GuaranteeDiscountPerc,
            this.GuaranteeDiscountAmount,
            this.ItemPackage});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // ProjectName
            // 
            this.ProjectName.Caption = "اسم المشروع";
            this.ProjectName.FieldName = "ProjectName";
            this.ProjectName.MinWidth = 25;
            this.ProjectName.Name = "ProjectName";
            this.ProjectName.Visible = true;
            this.ProjectName.VisibleIndex = 0;
            this.ProjectName.Width = 94;
            // 
            // CustomerID
            // 
            this.CustomerID.Caption = "CustomerID";
            this.CustomerID.FieldName = "رقم العميل";
            this.CustomerID.MinWidth = 25;
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.OptionsColumn.AllowEdit = false;
            this.CustomerID.Visible = true;
            this.CustomerID.VisibleIndex = 1;
            this.CustomerID.Width = 94;
            // 
            // StartDate
            // 
            this.StartDate.Caption = "تاريخ البدء";
            this.StartDate.FieldName = "StartDate";
            this.StartDate.MinWidth = 25;
            this.StartDate.Name = "StartDate";
            this.StartDate.Visible = true;
            this.StartDate.VisibleIndex = 2;
            this.StartDate.Width = 94;
            // 
            // IsActive
            // 
            this.IsActive.Caption = "النشاط";
            this.IsActive.ColumnEdit = this.repositoryItemToggleSwitch1;
            this.IsActive.FieldName = "IsActive";
            this.IsActive.MinWidth = 25;
            this.IsActive.Name = "IsActive";
            this.IsActive.Visible = true;
            this.IsActive.VisibleIndex = 3;
            this.IsActive.Width = 94;
            // 
            // repositoryItemToggleSwitch1
            // 
            this.repositoryItemToggleSwitch1.AutoHeight = false;
            this.repositoryItemToggleSwitch1.Name = "repositoryItemToggleSwitch1";
            this.repositoryItemToggleSwitch1.OffText = "Off";
            this.repositoryItemToggleSwitch1.OnText = "On";
            // 
            // Status
            // 
            this.Status.Caption = "الحالة";
            this.Status.FieldName = "Status";
            this.Status.MinWidth = 25;
            this.Status.Name = "Status";
            this.Status.Visible = true;
            this.Status.VisibleIndex = 4;
            this.Status.Width = 94;
            // 
            // IsFinished
            // 
            this.IsFinished.Caption = "الانتهاء";
            this.IsFinished.ColumnEdit = this.repositoryItemToggleSwitch2;
            this.IsFinished.FieldName = "IsFinished";
            this.IsFinished.MinWidth = 25;
            this.IsFinished.Name = "IsFinished";
            this.IsFinished.Visible = true;
            this.IsFinished.VisibleIndex = 5;
            this.IsFinished.Width = 94;
            // 
            // repositoryItemToggleSwitch2
            // 
            this.repositoryItemToggleSwitch2.AutoHeight = false;
            this.repositoryItemToggleSwitch2.Name = "repositoryItemToggleSwitch2";
            this.repositoryItemToggleSwitch2.OffText = "Off";
            this.repositoryItemToggleSwitch2.OnText = "On";
            // 
            // ExtractSerial
            // 
            this.ExtractSerial.Caption = "السريال";
            this.ExtractSerial.FieldName = "ExtractSerial";
            this.ExtractSerial.MinWidth = 25;
            this.ExtractSerial.Name = "ExtractSerial";
            this.ExtractSerial.Visible = true;
            this.ExtractSerial.VisibleIndex = 6;
            this.ExtractSerial.Width = 94;
            // 
            // ExtractType
            // 
            this.ExtractType.Caption = "نوع المستخلص";
            this.ExtractType.FieldName = "ExtractType";
            this.ExtractType.MinWidth = 25;
            this.ExtractType.Name = "ExtractType";
            this.ExtractType.Visible = true;
            this.ExtractType.VisibleIndex = 7;
            this.ExtractType.Width = 94;
            // 
            // Qty
            // 
            this.Qty.Caption = "الكمية";
            this.Qty.FieldName = "Qty";
            this.Qty.MinWidth = 25;
            this.Qty.Name = "Qty";
            this.Qty.Visible = true;
            this.Qty.VisibleIndex = 8;
            this.Qty.Width = 94;
            // 
            // ItemPrice
            // 
            this.ItemPrice.Caption = "سعر البند";
            this.ItemPrice.FieldName = "ItemPrice";
            this.ItemPrice.MinWidth = 25;
            this.ItemPrice.Name = "ItemPrice";
            this.ItemPrice.Visible = true;
            this.ItemPrice.VisibleIndex = 9;
            this.ItemPrice.Width = 94;
            // 
            // DonePerc
            // 
            this.DonePerc.Caption = "النسبة المحققة";
            this.DonePerc.FieldName = "DonePerc";
            this.DonePerc.MinWidth = 25;
            this.DonePerc.Name = "DonePerc";
            this.DonePerc.Visible = true;
            this.DonePerc.VisibleIndex = 10;
            this.DonePerc.Width = 94;
            // 
            // GuaranteeDiscountPerc
            // 
            this.GuaranteeDiscountPerc.Caption = "نسبة تأمين الاعمال";
            this.GuaranteeDiscountPerc.FieldName = "GuaranteeDiscountPerc";
            this.GuaranteeDiscountPerc.MinWidth = 25;
            this.GuaranteeDiscountPerc.Name = "GuaranteeDiscountPerc";
            this.GuaranteeDiscountPerc.Visible = true;
            this.GuaranteeDiscountPerc.VisibleIndex = 11;
            this.GuaranteeDiscountPerc.Width = 94;
            // 
            // GuaranteeDiscountAmount
            // 
            this.GuaranteeDiscountAmount.Caption = "قيمة تأمين الأعمال";
            this.GuaranteeDiscountAmount.FieldName = "GuaranteeDiscountAmount";
            this.GuaranteeDiscountAmount.MinWidth = 25;
            this.GuaranteeDiscountAmount.Name = "GuaranteeDiscountAmount";
            this.GuaranteeDiscountAmount.Visible = true;
            this.GuaranteeDiscountAmount.VisibleIndex = 12;
            this.GuaranteeDiscountAmount.Width = 94;
            // 
            // ItemPackage
            // 
            this.ItemPackage.Caption = "الوحدة";
            this.ItemPackage.FieldName = "ItemPackage";
            this.ItemPackage.MinWidth = 25;
            this.ItemPackage.Name = "ItemPackage";
            this.ItemPackage.Visible = true;
            this.ItemPackage.VisibleIndex = 13;
            this.ItemPackage.Width = 94;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1180, 537);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1160, 256);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // gridControl2
            // 
            this.gridControl2.Location = new System.Drawing.Point(12, 268);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(1156, 257);
            this.gridControl2.TabIndex = 5;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gridControl2;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 256);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(1160, 261);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // ExtractsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 537);
            this.Controls.Add(this.layoutControl1);
            this.Name = "ExtractsFrm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "ExtractsFrm";
            this.Load += new System.EventHandler(this.ExtractsFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemToggleSwitch1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemToggleSwitch2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn ProjectName;
        private DevExpress.XtraGrid.Columns.GridColumn CustomerID;
        private DevExpress.XtraGrid.Columns.GridColumn StartDate;
        private DevExpress.XtraGrid.Columns.GridColumn IsActive;
        private DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch repositoryItemToggleSwitch1;
        private DevExpress.XtraGrid.Columns.GridColumn Status;
        private DevExpress.XtraGrid.Columns.GridColumn IsFinished;
        private DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch repositoryItemToggleSwitch2;
        private DevExpress.XtraGrid.Columns.GridColumn ExtractSerial;
        private DevExpress.XtraGrid.Columns.GridColumn ExtractType;
        private DevExpress.XtraGrid.Columns.GridColumn Qty;
        private DevExpress.XtraGrid.Columns.GridColumn ItemPrice;
        private DevExpress.XtraGrid.Columns.GridColumn DonePerc;
        private DevExpress.XtraGrid.Columns.GridColumn GuaranteeDiscountPerc;
        private DevExpress.XtraGrid.Columns.GridColumn GuaranteeDiscountAmount;
        private DevExpress.XtraGrid.Columns.GridColumn ItemPackage;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}