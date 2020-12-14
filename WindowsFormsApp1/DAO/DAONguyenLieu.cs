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
	class DAONguyenLieu
	{
		MY_DB db = new MY_DB();
		public DataTable getNguyenLieu()
		{
			SqlCommand command = new SqlCommand("select * from nguyenlieu ORDER BY manl", db.GetConnection);
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
		public bool themnl(NguyenLieu nl)
		{
			SqlCommand command = new SqlCommand("insert into NguyenLieu values (@ten)", db.GetConnection);
			//command.Parameters.Add("@ma", SqlDbType.Int).Value = nl.Manguyenlieu;
			command.Parameters.Add("@ten", SqlDbType.NVarChar).Value = nl.Tennguyenlieu;
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
		public bool suanl(NguyenLieu nl)
		{
			SqlCommand command = new SqlCommand("update NguyenLieu set tenNL=@ten where Manl=@ma", db.GetConnection);
			command.Parameters.Add("@ma", SqlDbType.Int).Value = nl.Manguyenlieu;
			command.Parameters.Add("@ten", SqlDbType.NVarChar).Value = nl.Tennguyenlieu;
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
		public bool xoanl(NguyenLieu nl)
		{
			SqlCommand command = new SqlCommand("delete from NguyenLieu where Manl=@ma", db.GetConnection);
			command.Parameters.Add("@ma", SqlDbType.NVarChar).Value = nl.Manguyenlieu;
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
