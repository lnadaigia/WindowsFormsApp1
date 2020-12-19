using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DAO
{
	class DAOChiaca
	{
		MY_DB db = new MY_DB();
		public DataTable getDanhSachChiaCaFrmChiaCa()
		{
			SqlCommand command = new SqlCommand("SELECT NhanVien.MaNV,Hoten,Ngaysinh,SoDT,Tenca,ngay,ChiaCa.Maca FROM ChiaCa,NhanVien,Ca WHERE ChiaCa.MaNV=NhanVIen.MaNV AND ChiaCa.Maca=Ca.Maca", db.GetConnection);
			SqlDataAdapter adapter = new SqlDataAdapter(command);
			DataTable table = new DataTable();
			adapter.Fill(table);
			return table;
		}
		public DataTable getDanhSachChiaCa()
		{
			SqlCommand command = new SqlCommand("SELECT NhanVien.MaNV,Hoten,Ngaysinh,SoDT,Tenca,ngay FROM ChiaCa,NhanVien,Ca WHERE ChiaCa.MaNV=NhanVIen.MaNV AND ChiaCa.Maca=Ca.Maca", db.GetConnection);
			SqlDataAdapter adapter = new SqlDataAdapter(command);
			DataTable table = new DataTable();
			adapter.Fill(table);
			return table;
		}
		public DataTable getDanhSachChiaCaTheoNgay(DateTime a)
		{
			SqlCommand command = new SqlCommand("SELECT NhanVien.MaNV,Hoten,Ngaysinh,SoDT,Tenca,ngay FROM ChiaCa,NhanVien,Ca WHERE ChiaCa.MaNV=NhanVIen.MaNV AND ChiaCa.Maca=Ca.Maca  AND ChiaCa.ngay=@ngay", db.GetConnection);
			SqlDataAdapter adapter = new SqlDataAdapter(command);
			command.Parameters.Add("@ngay", SqlDbType.Date).Value = a;
			DataTable table = new DataTable();
			adapter.Fill(table);
			return table;
		}
		public DataTable getDanhSachChiaCaTheoKhoang(DateTime a, DateTime b)
		{
			SqlCommand command = new SqlCommand("SELECT NhanVien.MaNV,Hoten,Ngaysinh,SoDT,Tenca,ngay FROM ChiaCa,NhanVien,Ca WHERE ChiaCa.MaNV=NhanVIen.MaNV AND ChiaCa.Maca=Ca.Maca  AND ChiaCa.ngay BETWEEN @ngaybatdau AND  @ngayketthuc", db.GetConnection);
			SqlDataAdapter adapter = new SqlDataAdapter(command);
			command.Parameters.Add("@ngaybatdau", SqlDbType.Date).Value = a;
			command.Parameters.Add("@ngayketthuc", SqlDbType.Date).Value = b;
			DataTable table = new DataTable();
			adapter.Fill(table);
			return table;
		}

		public DataTable Search(string a)
		{
			SqlCommand command = new SqlCommand("SELECT NhanVien.MaNV, Hoten, Ngaysinh, SoDT, Tenca, ngay FROM ChiaCa, NhanVien, Ca WHERE ChiaCa.MaNV= NhanVIen.MaNV AND ChiaCa.Maca= Ca.Maca AND CONCAT(NhanVien.MaNV, Hoten, Ngaysinh, SoDT, Tenca) like '%" + a + "%'", db.GetConnection);
			SqlDataAdapter adapter = new SqlDataAdapter(command);
			DataTable table = new DataTable();
			adapter.Fill(table);
			return table;
		}


		public bool ThemVaoChiaCa(int manv,int maca, DateTime a)
		{
			SqlCommand command = new SqlCommand(" INSERT INTO ChiaCa(Manv,Maca,ngay)VALUES (@manv,@maca,CONVERT(date,@date))", db.GetConnection);
			command.Parameters.Add("@manv", SqlDbType.Int).Value = manv;
			command.Parameters.Add("@maca", SqlDbType.Int).Value = maca;
			command.Parameters.Add("@date", SqlDbType.DateTime).Value = a;
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

		public bool xoaChiaCa(int manv,int maca,DateTime ngay)
		{
			string sqlInsert = "DELETE FROM ChiaCa WHERE Manv=@Manv AND Maca=@Maca ANd ngay=CONVERT(date,@ngay) ";

			// Configure the command and parameter.  
			SqlCommand command = new SqlCommand(sqlInsert, db.GetConnection);
			command.Parameters.Add("@Manv", SqlDbType.Int).Value = manv;
			command.Parameters.Add("@Maca", SqlDbType.Int).Value = maca;
			command.Parameters.Add("@ngay", SqlDbType.DateTime).Value = ngay;
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
		public bool SuaChiaCa(int manv, DateTime ngay)
		{
			string sqlInsert = "UPDATE ChiaCa SET ngay=CONVERT(date,@ngay) WHERE Manv=@manv";

			// Configure the command and parameter.  
			SqlCommand command = new SqlCommand(sqlInsert, db.GetConnection);
			command.Parameters.Add("@Manv", SqlDbType.Int).Value = manv;
			command.Parameters.Add("@ngay", SqlDbType.DateTime).Value = ngay;
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
