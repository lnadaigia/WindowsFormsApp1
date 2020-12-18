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
    public partial class frmquanli : Form
    {
        public frmquanli()
        {
            InitializeComponent();
            loadngay();
        }

        void loadngay()
        {
            this.lb_ngay.Text = DateTime.Now.ToShortDateString();
            DAOCa ca = new DAOCa();
            dataGridView1.DataSource = ca.getDanhSachNhanVienVaCa();
        }
        private void frmquanli_Load(object sender, EventArgs e)
        {
            try
            {
                loadngay();
            }
            catch { }
        }


        private void btn_dsnhanvien_Click(object sender, EventArgs e)
        {
            frmdsnhanvien frm = new frmdsnhanvien();
            frm.Show();
        }

        private void btn_chiaca_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_tinhluong_Click(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lb_gio.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
