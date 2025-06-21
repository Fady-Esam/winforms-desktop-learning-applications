using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Filtering.Templates;
using DevExpress.XtraLayout.Filtering.Templates;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFs
{
    public partial class ModifiedSalesFrm : DevExpress.XtraEditors.XtraForm
    {
        DBClass dbCls = new DBClass();
        string qry;
        public ModifiedSalesFrm()
        {
            InitializeComponent();
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            
            if (!string.IsNullOrEmpty(dateEditFrom.Text) && !string.IsNullOrEmpty(DateEditTo.Text))
            {
                qry = "SELECT * FROM ModifiedSalesInvTbl WHERE ModifyDate BETWEEN '" + dateEditFrom.DateTime + "' AND '" + DateEditTo.DateTime + "'";
                gridControl1.DataSource = dbCls.dataget(qry, "get");
                //XtraMessageBox.Show(qry);
                //gridControl1.DataSource = ClsProject.showData(dateEditFrom.DateTime, DateEditTo.DateTime);
                //gridControl1.DataSource = ClsProject.showData(dateEditFrom.DateTime, DateEditTo.DateTime);
            }
        }

        private void ModifiedSalesFrm_Load(object sender, EventArgs e)
        {
            dateEditFrom.EditValue = DateEditTo.EditValue = DateTime.Now;
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            //var report = new rptCustomerGroup();
            //report.DataSource = gridControl1.DataSource;
            //report.CreateDocument();
            //PrintTool printTool = new ReportPrintTool(report);
            //printTool.ShowPreview();
        }
    }
}