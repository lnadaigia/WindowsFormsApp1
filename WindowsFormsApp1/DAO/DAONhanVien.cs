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
            SqlCommand command = new SqlCommand("select * from NhanVien", mydb.GetConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable getNhanVienDeChiaCa()
        {
            SqlCommand command = new SqlCommand("  SELECT MaNV,Hoten,SoDT,Ngaysinh FROM NhanVien where Role='employee'", mydb.GetConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public NhanVien getNhanVienByID(int manv)
        {
            NhanVien nv = new NhanVien();
            SqlCommand command = new SqlCommand("select * from NhanVien where manv = @manv", mydb.GetConnection);
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
        //public List<NhanVien> LoadNV()
        //{
        //    List<NhanVien> nvList = new List<NhanVien>();
        //    try
        //    {
        //        DataTable ds = getNhanVien();
        //        foreach (DataRow item in ds.Rows)
        //        {
        //                NhanVien NV = new NhanVien();
        //                NV.MaNv = int.Parse(ds.Rows[0][0].ToString());
        //                NV.Hoten = ds.Rows[0][1].ToString();
        //                NV.Sdt = ds.Rows[0][2].ToString();
        //                NV.Ngaysinh = (DateTime)ds.Rows[0][3];
        //                NV.Luong = float.Parse(ds.Rows[0][4].ToString());
        //                NV.MaNql = int.Parse(ds.Rows[0][5].ToString());
        //                NV.Username = ds.Rows[0][6].ToString();
        //                NV.Password = ds.Rows[0][7].ToString();
        //                NV.Role= ds.Rows[0][8].ToString();
        //                nvList.Add(NV);
        //        }
        //        return nvList;
        //    }
        //    catch
        //    {
        //        MessageBox.Show("error happened", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    }
        //    return nvList;
        //}
        public DataTable GetNhanVienBySearch(NhanVien nv)
        {
            //List<NhanVien> nvDungList = new List<NhanVien>();
            //NhanVien nv = new NhanVien();
            SqlCommand command = new SqlCommand("select * from NhanVien where Hoten like @hoten or UserName like @username", mydb.GetConnection);
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
            SqlCommand command = new SqlCommand("select * from NhanVien where manv = @manv", mydb.GetConnection);
            command.Parameters.Add("@manv", SqlDbType.Int).Value = manv;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool themNV(NhanVien nv)
        {
            SqlCommand command = new SqlCommand("insert into NhanVien (hoten,SoDT,ngaysinh,luong,UserName,Password,MaNQL,Role) values( @hoten, @sdt, @ngaysinh, @luong,@username,@password,@MaNQL,@Role)", mydb.GetConnection);
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
            SqlCommand command = new SqlCommand("update NhanVien set hoten = @hoten, SoDT = @sdt, ngaysinh = @ngaysinh, luong = @luong,UserName = @username,Password = @password where manv = @manv", mydb.GetConnection);
            command.Parameters.Add("@manv", SqlDbType.Int).Value = nv.MaNv;
            command.Parameters.Add("@hoten", SqlDbType.NVarChar).Value = nv.Hoten;
            command.Parameters.Add("@sdt", SqlDbType.NVarChar).Value = nv.Sdt;
            command.Parameters.Add("@ngaysinh", SqlDbType.Date).Value = nv.Ngaysinh;
            command.Parameters.Add("@luong", SqlDbType.Float).Value = nv.Luong;
            command.Parameters.Add("@username", SqlDbType.NVarChar).Value = nv.Username;
            command.Parameters.Add("@password", SqlDbType.NVarChar).Value = nv.Password;
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
        public bool SuaNVkhongmk(NhanVien nv)
        {
            SqlCommand command = new SqlCommand("update NhanVien set hoten = @hoten, SoDT = @sdt, ngaysinh = @ngaysinh, luong = @luong,UserName = @username where manv = @manv", mydb.GetConnection);
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
            SqlCommand command = new SqlCommand("delete NhanVien where manv = @manv", mydb.GetConnection);
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
