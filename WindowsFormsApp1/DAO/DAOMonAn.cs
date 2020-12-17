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
	class DAOMonAn
	{
		MY_DB db = new MY_DB();
		public DataTable thongkemonan(string query,DateTime dau,DateTime sau,DateTime ngay, int thang)
		{
			SqlCommand command = new SqlCommand(
			"select ma.tenmonan,sum(ct.Soluong) as 'so luong' ,sum((m.gia*ct.Soluong)) as 'thanhtien' " +
			"from Chitiethoadon as ct, Hoadon as hd, Monan as ma, Monantheongay as m " +
			"where hd.Mahoadon = ct.Mahoadon and  m.ngay=convert(date,hd.Thoigian) " +
			"and m.Mamonan = ct.Mamonan and ma.Mamonan = m.Mamonan " +
			query+
			" group by ma.tenmonan", db.GetConnection);
			command.Parameters.Add("@ngay", SqlDbType.DateTime).Value = ngay.Date;
			command.Parameters.Add("@dau", SqlDbType.DateTime).Value = dau.Date;
			command.Parameters.Add("@sau", SqlDbType.DateTime).Value = sau.Date;
			command.Parameters.Add("@thang", SqlDbType.Int).Value = thang;
			//command.Parameters.Add("@nam", SqlDbType.Int).Value = DateTime.Now.Year;
			SqlDataAdapter adapter = new SqlDataAdapter(command);
			DataTable table = new DataTable();
			adapter.Fill(table);
			return table;
		}
		
		public DataTable getMonAn()
		{
			SqlCommand command = new SqlCommand("select * from monan ORDER BY mamonan", db.GetConnection);
			SqlDataAdapter adapter = new SqlDataAdapter(command);
			DataTable table = new DataTable();
			adapter.Fill(table);
			return table;
		}
		public DataTable getNguyenlieutheomonan(int mamonan)
		{
			SqlCommand command = new SqlCommand("select * from Congthuc where Mamonan=@ma", db.GetConnection);
			command.Parameters.Add("@ma", SqlDbType.Int).Value = mamonan;
			SqlDataAdapter adapter = new SqlDataAdapter(command);
			DataTable table = new DataTable();
			adapter.Fill(table);
			return table;
		}
		public bool updatect(DataTable ct,int mamonan)
		{
			SqlCommand insertCommand = new SqlCommand("themct", db.GetConnection);
			insertCommand.CommandType = CommandType.StoredProcedure;
			insertCommand.Parameters.Add("@mamonan", SqlDbType.Int).Value = mamonan;
			SqlParameter tvpParam = insertCommand.Parameters.AddWithValue("@bang", ct);
			tvpParam.SqlDbType = SqlDbType.Structured;
			db.openConection();
			// Execute the command.  
			
			if (insertCommand.ExecuteNonQuery() == 1)
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
		public bool xoact(DataTable ct,int mamonan)
		{
			string sqlInsert = "delete from Congthuc where Mamonan=@ma and Manl in (select ct.manl from @bang as ct) ";

			// Configure the command and parameter.  
			SqlCommand insertCommand = new SqlCommand(sqlInsert, db.GetConnection);
			insertCommand.Parameters.Add("@ma", SqlDbType.Int).Value = mamonan;
			SqlParameter tvpParam = insertCommand.Parameters.AddWithValue("@bang", ct);
			tvpParam.SqlDbType = SqlDbType.Structured;
			tvpParam.TypeName = "bang"; 
			db.openConection();
			// Execute the command.  

			if (insertCommand.ExecuteNonQuery() == 1)
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
		public bool themmonan(MonAn nl)
		{
			SqlCommand command = new SqlCommand("insert into Monan values (@ten)", db.GetConnection);
			//command.Parameters.Add("@ma", SqlDbType.Int).Value = nl.Mamonan;
			command.Parameters.Add("@ten", SqlDbType.NVarChar).Value = nl.Tenmonan;
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
		public bool suamonan(MonAn nl)
		{
			SqlCommand command = new SqlCommand("update Monan set tenmonan=@ten where Mamonan=@ma", db.GetConnection);
			command.Parameters.Add("@ma", SqlDbType.Int).Value = nl.Mamonan;
			command.Parameters.Add("@ten", SqlDbType.NVarChar).Value = nl.Tenmonan;
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
		public bool xoamonan(MonAn nl)
		{
			SqlCommand command = new SqlCommand("delete from Monan where Mamonan=@ma", db.GetConnection);
			command.Parameters.Add("@ma", SqlDbType.Int).Value = nl.Mamonan;
			command.Parameters.Add("@ten", SqlDbType.NVarChar).Value = nl.Tenmonan;
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
