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

        }
        private void btn_cancer_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void frmlogin_Load(object sender, EventArgs e)
        {

        }

        private void btn_cancer_Click_1(object sender, EventArgs e)
        {
            this.Close();
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
        private void txt_pass_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_login_Click_1(this, new EventArgs());
            }
        }
        private void btn_login_Click_1(object sender, EventArgs e)
        {
            MY_DB db = new MY_DB();
            try
            {
                if (txt_user.Text == "" || txt_pass.Text == "")
                {
                    MessageBox.Show("không được để trống");
                }
                else
                {
                    SqlCommand command = new SqlCommand("SELECT MaNV,Role from NhanVien WHERE NhanVien.UserName=@user AND Password=@pass", db.GetConnection);
                    command.Parameters.Add("@user", SqlDbType.NVarChar).Value = txt_user.Text;
                    command.Parameters.Add("@pass", SqlDbType.NVarChar).Value = HashPasswordUsingMD5(txt_pass.Text);
                    //MessageBox.Show(HashPasswordUsingMD5(txt_pass.Text));
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    // MessageBox.Show(table.Rows.Count.ToString());
                    int count= table.Rows.Count;
                    if (count ==0)
                    {
                        MessageBox.Show("ban da nhap sai ten tai khoan hoac mat khau");
                    }
                    for (int i = 0; i <count ; i++)
                    {
                        if (table.Rows[i].ItemArray[0] != null)
                        {
                            string a = table.Rows[i].ItemArray[1].ToString();

                            if (a == "employee")
                            {
                                Globals.SetNV(Convert.ToInt32(table.Rows[i].ItemArray[0]));
                                Globals.SetRole("employee");
                                frmmaunhanvien frm = new frmmaunhanvien();
                                frm.ShowDialog();
                            }
                            else
                            {
                                Globals.SetNV(Convert.ToInt32(table.Rows[i].ItemArray[0]));
                                Globals.SetRole("manager");
                                frmmau frm = new frmmau();
                                frm.ShowDialog();
                            }
                        }
                       

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_pass_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_login_Click_1(this, new EventArgs());
            }
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
            role = "employee";
            DataTable l = new DataTable();
            Chitiethoadon = l;
        } // default value

        // public get, and private set for strict access control
        public static string role { get; private set; }
        public static int Mahoadon { get; private set; }
        public static DataTable Chitiethoadon { get; private set; }
        public static int Maban { get; private set; }
        public static int NumberofPeople { get; private set; }
        public static int NV { get; private set; }
        //public static string NRole { get; private set; }
        // GlobalInt can be changed only via this method
        public static void SetRole(string roles)
        {
            role = roles;
        }
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
        public static void SetChiTietHoaDon(DataTable a)
        {
            Chitiethoadon = a;
        }
        //public static void SetNRole(string newString)
        //{
        //    NRole = newString;
        //}
    }
}
