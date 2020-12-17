using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class MY_DB
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-18TCVFK\SQLEXPRESS;Initial Catalog=DBMS;Integrated Security=True");
        public SqlConnection GetConnection
        {
            get { return con; }
        }

        public void openConection()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }
        public void closedConection()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

    }
}
