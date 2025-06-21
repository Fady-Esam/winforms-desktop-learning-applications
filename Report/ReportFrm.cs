using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.UserDesigner;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFs
{
    public partial class ReportFrm : DevExpress.XtraEditors.XtraForm
    {
        public ReportFrm()
        {
            InitializeComponent();
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var report = new XtraReport();
            var designForm = new XRDesignForm();
            designForm.OpenReport(report);
            designForm.ShowDialog();
        }
    }
}



