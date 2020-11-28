﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
	class NhanVien
	{
		private int maNv;
		private string hoten;
		private string sdt;
		private DateTime ngaysinh;
		private float luong;
		private int maNql;
		public NhanVien() {  }
		public NhanVien(int Manv, string hoten, string sdt, DateTime ngaysinh, float luong, int MaNql)
		{
			this.maNv = Manv;
			this.hoten = hoten;
			this.sdt = sdt;
			this.ngaysinh = ngaysinh;
			this.luong = luong;
			this.maNql = MaNql;

		}

		public int MaNv { get => maNv; set => maNv = value; }
		public string Hoten { get => hoten; set => hoten = value; }
		public string Sdt { get => sdt; set => sdt = value; }
		public DateTime Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
		public float Luong { get => luong; set => luong = value; }
		public int MaNql { get => maNql; set => maNql = value; }
	}
}
