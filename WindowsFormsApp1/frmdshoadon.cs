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

namespace WindowsFormsApp1
{
    public partial class frmdshoadon : Form
    {
        public frmdshoadon()
        {
            InitializeComponent();
        }

        void load_hoadon(string query)
        {
            DAOHoaDon hd = new DAOHoaDon();
            DataTable tb = new DataTable();
            tb = hd.locHoaDon(query);
            dtg_hoadon.DataSource = tb;
        }
        private void frmdanhsachdonhang_Load(object sender, EventArgs e)
        {
            try
            {
                DAOHoaDon hd = new DAOHoaDon();
                DataTable tb = new DataTable();
                tb = hd.getHoaDon();
                dtg_hoadon.DataSource = tb;
            }
            catch
            {

            }
        }

        private void dtg_hoadon_Click(object sender, EventArgs e)
        {
            try
            {
                int mahoadon = (int)dtg_hoadon.CurrentRow.Cells[0].Value;
                DAOChiTietHoaDon cthd = new DAOChiTietHoaDon();
                DataTable tb = new DataTable();
                tb = cthd.getChiTietHoaDon(mahoadon);
                dtg_chitiet_hoa_don.DataSource = tb;

            }
            catch { }
        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "";
                //lọc theo hóa đơn đã thanh toán chưa
                if (rdb_chontatca.Checked)
                {
                    if (rdb_yes.Checked)
                    {
                        string dau = dt_dau.Value.ToString("yyyy-MM-dd");
                        string cuoi = dt_sau.Value.ToString("yyyy-MM-dd");
                        query = "select * from hoadon where convert(date,Hoadon.Thoigian) between '" + dau + "' and '" + cuoi + "'";
                        MessageBox.Show(query);
                    }
                    else
                    {
                        query = "select * from hoadon";
                    }
                }
                else if (rdb_dathanhtoan.Checked)
                {
                    if (rdb_yes.Checked)
                    {
                        string dau = dt_dau.Value.ToString("yyyy-MM-dd");
                        string cuoi = dt_sau.Value.ToString("yyyy-MM-dd");
                        query = "select * from hoadon where convert(date,Hoadon.Thoigian) between '" + dau + "' and '" + cuoi + "' and trangthai = 1";
                    }
                    else
                    {
                        query = "select * from hoadon where trangthai = 1";
                    }
                }
                else
                {
                    if (rdb_yes.Checked)
                    {
                        string dau = dt_dau.Value.ToString("yyyy-MM-dd");
                        string cuoi = dt_sau.Value.ToString("yyyy-MM-dd");
                        query = "select * from hoadon where convert(date,Hoadon.Thoigian) between '" + dau + "' and '" + cuoi + "' and trangthai = 0";
                    }
                    else
                    {
                        query = "select * from hoadon where trangthai = 0";
                    }
                }
                load_hoadon(query);
                //lọc theo bàn
            }
            catch (Exception ex)
            { MessageBox.Show(ex.ToString()); }
        }
    }
}
