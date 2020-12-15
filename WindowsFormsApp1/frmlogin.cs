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
                    command.Parameters.Add("@pass", SqlDbType.NVarChar).Value = txt_pass.Text;
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    
                   
                   // MessageBox.Show(table.Rows.Count.ToString());
                    for (int i = 0; i < table.Rows.Count ; i++)
                    {

                        if (table.Rows[i].ItemArray[0] != null)
                        {
                            string a = table.Rows[i].ItemArray[1].ToString();
                            if (a=="employee")
                            {
                                Globals.SetNV (Convert.ToInt32(table.Rows[i].ItemArray[0]));
                                frmmaunhanvien frm = new frmmaunhanvien();
                                frm.ShowDialog();
                            }
                            else
                            {
                                Globals.SetNV(Convert.ToInt32(table.Rows[i].ItemArray[0]));
                                frmmau frm = new frmmau();
                                frm.ShowDialog();
                            }
                        }
                        else
                        {
                            MessageBox.Show("ban da nhap sai ten tai khoan hoac mat khau");
                        }

                    }
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
            DataTable l = new DataTable();
            Chitiethoadon = l;
        } // default value

        // public get, and private set for strict access control
        public static int Mahoadon { get; private set; }
        public static DataTable Chitiethoadon { get; private set; }
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
        public static void SetChiTietHoaDon(DataTable a)
        {
            Chitiethoadon = a;
        }
    }
}

