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
    public partial class frmdsban : Form
    {
        public frmdsban()
        {
            InitializeComponent();
        }
       
        private void btn_2_Click(object sender, EventArgs e)
        {
            try
            {
                frmdatdonhang frm = new frmdatdonhang();
                frm.ShowDialog();
            }
            catch { }

        }

        private void frmgiaodienchinh_Load(object sender, EventArgs e)
        {
            
            
        }
    }
}
