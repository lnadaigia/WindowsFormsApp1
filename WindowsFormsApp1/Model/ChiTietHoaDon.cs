using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
	class ChiTietHoaDon
	{
		private int mahoadon;
		private int mamonan;
		private int soluong;
		public ChiTietHoaDon()
        {

        }
		public ChiTietHoaDon(int mahoadon, int mamonan, int soluong)
		{
			this.mahoadon = mahoadon;
			this.mamonan = mahoadon;
			this.soluong = soluong;
		}
		public int Mahoadon { get => mahoadon; set => mahoadon = value; }
		public int Mamonan { get => mamonan; set => mamonan = value; }
		public int Soluong { get => soluong; set => soluong = value; }
	}
}
