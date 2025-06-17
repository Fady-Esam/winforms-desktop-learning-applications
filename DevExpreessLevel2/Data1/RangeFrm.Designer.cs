namespace Lesson1
{
    partial class RangeFrm
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
            DevExpress.XtraEditors.RangeControlRange rangeControlRange3 = new DevExpress.XtraEditors.RangeControlRange();
            DevExpress.XtraEditors.DateTimeRangeClientRuler dateTimeRangeClientRuler1 = new DevExpress.XtraEditors.DateTimeRangeClientRuler();
            this.rangeControl1 = new DevExpress.XtraEditors.RangeControl();
            this.numericChartRangeControlClient1 = new DevExpress.XtraEditors.NumericChartRangeControlClient();
            this.dateTimeChartRangeControlClient1 = new DevExpress.XtraEditors.DateTimeChartRangeControlClient();
            this.timeSpanChartRangeControlClient1 = new DevExpress.XtraEditors.TimeSpanChartRangeControlClient();
            this.dateTimeRangeControlClient1 = new DevExpress.XtraEditors.DateTimeRangeControlClient();
            this.numericChartRangeControlClient2 = new DevExpress.XtraEditors.NumericChartRangeControlClient();
            this.tileBar1 = new DevExpress.XtraBars.Navigation.TileBar();
            this.tileBarGroup2 = new DevExpress.XtraBars.Navigation.TileBarGroup();
            this.ganttControl1 = new DevExpress.XtraGantt.GanttControl();
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.rangeControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericChartRangeControlClient1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeChartRangeControlClient1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeSpanChartRangeControlClient1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericChartRangeControlClient2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ganttControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // rangeControl1
            // 
            this.rangeControl1.Client = this.numericChartRangeControlClient2;
            this.rangeControl1.Location = new System.Drawing.Point(12, 41);
            this.rangeControl1.Name = "rangeControl1";
            rangeControlRange3.Maximum = 9D;
            rangeControlRange3.Minimum = 0D;
            rangeControlRange3.Owner = this.rangeControl1;
            this.rangeControl1.SelectedRange = rangeControlRange3;
            this.rangeControl1.Size = new System.Drawing.Size(868, 108);
            this.rangeControl1.TabIndex = 0;
            this.rangeControl1.Text = "rangeControl1";
            // 
            // dateTimeRangeControlClient1
            // 
            this.dateTimeRangeControlClient1.LabelFormatString = "";
            this.dateTimeRangeControlClient1.Minimum = new System.DateTime(((long)(0)));
            this.dateTimeRangeControlClient1.RangeControl = this.rangeControl1;
            this.dateTimeRangeControlClient1.Rulers.Add(dateTimeRangeClientRuler1);
            // 
            // tileBar1
            // 
            this.tileBar1.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.tileBar1.Groups.Add(this.tileBarGroup2);
            this.tileBar1.Location = new System.Drawing.Point(12, 175);
            this.tileBar1.Name = "tileBar1";
            this.tileBar1.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.ScrollButtons;
            this.tileBar1.Size = new System.Drawing.Size(364, 263);
            this.tileBar1.TabIndex = 1;
            this.tileBar1.Text = "tileBar1";
            // 
            // tileBarGroup2
            // 
            this.tileBarGroup2.Name = "tileBarGroup2";
            // 
            // ganttControl1
            // 
            this.ganttControl1.Location = new System.Drawing.Point(447, 175);
            this.ganttControl1.Name = "ganttControl1";
            this.ganttControl1.Size = new System.Drawing.Size(400, 200);
            this.ganttControl1.TabIndex = 2;
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "System.Windows.Forms.StatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane",
            "DevExpress.XtraBars.TabFormControl",
            "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl",
            "DevExpress.XtraBars.ToolbarForm.ToolbarFormControl"});
            // 
            // RangeFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 643);
            this.Controls.Add(this.ganttControl1);
            this.Controls.Add(this.tileBar1);
            this.Controls.Add(this.rangeControl1);
            this.Name = "RangeFrm";
            this.Text = "RangeFrm";
            ((System.ComponentModel.ISupportInitialize)(this.rangeControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericChartRangeControlClient1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeChartRangeControlClient1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeSpanChartRangeControlClient1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericChartRangeControlClient2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ganttControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.RangeControl rangeControl1;
        private DevExpress.XtraEditors.DateTimeRangeControlClient dateTimeRangeControlClient1;
        private DevExpress.XtraEditors.NumericChartRangeControlClient numericChartRangeControlClient1;
        private DevExpress.XtraEditors.DateTimeChartRangeControlClient dateTimeChartRangeControlClient1;
        private DevExpress.XtraEditors.TimeSpanChartRangeControlClient timeSpanChartRangeControlClient1;
        private DevExpress.XtraEditors.NumericChartRangeControlClient numericChartRangeControlClient2;
        private DevExpress.XtraBars.Navigation.TileBar tileBar1;
        private DevExpress.XtraBars.Navigation.TileBarGroup tileBarGroup2;
        private DevExpress.XtraGantt.GanttControl ganttControl1;
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
    }
}