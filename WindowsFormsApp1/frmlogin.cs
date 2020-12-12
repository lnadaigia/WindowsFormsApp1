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
namespace GlobalVariables
{
    public static class Globals
    {
        // parameterless constructor required for static class
        static Globals()
        {   
            Maban = 1234;
            NumberofPeople = 0;
            NV = 1;
            Mahoadon = 30;
        } // default value

        // public get, and private set for strict access control
        public static int Mahoadon { get; private set; }
        public static int Maban { get; private set; }
        public static int NumberofPeople { get; private set; }
        public static int NV { get; private set; }
        // GlobalInt can be changed only via this method
        public static void SetMaban(int newInt)
        {
            Maban = newInt;
        }
        public static void SetMahoadon(int newInt)
        {
            Mahoadon = newInt;
        }
        public static void SetNumbleOfpeople(int newInt)
        {
            NumberofPeople = newInt;
        }
        public static void SetNV(int newInt)
        {
            NV = newInt;
        }

    }
}

