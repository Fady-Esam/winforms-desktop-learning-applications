using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;


namespace WFs
{
    internal class DBClass
    {
         private static readonly SqlConnection sqlConn;
         private const string connString = "Server =.; DataBase = DB; User Id = sa; Password = 123; Timeout=30";
         private static DataTable dt1;
         private static SqlCommand cmd;
         private static SqlDataAdapter sda;
         private static SqlCommandBuilder cmdbl;
         private static string returnedCell;
         private static int returnedRowsCount;
         private static int returnedID = 0;
         private static object result;

        static DBClass()
        {
            try
            {
                sqlConn = new SqlConnection(connString);
            }
            catch
            {
                MessageBox.Show("Kindly check your connection");
            }
        }

        public DataTable dataget(string qry1, string state) 
        {
            sda = new SqlDataAdapter(qry1, sqlConn);
            if (state == "get") 
            {
                dt1 = new DataTable();
                try
                {
                    sda.Fill(dt1);
                }
                catch (Exception ex1)
                {
                    MessageBox.Show(ex1.Message, "Error of DataGet");
                }
                return dt1;
            }
            else 
            {
                try
                {
                    cmdbl = new SqlCommandBuilder(sda);
                    sda.Update(dt1);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                return null;
            }
        }

        public string dataget(string qry, int x)
        {

            dt1 = new DataTable();
            try
            {
                sda = new SqlDataAdapter(qry, sqlConn);
                sda.Fill(dt1);

                returnedCell = dt1.Rows[0][x].ToString();
                return returnedCell;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public int saveway(string qry1)
        {
            cmd = new SqlCommand(qry1, sqlConn);

            try
            {
                if (sqlConn.State == ConnectionState.Closed)
                {
                    sqlConn.Open();
                }

                returnedRowsCount = cmd.ExecuteNonQuery();
                sqlConn.Close();
                return returnedRowsCount;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SaveWay Error");
                sqlConn.Close();
                return 0;
            }
        }
        public int SaveWithReturnIdentity(string qry)
        {
            cmd = new SqlCommand(qry, sqlConn);
            try
            {
                if (sqlConn.State == ConnectionState.Closed)
                    sqlConn.Open();
                result = cmd.ExecuteScalar();
                if(result != null && result != DBNull.Value)
                    returnedID = Convert.ToInt32(result);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SaveWithReturnIdentity Error");
            }
            finally
            {
                sqlConn.Close();
            }
            return returnedID;
        }
        public int InsertWithIdentity(string query)
        {
            int insertedId = 0;

            string fullQuery = $"{query}; SELECT SCOPE_IDENTITY();";

            try
            {
                if (sqlConn.State == ConnectionState.Closed)
                    sqlConn.Open();

                using (SqlCommand insertCmd = new SqlCommand(fullQuery, sqlConn))
                {
                    object result = insertCmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                        insertedId = Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "InsertWithIdentity Error");
            }
            finally
            {
                sqlConn.Close();
            }

            return insertedId;
        }
        public void FillLookUpEdit(LookUpEdit lue, DataTable dt, string valMember, string disMember)
        {
            lue.Properties.DataSource = dt;
            lue.Properties.ValueMember = valMember;
            lue.Properties.DisplayMember = disMember;
        }
        public void FillGridLookUpEdit(RepositoryItemLookUpEdit lue, DataTable dt, string valMember, string disMember)
        {
            lue.ValueMember = valMember;
            lue.DisplayMember = disMember;
            lue.DataSource = dt;
        }
    }


}

