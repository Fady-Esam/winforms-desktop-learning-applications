namespace WindowsFormsApp1
{
    partial class CustomGroupFrm
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
            this.btnInsert = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.txtGroupName = new DevExpress.XtraEditors.TextEdit();
            this.labGroupName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMainGroup = new DevExpress.XtraEditors.TextEdit();
            this.chkIsFast = new DevExpress.XtraEditors.CheckEdit();
            this.gvCustomerGroup = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.txtGroupName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMainGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkIsFast.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCustomerGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(1282, 12);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(94, 29);
            this.btnInsert.TabIndex = 0;
            this.btnInsert.Text = "Insert";
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(1282, 704);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 29);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtGroupName
            // 
            this.txtGroupName.Location = new System.Drawing.Point(393, 34);
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGroupName.Properties.Appearance.Options.UseFont = true;
            this.txtGroupName.Size = new System.Drawing.Size(154, 30);
            this.txtGroupName.TabIndex = 3;
            // 
            // labGroupName
            // 
            this.labGroupName.AutoSize = true;
            this.labGroupName.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labGroupName.Location = new System.Drawing.Point(252, 34);
            this.labGroupName.Name = "labGroupName";
            this.labGroupName.Size = new System.Drawing.Size(122, 22);
            this.labGroupName.TabIndex = 4;
            this.labGroupName.Text = "اسم المجموعة";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(630, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "المجموعة الرئيسية";
            // 
            // txtMainGroup
            // 
            this.txtMainGroup.Location = new System.Drawing.Point(806, 36);
            this.txtMainGroup.Name = "txtMainGroup";
            this.txtMainGroup.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMainGroup.Properties.Appearance.Options.UseFont = true;
            this.txtMainGroup.Size = new System.Drawing.Size(154, 30);
            this.txtMainGroup.TabIndex = 5;
            // 
            // chkIsFast
            // 
            this.chkIsFast.Location = new System.Drawing.Point(1015, 38);
            this.chkIsFast.Name = "chkIsFast";
            this.chkIsFast.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIsFast.Properties.Appearance.Options.UseFont = true;
            this.chkIsFast.Properties.Caption = "السرعة";
            this.chkIsFast.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkIsFast.Size = new System.Drawing.Size(107, 28);
            this.chkIsFast.TabIndex = 7;
            // 
            // gvCustomerGroup
            // 
            this.gvCustomerGroup.Location = new System.Drawing.Point(27, 81);
            this.gvCustomerGroup.MainView = this.gridView1;
            this.gvCustomerGroup.Name = "gvCustomerGroup";
            this.gvCustomerGroup.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gvCustomerGroup.Size = new System.Drawing.Size(1422, 601);
            this.gvCustomerGroup.TabIndex = 11;
            this.gvCustomerGroup.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gvCustomerGroup;
            this.gridView1.Name = "gridView1";
            // 
            // CustomGroupFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1461, 745);
            this.Controls.Add(this.gvCustomerGroup);
            this.Controls.Add(this.chkIsFast);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMainGroup);
            this.Controls.Add(this.labGroupName);
            this.Controls.Add(this.txtGroupName);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Name = "CustomGroupFrm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "مجموعة العميل";
            this.Load += new System.EventHandler(this.CustomGroupFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtGroupName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMainGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkIsFast.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCustomerGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnInsert;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.TextEdit txtGroupName;
        private System.Windows.Forms.Label labGroupName;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtMainGroup;
        private DevExpress.XtraEditors.CheckEdit chkIsFast;
        private DevExpress.XtraGrid.GridControl gvCustomerGroup;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}