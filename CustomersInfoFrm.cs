using DevExpress.CodeParser;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFs
{
    public partial class CustomersInfoFrm : DevExpress.XtraEditors.XtraForm
    {
        DBClass DBClass = new DBClass();
        string showCstQry;
        DataTable showCstDT, customerNameDT, customerPriceListDT, customerGroupDT, salesPersonDT;
        private void ShowCustomersFn()
        {
            if(allChBox.Checked == true)
            {
                showCstQry = "Select CustomerID, ContactNu, RegistrationTaxNumber, ReceiverTyp, Country, Governate, RegionCity, ChartAccount,"
                              + " PriceProfileID, GroupID, SalesPersonID, LimitationAmount From CustomersTbl";

                showCstDT = DBClass.dataget(showCstQry, "get");

                gridControl1.DataSource = showCstDT;
            }
            else
            {
                if (cstMainGroupLue.EditValue != null)
                {
                    showCstQry = "Select CustomerID, ContactNu, RegistrationTaxNumber, ReceiverTyp, Country, Governate, RegionCity, ChartAccount,"
                              + " PriceProfileID, GroupID, SalesPersonID, LimitationAmount From CustomersTbl"
                              + " Where GroupID IN (Select GroupID From CustomersGroupTbl Where MainGroup = N'" + cstMainGroupLue.EditValue.ToString() + "')";

                    showCstDT = DBClass.dataget(showCstQry, "get");

                    gridControl1.DataSource = showCstDT;
                }
            }
            
            
        }

        public CustomersInfoFrm()
        {
            InitializeComponent();
        }

        private void GetCustomerLookupFn()
        {
            customerNameDT = DBClass.dataget("Select ContactNu, ContactName from ContactsTbl Where ContactTypeID Like '%1%' AND ContactNu != 0", "get");
            customerNameLue.DataSource = customerNameDT;
            customerNameLue.ValueMember = "ContactNu";
            customerNameLue.DisplayMember = "ContactName";
        }
        private void CustomersInfoFrm_Load(object sender, EventArgs e)
        {
            DataTable mainGroupDT = new DataTable();
            mainGroupDT.Columns.Add("MGroupName", typeof(string));

            if (FeturesClass.OfficeOrPOS == "Office")
            {
                mainGroupDT.Rows.Add("الشركة");
                mainGroupDT.Rows.Add("معارض");

                cstMainGroupLue.Properties.DataSource = mainGroupDT;
                cstMainGroupLue.Properties.ValueMember = "MGroupName";
                cstMainGroupLue.Properties.DisplayMember = "MGroupName";
                cstMainGroupLue.EditValue = mainGroupDT.Rows[0][0].ToString();
            }
            else
            {
                mainGroupDT.Rows.Add("معارض");

                cstMainGroupLue.Properties.DataSource = mainGroupDT;
                cstMainGroupLue.Properties.ValueMember = "MGroupName";
                cstMainGroupLue.Properties.DisplayMember = "MGroupName";
                cstMainGroupLue.EditValue = mainGroupDT.Rows[0][0].ToString();

                allGroupsLayOut.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }

            GetCustomerLookupFn();

            customerPriceListDT = DBClass.dataget("Select PriceListID, PriceListName From PriceListsTbl", "get");
            customerPriceListLue.DataSource = customerPriceListDT;
            customerPriceListLue.ValueMember = "PriceListID";
            customerPriceListLue.DisplayMember = "PriceListName";

            customerGroupDT = DBClass.dataget("Select GroupID, GroupName From CustomersGroupTbl", "get");
            customerGroupLue.DataSource = customerGroupDT;
            customerGroupLue.ValueMember = "GroupID";
            customerGroupLue.DisplayMember = "GroupName";

            salesPersonDT = DBClass.dataget("Select UserID, FullName From UsersTbl", "get");
            salesPersonLue.DataSource = salesPersonDT;
            salesPersonLue.ValueMember = "UserID";
            salesPersonLue.DisplayMember = "FullName";
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            GetCustomerLookupFn();

            ShowCustomersFn();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            DBClass.dataget(showCstQry, "Update");
            XtraMessageBox.Show("تم الحفظ");

            ShowCustomersFn();
        }

        private void excelBtn_Click(object sender, EventArgs e)
        {
            GridView gridView = gridView1;
            string selectedPath;
            string fileName = "CustomersInfoReport.xlsx";

            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                DialogResult result = dialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    selectedPath = dialog.SelectedPath;
                    gridView1.ExportToXlsx(selectedPath + @"\" + fileName);

                    try
                    {
                        // Use Process.Start to open the file with the default associated program
                        Process.Start(selectedPath + @"\" + fileName);
                    }
                    catch (Exception ex0)
                    {
                        XtraMessageBox.Show(ex0.Message, "Catch Error 0");
                    }
                }
                else
                {
                    XtraMessageBox.Show("No Path Selected");
                }
            }
        }

        private void AddNewCstBtn_Click(object sender, EventArgs e)
        {
            //AddCustomersFrm frm = new AddCustomersFrm();
            //frm.Show();
        }

        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete)
            {
                if (gridView1.GetFocusedRowCellValue("CustomerID") != null)
                {
                    DialogResult dialogResult = XtraMessageBox.Show(" هل تريد حذف هذا العميل؟ " + gridView1.GetFocusedRowCellValue("CustomerID").ToString(), "Delete Customer", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        DBClass.saveway("Delete From CustomersTbl Where ContactNu = " + gridView1.GetFocusedRowCellValue("ContactNu"));

                        showBtn.PerformClick();
                    }
                }
            }
        }
    }
}