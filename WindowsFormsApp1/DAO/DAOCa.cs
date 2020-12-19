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
			SqlCommand command = new SqlCommand("select * FROM Ca", db.GetConnection);
			SqlDataAdapter adapter = new SqlDataAdapter(command);
			DataTable table = new DataTable();
			adapter.Fill(table);
			return table;
		}
		public DataTable getDanhSachCaDeChiaCa()
		{
			SqlCommand command = new SqlCommand(" SELECT Maca,Tenca,GioBatDau,GioKetThuc FROM Ca", db.GetConnection);
			SqlDataAdapter adapter = new SqlDataAdapter(command);
			DataTable table = new DataTable();
			adapter.Fill(table);
			return table;
		}
		public DataTable getDanhSachCaChoNV(int manv)
		{
			SqlCommand command = new SqlCommand("SELECT Ca.Tenca, Ca.GioBatDau,Ca.GioKetThuc FROM Ca,ChiaCa,NhanVien WHERE Ca.Maca=ChiaCa.Maca AND ChiaCa.Manv=NhanVien.MaNV  AND NhanVien.MaNV=@manv AND ChiaCa.ngay=CONVERT(Date,getdate())", db.GetConnection);
			SqlDataAdapter adapter = new SqlDataAdapter(command);
			command.Parameters.Add("@manv", SqlDbType.Int).Value = manv;
			DataTable table = new DataTable();
			adapter.Fill(table);
			return table;
		}
		public DataTable getDanhSachNhanVienVaCa()
		{
			SqlCommand command = new SqlCommand("SELECT ChiaCa.*,Ca.Tenca,NhanVien.Hoten,NhanVien.SoDT,Ca.GioBatDau,Ca.GioKetThuc FROM ChiaCa,Ca,NhanVien where Ca.Maca=ChiaCa.Maca AND NhanVien.MaNV=ChiaCa.Manv AND ChiaCa.ngay = CONVERT(date, getdate()) AND CA.Maca in (SELECT Maca FROM Ca WHERE CONVERT(time, @gio) BETWEEN Ca.GioBatDau AND Ca.GioKetThuc)", db.GetConnection);
			SqlDataAdapter adapter = new SqlDataAdapter(command);
			command.Parameters.Add("@gio", SqlDbType.Time).Value = TimeSpan.Parse (DateTime.Now.ToString("HH:mm:ss"));
			DataTable table = new DataTable();
			adapter.Fill(table);
			return table;
		}

		public DataTable getDanhSachCaTheoNV(int manv)
		{
			SqlCommand command = new SqlCommand("SELECT ChiaCa.ngay,Ca.* FROM ChiaCa,Ca WHERE ChiaCa.Maca= Ca.Maca AND Manv=@MaNV", db.GetConnection);
			SqlDataAdapter adapter = new SqlDataAdapter(command);
			command.Parameters.Add("@MaNV", SqlDbType.Int).Value = manv;
			DataTable table = new DataTable();
			adapter.Fill(table);
			return table;
		}

		public DataTable getDanhSachCaTheoNVVaTheoNgay(int manv,DateTime a)
		{
			SqlCommand command = new SqlCommand("SELECT ChiaCa.ngay,Ca.* FROM ChiaCa,Ca WHERE ChiaCa.Maca= Ca.Maca AND Manv=@MaNV AND ChiaCa.ngay=CONVERT(date,@date)", db.GetConnection);
			SqlDataAdapter adapter = new SqlDataAdapter(command);
			command.Parameters.Add("@MaNV", SqlDbType.Int).Value = manv;
			command.Parameters.Add("@date", SqlDbType.DateTime).Value = a;
			DataTable table = new DataTable();
			adapter.Fill(table);
			return table;
		}
		public DataTable getDanhSachCaTheoNVVaTheoKhoang(int manv, DateTime a,DateTime b)
		{
			SqlCommand command = new SqlCommand("SELECT ChiaCa.ngay,Ca.* FROM ChiaCa,Ca WHERE ChiaCa.Maca= Ca.Maca AND Manv=@MaNV AND ChiaCa.ngay BETWEEN CONVERT(date,@dateT) AND CONVERT(date,@dateS) ", db.GetConnection);
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
