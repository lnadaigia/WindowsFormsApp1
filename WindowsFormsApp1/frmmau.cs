using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmmau : Form
    {
        public frmmau()
        {
            InitializeComponent();
        }
        private string idql;
        public string setid
        {
            set { idql = value; }
        }
        private void button1_Click(object sender, EventArgs e)
        { 
            this.pn_menu.Visible = !this.pn_menu.Visible; ;
        }

        private void btn_dsnhanvien_Click(object sender, EventArgs e)
        {
            
        }
        private Form activeform = null;
        private void openchildform(Form childform)
        {
            if (activeform != null)
                activeform.Close();
            activeform = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            pn_childform.Controls.Add(childform);
            pn_childform.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            openchildform(new frmquanli());
        }

        private void btn_dsbanan_Click(object sender, EventArgs e)
        {
            openchildform(new frmdsban());
        }

        private void btn_dshoadon_Click(object sender, EventArgs e)
        {
            openchildform(new frmdshoadon());
        }

        private void btn_dsmonan_Click(object sender, EventArgs e)
        {
            openchildform(new frmdsdoan());
        }

        private void btn_dsnhanvien_Click_1(object sender, EventArgs e)
        {
            openchildform(new frmdsnhanvien());
        }

        private void btn_muanguyenlieu_Click(object sender, EventArgs e)
        {
            openchildform(new frmmuanguyenlieu());
        }

        private void btn_thongke_Click(object sender, EventArgs e)
        {
            openchildform(new frmthongke());
        }

        private void btn_dsca_Click(object sender, EventArgs e)
        {
            openchildform(new frmdanhsachca());
        }

        private void btn_Voucher_Click(object sender, EventArgs e)
        {
            openchildform(new frmVoucher());
        }

        private void btn_thongtin_Click(object sender, EventArgs e)
        {
            openchildform(new frmthongtin());
        }
    }
}
