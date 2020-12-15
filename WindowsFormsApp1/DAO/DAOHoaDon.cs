using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
		public int getTongbill(int mahoadon)
		{
			SqlCommand command = new SqlCommand("  SELECT Tongbill FROM Hoadon WHere Mahoadon=@mahoadon", db.GetConnection);
			command.Parameters.Add("@mahoadon", SqlDbType.Int).Value = mahoadon;
			SqlDataAdapter adapter = new SqlDataAdapter(command);
			db.openConection();

			object a = command.ExecuteScalar();
			int b = int.Parse(a.ToString());
			if (b != 0)
			{
				db.closedConection();
				return b;
			}
			else
			{
				db.closedConection();
				return 0;
			}
		}
		public int getCurrentMahoadon(int maban)
		{
			SqlCommand command = new SqlCommand(" SELECT Mahoadon FROM Hoadon WHERE Maban=@MaBan AND Thoigian=CONVERT(date,GETDATE()) AND Trangthai=0", db.GetConnection);
			command.Parameters.Add("@Maban", SqlDbType.Int).Value = maban;
			SqlDataAdapter adapter = new SqlDataAdapter(command);
			db.openConection();
			
			object a = command.ExecuteScalar();
			int b= int.Parse(a.ToString());		
            if (b != 0)
            {
                db.closedConection();
                return b;
            }
            else
            {
                db.closedConection();
                return 0;
            }
		}
		public bool DatHang(HoaDon hd)
		{
			SqlCommand command = new SqlCommand("insert into Hoadon (Maban,Thoigian,Tongbill,Manv,mavoucher,Trangthai) values(@Maban,@Thoigian,@Tongbill,@Manv,@mavoucher,@Trangthai)", db.GetConnection);
			command.Parameters.Add("@Maban", SqlDbType.Int).Value = hd.Maban;
			command.Parameters.Add("@Thoigian", SqlDbType.DateTime).Value = hd.Thoigian;
			command.Parameters.Add("@Tongbill", SqlDbType.Float).Value = hd.Tongbill;
			command.Parameters.Add("@Manv", SqlDbType.Int).Value = hd.Manv;
			command.Parameters.Add("@mavoucher", SqlDbType.Int).Value = hd.Mavoucher;
			command.Parameters.Add("@Trangthai", SqlDbType.Bit).Value = hd.Trangthai;
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
		public bool ThanhToan(int mahoadon)
        {

			SqlCommand command = new SqlCommand("UPDATE HoaDon SET	Trangthai=1 WHERE Mahoadon=@Mahoadon	", db.GetConnection);
			command.Parameters.Add("@Mahoadon", SqlDbType.Int).Value = mahoadon;

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
