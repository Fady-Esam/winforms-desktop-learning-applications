namespace WFs
{
    partial class ModifiedSalesFrm
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
            this.btnReport = new DevExpress.XtraEditors.SimpleButton();
            this.btnGet = new DevExpress.XtraEditors.SimpleButton();
            this.DateEditTo = new DevExpress.XtraEditors.DateEdit();
            this.dateEditFrom = new DevExpress.XtraEditors.DateEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.HeaderID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DocumentType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CustomerID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.InvoiceNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TaxesInvoiceNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DiscountAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BranchID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Comment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PakageName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ProductNameAR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Qty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DiscountPrg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SaleCurrency = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SaleCurrRate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.StoreName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.InvoiceDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.OrderNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ModifyUser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ModifyDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateTimeOffsetEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateTimeOffsetEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DateEditTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateEditTo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateTimeOffsetEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnReport);
            this.layoutControl1.Controls.Add(this.btnGet);
            this.layoutControl1.Controls.Add(this.DateEditTo);
            this.layoutControl1.Controls.Add(this.dateEditFrom);
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsView.RightToLeftMirroringApplied = true;
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1448, 689);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(828, 12);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(129, 27);
            this.btnReport.StyleController = this.layoutControl1;
            this.btnReport.TabIndex = 8;
            this.btnReport.Text = "Open Report";
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(961, 12);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(120, 27);
            this.btnGet.StyleController = this.layoutControl1;
            this.btnGet.TabIndex = 7;
            this.btnGet.Text = "Get Data";
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // DateEditTo
            // 
            this.DateEditTo.EditValue = null;
            this.DateEditTo.Location = new System.Drawing.Point(1110, 12);
            this.DateEditTo.Name = "DateEditTo";
            this.DateEditTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateEditTo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateEditTo.Size = new System.Drawing.Size(146, 22);
            this.DateEditTo.StyleController = this.layoutControl1;
            this.DateEditTo.TabIndex = 6;
            // 
            // dateEditFrom
            // 
            this.dateEditFrom.EditValue = null;
            this.dateEditFrom.Location = new System.Drawing.Point(1282, 12);
            this.dateEditFrom.Name = "dateEditFrom";
            this.dateEditFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditFrom.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditFrom.Size = new System.Drawing.Size(154, 22);
            this.dateEditFrom.StyleController = this.layoutControl1;
            this.dateEditFrom.TabIndex = 5;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 43);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateTimeOffsetEdit1});
            this.gridControl1.Size = new System.Drawing.Size(1424, 634);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.HeaderID,
            this.DocumentType,
            this.CustomerID,
            this.InvoiceNum,
            this.TaxesInvoiceNum,
            this.DiscountAmount,
            this.BranchID,
            this.Comment,
            this.PakageName,
            this.ProductNameAR,
            this.Qty,
            this.Price,
            this.DiscountPrg,
            this.SaleCurrency,
            this.SaleCurrRate,
            this.StoreName,
            this.InvoiceDate,
            this.OrderNumber,
            this.ModifyUser,
            this.ModifyDate});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // HeaderID
            // 
            this.HeaderID.Caption = "رقم المستند";
            this.HeaderID.FieldName = "HeaderID";
            this.HeaderID.MinWidth = 25;
            this.HeaderID.Name = "HeaderID";
            this.HeaderID.Visible = true;
            this.HeaderID.VisibleIndex = 0;
            this.HeaderID.Width = 94;
            // 
            // DocumentType
            // 
            this.DocumentType.Caption = "نوع المستند";
            this.DocumentType.FieldName = "DocumentType";
            this.DocumentType.MinWidth = 25;
            this.DocumentType.Name = "DocumentType";
            this.DocumentType.Visible = true;
            this.DocumentType.VisibleIndex = 1;
            this.DocumentType.Width = 94;
            // 
            // CustomerID
            // 
            this.CustomerID.Caption = "رقم العميل";
            this.CustomerID.FieldName = "CustomerID";
            this.CustomerID.MinWidth = 25;
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.Visible = true;
            this.CustomerID.VisibleIndex = 2;
            this.CustomerID.Width = 94;
            // 
            // InvoiceNum
            // 
            this.InvoiceNum.Caption = "رقم الفاتورة";
            this.InvoiceNum.FieldName = "InvoiceNum";
            this.InvoiceNum.MinWidth = 25;
            this.InvoiceNum.Name = "InvoiceNum";
            this.InvoiceNum.Visible = true;
            this.InvoiceNum.VisibleIndex = 3;
            this.InvoiceNum.Width = 94;
            // 
            // TaxesInvoiceNum
            // 
            this.TaxesInvoiceNum.Caption = "ضريبة الفاتورة";
            this.TaxesInvoiceNum.FieldName = "TaxesInvoiceNum";
            this.TaxesInvoiceNum.MinWidth = 25;
            this.TaxesInvoiceNum.Name = "TaxesInvoiceNum";
            this.TaxesInvoiceNum.Visible = true;
            this.TaxesInvoiceNum.VisibleIndex = 4;
            this.TaxesInvoiceNum.Width = 94;
            // 
            // DiscountAmount
            // 
            this.DiscountAmount.Caption = "كمية الخصم";
            this.DiscountAmount.FieldName = "DiscountAmount";
            this.DiscountAmount.MinWidth = 25;
            this.DiscountAmount.Name = "DiscountAmount";
            this.DiscountAmount.Visible = true;
            this.DiscountAmount.VisibleIndex = 5;
            this.DiscountAmount.Width = 94;
            // 
            // BranchID
            // 
            this.BranchID.Caption = "رقم الفرع";
            this.BranchID.FieldName = "BranchID";
            this.BranchID.MinWidth = 25;
            this.BranchID.Name = "BranchID";
            this.BranchID.Visible = true;
            this.BranchID.VisibleIndex = 6;
            this.BranchID.Width = 94;
            // 
            // Comment
            // 
            this.Comment.Caption = "التعليق";
            this.Comment.FieldName = "Comment";
            this.Comment.MinWidth = 25;
            this.Comment.Name = "Comment";
            this.Comment.Visible = true;
            this.Comment.VisibleIndex = 7;
            this.Comment.Width = 94;
            // 
            // PakageName
            // 
            this.PakageName.Caption = "اسم الوحدة";
            this.PakageName.FieldName = "PakageName";
            this.PakageName.MinWidth = 25;
            this.PakageName.Name = "PakageName";
            this.PakageName.Visible = true;
            this.PakageName.VisibleIndex = 8;
            this.PakageName.Width = 94;
            // 
            // ProductNameAR
            // 
            this.ProductNameAR.Caption = "اسم المنتج";
            this.ProductNameAR.FieldName = "ProductNameAR";
            this.ProductNameAR.MinWidth = 25;
            this.ProductNameAR.Name = "ProductNameAR";
            this.ProductNameAR.Visible = true;
            this.ProductNameAR.VisibleIndex = 9;
            this.ProductNameAR.Width = 94;
            // 
            // Qty
            // 
            this.Qty.Caption = "الكمية";
            this.Qty.FieldName = "Qty";
            this.Qty.MinWidth = 25;
            this.Qty.Name = "Qty";
            this.Qty.Visible = true;
            this.Qty.VisibleIndex = 10;
            this.Qty.Width = 94;
            // 
            // Price
            // 
            this.Price.Caption = "السعر";
            this.Price.FieldName = "Price";
            this.Price.MinWidth = 25;
            this.Price.Name = "Price";
            this.Price.Visible = true;
            this.Price.VisibleIndex = 11;
            this.Price.Width = 94;
            // 
            // DiscountPrg
            // 
            this.DiscountPrg.Caption = "الخصم";
            this.DiscountPrg.FieldName = "DiscountPrg";
            this.DiscountPrg.MinWidth = 25;
            this.DiscountPrg.Name = "DiscountPrg";
            this.DiscountPrg.Visible = true;
            this.DiscountPrg.VisibleIndex = 12;
            this.DiscountPrg.Width = 94;
            // 
            // SaleCurrency
            // 
            this.SaleCurrency.Caption = "عملة البيع";
            this.SaleCurrency.FieldName = "SaleCurrency";
            this.SaleCurrency.MinWidth = 25;
            this.SaleCurrency.Name = "SaleCurrency";
            this.SaleCurrency.Visible = true;
            this.SaleCurrency.VisibleIndex = 13;
            this.SaleCurrency.Width = 94;
            // 
            // SaleCurrRate
            // 
            this.SaleCurrRate.Caption = "معدل البيع الحالي";
            this.SaleCurrRate.FieldName = "SaleCurrRate";
            this.SaleCurrRate.MinWidth = 25;
            this.SaleCurrRate.Name = "SaleCurrRate";
            this.SaleCurrRate.Visible = true;
            this.SaleCurrRate.VisibleIndex = 14;
            this.SaleCurrRate.Width = 94;
            // 
            // StoreName
            // 
            this.StoreName.Caption = "اسم المخزن";
            this.StoreName.FieldName = "StoreName";
            this.StoreName.MinWidth = 25;
            this.StoreName.Name = "StoreName";
            this.StoreName.Visible = true;
            this.StoreName.VisibleIndex = 15;
            this.StoreName.Width = 94;
            // 
            // InvoiceDate
            // 
            this.InvoiceDate.Caption = "تاريخ الفاتورة";
            this.InvoiceDate.FieldName = "InvoiceDate";
            this.InvoiceDate.MinWidth = 25;
            this.InvoiceDate.Name = "InvoiceDate";
            this.InvoiceDate.Visible = true;
            this.InvoiceDate.VisibleIndex = 16;
            this.InvoiceDate.Width = 94;
            // 
            // OrderNumber
            // 
            this.OrderNumber.Caption = "رقم الطلب";
            this.OrderNumber.FieldName = "OrderNumber";
            this.OrderNumber.MinWidth = 25;
            this.OrderNumber.Name = "OrderNumber";
            this.OrderNumber.Visible = true;
            this.OrderNumber.VisibleIndex = 17;
            this.OrderNumber.Width = 94;
            // 
            // ModifyUser
            // 
            this.ModifyUser.Caption = "المستخدم المعدل";
            this.ModifyUser.FieldName = "ModifyUser";
            this.ModifyUser.MinWidth = 25;
            this.ModifyUser.Name = "ModifyUser";
            this.ModifyUser.Visible = true;
            this.ModifyUser.VisibleIndex = 18;
            this.ModifyUser.Width = 94;
            // 
            // ModifyDate
            // 
            this.ModifyDate.Caption = "التاريخ المعدل";
            this.ModifyDate.ColumnEdit = this.repositoryItemDateTimeOffsetEdit1;
            this.ModifyDate.FieldName = "ModifyDate";
            this.ModifyDate.GroupFormat.FormatString = "d";
            this.ModifyDate.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.ModifyDate.MinWidth = 25;
            this.ModifyDate.Name = "ModifyDate";
            this.ModifyDate.Visible = true;
            this.ModifyDate.VisibleIndex = 19;
            this.ModifyDate.Width = 94;
            // 
            // repositoryItemDateTimeOffsetEdit1
            // 
            this.repositoryItemDateTimeOffsetEdit1.AutoHeight = false;
            this.repositoryItemDateTimeOffsetEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateTimeOffsetEdit1.Name = "repositoryItemDateTimeOffsetEdit1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.emptySpaceItem1,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1448, 689);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 31);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1428, 638);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.dateEditFrom;
            this.layoutControlItem2.Location = new System.Drawing.Point(1248, 0);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(180, 26);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(180, 26);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(180, 31);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.Text = "من";
            this.layoutControlItem2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(17, 16);
            this.layoutControlItem2.TextToControlDistance = 5;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(816, 31);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.DateEditTo;
            this.layoutControlItem3.Location = new System.Drawing.Point(1073, 0);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(175, 26);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(175, 26);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(175, 31);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.Text = "الى";
            this.layoutControlItem3.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(20, 16);
            this.layoutControlItem3.TextToControlDistance = 5;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnGet;
            this.layoutControlItem4.Location = new System.Drawing.Point(949, 0);
            this.layoutControlItem4.MaxSize = new System.Drawing.Size(124, 0);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(124, 31);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(124, 31);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnReport;
            this.layoutControlItem5.Location = new System.Drawing.Point(816, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(133, 31);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // ModifiedSalesFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1448, 689);
            this.Controls.Add(this.layoutControl1);
            this.Name = "ModifiedSalesFrm";
            this.Text = "الفواتير المعدلة";
            this.Load += new System.EventHandler(this.ModifiedSalesFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DateEditTo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateEditTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateTimeOffsetEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.SimpleButton btnGet;
        private DevExpress.XtraEditors.DateEdit DateEditTo;
        private DevExpress.XtraEditors.DateEdit dateEditFrom;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraGrid.Columns.GridColumn HeaderID;
        private DevExpress.XtraGrid.Columns.GridColumn DocumentType;
        private DevExpress.XtraGrid.Columns.GridColumn CustomerID;
        private DevExpress.XtraGrid.Columns.GridColumn InvoiceNum;
        private DevExpress.XtraGrid.Columns.GridColumn TaxesInvoiceNum;
        private DevExpress.XtraGrid.Columns.GridColumn DiscountAmount;
        private DevExpress.XtraGrid.Columns.GridColumn BranchID;
        private DevExpress.XtraGrid.Columns.GridColumn Comment;
        private DevExpress.XtraGrid.Columns.GridColumn PakageName;
        private DevExpress.XtraGrid.Columns.GridColumn ProductNameAR;
        private DevExpress.XtraGrid.Columns.GridColumn Qty;
        private DevExpress.XtraGrid.Columns.GridColumn Price;
        private DevExpress.XtraGrid.Columns.GridColumn DiscountPrg;
        private DevExpress.XtraGrid.Columns.GridColumn SaleCurrency;
        private DevExpress.XtraGrid.Columns.GridColumn SaleCurrRate;
        private DevExpress.XtraGrid.Columns.GridColumn StoreName;
        private DevExpress.XtraGrid.Columns.GridColumn InvoiceDate;
        private DevExpress.XtraGrid.Columns.GridColumn OrderNumber;
        private DevExpress.XtraGrid.Columns.GridColumn ModifyUser;
        private DevExpress.XtraGrid.Columns.GridColumn ModifyDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateTimeOffsetEdit repositoryItemDateTimeOffsetEdit1;
        private DevExpress.XtraEditors.SimpleButton btnReport;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    }
}