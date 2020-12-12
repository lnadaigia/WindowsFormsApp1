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
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }
        void MoveIndicator(Control control)
        {
            indicator.Left = control.Left;
            indicator.Width = control.Width;
        }
        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_user.Text == "" || txt_pass.Text == "")
                {
                    MessageBox.Show("không được để trống");
                }
                else
                {
                    SqlCommand command = new SqlCommand("select nv.idnv,ql.idql from nhanvien as nv,quanli as ql " +
                    "where (nv.username=@user and nv.password=@pass) or (ql.username=@user and ql.password=@pass)");
                    command.Parameters.Add("@user", SqlDbType.NVarChar).Value = txt_user.Text;
                    command.Parameters.Add("@pass", SqlDbType.NVarChar).Value = txt_pass.Text;
                  //  DataTable table = pv.getnhanvien(command);
                 
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_cancer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.ForeColor = Color.White;
            button1.ForeColor = Color.FromArgb(89, 121, 254);
            MoveIndicator((Control)sender);
            frmmaunhanvien frm = new frmmaunhanvien();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.ForeColor = Color.White;
            button2.ForeColor = Color.FromArgb(89, 121, 254);
            MoveIndicator((Control)sender);
            frmmau frm = new frmmau();
            frm.ShowDialog();
        }

        private void frmlogin_Load(object sender, EventArgs e)
        {

        }

        private void btn_cancer_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
