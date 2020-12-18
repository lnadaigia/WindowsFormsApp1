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

namespace WindowsFormsApp1
{
    public partial class frmdscanhanvien : Form
    {
        public frmdscanhanvien()
        {
            InitializeComponent();
        }
        private void frmdscanhanvien_Load(object sender, EventArgs e)
        {
            DAOCa ca = new DAOCa();
            dataGridView1.DataSource= ca.getDanhSachCaTheoNV(Globals.NV);
        }
     

        private void btn_check_Click_1(object sender, EventArgs e)
        {
            if (rdb_ngay.Checked == true)
            {
                DAOCa cc = new DAOCa();
                DateTime a = DateTime.Parse(dt_ngay.Value.ToString());
                dataGridView1.DataSource = cc.getDanhSachCaTheoNVVaTheoNgay(Globals.NV,a);
            }
            if (rdb_khoang.Checked == true)
            {
                DAOCa cc = new DAOCa();
                DateTime a = DateTime.Parse(dt_dau.Value.ToString());
                DateTime b = DateTime.Parse(dt_sau.Value.ToString());
                dataGridView1.DataSource = cc.getDanhSachCaTheoNVVaTheoKhoang(Globals.NV,a, b);
            }
        }

        private void rdb_all_CheckedChanged(object sender, EventArgs e)
        {
       
            DAOCa ca = new DAOCa();
            dataGridView1.DataSource = ca.getDanhSachCaTheoNV(Globals.NV);
        }
    }
}
