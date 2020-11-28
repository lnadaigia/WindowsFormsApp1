using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
	class MonAn
	{
		private int mamonan;
		private string tenmonan;

		public MonAn()
		{

		}
		public MonAn(int mamonan, string tenmonan)
		{
			this.mamonan = mamonan;
			this.tenmonan = tenmonan;
		}

		public int Mamonan { get => mamonan; set => mamonan = value; }
		public string Tenmonan { get => tenmonan; set => tenmonan = value; }
	}
}
