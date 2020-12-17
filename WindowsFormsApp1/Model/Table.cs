using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    class Table
    {

        private string TableStatus;
        private string maban;
        private string tenban;
        private int soluongnguoi;
        public static double tbHeight = 100;
        public static double tbwidth = 200;

        public string TableStatus1 { get => TableStatus; set => TableStatus = value; }
        public string Maban { get => maban; set => maban = value; }
        public int Soluongnguoi { get => soluongnguoi; set => soluongnguoi = value; }
        public string Tenban { get => tenban; set => tenban = value; }

        public Table()
        {

        }
        public Table( string Table, string tenban, int soluong)
        {
            this.TableStatus = Table;
            this.Tenban = tenban;
            this.soluongnguoi = soluong;
        }

        public Table(DataRow row)
        {
            this.maban = row["Maban"].ToString();
            this.tenban = row["Tenban"].ToString();
            this.TableStatus1 = row["Trangthai"].ToString();
            this.soluongnguoi = (int)row["SoLuongKhach"];
        }
    }
}
