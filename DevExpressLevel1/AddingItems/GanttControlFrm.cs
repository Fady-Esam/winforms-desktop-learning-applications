using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddingItems
{
    public partial class GanttControlFrm : DevExpress.XtraEditors.XtraForm
    {
        public GanttControlFrm()
        {
            InitializeComponent();
        }

        private void GanttControlFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hR_DBDataSet1.Employees' table. You can move, or remove it, as needed.
            // this.employeesTableAdapter1.Fill(this.hR_DBDataSet1.Employees);
            // TODO: This line of code loads data into the 'employeesDBDataSet.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.employeesDBDataSet.Employees);

        }
    }
}