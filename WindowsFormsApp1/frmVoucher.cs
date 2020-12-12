using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DAO;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1
{
    public partial class frmVoucher : Form
    {
        public frmVoucher()
        {
            InitializeComponent();
        }

        private void frmVoucher_Load(object sender, EventArgs e)
        {
            try
            {
                DAOVoucher a = new DAOVoucher();
                dataGridView1.DataSource = a.getvoucher();
                this.txt_ma.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                this.txt_tenma.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                this.dt_ngaybatdau.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[2].Value.ToString());
                this.dt_ngaykt.Value= Convert.ToDateTime(dataGridView1.CurrentRow.Cells[3].Value.ToString());
                this.txt_chitiet.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                this.txt_discount.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            }
            catch
            {
                MessageBox.Show("error");
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {

            try
            {
                Voucher vc = new Voucher();
                vc.Ten = this.txt_tenma.Text;
                vc.Chitiet = this.txt_chitiet.Text;
                vc.Discount = float.Parse(this.txt_discount.Text);
                vc.Ngaybatdau = this.dt_ngaybatdau.Value;
                vc.Ngayketthuc = this.dt_ngaykt.Value;
                DAOVoucher a = new DAOVoucher();
                a.themVoucher(vc);
                MessageBox.Show("them thanh cong"); 
                dataGridView1.DataSource = a.getvoucher();

            }
            catch
            {
                MessageBox.Show("error");
            }
            
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            try
            {
                Voucher vc = new Voucher();
                vc.Mavoucher = int.Parse(this.txt_ma.Text);
                vc.Ten = this.txt_tenma.Text;
                vc.Chitiet = this.txt_chitiet.Text;
                vc.Discount = float.Parse(this.txt_discount.Text);


                DateTime a = Convert.ToDateTime(dt_ngaybatdau.Value);
                vc.Ngaybatdau = a;
                DateTime b = Convert.ToDateTime(dt_ngaykt.Value);
                vc.Ngayketthuc = b;
                DAOVoucher k = new DAOVoucher();
                k.suaVoucher(vc);
                dataGridView1.DataSource = k.getvoucher();

                MessageBox.Show("sua thanh cong");

            }
            catch
            {
                MessageBox.Show("error");
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                Voucher vc = new Voucher();
                vc.Mavoucher = int.Parse(this.txt_ma.Text);
                vc.Ten = this.txt_tenma.Text;
                vc.Chitiet = this.txt_chitiet.Text;
                vc.Discount = float.Parse(this.txt_discount.Text);


                DateTime a = Convert.ToDateTime(dt_ngaybatdau.Value);
                vc.Ngaybatdau = a;
                DateTime b = Convert.ToDateTime(dt_ngaykt.Value);
                vc.Ngayketthuc = b;
                DAOVoucher k = new DAOVoucher();
                k.xoaVoucher(vc);
                dataGridView1.DataSource = k.getvoucher();
                MessageBox.Show("xoa thanh cong");

            }
            catch
            {
                MessageBox.Show("error");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.txt_ma.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                this.txt_tenma.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                this.dt_ngaybatdau.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[2].Value.ToString());
                this.dt_ngaykt.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[3].Value.ToString());
                this.txt_chitiet.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                this.txt_discount.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            }
            catch
            {
                MessageBox.Show("error");
            }
        }
    }
}
