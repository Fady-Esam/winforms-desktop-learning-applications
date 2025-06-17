using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskProject
{
    internal class DBClass
    {
        static public SqlConnection sqlConn = new SqlConnection();
        public DBClass()
        {
            try
            {
                string connString = "Server =.; DataBase = Task; Integrated Security = True;Timeout=30";
                // string connString = "Server =.; DataBase = HR_DB; Integrated Security = True;Timeout=30";
                SqlConnection sqlConn2 = new SqlConnection(connString);
                sqlConn = sqlConn2;
            }
            catch
            {
                MessageBox.Show("Kindly check your connection");
            }

        }

        DataTable dt1 = new DataTable();
        public DataTable dataget(string qry1, string state) // to get or update
        {
            SqlDataAdapter sda = new SqlDataAdapter(qry1, sqlConn);
            if (state == "get") // to get data table
            {
                DataTable dt2 = new DataTable();
                try
                {
                    sda.Fill(dt2);
                    dt1 = dt2;
                }
                catch (Exception ex1)
                {
                    MessageBox.Show(ex1.Message, "Error of DataGet");
                }
                return dt2;
            }
            else // to update data table
            {
                try
                {
                    SqlCommandBuilder cmdbl = new SqlCommandBuilder(sda);
                    sda.Update(dt1);
                    //MessageBox.Show("Data updated");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                return null;
            }
        }
        // public 

        public string dataget(string qry, int x) // To get one cell from data table
        {
            //CheckSysDate();

            try
            {
                SqlDataAdapter sda = new SqlDataAdapter(qry, sqlConn);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                string cell = dt.Rows[0][x].ToString();
                return cell;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public int saveway(string qry1)
        {
            int returnedRowsCount;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlConn;
            cmd.CommandText = qry1;

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
        static string connString = "Server =.; DataBase = TaskDB; Integrated Security = True; Timeout=30";
        SqlConnection sqlConn2 = new SqlConnection(connString);
        public int savedata(string gruopName, string mainGroup, bool isFast)
        {
            string query = "INSERT INTO CustomersGroupTbl (GroupName, MainGroup, IsFast) " +
            "VALUES (@gN, @mG, @iF)";
            SqlCommand com = new SqlCommand(query, sqlConn2);
            com.Parameters.AddWithValue("@gN", gruopName);
            com.Parameters.AddWithValue("@mG", mainGroup);
            com.Parameters.AddWithValue("@iF", isFast);
            int affectRows = -1;
            try
            {
                sqlConn2.Open();
                affectRows = com.ExecuteNonQuery();
                sqlConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in save data =>" + ex);
            }
            return affectRows;
        }
        public int updateData(string groupName, string mainGroup, bool isFast, int id)
        {
            string query = "UPDATE CustomersGroupTbl SET GroupName = @gN, MainGroup = @mG, IsFast = @iF WHERE GroupID = @ID";
            SqlCommand com = new SqlCommand(query, sqlConn2);
            com.Parameters.AddWithValue("@gN", groupName);
            com.Parameters.AddWithValue("@mG", mainGroup);
            com.Parameters.AddWithValue("@iF", isFast);
            com.Parameters.AddWithValue("@ID", id);
            int affectRows = -1;
            try
            {
                sqlConn2.Open();
                affectRows = com.ExecuteNonQuery();
                sqlConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in save data => " + ex);
            }
            return affectRows;
        }

    }
}
