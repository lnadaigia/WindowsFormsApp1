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
    public partial class frmmaunhanvien : Form
    {
        public frmmaunhanvien()
        {
            InitializeComponent();
        }
        private string id;
        public string setid
        {
            set { id = value; }
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
        private void frmmaunhanvien_Load(object sender, EventArgs e)
        {
           
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            this.pn_menu.Visible = !this.pn_menu.Visible; 
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            openchildform(new frmnhanvien());
        }

        private void btn_dsca_Click(object sender, EventArgs e)
        {
            openchildform(new frmdscanhanvien());
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
            openchildform(new frmmuanguyenlieu());
        }

        private void btn_thongtin_Click(object sender, EventArgs e)
        {
            openchildform(new frmthongtin());
        }
    }
}
