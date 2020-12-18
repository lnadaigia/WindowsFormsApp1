using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    class Ca
    {
        private int Maca;
        private string Tenca;


        public Ca()
        {

        }
        public Ca(int maca, string tenca)
        {
            this.Maca = maca;
            this.Tenca = tenca;
        }

        public int Maca1 { get => Maca; set => Maca = value; }
        public string Tenca1 { get => Tenca; set => Tenca = value; }
    }
}
