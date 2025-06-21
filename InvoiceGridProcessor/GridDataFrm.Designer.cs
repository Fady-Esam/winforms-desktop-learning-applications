namespace WFs
{
    partial class GridDataFrm
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
            this.ProductPackageID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Qty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SaleCurrency = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SaleCurrRate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.StoreID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DiscountPrg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SupplyDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CostAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.InvoiceNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TotalPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.TaxName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TaxValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TaxEffect = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1108, 163, 812, 500);
            this.layoutControl1.OptionsView.RightToLeftMirroringApplied = true;
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1448, 654);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1424, 630);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ProductPackageID,
            this.Qty,
            this.Price,
            this.SaleCurrency,
            this.SaleCurrRate,
            this.StoreID,
            this.DiscountPrg,
            this.SupplyDate,
            this.CostAmount,
            this.InvoiceNum,
            this.TotalPrice,
            this.TaxName,
            this.TaxValue,
            this.TaxEffect});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // ProductPackageID
            // 
            this.ProductPackageID.Caption = "ID";
            this.ProductPackageID.FieldName = "ProductPackageID";
            this.ProductPackageID.MinWidth = 25;
            this.ProductPackageID.Name = "ProductPackageID";
            this.ProductPackageID.Visible = true;
            this.ProductPackageID.VisibleIndex = 0;
            this.ProductPackageID.Width = 94;
            // 
            // Qty
            // 
            this.Qty.Caption = "الكمية";
            this.Qty.FieldName = "Qty";
            this.Qty.MinWidth = 25;
            this.Qty.Name = "Qty";
            this.Qty.Visible = true;
            this.Qty.VisibleIndex = 1;
            this.Qty.Width = 94;
            // 
            // Price
            // 
            this.Price.Caption = "السعر";
            this.Price.FieldName = "Price";
            this.Price.MinWidth = 25;
            this.Price.Name = "Price";
            this.Price.Visible = true;
            this.Price.VisibleIndex = 2;
            this.Price.Width = 94;
            // 
            // SaleCurrency
            // 
            this.SaleCurrency.Caption = "عملة البيع";
            this.SaleCurrency.FieldName = "SaleCurrency";
            this.SaleCurrency.MinWidth = 25;
            this.SaleCurrency.Name = "SaleCurrency";
            this.SaleCurrency.Visible = true;
            this.SaleCurrency.VisibleIndex = 3;
            this.SaleCurrency.Width = 94;
            // 
            // SaleCurrRate
            // 
            this.SaleCurrRate.Caption = "سعر الصرف";
            this.SaleCurrRate.FieldName = "SaleCurrRate";
            this.SaleCurrRate.MinWidth = 25;
            this.SaleCurrRate.Name = "SaleCurrRate";
            this.SaleCurrRate.Visible = true;
            this.SaleCurrRate.VisibleIndex = 4;
            this.SaleCurrRate.Width = 94;
            // 
            // StoreID
            // 
            this.StoreID.Caption = "رقم المخزن";
            this.StoreID.FieldName = "StoreID";
            this.StoreID.MinWidth = 25;
            this.StoreID.Name = "StoreID";
            this.StoreID.Visible = true;
            this.StoreID.VisibleIndex = 5;
            this.StoreID.Width = 94;
            // 
            // DiscountPrg
            // 
            this.DiscountPrg.Caption = "الخصم";
            this.DiscountPrg.FieldName = "DiscountPrg";
            this.DiscountPrg.MinWidth = 25;
            this.DiscountPrg.Name = "DiscountPrg";
            this.DiscountPrg.Visible = true;
            this.DiscountPrg.VisibleIndex = 6;
            this.DiscountPrg.Width = 94;
            // 
            // SupplyDate
            // 
            this.SupplyDate.Caption = "تاريخ التوريد";
            this.SupplyDate.FieldName = "SupplyDate";
            this.SupplyDate.MinWidth = 25;
            this.SupplyDate.Name = "SupplyDate";
            this.SupplyDate.Visible = true;
            this.SupplyDate.VisibleIndex = 7;
            this.SupplyDate.Width = 94;
            // 
            // CostAmount
            // 
            this.CostAmount.Caption = "التكلفة";
            this.CostAmount.FieldName = "CostAmount";
            this.CostAmount.MinWidth = 25;
            this.CostAmount.Name = "CostAmount";
            this.CostAmount.Visible = true;
            this.CostAmount.VisibleIndex = 8;
            this.CostAmount.Width = 94;
            // 
            // InvoiceNum
            // 
            this.InvoiceNum.Caption = "رقم الفاتورة";
            this.InvoiceNum.FieldName = "InvoiceNum";
            this.InvoiceNum.MinWidth = 25;
            this.InvoiceNum.Name = "InvoiceNum";
            this.InvoiceNum.Visible = true;
            this.InvoiceNum.VisibleIndex = 9;
            this.InvoiceNum.Width = 94;
            // 
            // TotalPrice
            // 
            this.TotalPrice.Caption = "المبلغ الكلي";
            this.TotalPrice.FieldName = "TotalPrice";
            this.TotalPrice.MinWidth = 25;
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.Visible = true;
            this.TotalPrice.VisibleIndex = 10;
            this.TotalPrice.Width = 94;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1448, 654);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1428, 634);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // TaxName
            // 
            this.TaxName.Caption = "اسم الضريبة";
            this.TaxName.FieldName = "TaxName";
            this.TaxName.MinWidth = 25;
            this.TaxName.Name = "TaxName";
            this.TaxName.Visible = true;
            this.TaxName.VisibleIndex = 11;
            this.TaxName.Width = 94;
            // 
            // TaxValue
            // 
            this.TaxValue.Caption = "قيمة الضريبة";
            this.TaxValue.FieldName = "TaxValue";
            this.TaxValue.MinWidth = 25;
            this.TaxValue.Name = "TaxValue";
            this.TaxValue.Visible = true;
            this.TaxValue.VisibleIndex = 12;
            this.TaxValue.Width = 94;
            // 
            // TaxEffect
            // 
            this.TaxEffect.Caption = "تأثير الضريبة";
            this.TaxEffect.FieldName = "TaxEffect";
            this.TaxEffect.MinWidth = 25;
            this.TaxEffect.Name = "TaxEffect";
            this.TaxEffect.Visible = true;
            this.TaxEffect.VisibleIndex = 13;
            this.TaxEffect.Width = 94;
            // 
            // GridDataFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1448, 654);
            this.Controls.Add(this.layoutControl1);
            this.Name = "GridDataFrm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "GridDataFrm";
            this.Load += new System.EventHandler(this.GridDataFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn ProductPackageID;
        private DevExpress.XtraGrid.Columns.GridColumn Qty;
        private DevExpress.XtraGrid.Columns.GridColumn Price;
        private DevExpress.XtraGrid.Columns.GridColumn SaleCurrency;
        private DevExpress.XtraGrid.Columns.GridColumn SaleCurrRate;
        private DevExpress.XtraGrid.Columns.GridColumn StoreID;
        private DevExpress.XtraGrid.Columns.GridColumn DiscountPrg;
        private DevExpress.XtraGrid.Columns.GridColumn SupplyDate;
        private DevExpress.XtraGrid.Columns.GridColumn CostAmount;
        private DevExpress.XtraGrid.Columns.GridColumn InvoiceNum;
        private DevExpress.XtraGrid.Columns.GridColumn TotalPrice;
        private DevExpress.XtraGrid.Columns.GridColumn TaxName;
        private DevExpress.XtraGrid.Columns.GridColumn TaxValue;
        private DevExpress.XtraGrid.Columns.GridColumn TaxEffect;
    }
}