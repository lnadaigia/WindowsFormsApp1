using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    class MonAnTheoNgay
    {
        private DateTime ngay;
        private int soluong;
        private float gia;
        private int mamonan;

        public DateTime Ngay
        {
            get{ return this.ngay; }
            set{ this.ngay = value; }
        }
        public int Soluong
        {
            get { return this.soluong; }
            set { this.soluong = value; }
        }
        public float Gia
        {
            get { return this.gia; }
            set { this.gia = value; }
        }
        public int Mamonan
        {
            get { return this.mamonan; }
            set { this.mamonan = value; }
        }
    }

}
