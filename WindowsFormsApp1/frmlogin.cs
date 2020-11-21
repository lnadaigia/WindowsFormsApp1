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
           
            frmmaunhanvien frm = new frmmaunhanvien();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmmau frm = new frmmau();
            frm.ShowDialog();
        }
    }
}
