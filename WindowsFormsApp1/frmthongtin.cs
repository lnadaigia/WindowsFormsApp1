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
using WindowsFormsApp1.Model;

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

        //static DAONhanVien nv;
        //static NhanVien NV;
        
        void load()
        {
            //string query = "select * from NhanVien where manv = @manv";
            //lb_quanli.Text = "Chức vụ: Quản lý";
            //if (id[0] == 'n')
            //{
            //    query = "select * from NhanVien where manv = @manv";
            //    lb_quanli.Text = "Chức vụ: Nhân viên";
            //}
            //SqlCommand command = new SqlCommand(query);
            //command.Parameters.Add("@manv", SqlDbType.NVarChar).Value = id;
            DAONhanVien nv = new DAONhanVien();
            NhanVien NVien = new NhanVien();
            NVien = nv.getNhanVienByID(Globals.NV);
            txt_idql.Text = NVien.MaNv.ToString();
            txt_hovaten.Text = NVien.Hoten;
            txt_sdt.Text = NVien.Sdt;
            txt_username.Text = NVien.Username;
            dt_nsinh.Value = NVien.Ngaysinh;
            if (NVien.Role=="manager")
            {
                lb_quanli.Text = "Chức vụ: Quản lý";
            }
            else
            {
                lb_quanli.Text = "Chức vụ: Nhân viên";
            }
        }
        void sua()
        {
            string manv = txt_idql.Text;
            string hovaten = txt_hovaten.Text;
            DateTime namsinh = dt_nsinh.Value;
            string sdt = txt_sdt.Text;
            string uname = txt_username.Text;
            if (manv == ""||hovaten==""||sdt==""||uname=="")
            {
                MessageBox.Show("không được để trống");
            }
            else
            {
                DAONhanVien nv = new DAONhanVien();
                NhanVien NV = nv.getNhanVienByID(Globals.NV);
                NV.Sdt = txt_sdt.Text;
                NV.MaNv = int.Parse(txt_idql.Text);
                NV.Hoten = txt_hovaten.Text;
                NV.Sdt = txt_sdt.Text;
                NV.Ngaysinh = Convert.ToDateTime(dt_nsinh.Value);
                NV.Username = txt_username.Text;
                nv.suaNV(NV);
                MessageBox.Show("Sua thong tin thanh cong");
            }
        }
        private void frmthongtin_Load(object sender, EventArgs e)
        {
            load();
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_doimk_Click_1(object sender, EventArgs e)
        {
            frmdoimk frm = new frmdoimk();
            frm.ShowDialog();
        }

        private void btn_sua_Click_1(object sender, EventArgs e)
        {
            try
            {
                sua();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
