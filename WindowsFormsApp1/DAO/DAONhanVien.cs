using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
		public NhanVien getNhanVienByID(int manv)
		{
			NhanVien nv = new NhanVien();
			SqlCommand command = new SqlCommand("select * from NhanVien where manv = @manv", mydb.GetConnection);
			command.Parameters.Add("");
			SqlDataAdapter adapter = new SqlDataAdapter(command);
			DataTable table = new DataTable();
			adapter.Fill(table);
			if(table.Rows.Count > 0)
			{
				nv.MaNv = int.Parse(table.Rows[0][0].ToString());
				nv.Hoten = table.Rows[0][1].ToString();
				nv.Sdt = table.Rows[0][2].ToString();
				nv.Ngaysinh = (DateTime)table.Rows[0][3];
				nv.Luong = (float)table.Rows[0][4];
				nv.MaNql = (int)table.Rows[0][5];

			}

			return nv;

		}
		public bool themNV(NhanVien vn)
		{
			SqlCommand command = new SqlCommand("insert into NhanVien values(@manv, @hoten, @sdt, @ngaysinh, @luong, @manql)", mydb.GetConnection);
			command.Parameters.Add("@manv", SqlDbType.Int).Value = nv.MaNv;
			command.Parameters.Add("@hoten", SqlDbType.NVarChar).Value = nv.Hoten;
			command.Parameters.Add("@sdt", SqlDbType.NVarChar).Value = nv.Sdt;
			command.Parameters.Add("@ngaysinh", SqlDbType.Date).Value = nv.Ngaysinh.Date;
			command.Parameters.Add("@luong", SqlDbType.Float).Value = nv.Luong;
			command.Parameters.Add("@manql", SqlDbType.Int).Value = nv.MaNql;
			mydb.openConection();
			if(command.ExecuteNonQuery() == 1)
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
		public bool suaNV(NhanVien vn)
		{
			SqlCommand command = new SqlCommand("update NhanVien set hoten = @hoten, sdt = @sdt, ngaysinh = @ngaysinh, luong = @luong, manql = @manql where manv = @manv", mydb.GetConnection);
			command.Parameters.Add("@manv", SqlDbType.Int).Value = nv.MaNv;
			command.Parameters.Add("@hoten", SqlDbType.NVarChar).Value = nv.Hoten;
			command.Parameters.Add("@sdt", SqlDbType.NVarChar).Value = nv.Sdt;
			command.Parameters.Add("@ngaysinh", SqlDbType.Date).Value = nv.Ngaysinh.Date;
			command.Parameters.Add("@luong", SqlDbType.Float).Value = nv.Luong;
			command.Parameters.Add("@manql", SqlDbType.Int).Value = nv.MaNql;
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
