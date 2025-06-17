using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraLayout;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class CustomGroupFrm : DevExpress.XtraEditors.XtraForm
    {
        DBClass dbCls = new DBClass();
        public CustomGroupFrm()
        {
            InitializeComponent();
        }

        private void CustomGroupFrm_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM CustomersGroupTbl";
            gvCustomerGroup.DataSource = dbCls.dataget(query, "get");
        }


        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtGroupName.Text) && !string.IsNullOrEmpty(txtMainGroup.Text))
            {

                if (dbCls.savedata(txtGroupName.Text, txtMainGroup.Text, chkIsFast.Checked) > 0)
                {
                    MessageBox.Show("Data Added Successfully");
                    string insQuery = "SELECT * FROM CustomersGroupTbl";
                    gvCustomerGroup.DataSource = dbCls.dataget(insQuery, "get");
                }
                else
                {
                    MessageBox.Show("Something went wrong please try again");
                }

            }
            
        }

        private int groupID = -1;
        private string grName = "";
        private string mainGroup = "";
        private bool isFast = false;

        private void gridView1_RowUpdated_1(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            DataRow row = gridView1.GetDataRow(e.RowHandle);
            groupID = (int)row["GroupID"];
            grName = (string)row["GroupName"];
            mainGroup = (string)row["MainGroup"];
            isFast = (bool)row["IsFast"];
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(grName) && !string.IsNullOrEmpty(mainGroup) && groupID != -1)
            {

                if (dbCls.updateData(grName, mainGroup, isFast, groupID) > 0)
                {
                    MessageBox.Show("Data Updated Successfully");
                    string insQuery = "SELECT * FROM CustomersGroupTbl";
                    gvCustomerGroup.DataSource = dbCls.dataget(insQuery, "get");
                }
                else
                {
                    MessageBox.Show("Something went wrong please try again");
                }

            }
        }

        private void gvCustomerGroup_Click(object sender, EventArgs e)
        {

        }
    }
}