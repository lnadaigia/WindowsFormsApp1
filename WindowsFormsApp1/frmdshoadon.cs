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
            
        }
        private void frmdanhsachdonhang_Load(object sender, EventArgs e)
        {
			DAOHoaDon hd = new DAOHoaDon();
			DataTable tb = new DataTable();
			tb = hd.getHoaDon();
			try
			{
				dtg_hoadon.DataSource = tb;
			}
			catch
			{

			}
        }

        private void dataGridView1_Click(object sender, EventArgs e)
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
            }
            catch
            { }
        }
    }
}
