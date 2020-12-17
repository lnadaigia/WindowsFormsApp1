using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    class Voucher
    {
        int mavoucher;
        string ten;
        DateTime ngaybatdau;
        DateTime ngayketthuc;
        string chitiet;
        float discount;

        public int Mavoucher { get => mavoucher; set => mavoucher = value; }
        public string Ten { get => ten; set => ten = value; }
        public DateTime Ngaybatdau { get => ngaybatdau; set => ngaybatdau = value; }
        public DateTime Ngayketthuc { get => ngayketthuc; set => ngayketthuc = value; }
        public string Chitiet { get => chitiet; set => chitiet = value; }
        public float Discount { get => discount; set => discount = value; }


        public Voucher()
        {


        }
        public Voucher(DateTime ngaybatdau, DateTime ngayketthuc,string ten, float discount,string chitiet)
        {
            this.ngaybatdau = ngaybatdau;
            this.ngayketthuc = ngayketthuc;
            this.ten = ten;
            this.discount = discount;
            this.chitiet = chitiet;

        }
    }
}
