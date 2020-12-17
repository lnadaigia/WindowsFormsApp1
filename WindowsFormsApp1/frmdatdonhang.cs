using GlobalVariables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DAO;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1
{
    public partial class frmdatdonhang : Form
    {
        public frmdatdonhang()
        {
            InitializeComponent();
        }
        void loadkhach()
        {
            int[] mang = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            comboBox1.DataSource = mang;
        }
        void loadVoucher()
        {
            DAOVoucher a = new DAOVoucher();
            cbVoucher.DataSource = a.getvoucher();
            cbVoucher.DisplayMember = "mavoucher";
            cbVoucher.ValueMember = "Discount";

        }
        void loadmonan()
        {
            DAODoAntheongay doan = new DAODoAntheongay();
            dtg_doan.DataSource = doan.getMonAndeban();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                dtg_doan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dtg_chitiet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dtg_doan.AllowUserToAddRows = false;
                dtg_chitiet.AllowUserToDeleteRows = false;
                dtg_doan.ReadOnly = true;
                dtg_chitiet.ReadOnly = true;
                numericUpDown1.Visible = false;
                loadkhach();
                loadmonan();
                loadVoucher();

            }
            catch { }


        }
        int row = 0;
        int max = 0;

        private void dtg_doan_Click(object sender, EventArgs e)
        {
            try
            {
                numericUpDown1.Visible = true;
                max = (int)dtg_doan.CurrentRow.Cells[3].Value + (int)dtg_doan.CurrentRow.Cells[4].Value;
                numericUpDown1.Maximum = max;
                int x = dtg_doan.CurrentRow.Index;
                row = x;
                Rectangle rectangle = dtg_doan.GetCellDisplayRectangle(0, x, true);
                numericUpDown1.Location = new Point(465, rectangle.Y);
                numericUpDown1.Value = (int)dtg_doan.Rows[row].Cells[4].Value;
            }
            catch { }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            dtg_doan.Rows[row].Cells[4].Value = numericUpDown1.Value;
            dtg_doan.Rows[row].Cells[3].Value = max - numericUpDown1.Value;
        }
        float tongtien = 0;

        private void btn_xemdon_Click(object sender, EventArgs e)
        {
            dtg_chitiet.DataSource = dtg_doan.DataSource;
            tongtien = 0;


            for (int i = 0; i < dtg_chitiet.Rows.Count - 1; i++)
            {
                try
                {
                    // MessageBox.Show(dtg_chitiet.Rows[i].Cells[1].Value.ToString());
                    tongtien += int.Parse(dtg_chitiet.Rows[i].Cells[4].Value.ToString()) * float.Parse(dtg_chitiet.Rows[i].Cells[2].Value.ToString());
                }
                catch
                {
                    MessageBox.Show("Failed");
                }

            }

            txt_tongtien.text=tongtien.ToString();
        }

        private void btn_dathang_Click(object sender, EventArgs e)
        {
            try
            {
                HoaDon hd = new HoaDon();
                
                hd.Maban = Globals.Maban;
                hd.Manv = Globals.NV;
                hd.Thoigian = DateTime.Now;
                hd.Tongbill = tongtien;
                hd.Trangthai = false;
                hd.Mavoucher = cbVoucher.Items.Count>0?int.Parse(cbVoucher.Text):0;
                DAOHoaDon a = new DAOHoaDon();
                DAOChiTietHoaDon DCT = new DAOChiTietHoaDon();
                a.DatHang(hd);
                int mahoadon = a.getCurrentMahoadon();
                for (int i = 0; i < dtg_chitiet.Rows.Count - 1; i++)
                {
                    int soluong = int.Parse(dtg_chitiet.Rows[i].Cells[4].Value.ToString());
                    ChiTietHoaDon ct = new ChiTietHoaDon();
                    if (soluong != 0)
                    {
                        ct.Mahoadon = mahoadon;
                        ct.Mamonan = int.Parse(dtg_chitiet.Rows[i].Cells[0].Value.ToString());
                        ct.Soluong = soluong;
                        DCT.Themvaochitiethoadon(ct);
                    }
                }
                MessageBox.Show("Dat hang thanh cong");
                Globals.SetMahoadon(mahoadon);
                //update trang thai ban
                DAOTable tb = new DAOTable();
                tb.UpdatetableStatus(Globals.Maban, 0);

            }
            catch (SqlException oke)
            {
                MessageBox.Show(oke.Message);
            }
        }

        private void btn_thanhtoan_Click(object sender, EventArgs e)
        {
            try
            {
                DAOHoaDon a = new DAOHoaDon();
                a.ThanhToan(Globals.Mahoadon);
                MessageBox.Show("Thanh toan thanh cong");
                //update trang thai ban
                DAOTable tb = new DAOTable();
                tb.UpdatetableStatus(Globals.Maban, 1);
            }
            catch
            {

            }
        }

        private void cbVoucher_SelectedIndexChanged(object sender, EventArgs e)
        {
            float a = tongtien;
            try
            {
                //MessageBox.Show(cbVoucher.Text.ToString());
                if (cbVoucher.SelectedValue != null)
                {
                    //MessageBox.Show(cbVoucher.SelectedValue.ToString());
                    a = tongtien * float.Parse(cbVoucher.SelectedValue.ToString());
                    this.txt_tongtien.Text = a.ToString();
                }
            }
            catch
            {

            }
        }
    }
}
