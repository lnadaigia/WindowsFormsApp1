using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DAO
{
	class DAOChiTietHoaDon
	{
		MY_DB db = new MY_DB();
		public DataTable getChiTietHoaDon(int mahoadon)
		{
			
			SqlCommand command = new SqlCommand("select ct.Mahoadon,ct.Mamonan,ma.tenmonan,ct.Soluong ,m.gia,(m.gia*ct.Soluong) as 'thanhtien' " +
				"from Chitiethoadon as ct, Hoadon as hd, Monan as ma, Monantheongay as m " +
				"where hd.Mahoadon = ct.Mahoadon and CONVERT(date, hd.Thoigian) = m.ngay " +
				"and m.Mamonan = ct.Mamonan and ma.Mamonan = m.Mamonan and hd.Mahoadon = @mahd", db.GetConnection);
			command.Parameters.Add("@mahd", SqlDbType.Int).Value = mahoadon;
			SqlDataAdapter adapter = new SqlDataAdapter(command);
			DataTable table = new DataTable();
			adapter.Fill(table);
			return table;
		}
		
	}
}
