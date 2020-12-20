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
			SqlCommand command = new SqlCommand("select * from getMonAntheongay()", db.GetConnection);
			SqlDataAdapter adapter = new SqlDataAdapter(command);
			DataTable table = new DataTable();
			adapter.Fill(table);
			return table;
		}
		public DataTable getMonAndeban()
		{
			SqlCommand command = new SqlCommand("select * from getMonAndeban()", db.GetConnection);
			SqlDataAdapter adapter = new SqlDataAdapter(command);
			DataTable table = new DataTable();
			adapter.Fill(table);
			return table;
		}
		public bool themMonAntheongay(MonAnTheoNgay ma)
		{
			SqlCommand command = new SqlCommand("execute themMonAntheongay @mamonan,@gia,@soluong", db.GetConnection);
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
			SqlCommand command = new SqlCommand("execute suaMonAntheongay  @mamonan,@gia,@soluong", db.GetConnection);
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
			SqlCommand command = new SqlCommand("execute xoaMonAntheongay @mamonan", db.GetConnection);
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
