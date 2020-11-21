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
    public partial class frmdoimk : Form
    {
        public frmdoimk()
        {
            InitializeComponent();
            label4.Text = id;
        }
        private string id;
        public string getid
        {
            set { id=value; }
        }

        private void btn_cancer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
        private void btn_doimk_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_mkcu.Text == "" || txt_mkmoi.Text == "" || txt_mkmoi2.Text == "")
                {
                    MessageBox.Show("không được để rỗng");
                }
                else
                {
                    if (txt_mkmoi.Text != txt_mkmoi2.Text)
                    {
                        MessageBox.Show("mật khẩu mới phải có độ dài bằng nhau");
                    }
                    else
                    {
                        
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
    }
}
