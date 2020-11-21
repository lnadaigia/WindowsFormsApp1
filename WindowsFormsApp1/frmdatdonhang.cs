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
    public partial class frmdatdonhang : Form
    {
        public frmdatdonhang()
        {
            InitializeComponent();
        }
        private string ban="2";
        private int madonhang = 1;
        public int setma_donhang
        {
            set { madonhang = value; }
        }
        public string setban
        {
            set { this.ban = value; }
        }
       
        void loaddoan()
        {
           
        }
        void loadkhach()
        {
            int[] mang = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            comboBox1.DataSource = mang;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            loadkhach();
           

        }
        int row=0;
        int max = 0;
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch { }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
           

        }
        float tongtien=0;
        //int hang = 0;
        void loaddonhang()
        {
            
           
            
        }
        private void btn_xemdonhang_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_dathang_Click(object sender, EventArgs e)
        {
                

        }

        private void btn_thanhtoan_Click(object sender, EventArgs e)
        {
            
        }
    }
}
