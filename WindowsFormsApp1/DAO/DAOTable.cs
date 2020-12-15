using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.DAO
{
    class DAOTable
    {
        MY_DB db = new MY_DB();
        public bool KTBanDangSD(int maban)
        {
            SqlCommand command = new SqlCommand("select maban from hoadon where convert(date,Hoadon.Thoigian) = convert(date, getdate()) and trangthai = 0 and maban=@maban", db.GetConnection);
            command.Parameters.Add("@maban", SqlDbType.Int).Value = maban;
            db.openConection();
            if (Convert.ToInt32(command.ExecuteScalar()) != 0)
            {
                db.closedConection();
                return true;
            }
            else
            {
                db.closedConection();
                return false;
            }
        }

        public List<Table> LoadTable()
        {
            List<Table> tableList = new List<Table>();
            try
            {
                string query = "SELECT * FROM Ban";
                SqlConnection connect = db.GetConnection;
                SqlCommand cmd = new SqlCommand(query, connect);
                connect.Open();
                if (connect.State == System.Data.ConnectionState.Open)
                {

                    SqlDataAdapter da = new SqlDataAdapter(query, connect);
                    DataTable ds = new DataTable();
                    da.Fill(ds);
                    foreach (DataRow item in ds.Rows)
                    {
                        Table tb = new Table(item);
                        tableList.Add(tb);
                    }
                }
                connect.Close();
                return tableList;
            }
            catch
            {
                MessageBox.Show("error happened", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return tableList;
        }
        public Table addTable()
        {
            Table l = new Table();
            try
            {
                SqlConnection connect = db.GetConnection;
                connect.Open();
                if (connect.State == System.Data.ConnectionState.Open)
                {
                    string query = "INSERT INTO dbo.Ban (Tenban ,Trangthai ,SoLuongKhach)VALUES  (@Tenban,@Trangthai,@SoLuongKhach )";
                    string query1 = "SELECT COUNT(Maban) FROM dbo.Ban";
                    SqlCommand cmd = new SqlCommand(query, connect);
                    SqlCommand cmd1 = new SqlCommand(query1, connect);
                    object a = cmd1.ExecuteScalar();
                        int ID = Convert.ToInt32(a) + 1;
                    //cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
                    Table k = new Table( "Available", "Table " + ID.ToString(), 0);
                    cmd.Parameters.Add("@Tenban", SqlDbType.VarChar).Value = k.Tenban;
                    cmd.Parameters.Add("@Trangthai", SqlDbType.VarChar).Value = k.TableStatus1;
                    cmd.Parameters.Add("@SoLuongKhach", SqlDbType.Int).Value = k.Soluongnguoi;

                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Add successfully ", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return k;
                    }
                    else
                    {
                        MessageBox.Show("wrong id ", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                connect.Close();
            }
            catch
            {
                MessageBox.Show("error", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return l;
        }

        public int deleteTable()
        {
            try
            {
                SqlConnection connect = db.GetConnection;
                connect.Open();

                if (connect.State == System.Data.ConnectionState.Open)
                {
                    string query = "DELETE dbo.Ban WHERE Maban=@ID";
                    string query1 = "SELECT MAX(Maban) FROM dbo.Ban";
                    SqlCommand cmd1 = new SqlCommand(query1, connect);
                    SqlCommand cmd = new SqlCommand(query, connect);
                    object a = cmd1.ExecuteScalar();
                    int ID = Convert.ToInt32(a);
                    cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
                    if (ID != 0 && cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Remove successfully ", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return ID;
                    }
                    else
                    {
                        MessageBox.Show("wrong id ", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                connect.Close();
            }
            catch
            {
                MessageBox.Show("error", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return 0;
        }


        public bool UpdatetableStatus(int maban,int index)
        {
            
            SqlCommand command = new SqlCommand("UPDATE Ban SET	Trangthai=@Trangthai WHERE Maban=@Maban	", db.GetConnection);
            command.Parameters.Add("@Maban", SqlDbType.Int).Value = maban;
            if (index == 1)
            {
                command.Parameters.Add("@Trangthai", SqlDbType.NVarChar).Value = "Available";
            }
            else
            {
                command.Parameters.Add("@Trangthai", SqlDbType.NVarChar).Value = "UnAvailable";
            }
            db.openConection();
            if (command.ExecuteNonQuery() == 1)
            {
                db.closedConection();
                return true;
            }
            else
            {
                db.closedConection();
                return false;
            }

        }
    }
}
