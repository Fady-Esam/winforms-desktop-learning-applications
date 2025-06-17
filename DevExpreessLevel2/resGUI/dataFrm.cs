using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace resGUI
{
    public partial class dataFrm : DevExpress.XtraEditors.XtraForm
    {
        public dataFrm()
        {
            InitializeComponent();
        }

        private void dataFrm_Load(object sender, EventArgs e)
        {
            // MessageBox.Show(ClsNumberCheck.Chek(153.78).ToString());
            gridControl1.DataSource = ClsNumberCheck.NumChck2(100000, 21000);
        }

        private void dataFrm_FormClosing(object sender, FormClosingEventArgs e)
        {/*
            DialogResult result = MessageBox.Show("Are you sure you want to close the application?",
                                      "Confirm Exit",
                                      MessageBoxButtons.YesNo,
                                      MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true; // Cancel the close operation
            }*/

        }
    }
}

