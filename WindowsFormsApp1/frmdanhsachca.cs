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
    public partial class frmdanhsachca : Form
    {
        public frmdanhsachca()
        {
            InitializeComponent();
        }

        private void frmchiaca_Load(object sender, EventArgs e)
        {
            DAOChiaca cc = new DAOChiaca();
            dataGridView1.DataSource = cc.getDanhSachChiaCa();
        }
      
        
       
        private void bn_capnhat_Click(object sender, EventArgs e)
        {
            frmchiacav2 frm = new frmchiacav2();
            frm.ShowDialog();
        }


        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            frmchiacav2 frm = new frmchiacav2();
            frm.ShowDialog();
        }

        private void btn_check_Click_1(object sender, EventArgs e)
        {
            if (rdb_ngay.Checked == true)
            {
                DAOChiaca cc = new DAOChiaca();
                DateTime a = DateTime.Parse(dt_ngay.Value.ToString());
                dataGridView1.DataSource = cc.getDanhSachChiaCaTheoNgay(a);
            }
            if (rdb_khoang.Checked == true)
            {
                DAOChiaca cc = new DAOChiaca();
                DateTime a = DateTime.Parse(dt_dau.Value.ToString());
                DateTime b = DateTime.Parse(dt_sau.Value.ToString());
                dataGridView1.DataSource = cc.getDanhSachChiaCaTheoKhoang(a, b);
            }
        }

        private void btn_search_Click_1(object sender, EventArgs e)
        {

            DAOChiaca cc = new DAOChiaca();
            string a = txt_search.Text;
            //MessageBox.Show(txt_search.Text);
            dataGridView1.DataSource = cc.Search(a);
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            DAOChiaca cc = new DAOChiaca();
            string a = txt_search.Text;
            //MessageBox.Show(txt_search.Text);
            dataGridView1.DataSource = cc.Search(a);
        }

        private void rdb_all_CheckedChanged(object sender, EventArgs e)
        {
            DAOChiaca cc = new DAOChiaca();
            dataGridView1.DataSource = cc.getDanhSachChiaCa();
        }
    }
}
