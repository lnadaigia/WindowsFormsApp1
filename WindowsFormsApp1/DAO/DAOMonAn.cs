﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DAO
{
	class DAOMonAn
	{
		MY_DB db = new MY_DB();
		public DataTable getMonAn()
		{
			SqlCommand command = new SqlCommand("select * from monan", db.GetConnection);
			SqlDataAdapter adapter = new SqlDataAdapter(command);
			DataTable table = new DataTable();
			adapter.Fill(table);
			return table;
		}
	}
}