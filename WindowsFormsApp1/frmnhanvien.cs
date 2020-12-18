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

      
        private void frmnhanvien_Load(object sender, EventArgs e)
        {
            DAOCa ca = new DAOCa();
            dataGridView1.DataSource = ca.getDanhSachCaChoNV(Globals.NV);
        }
       

      

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.lb_gio.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
