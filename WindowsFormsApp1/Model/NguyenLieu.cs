using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
	class NguyenLieu
	{
		private int manguyenlieu;
		private string tennguyenlieu;
		public NguyenLieu()
		{

		}
		public NguyenLieu(int manguyenlieu, string tennguyenlieu)
		{
			this.manguyenlieu = manguyenlieu;
			this.tennguyenlieu = tennguyenlieu;
		}

		public int Manguyenlieu { get => manguyenlieu; set => manguyenlieu = value; }
		public string Tennguyenlieu { get => tennguyenlieu; set => tennguyenlieu = value; }
	}
}
