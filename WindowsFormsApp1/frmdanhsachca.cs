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
    public partial class frmdanhsachca : Form
    {
        public frmdanhsachca()
        {
            InitializeComponent();
        }

        private void frmchiaca_Load(object sender, EventArgs e)
        {
            loadcatatca(); ;
        }
      
        void loadcatheongay()
        {
           
        }
        void  loadcatatca()
        {
            
        }
        void loadtheokhoang()
        {
           
        }
       
        private void bn_capnhat_Click(object sender, EventArgs e)
        {
            frmchiacav2 frm = new frmchiacav2();
            frm.ShowDialog();
        }

        private void btn_caquanli_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_check_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            
        }
    }
}
