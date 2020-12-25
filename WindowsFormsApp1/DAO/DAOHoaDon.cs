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
		public DataTable thongkedoanhthu(int thang)
		{
			SqlCommand command = new SqlCommand(
			"select * from thongkedoanhthu(@thang)", db.GetConnection);

			command.Parameters.Add("@thang", SqlDbType.Int).Value = thang;
			//command.Parameters.Add("@nam", SqlDbType.Int).Value = DateTime.Now.Year;
			SqlDataAdapter adapter = new SqlDataAdapter(command);
			DataTable table = new DataTable();
			adapter.Fill(table);
			return table;
		}
		public DataTable getHoaDonbyban(int maban)
		{
			SqlCommand command = new SqlCommand("select * from getHoaDonbyban(@maban)", db.GetConnection);
			command.Parameters.Add("@maban", SqlDbType.Int).Value = maban;
			SqlDataAdapter adapter = new SqlDataAdapter(command);
			DataTable table = new DataTable();
			adapter.Fill(table);
			return table;
		}
		public DataTable getHoaDon()
		{
			SqlCommand command = new SqlCommand("select * from hoadon", db.GetConnection);
			SqlDataAdapter adapter = new SqlDataAdapter(command);
			DataTable table = new DataTable();
			adapter.Fill(table);
			return table;
		}

		public DataTable locHoaDon(String sql)
		{
			SqlCommand command = new SqlCommand(sql, db.GetConnection);
			SqlDataAdapter adapter = new SqlDataAdapter(command);
			DataTable table = new DataTable();
			adapter.Fill(table);
			return table;

		}
		public bool updatect(DataTable ct, int maban)
		{
			SqlCommand insertCommand = new SqlCommand("themchitiet", db.GetConnection);
			insertCommand.CommandType = CommandType.StoredProcedure;
			insertCommand.Parameters.Add("@maban", SqlDbType.Int).Value = maban;
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
		public int getmahoadonbyban(int maban)
		{
			SqlCommand command = new SqlCommand("select * from hoadon where Trangthai=0 and maban=@maban and CONVERT(date, Thoigian) = convert(date, GETDATE())", db.GetConnection);
			command.Parameters.Add("@maban", SqlDbType.Int).Value = maban;
			SqlDataAdapter adapter = new SqlDataAdapter(command);
			DataTable table = new DataTable();
			adapter.Fill(table);
			if (table.Rows.Count > 0)
				return (int)table.Rows[0][0];
			return 0;
		}
		public bool themhoadon(int maban, int idnv, int makm)
		{
			if (getmahoadonbyban(maban) == 0)
			{
				SqlCommand command = new SqlCommand("insert into Hoadon values(@maban,CONVERT(datetime,getdate()),0,@manv,@makm,0)", db.GetConnection);
				command.Parameters.Add("@mahoadon", SqlDbType.Int).Value = maban;
				command.Parameters.Add("@manv", SqlDbType.Int).Value = idnv;
				command.Parameters.Add("@makm", SqlDbType.Int).Value = makm;
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
			return false;

		}
		public bool themchitiet(DataTable ct, int mahoadon)
		{
			bool t = false;
			db.openConection();
			SqlTransaction objTrans = db.GetConnection.BeginTransaction();
			SqlCommand command = new SqlCommand("insert into chitiethoadon values(@mahoadon,@mamonan,@soluong)", db.GetConnection, objTrans);
			command.Parameters.Add("@mahoadon", SqlDbType.Int);
			command.Parameters.Add("@mamonan", SqlDbType.Int);
			command.Parameters.Add("@soluong", SqlDbType.Int);
			SqlCommand command2 = new SqlCommand("delete from chitiethoadon where mahoadon=@mahoadon", db.GetConnection, objTrans);
			command2.Parameters.Add("@mahoadon", SqlDbType.Int).Value = mahoadon;
			SqlCommand command3 = new SqlCommand("update hoadon set tongbill=0  where mahoadon=@mahoadon", db.GetConnection, objTrans);
			command3.Parameters.Add("@mahoadon", SqlDbType.Int).Value = mahoadon;

			try
			{
				command2.ExecuteNonQuery();
				command3.ExecuteNonQuery();
				foreach (DataRow row in ct.Rows)
				{
					command.Parameters[0].Value = mahoadon;
					command.Parameters[1].Value = (int)row[0];
					command.Parameters[2].Value = (int)row[1];

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


		public int getTongbill(int mahoadon)
		{
			SqlCommand command = new SqlCommand("  SELECT Tongbill FROM Hoadon WHere Mahoadon=@mahoadon", db.GetConnection);
			command.Parameters.Add("@mahoadon", SqlDbType.Int).Value = mahoadon;
			SqlDataAdapter adapter = new SqlDataAdapter(command);
			DataTable table = new DataTable();
			adapter.Fill(table);
			if (table.Rows.Count > 0)
				return int.Parse(table.Rows[0][0].ToString());
			return 0;
		}
		public int getCurrentMahoadon(int maban)
		{
			SqlCommand command = new SqlCommand(" SELECT Mahoadon FROM Hoadon WHERE Maban=@MaBan AND convert(date,Thoigian)=CONVERT(date,GETDATE()) AND Trangthai=0", db.GetConnection);
			command.Parameters.Add("@Maban", SqlDbType.Int).Value = maban;
			SqlDataAdapter adapter = new SqlDataAdapter(command);
			DataTable table = new DataTable();
			adapter.Fill(table);
			if (table.Rows.Count > 0)
				return int.Parse(table.Rows[0][0].ToString());
			return 0;
		}
		public bool DatHang(HoaDon hd)
		{
			SqlCommand command = new SqlCommand("execute DatHang @Maban,@Thoigian,@Tongbill,@Manv,@mavoucher,@Trangthai", db.GetConnection);
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

			SqlCommand command = new SqlCommand("execute ThanhToan @Mahoadon	", db.GetConnection);
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

		public bool xoahoadon(int maban)
		{

			SqlCommand command = new SqlCommand("DELETE FROM Hoadon WHERE Mahoadon=@mahoadon", db.GetConnection);
			command.Parameters.Add("@mahoadon", SqlDbType.Int).Value = maban;
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

