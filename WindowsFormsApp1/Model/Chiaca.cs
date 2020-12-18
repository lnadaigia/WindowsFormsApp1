using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{


    class Chiaca
    {
        private int manv;
        private int maca;
        private DateTime ngay;
        public Chiaca()
        {

        }
        public Chiaca(int Manv, int Maca, DateTime Ngay)
        {
            this.manv = Manv;
            this.maca = Maca;
            this.ngay = Ngay;
        }
        public int Manv { get => manv; set => manv = value; }
        public int Maca { get => maca; set => maca = value; }
        public DateTime Ngay { get => ngay; set => ngay = value; }
    }
}
