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
    public partial class frmdscanhanvien : Form
    {
        public frmdscanhanvien()
        {
            InitializeComponent();
        }
        private string idnv;
        public string setid
        {
            set { idnv = value; }
        }

        private void frmdscanhanvien_Load(object sender, EventArgs e)
        {

        }
     
        void loadca(SqlCommand command)
        {
            
        }

       

        private void btn_check_Click(object sender, EventArgs e)
        {
           
        }
    }
}
