namespace TestDev {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            
            this.spreadsheetFormulaBarPanel = new System.Windows.Forms.Panel();
this.spreadsheetControl = new DevExpress.XtraSpreadsheet.SpreadsheetControl();
this.splitterControl = new DevExpress.XtraEditors.SplitterControl();
this.spreadsheetFormulaBar = new DevExpress.XtraSpreadsheet.SpreadsheetFormulaBar();


            

            this.SuspendLayout();

            this.spreadsheetFormulaBarPanel.SuspendLayout();
this.spreadsheetFormulaBarPanel.Controls.Add(this.spreadsheetControl);
this.spreadsheetFormulaBarPanel.Controls.Add(this.splitterControl);
this.spreadsheetFormulaBarPanel.Controls.Add(this.spreadsheetFormulaBar);
this.spreadsheetFormulaBarPanel.Dock = System.Windows.Forms.DockStyle.Fill;
this.spreadsheetFormulaBarPanel.Location = new System.Drawing.Point(0, 0);
this.spreadsheetFormulaBarPanel.Name = "spreadsheetFormulaBarPanel";
this.spreadsheetFormulaBarPanel.Size = new System.Drawing.Size(499, 375);
this.spreadsheetFormulaBarPanel.TabIndex = 0;
this.spreadsheetFormulaBarPanel.ResumeLayout(false);
this.spreadsheetControl.Dock = System.Windows.Forms.DockStyle.Fill;
this.spreadsheetControl.Location = new System.Drawing.Point(0, 25);
this.spreadsheetControl.Name = "spreadsheetControl";
this.spreadsheetControl.Size = new System.Drawing.Size(499, 350);
this.spreadsheetControl.TabIndex = 1;
this.spreadsheetControl.Text = "spreadsheetControl1";
this.splitterControl.Dock = System.Windows.Forms.DockStyle.Top;
this.splitterControl.Location = new System.Drawing.Point(0, 20);
this.splitterControl.MinSize = 20;
this.splitterControl.Name = "splitterControl";
this.splitterControl.Size = new System.Drawing.Size(499, 5);
this.splitterControl.TabIndex = 2;
this.splitterControl.TabStop = false;
this.spreadsheetFormulaBar.AccessibleName = "Formula bar";
this.spreadsheetFormulaBar.Dock = System.Windows.Forms.DockStyle.Top;
this.spreadsheetFormulaBar.Location = new System.Drawing.Point(0, 0);
this.spreadsheetFormulaBar.MinimumSize = new System.Drawing.Size(0, 24);
this.spreadsheetFormulaBar.Name = "spreadsheetFormulaBar";
this.spreadsheetFormulaBar.Size = new System.Drawing.Size(483, 24);
this.spreadsheetFormulaBar.SpreadsheetControl = this.spreadsheetControl;
this.spreadsheetFormulaBar.TabIndex = 3;


            this.Name = "Form1";
            this.Text = "Form1";
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.Controls.Add(this.spreadsheetFormulaBarPanel);

            
            
            
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel spreadsheetFormulaBarPanel;
private DevExpress.XtraSpreadsheet.SpreadsheetControl spreadsheetControl;
private DevExpress.XtraEditors.SplitterControl splitterControl;
private DevExpress.XtraSpreadsheet.SpreadsheetFormulaBar spreadsheetFormulaBar;
        
    }
}
