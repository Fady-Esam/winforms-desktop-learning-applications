namespace AddingItems
{
    partial class GanttControlFrm
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
            this.components = new System.ComponentModel.Container();
            this.ganttControl1 = new DevExpress.XtraGantt.GanttControl();
            this.colEmployeeID = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colManagerID = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colSalary = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesDBDataSet = new AddingItems.EmployeesDBDataSet();
            this.employeesTableAdapter = new AddingItems.EmployeesDBDataSetTableAdapters.EmployeesTableAdapter();
            // this.hR_DBDataSet1 = new AddingItems.HR_DBDataSet1();
            this.employeesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            // this.employeesTableAdapter1 = new AddingItems.HR_DBDataSet1TableAdapters.EmployeesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ganttControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDBDataSet)).BeginInit();
            // ((System.ComponentModel.ISupportInitialize)(this.hR_DBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // ganttControl1
            // 
            this.ganttControl1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colEmployeeID,
            this.colName,
            this.colManagerID,
            this.colSalary});
            // this.ganttControl1.DataSource = this.hR_DBDataSet1;
            this.ganttControl1.Location = new System.Drawing.Point(129, 31);
            this.ganttControl1.Name = "ganttControl1";
            this.ganttControl1.Size = new System.Drawing.Size(647, 446);
            this.ganttControl1.TabIndex = 0;
            // 
            // colEmployeeID
            // 
            this.colEmployeeID.FieldName = "EmployeeID";
            this.colEmployeeID.Name = "colEmployeeID";
            this.colEmployeeID.Visible = true;
            this.colEmployeeID.VisibleIndex = 0;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            // 
            // colManagerID
            // 
            this.colManagerID.FieldName = "ManagerID";
            this.colManagerID.Name = "colManagerID";
            this.colManagerID.Visible = true;
            this.colManagerID.VisibleIndex = 2;
            // 
            // colSalary
            // 
            this.colSalary.FieldName = "Salary";
            this.colSalary.Name = "colSalary";
            this.colSalary.Visible = true;
            this.colSalary.VisibleIndex = 3;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.employeesDBDataSet;
            // 
            // employeesDBDataSet
            // 
            this.employeesDBDataSet.DataSetName = "EmployeesDBDataSet";
            this.employeesDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // hR_DBDataSet1
            // 
            // this.hR_DBDataSet1.DataSetName = "HR_DBDataSet1";
            // this.hR_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeesBindingSource1
            // 
            this.employeesBindingSource1.DataMember = "Employees";
            // this.employeesBindingSource1.DataSource = this.hR_DBDataSet1;
            // 
            // employeesTableAdapter1
            // 
            // this.employeesTableAdapter1.ClearBeforeFill = true;
            // 
            // GanttControlFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 604);
            this.Controls.Add(this.ganttControl1);
            this.Name = "GanttControlFrm";
            this.Text = "GanttControlFrm";
            this.Load += new System.EventHandler(this.GanttControlFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ganttControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDBDataSet)).EndInit();
            // ((System.ComponentModel.ISupportInitialize)(this.hR_DBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGantt.GanttControl ganttControl1;
        private EmployeesDBDataSet employeesDBDataSet;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private EmployeesDBDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colEmployeeID;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colManagerID;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colSalary;
     //   private HR_DBDataSet1 hR_DBDataSet1;
        private System.Windows.Forms.BindingSource employeesBindingSource1;
      //  private HR_DBDataSet1TableAdapters.EmployeesTableAdapter employeesTableAdapter1;
    }
}