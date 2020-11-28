using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
	class HoaDon
	{
		private int mahoadon;
		private int maban;
		private DateTime thoigian;
		private float tongbill;
		private int manv;
		private int mavoucher;
		private bool trangthai;
		public HoaDon() { }
		public HoaDon(int mahoadon, int maban, DateTime thoigian, float tongbill, int manv, int mavoucher, bool trangthai)
		{
			this.mahoadon = mahoadon;
			this.maban = maban;
			this.thoigian = thoigian;
			this.tongbill = tongbill;
			this.manv = manv;
			this.mavoucher = mavoucher;
			this.trangthai = trangthai;
		}

		public int Mahoadon { get => mahoadon; set => mahoadon = value; }
		public int Maban { get => maban; set => maban = value; }
		public DateTime Thoigian { get => thoigian; set => thoigian = value; }
		public float Tongbill { get => tongbill; set => tongbill = value; }
		public int Manv { get => manv; set => manv = value; }
		public int Mavoucher { get => mavoucher; set => mavoucher = value; }
		public bool Trangthai { get => trangthai; set => trangthai = value; }
	}
}
