using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace WFs
{
    public partial class AddSuppliersFrm : DevExpress.XtraEditors.XtraForm
    {
        DBClass DBObj = new DBClass();
        string custGroup, addContactQry;
        DataTable custGrouDT;
        int contactNu, customerID;

        public AddSuppliersFrm()
        {
            InitializeComponent();
        }

        private void CustomersFrm_Load(object sender, EventArgs e)
        {

            string custGroup = "SELECT GroupID, GroupName  FROM CustomersGroupTbl";
            DataTable custGrouDT = DBObj.dataget(custGroup, "get");
            FillLookUpEdit(custGrouDT, "GroupID", "GroupName", GroupLue);
            GroupLue.EditValue = custGrouDT.Rows[0][0];

            DataTable cstChartDT = DBObj.dataget("Select Accounts_Items.Account_ID, Accounts_Items.Account_Name" +
                        " From Accounts_Routs Inner Join (Accounts_Main Inner Join Accounts_Items" +
                        " ON Accounts_Main.Dep_ID = Accounts_Items.Dep_Code) ON Accounts_Routs.Route_ID = Accounts_Main.Route_ID" +
                        " Where Accounts_Items.Acc_Type = 'CST'", "get");
            FillLookUpEdit(cstChartDT, "Account_ID", "Account_Name", ChartAccountLue);
            ChartAccountLue.EditValue = cstChartDT.Rows[0][0].ToString();

            DataTable salesPersonDT = DBObj.dataget("Select UserID, FullName From UsersTbl", "get");
            FillLookUpEdit(salesPersonDT, "UserID", "FullName", SalesPersonLue);
            // SalesPersonLue.EditValue = ClassesFdr.GeneralVarClass.userID;

            DataTable priceListDT = DBObj.dataget("SELECT * FROM PriceListsTbl ORDER BY PriceListID", "get");
            FillLookUpEdit(priceListDT, "PriceListID", "PriceListName", PriceProfileLue);
            PriceProfileLue.EditValue = priceListDT.Rows[0][0];


            DataTable table = new DataTable();
            table.Columns.Add("Type", typeof(string));
            table.Rows.Add(new object[] { "P" });
            table.Rows.Add(new object[] { "B" });
            table.Rows.Add(new object[] { "F" });
            FillLookUpEdit(table, "Type", "Type", ReceiverTypeLue);
            ReceiverTypeLue.EditValue = "P";
        }

        private void FillLookUpEdit(DataTable dt, string valueMember, string displayMember, LookUpEdit name)
        {
            name.Properties.DataSource = dt;
            name.Properties.DisplayMember = displayMember;
            name.Properties.ValueMember = valueMember;
        }

        private void AddCustomerFn()
        {

            try
            {
                contactNu = Convert.ToInt32(DBObj.dataget("Select MAX(ContactNu) From ContactsTbl", 0)) + 1;
            }
            catch
            {
                contactNu = 1;
            }

            try
            {
                customerID = Convert.ToInt32(DBObj.dataget("Select MAX(CustomerID) From CustomersTbl", 0)) + 1;
            }
            catch
            {
                customerID = 1;
            }

            addContactQry = "Insert Into ContactsTbl (ContactNu, ContactName, Phone1, Phone2, ContactTypeID, UserID, UserDate, BranchID)"
                          + " Values (" + contactNu + " , N'" + CustomerNameTxt.Text + "' , N'" + Phone1Txt.Text + "', N'" + Phone1Txt.Text + "' ,"
                          + " '1' , " + $"{ID}" + " , "
                          + " '" + DateTime.Now + "' , " + $"{LocationID}" + ")";

            addContactQry += " Insert Into CustomersTbl (CustomerID, ContactNu, BranchID, GroupID, ChartAccount, RegistrationTaxNumber,"
                          + " PriceProfileID, LimitationAmount, Country, ReceiverTyp, SalesPersonID)"
                          + " Values (" + customerID + " , " + contactNu + " , " + $"{LocationID}" + " ,"
                          + " " + GroupLue.EditValue + ", '" + ChartAccountLue.EditValue.ToString() + "' , '" + RegistrationTaxNumberTxt.Text + "' ,"
                          + " " + PriceProfileLue.EditValue + " , " + LimitationAmountTxt.Text + " , N'" + CountryTxt.Text + "' , '" + ReceiverTypeLue.EditValue + "', "
                          + " " + SalesPersonLue.EditValue + ")";

            DBObj.InsertWithIdentity(addContactQry);

            XtraMessageBox.Show("Done", "Add Contact");

            this.Close();
        }
        private void addCustomerBtn_Click(object sender, EventArgs e)
        {

            if (SupplierNameTxt.Text != "")
            {
                AddCustomerFn();
            }
            else
            {
                XtraMessageBox.Show("اكتب اسم العميل");
            }
        }
    }
}