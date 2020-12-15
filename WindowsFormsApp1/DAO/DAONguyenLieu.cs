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
			SqlCommand command = new SqlCommand("select nguyenlieu.manl,NguyenLieu.tenNL,isnull(m.gia,0) as 'gia',isnull(m.tongsoluong,0) as 'soluong' from NguyenLieu  left join Nguyenlieutheongay as m on m.Manl=NguyenLieu.Manl and ngay=convert(date,getdate()) ORDER BY nguyenlieu.manl", db.GetConnection);
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
		public float gettonggia()
        {
			SqlCommand command = new SqlCommand("select sum(ISNULL(gia,0)*tongsoluong) from Nguyenlieutheongay where ngay=convert(date,getdate())", db.GetConnection);
			SqlDataAdapter adapter = new SqlDataAdapter(command);
			DataTable table = new DataTable();
			adapter.Fill(table);
			if (table.Rows.Count > 0)
				return float.Parse(table.Rows[0][0].ToString());
			return 0;
		}
		public bool updategia_nguyenlieu(DataTable ct)
		{
			bool t = false;
			db.openConection();
			SqlTransaction objTrans = db.GetConnection.BeginTransaction();
			SqlCommand command = new SqlCommand("update Nguyenlieutheongay set gia=@gia where ngay=convert(date,getdate()) and manl=@manl", db.GetConnection, objTrans);
			command.Parameters.Add("@gia", SqlDbType.Float);
			command.Parameters.Add("@manl", SqlDbType.Int);
			

			try
			{
				
				foreach (DataRow row in ct.Rows)
				{

					command.Parameters[0].Value = float.Parse(row[1].ToString());
					command.Parameters[1].Value = (int)row[0];

					command.ExecuteNonQuery();
				}
				objTrans.Commit();
				t = true;
			}
			catch (Exception)
			{
				objTrans.Rollback();
				
			}
			finally
			{
				db.closedConection();
			}
			return t;

		}

	}
}
