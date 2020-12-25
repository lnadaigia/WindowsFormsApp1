using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DAO
{
	class DAOCa
	{

		MY_DB db = new MY_DB();
		public DataTable getDanhSachCa()
		{
			SqlCommand command = new SqlCommand("SELECT * FROM getDanhSachCa", db.GetConnection);
			SqlDataAdapter adapter = new SqlDataAdapter(command);
			DataTable table = new DataTable();
			adapter.Fill(table);
			return table;
		}
		public DataTable getDanhSachCaDeChiaCa()
		{
			SqlCommand command = new SqlCommand(" select * from getDanhSachCaDeChiaCa", db.GetConnection);
			SqlDataAdapter adapter = new SqlDataAdapter(command);
			DataTable table = new DataTable();
			adapter.Fill(table);
			return table;
		}
		public DataTable getDanhSachCaChoNV(int manv)
		{
			SqlCommand command = new SqlCommand("select * FROM getDanhSachCaChoNV(@manv)", db.GetConnection);
			SqlDataAdapter adapter = new SqlDataAdapter(command);
			command.Parameters.Add("@manv", SqlDbType.Int).Value = manv;
			DataTable table = new DataTable();
			adapter.Fill(table);
			return table;
		}
		public DataTable getDanhSachNhanVienVaCa()
		{
			SqlCommand command = new SqlCommand("SELECT * FROM getDanhSachNhanVienVaCa(@gio)", db.GetConnection);
			SqlDataAdapter adapter = new SqlDataAdapter(command);
			
			command.Parameters.Add("@gio", SqlDbType.Time).Value = TimeSpan.Parse (DateTime.Now.ToString("HH:mm:ss"));
			DataTable table = new DataTable();
			adapter.Fill(table);
			return table;
		}

		public DataTable getDanhSachCaTheoNV(int manv)
		{
			SqlCommand command = new SqlCommand("SELECT * FROM getDanhSachCaTheoNV(@MaNV)", db.GetConnection);
			SqlDataAdapter adapter = new SqlDataAdapter(command);
			command.Parameters.Add("@MaNV", SqlDbType.Int).Value = manv;
			DataTable table = new DataTable();
			adapter.Fill(table);
			return table;
		}

		public DataTable getDanhSachCaTheoNVVaTheoNgay(int manv,DateTime a)
		{
			SqlCommand command = new SqlCommand("select * from getDanhSachCaTheoNVVaTheoNgay (@MaNV,@date)", db.GetConnection);
			SqlDataAdapter adapter = new SqlDataAdapter(command);
			command.Parameters.Add("@MaNV", SqlDbType.Int).Value = manv;
			command.Parameters.Add("@date", SqlDbType.DateTime).Value = a;
			DataTable table = new DataTable();
			adapter.Fill(table);
			return table;
		}
		public DataTable getDanhSachCaTheoNVVaTheoKhoang(int manv, DateTime a,DateTime b)
		{
			SqlCommand command = new SqlCommand("select * from getDanhSachCaTheoNVVaTheoKhoang (@MaNV,@dateT,@dateS)", db.GetConnection);
			SqlDataAdapter adapter = new SqlDataAdapter(command);
			command.Parameters.Add("@MaNV", SqlDbType.Int).Value = manv;
			command.Parameters.Add("@dateT", SqlDbType.DateTime).Value = a;
			command.Parameters.Add("@dateS", SqlDbType.DateTime).Value = b;
			DataTable table = new DataTable();
			adapter.Fill(table);
			return table;
		}
	}
}
