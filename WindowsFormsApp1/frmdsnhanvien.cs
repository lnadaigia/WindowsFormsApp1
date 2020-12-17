using GlobalVariables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DAO;
using WindowsFormsApp1.Model;

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
            try
            {
                loadnv();
            }
            catch { }
        }

        void loadnv()
        {
            DAONhanVien nv = new DAONhanVien();
            DataTable dt = new DataTable();
            dt = nv.getNhanVien();
           
                dataGridView1.DataSource = dt;
           
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
            dt_nsinh.Value = DateTime.Now;
            txt_sdt.Text = "";
            txt_luong.Text = "";
           
        }
        bool rong()
        {
            if(txt_hovaten.Text==""||txt_sdt.Text==""||txt_luong.Text=="")
            return true;
            return false;
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_idnv.Text = "";
            txt_hovaten.Text = "";
            dt_nsinh.Value = DateTime.Now;
            txt_sdt.Text = "";
            txt_luong.Text = "";
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            try
            {
                loadnv();
            }
            catch { }
        }

        private void btn_timid_Click(object sender, EventArgs e)
        {
            DAONhanVien nv = new DAONhanVien();
            DataTable dt = new DataTable();
            dataGridView1.DataSource = dt;
            if(txt_timkiem.Text!="")
            {
                int id_tim = Int32.Parse(txt_timkiem.Text);
                dt = nv.GetNhanVienByID(id_tim);
            }
            else
            {
                MessageBox.Show("vui lòng nhập nhân viên id", "xóa sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            txt_idnv.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_hovaten.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            dt_nsinh.Value = (DateTime)dataGridView1.CurrentRow.Cells[2].Value;
            txt_sdt.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_luong.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
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

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_user_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        public static string HashPasswordUsingMD5(string password)
        {
            using (var md5 = MD5.Create())
            {
                byte[] passwordBytes = Encoding.ASCII.GetBytes(password);

                byte[] hash = md5.ComputeHash(passwordBytes);

                var stringBuilder = new StringBuilder();

                for (int i = 0; i < hash.Length; i++)
                    stringBuilder.Append(hash[i].ToString("X2"));

                return stringBuilder.ToString();
            }
        }

        private void dataGridView1_Click_1(object sender, EventArgs e)
        {
            try
            {
                txt_idnv.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txt_hovaten.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txt_sdt.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                dt_nsinh.Value = (DateTime)dataGridView1.CurrentRow.Cells[3].Value;
                txt_luong.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                txt_username.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                txt_password.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        private void btn_timid_Click_1(object sender, EventArgs e)
        {
            DAONhanVien nv = new DAONhanVien();
            DataTable dt = new DataTable();
            if (txt_timkiem.Text != "")
            {
                int id_tim = Int32.Parse(txt_timkiem.Text);
                dt = nv.GetNhanVienByID(id_tim);
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("vui lòng nhập nhân viên id", "xóa sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        private void txt_hovaten_TextChanged(object sender, EventArgs e)
        {
            //txt_hovaten.TextChanged += txt_hovaten_TextChanged;
        }

        private void txt_sdt_TextChanged(object sender, EventArgs e)
        {
            //txt_sdt.TextChanged += txt_sdt_TextChanged;
        }

        private void txt_luong_TextChanged(object sender, EventArgs e)
        {
            //txt_luong.TextChanged += txt_luong_TextChanged;
        }
        private void dt_nsinh_ContextMenuStripChanged(object sender, EventArgs e)
        {
        }

        private void btn_them_Click_1(object sender, EventArgs e)
        {
            if (rong())
            {
                MessageBox.Show("không được để rỗng");
            }
            else
            {
                DAONhanVien nv = new DAONhanVien();
                NhanVien NV = new NhanVien();
                NV.Sdt = txt_sdt.Text;
                //NV.MaNv = int.Parse(txt_idnv.Text);
                NV.Hoten = txt_hovaten.Text;
                // MessageBox.Show(NV.Hoten);
                NV.Luong = float.Parse(txt_luong.Text);
                NV.Sdt = txt_sdt.Text;
                NV.Ngaysinh = Convert.ToDateTime(dt_nsinh.Value);
                NV.Username = txt_username.Text;
                NV.Password = HashPasswordUsingMD5(txt_password.Text);
                NV.MaNql = Globals.NV;
                NV.Role = "employee";
                //MessageBox.Show(NV.Luong.ToString());
                //MessageBox.Show(NV.Hoten.ToString());
                //MessageBox.Show(NV.Sdt.ToString());
                //MessageBox.Show(NV.Username.ToString());
                //MessageBox.Show(NV.Password.ToString());
                //MessageBox.Show(NV.MaNql.ToString());
                //MessageBox.Show(NV.Role.ToString());
                nv.themNV(NV);
                //txt_password.Text = NV.Password;
            }
        
    }

        private void btn_sua_Click_1(object sender, EventArgs e)
        {
            if (rong())
            {
                MessageBox.Show("không được để rỗng");
            }
            else
            {
                DAONhanVien nv = new DAONhanVien();
                NhanVien NV = new NhanVien();
                NV.Sdt = txt_sdt.Text;
                NV.MaNv = int.Parse(txt_idnv.Text);
                NV.Hoten = txt_hovaten.Text;
               // MessageBox.Show(NV.Hoten);
                NV.Luong = float.Parse(txt_luong.Text);
                NV.Sdt = txt_sdt.Text;
                NV.Ngaysinh =Convert.ToDateTime(dt_nsinh.Value);
                NV.Username = txt_username.Text;
                NV.Password = HashPasswordUsingMD5(txt_password.Text);
                nv.suaNV(NV);
            }
        }

        private void btn_xoa_Click_1(object sender, EventArgs e)
        {
            if (rong())
            {
                MessageBox.Show("không được để rỗng");
            }
            else
            {
                DAONhanVien nv = new DAONhanVien();
                NhanVien NV = new NhanVien();
                NV.MaNv = int.Parse(txt_idnv.Text);
                if (NV.MaNv != Globals.NV)
                {
                    nv.xoaNV(NV.MaNv);
                }
                else
                {
                    MessageBox.Show("Ban đang xóa tài khoản của chính bạn ");
                }
            }
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {

                txt_idnv.Text = "";
                txt_hovaten.Text = "";
                txt_sdt.Text = "";
                txt_luong.Text = "";
                txt_username.Text = "";
                txt_password.Text = "";
                txt_timkiem.Text = "";
                txt_search.Text = "";

                DAONhanVien nv = new DAONhanVien();
                DataTable dt = new DataTable();
                dt = nv.getNhanVien();
                dataGridView1.DataSource = dt;

        }

        private void btn_refresh_Click_1(object sender, EventArgs e)
        {
            txt_idnv.Text = "";
            txt_hovaten.Text = "";
            txt_sdt.Text = "";
            txt_luong.Text = "";
            txt_username.Text = "";
            txt_password.Text = "";
            txt_timkiem.Text = "";
            txt_search.Text = "";

            DAONhanVien nv = new DAONhanVien();
            DataTable dt = new DataTable();
            dt = nv.getNhanVien();
            dataGridView1.DataSource = dt;
        }

        private void btn_tim_Click(object sender, EventArgs e)
        {
            DAONhanVien nv = new DAONhanVien();
            NhanVien NV = new NhanVien();
            DataTable dt = new DataTable();
            if (txt_search.Text == "")
            {
                MessageBox.Show("không được để rỗng");
            }
            else
            {
                NV.Hoten = NV.Username = txt_search.Text;
                dt = nv.GetNhanVienBySearch(NV);
                dataGridView1.DataSource = dt;
            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
