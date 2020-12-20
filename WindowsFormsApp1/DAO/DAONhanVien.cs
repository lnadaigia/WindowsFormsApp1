using GlobalVariables;
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
    class DAONhanVien
    {
        MY_DB mydb = new MY_DB();
        NhanVien nv = new NhanVien();
        public DataTable getNhanVien()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM getNhanVien", mydb.GetConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable getNhanVienDeChiaCa()
        {
            SqlCommand command = new SqlCommand("  SELECT* FROM GetNhanVienDeChiaCa", mydb.GetConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public NhanVien getNhanVienByID(int manv)
        {
            NhanVien nv = new NhanVien();
            SqlCommand command = new SqlCommand("EXEC SelectAllCustomers @manv = @manv;", mydb.GetConnection);
            command.Parameters.Add("@manv", SqlDbType.Int).Value = manv;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                nv.MaNv = int.Parse(table.Rows[0][0].ToString());
                nv.Hoten = table.Rows[0][1].ToString();
                nv.Sdt = table.Rows[0][2].ToString();
                nv.Ngaysinh = (DateTime)table.Rows[0][3];
                nv.Luong = float.Parse(table.Rows[0][4].ToString());
                if (table.Rows[0][5].ToString() == "")
                {
                    nv.MaNql = 0;
                }
                else
                {
                    nv.MaNql = int.Parse(table.Rows[0][5].ToString());
                }
                nv.Username = table.Rows[0][6].ToString();
                nv.Password = table.Rows[0][7].ToString();
                nv.Role = table.Rows[0][8].ToString();
            }
            return nv;
        }
       
        public DataTable GetNhanVienBySearch(NhanVien nv)
        {
            //List<NhanVien> nvDungList = new List<NhanVien>();
            //NhanVien nv = new NhanVien();
            SqlCommand command = new SqlCommand("EXEC GetNhanVienBySearch @hoten = @hoten,@username=@username", mydb.GetConnection);
            command.Parameters.Add("@hoten", SqlDbType.NVarChar).Value = nv.Hoten;
            command.Parameters.Add("@username", SqlDbType.NVarChar).Value = nv.Username;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable GetNhanVienByID(int manv)
        {
            NhanVien nv = new NhanVien();
            SqlCommand command = new SqlCommand("EXEC GetNhanVienByID @manv = @manv;", mydb.GetConnection);
            command.Parameters.Add("@manv", SqlDbType.Int).Value = manv;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool themNV(NhanVien nv)
        {
            SqlCommand command = new SqlCommand("EXEC themNV @hoten = @hoten,@username=@username,@sdt=@sdt" +
                ",@ngaysinh=@ngaysinh,@luong=@luong,@password=@password,@MaNQL=@MaNQL,@Role=@Role", mydb.GetConnection);
            command.Parameters.Add("@hoten", SqlDbType.NVarChar).Value = nv.Hoten;
            command.Parameters.Add("@sdt", SqlDbType.NVarChar).Value = nv.Sdt;
            command.Parameters.Add("@ngaysinh", SqlDbType.Date).Value = nv.Ngaysinh;
            command.Parameters.Add("@luong", SqlDbType.Float).Value = nv.Luong;
            command.Parameters.Add("@username", SqlDbType.NVarChar).Value = nv.Username;
            command.Parameters.Add("@password", SqlDbType.NVarChar).Value = nv.Password;
            command.Parameters.Add("@MaNQL", SqlDbType.Int).Value = nv.MaNql;
            command.Parameters.Add("@Role", SqlDbType.NVarChar).Value = nv.Role;
            mydb.openConection();
            if (command.ExecuteNonQuery() == 1)
            {
                mydb.closedConection();
                return true;
            }
            else
            {
                mydb.closedConection();
                return false;
            }

        }
        public bool suaNV(NhanVien nv)
        {
            //SqlCommand command = new SqlCommand("update NhanVien set hoten = @hoten, sdt = @sdt, ngaysinh = @ngaysinh, luong = @luong, manql = @manql where manv = @manv", mydb.GetConnection);
            SqlCommand command = new SqlCommand("EXEC suaNV @hoten = @hoten,@username=@username,@sdt=@sdt,@ngaysinh=@ngaysinh" +
                ",@luong=@luong,@password=@password,@MaNQL=@MaNQL,@manv=@manv", mydb.GetConnection);
            command.Parameters.Add("@manv", SqlDbType.Int).Value = nv.MaNv;
            command.Parameters.Add("@hoten", SqlDbType.NVarChar).Value = nv.Hoten;
            command.Parameters.Add("@sdt", SqlDbType.NVarChar).Value = nv.Sdt;
            command.Parameters.Add("@ngaysinh", SqlDbType.Date).Value = nv.Ngaysinh;
            command.Parameters.Add("@luong", SqlDbType.Float).Value = nv.Luong;
            command.Parameters.Add("@username", SqlDbType.NVarChar).Value = nv.Username;
            command.Parameters.Add("@password", SqlDbType.NVarChar).Value = nv.Password;
            command.Parameters.Add("@manql", SqlDbType.Int).Value = Globals.NV;
            mydb.openConection();
            if (command.ExecuteNonQuery() == 1)
            {
                mydb.closedConection();
                return true;
            }
            else
            {
                mydb.closedConection();
                return false;
            }
        }
        public bool SuaNVkhongmk(NhanVien nv)
        {
            SqlCommand command = new SqlCommand("EXEC SuaNVkhongmk @hoten = @hoten,@username=@username,@sdt=@sdt," +
                "@ngaysinh=@ngaysinh,@luong=@luong,@manv=@manv", mydb.GetConnection);
            command.Parameters.Add("@manv", SqlDbType.Int).Value = nv.MaNv;
            command.Parameters.Add("@hoten", SqlDbType.NVarChar).Value = nv.Hoten;
            command.Parameters.Add("@sdt", SqlDbType.NVarChar).Value = nv.Sdt;
            command.Parameters.Add("@ngaysinh", SqlDbType.Date).Value = nv.Ngaysinh;
            command.Parameters.Add("@luong", SqlDbType.Float).Value = nv.Luong;
            command.Parameters.Add("@username", SqlDbType.NVarChar).Value = nv.Username;
            //command.Parameters.Add("@password", SqlDbType.NVarChar).Value = nv.Password;
            //command.Parameters.Add("@manql", SqlDbType.Int).Value = nv.MaNql;
            mydb.openConection();
            if (command.ExecuteNonQuery() == 1)
            {
                mydb.closedConection();
                return true;
            }
            else
            {
                mydb.closedConection();
                return false;
            }
        }
        public bool xoaNV(int manv)
        {
            SqlCommand command = new SqlCommand("EXEC xoaNV @manv=@manv", mydb.GetConnection);
            command.Parameters.Add("@manv", SqlDbType.Int).Value = manv;

            mydb.openConection();
            if (command.ExecuteNonQuery() == 1)
            {
                mydb.closedConection();
                return true;
            }
            else
            {
                mydb.closedConection();
                return false;
            }
        }
    }
}
