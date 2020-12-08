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
    public partial class frmmuanguyenlieu : Form
    {
        public frmmuanguyenlieu()
        {
            InitializeComponent();
        }

        MY_DB db = new MY_DB();
        private void frmmuanguyenlieu_Load(object sender, EventArgs e)
        {
            try
            {
                load_doan_theo_ngay();
                load_nguyen_lieu();

                numericUpDown1.Visible = false;
            }
            catch { }
        }
        int row = 0;
        private void dtg_doan_Click(object sender, EventArgs e)
        {
            try
            {
                numericUpDown1.Visible = true;
                int x = dtg_doan.CurrentRow.Index;
                row = x;
                Rectangle rectangle = dtg_doan.GetCellDisplayRectangle(0, x, true);
                numericUpDown1.Location = new Point(465, rectangle.Y);
                numericUpDown1.Value = (int)dtg_doan.Rows[row].Cells[3].Value;
            }
            catch { }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            dtg_doan.Rows[row].Cells[3].Value = numericUpDown1.Value;
        }
        void load_doan_theo_ngay()
        {
            DAODoAntheongay ma = new DAODoAntheongay();
            dtg_doan.DataSource = ma.getMonAntheongay();
            dtg_doan.AllowUserToAddRows = false;
        }
        void load_nguyen_lieu()
        {

            DAONguyenLieu nl = new DAONguyenLieu();
            dtg_nguyenlieu_theongay.DataSource = nl.getNguyenLieutheongay();
            dtg_nguyenlieu_theongay.AllowUserToAddRows = false;
            dtg_nguyenlieu_theongay.ReadOnly = true;
        }
        private void btn_xemdonhang_Click(object sender, EventArgs e)
        {
            MonAnTheoNgay ma = new MonAnTheoNgay();
            DAODoAntheongay dao = new DAODoAntheongay();
            try
            {
                
                ma.Mamonan = (int)dtg_doan.CurrentRow.Cells[0].Value;
                ma.Gia = float.Parse(dtg_doan.CurrentRow.Cells[2].Value.ToString());
                ma.Soluong= (int)dtg_doan.CurrentRow.Cells[3].Value;
                if (dao.themMonAntheongay(ma)==false)
                {
                    MessageBox.Show("Thêm món ăn thành công");
                }
                else
                {
                    MessageBox.Show("Thêm món ăn thất bại");
                }
                load_doan_theo_ngay();
                load_nguyen_lieu();
            }
            catch(Exception a){ 
                MessageBox.Show(a.ToString()); 
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            MonAnTheoNgay ma = new MonAnTheoNgay();
            DAODoAntheongay dao = new DAODoAntheongay();
            try
            {

                ma.Mamonan = (int)dtg_doan.CurrentRow.Cells[0].Value;
                ma.Gia = float.Parse(dtg_doan.CurrentRow.Cells[2].Value.ToString());
                ma.Soluong = (int)dtg_doan.CurrentRow.Cells[3].Value;
                if (dao.xoaMonAntheongay(ma) == false)
                {
                    MessageBox.Show("Xóa món ăn thành công");
                }
                else
                {
                    MessageBox.Show("Xóa món ăn thất bại");
                }
                load_doan_theo_ngay();
                load_nguyen_lieu();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            MonAnTheoNgay ma = new MonAnTheoNgay();
            DAODoAntheongay dao = new DAODoAntheongay();
            try
            {

                ma.Mamonan = (int)dtg_doan.CurrentRow.Cells[0].Value;
                ma.Gia = float.Parse(dtg_doan.CurrentRow.Cells[2].Value.ToString());
                ma.Soluong = (int)dtg_doan.CurrentRow.Cells[3].Value;
                if (dao.suaMonAntheongay(ma) == false)
                {
                    MessageBox.Show("Sửa món ăn thành công");
                }
                else
                {
                    MessageBox.Show("Sửa món ăn thất bại");
                }
                load_doan_theo_ngay();
                load_nguyen_lieu();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
            }
        }
    }
}
