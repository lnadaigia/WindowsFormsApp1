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
	class DAOHoaDon
	{
		MY_DB db = new MY_DB();
		HoaDon hd = new HoaDon();
		public DataTable getHoaDon() {
			SqlCommand command = new SqlCommand("select * from hoadon", db.GetConnection);
			SqlDataAdapter adapter = new SqlDataAdapter(command);
			DataTable table = new DataTable();
			adapter.Fill(table);
			return table;
		}
	}
}
