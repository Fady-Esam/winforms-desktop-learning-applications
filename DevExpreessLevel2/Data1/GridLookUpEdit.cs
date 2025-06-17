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

namespace Lesson1
{
    public partial class GridLookUpEdit : DevExpress.XtraEditors.XtraForm
    {
        public GridLookUpEdit()
        {
            InitializeComponent();
        }

        private void GridLookUpEdit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hR_DBDataSet.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.hR_DBDataSet.Employees);

        }
    }
}