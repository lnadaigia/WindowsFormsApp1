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



	}
}
