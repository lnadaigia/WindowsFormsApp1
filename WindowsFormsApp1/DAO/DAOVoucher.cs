﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.DAO
{
    class DAOVoucher
    {
		MY_DB db = new MY_DB();
		Voucher vc = new Voucher();
		public DataTable getvoucher()
		{
			SqlCommand command = new SqlCommand("SELECT * FROM getvoucher", db.GetConnection);
			SqlDataAdapter adapter = new SqlDataAdapter(command);
			DataTable table = new DataTable();
			adapter.Fill(table);
			return table;
		}
		public bool themVoucher(Voucher vc)
		{
			SqlCommand command = new SqlCommand("EXEC themVoucher @ngaybatdau=@ngaybatdau,@ngayketthuc=@ngayketthuc," +
				"@ten=@ten,@chitiet=@chitiet,@Discount=@Discount", db.GetConnection);
			command.Parameters.Add("@ten", SqlDbType.NVarChar).Value = vc.Ten;
			command.Parameters.Add("@chitiet", SqlDbType.NVarChar).Value = vc.Chitiet;
			command.Parameters.Add("@Discount", SqlDbType.Float).Value = vc.Discount;
			command.Parameters.Add("@ngaybatdau", SqlDbType.Date).Value = vc.Ngaybatdau;
			command.Parameters.Add("@ngayketthuc", SqlDbType.Date).Value = vc.Ngayketthuc;
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
		public bool suaVoucher(Voucher vc)
		{
			SqlCommand command = new SqlCommand("EXEC suaVoucher @ngaybatdau=@ngaybatdau,@ngayketthuc=@ngayketthuc,@ten=@ten," +
				"@chitiet=@chitiet,@Discount=@Discount,@mavoucher=@mavoucher", db.GetConnection);
			command.Parameters.Add("@Ten", SqlDbType.NVarChar).Value = vc.Ten;
			command.Parameters.Add("@mavoucher", SqlDbType.Int).Value = vc.Mavoucher;
			command.Parameters.Add("@Chitiet", SqlDbType.NVarChar).Value = vc.Chitiet;
			command.Parameters.Add("@Discount", SqlDbType.Float).Value = vc.Discount;
			command.Parameters.Add("@ngaybatdau", SqlDbType.DateTime).Value = vc.Ngaybatdau;
			command.Parameters.Add("@ngayketthuc", SqlDbType.DateTime).Value = vc.Ngayketthuc;
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
		public bool xoaVoucher(Voucher vc)
		{
			SqlCommand command = new SqlCommand("EXEC xoaVoucher @mavoucher=@mavoucher", db.GetConnection);
			command.Parameters.Add("@mavoucher", SqlDbType.Int).Value = vc.Mavoucher;
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
