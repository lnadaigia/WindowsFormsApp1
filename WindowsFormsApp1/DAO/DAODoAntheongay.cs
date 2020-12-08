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
    class DAODoAntheongay
    {
		MY_DB db = new MY_DB();
		public DataTable getMonAntheongay()
		{
			SqlCommand command = new SqlCommand("select monan.*,isnull(m.gia,0) as 'gia',isnull(m.tongsoluong,0) as 'soluong' from monan  left join Monantheongay as m on m.Mamonan=Monan.Mamonan and ngay=convert(date,getdate())", db.GetConnection);
			SqlDataAdapter adapter = new SqlDataAdapter(command);
			DataTable table = new DataTable();
			adapter.Fill(table);
			return table;
		}
		public DataTable getMonAndeban()
		{
			SqlCommand command = new SqlCommand("select m.Mamonan,m.gia,m.tongsoluong,(m.tongsoluong-isnull(ham.soluong_daban,0)) as 'soluong_con',0 as 'soluong'  " +
				"from Monantheongay as m " +
				"left join dsmonan() as ham " +
				"on m.Mamonan=ham.Mamonan where m.ngay=convert(date,getdate())", db.GetConnection);
			SqlDataAdapter adapter = new SqlDataAdapter(command);
			DataTable table = new DataTable();
			adapter.Fill(table);
			return table;
		}
		public bool themMonAntheongay(MonAnTheoNgay ma)
		{
			SqlCommand command = new SqlCommand("insert into Monantheongay values(CONVERT(date,getdate()),@mamonan,@gia,@soluong)", db.GetConnection);
			command.Parameters.Add("@mamonan", SqlDbType.Int).Value = ma.Mamonan;
			command.Parameters.Add("@gia", SqlDbType.Float).Value = ma.Gia;
			command.Parameters.Add("@soluong", SqlDbType.Int).Value = ma.Soluong;
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
		public bool suaMonAntheongay(MonAnTheoNgay ma)
		{
			SqlCommand command = new SqlCommand("update Monantheongay  set tongsoluong=@soluong,gia=@gia where Mamonan=@mamonan and ngay=CONVERT(date,getdate())", db.GetConnection);
			command.Parameters.Add("@mamonan", SqlDbType.Int).Value = ma.Mamonan;
			command.Parameters.Add("@gia", SqlDbType.Float).Value = ma.Gia;
			command.Parameters.Add("@soluong", SqlDbType.Int).Value = ma.Soluong;
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
		public bool xoaMonAntheongay(MonAnTheoNgay ma)
		{
			SqlCommand command = new SqlCommand("delete from Monantheongay where Mamonan=@mamonan and ngay=CONVERT(date,getdate())", db.GetConnection);
			command.Parameters.Add("@mamonan", SqlDbType.Int).Value = ma.Mamonan;
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
