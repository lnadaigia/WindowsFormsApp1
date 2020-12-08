using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DAO
{
	class DAONguyenLieu
	{
		MY_DB db = new MY_DB();
		public DataTable getNguyenLieu()
		{
			SqlCommand command = new SqlCommand("select * from nguyenlieu", db.GetConnection);
			SqlDataAdapter adapter = new SqlDataAdapter(command);
			DataTable table = new DataTable();
			adapter.Fill(table);
			return table;
		}
		public DataTable getNguyenLieutheongay()
		{
			SqlCommand command = new SqlCommand("select NguyenLieu.tenNL,isnull(m.gia,0) as 'gia',isnull(m.tongsoluong,0) as 'soluong' from NguyenLieu  left join Nguyenlieutheongay as m on m.Manl=NguyenLieu.Manl and ngay=convert(date,getdate())", db.GetConnection);
			SqlDataAdapter adapter = new SqlDataAdapter(command);
			DataTable table = new DataTable();
			adapter.Fill(table);
			return table;
		}
	}
}
