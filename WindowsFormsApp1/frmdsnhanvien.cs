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
    public partial class frmdsnhanvien : Form
    {
        public frmdsnhanvien()
        {
            InitializeComponent();
        }

        private void frmdsnhanvien_Load(object sender, EventArgs e)
        {
            loadnv();

        }
		
        void loadnv()
        {
			DAONhanVien nv = new DAONhanVien();
			DataTable dt = new DataTable();
			dt = nv.getNhanVien();
			try
			{
				dataGridView1.DataSource = dt;
			}
			catch { }
		}

       

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string idnv = txt_idnv.Text;
            string hovaten = txt_hovaten.Text;
            DateTime namsinh = dt_namsinh.Value;
            string sdt = txt_sdt.Text;
            string cmnd = txt_cmnd.Text;
            if (rong())
            {
                MessageBox.Show("không được để rỗng");
            }
            else
            {
               
            }
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
          
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {

            try
            {
                if ((MessageBox.Show("bạn có muốn xóa nhân viên không", "xóa nhân viên", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
                {
                   
                }
            }
            catch
            {
                MessageBox.Show("vui lòng nhập nhân viên id", "xóa sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txt_idnv.Text = "";
            txt_hovaten.Text = "";
            dt_namsinh.Value = DateTime.Now;
            txt_sdt.Text = "";
            txt_cmnd.Text = "";
           
        }
        bool rong()
        {
            if(txt_idnv.Text==""||txt_hovaten.Text==""||txt_sdt.Text==""||txt_cmnd.Text=="")
            return true;
            return false;
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_idnv.Text = "";
            txt_hovaten.Text = "";
            dt_namsinh.Value = DateTime.Now;
            txt_sdt.Text = "";
            txt_cmnd.Text = "";
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            loadnv();
        }

        private void btn_timid_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            txt_idnv.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_hovaten.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            dt_namsinh.Value = (DateTime)dataGridView1.CurrentRow.Cells[2].Value;
            txt_sdt.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_cmnd.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

        }

        private void btn_dilam_Click(object sender, EventArgs e)
        {
            try
            {
               
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_searh_TextChanged(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch
            {

            }
        }

        private void btn_quenmk_Click(object sender, EventArgs e)
        {
            try
            {
            }
            catch
            {

            }
        }

       
    }
}
