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

namespace WindowsFormsApp1
{
    public partial class frmquanli : Form
    {
        public frmquanli()
        {
            InitializeComponent();
        }
       
       

        void loadngay()
        {
            this.lb_ngay.Text += DateTime.Now.ToShortDateString();

        }
        string ca()
        {
            int baygio = (int)DateTime.Now.Hour;
            string ca;
            if (baygio >= 6 && baygio < 11)
            {
                ca = "sáng";
            }
            else if (baygio >= 11 && baygio < 16)
            {
                ca = "trưa";
            }
            else if (baygio >= 18 && baygio < 22)
            {
                ca = "tối";
            }
            else
            {
                ca = "giờ nghỉ";
            }
            return ca;

        }
        string loadca()
        {
            int baygio = (int)DateTime.Now.Hour;
            string ca;
            if (baygio >= 6 && baygio < 11)
            {
                ca = "select id,ngay,idnv,sang,trua,toi,checkinsang,checkoutsang from danhsachca where ngay = @ng and sang=@tr";
            }
            else if (baygio >= 11 && baygio < 16)
            {
                ca = "select id,ngay,idnv,sang,trua,toi,checkintrua,checkouttrua from danhsachca where ngay = @ng and trua=@tr";
            }
            else if (baygio >= 18 && baygio < 22)
            {
                ca = "select id,ngay,idnv,sang,trua,toi,checkintoi,checkouttoi from danhsachca where ngay = @ng and toi=@tr";
            }
            else
            {
                ca = "giờ nghỉ";
            }
            return ca;

        }
        void loadvieclam()
        {
            string ca = loadca();
            if (ca == "giờ nghỉ")
            {
                MessageBox.Show(ca);
            }
            else
            {

                
            }

        }
        void loadquanli()
        {
           
        }
        private void frmquanli_Load(object sender, EventArgs e)
        {
            try
            {
               
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
