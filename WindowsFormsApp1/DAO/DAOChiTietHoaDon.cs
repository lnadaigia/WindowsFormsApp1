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
	class DAOChiTietHoaDon
	{
		MY_DB db = new MY_DB();
		public DataTable getChiTietHoaDon(int mahoadon)
		{
			
			SqlCommand command = new SqlCommand("select ct.* ,m.gia,ma.tenmonan from Chitiethoadon as ct, Hoadon as hd, Monan as ma, Monantheongay as m where hd.Mahoadon = ct.Mahoadon and m.Mamonan = ct.Mamonan and ma.Mamonan = m.Mamonan and hd.mahoadon=@mahd", db.GetConnection);
			command.Parameters.Add("@mahd", SqlDbType.Int).Value = mahoadon;
			SqlDataAdapter adapter = new SqlDataAdapter(command);
			DataTable table = new DataTable();
			adapter.Fill(table);
			return table;
		}

		public bool Themvaochitiethoadon(ChiTietHoaDon hd)
		{
			SqlCommand command = new SqlCommand(" EXEC themdonhang @mahoadon=@ma,@mamonan=@mamon,@soluong=@sl", db.GetConnection);
			command.Parameters.Add("@ma", SqlDbType.Int).Value = hd.Mahoadon;
			command.Parameters.Add("@mamon", SqlDbType.Int).Value = hd.Mamonan;
			command.Parameters.Add("@sl", SqlDbType.Int).Value = hd.Soluong;
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
