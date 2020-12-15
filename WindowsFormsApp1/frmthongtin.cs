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
    public partial class frmthongtin : Form
    {
        public frmthongtin()
        {
            InitializeComponent();
        }
        private string id;
        public string setid
        {
            set { id = value; }
        }
       
        void load()
        {
            string query = "select * from quanli where idql=@i";
            lb_quanli.Text = "chức vụ: quản lí";
            if (id[0] == 'n')
            {
                query = "select * from nhanvien where idnv=@i";
                lb_quanli.Text = "chức vụ: nhân viên";
            }
            SqlCommand command = new SqlCommand(query);
            command.Parameters.Add("@i", SqlDbType.NVarChar).Value = id;
           
          
        }
        void sua()
        {
            string idql = txt_idql.Text;
            string hovaten = txt_hovaten.Text;
            DateTime namsinh = dt_nsinh.Value;
            string sdt = txt_sdt.Text;
            string cmnd = txt_cmnd.Text;
            if (idql==""||hovaten==""||sdt==""||cmnd=="")
            {
                MessageBox.Show("không được để trống");
            }
            else
            {
                
               
            }
        }
        private void frmthongtin_Load(object sender, EventArgs e)
        {
            try
            {
               
            }
            catch
            {

            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            try
            {
                sua();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_doimk_Click(object sender, EventArgs e)
        {
            frmdoimk frm = new frmdoimk();
            frm.ShowDialog();
        }

        private void dt_nsinh_onValueChanged(object sender, EventArgs e)
        {

        }
    }
}
