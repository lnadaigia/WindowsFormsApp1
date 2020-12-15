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
    public partial class frmnhanvien : Form
    {
        public frmnhanvien()
        {
            InitializeComponent();
            loadngay();
            loadgio();
        }
        void loadngay()
        {
            this.lb_ngay.Text= DateTime.Now.ToShortDateString();
 
        }
        void loadgio()
        {
            this.lb_gio.Text = DateTime.Now.ToLongTimeString();
        }
      
        private string id;
        public string setid
        {
            set { id = value; }
        }

       
       
        TimeSpan gio=new TimeSpan(0,0,0);
        void loadvieclam()
        {
        }
      
        private void frmnhanvien_Load(object sender, EventArgs e)
        {
           
        }
       

        private void btn_checkin_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_checkout_Click(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.lb_gio.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
