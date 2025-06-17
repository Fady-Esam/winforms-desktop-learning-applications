using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskProject
{
    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
    {
        public XtraForm1()
        {
            InitializeComponent();
        }

        private void XtraForm1_Load(object sender, EventArgs e)
        {
            ClsNumberCheck.CheckNum(140);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }
        /*
private void simpleButton1_Click(object sender, EventArgs e)
{
   string connString = "Server =.; DataBase = FF; Integrated Security = True;Timeout=30";
   SqlConnection sqlCon = new SqlConnection(connString);
   string sqlQuery = @"
   DECLARE @val INT;

   INSERT INTO DataTable (name, Password, Email, Phone) 
   VALUES ('fdsa456', '1', 'asd', 'asd');

   INSERT INTO DataTable (name, Password, Email, Phone) 
   VALUES ('4613', '432', 'asd', 'asd'); 

   SET @val = SCOPE_IDENTITY();

   INSERT INTO DataTable (name, Password, Email, Phone) 
   VALUES ('data', '432', 'asd', 'asd');

   SELECT @val;
";
   SqlCommand com = new SqlCommand(sqlQuery, sqlCon);
   try
   {
       sqlCon.Open();
       object res = com.ExecuteScalar();
       if(res != null && res != DBNull.Value)
       {
           int id = Convert.ToInt32(res);
       }
       sqlCon.Close();
   }catch(Exception ex)
   {
       MessageBox.Show("Error");
   }


}*/
    }
}