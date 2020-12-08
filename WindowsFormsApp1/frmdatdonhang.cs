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
        void loadmonan()
        {
            DAODoAntheongay doan = new DAODoAntheongay();
            dtg_doan.DataSource = doan.getMonAndeban();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                dtg_doan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dtg_chitiet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dtg_doan.AllowUserToAddRows = false;
                dtg_chitiet.AllowUserToDeleteRows = false;
                dtg_doan.ReadOnly = true;
                dtg_chitiet.ReadOnly = true;
                numericUpDown1.Visible = false;
                loadkhach();
                loadmonan();
            }
            catch { }

           

        }
        int row=0;
        int max = 0;
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            try
            {
                numericUpDown1.Visible = true;
                max = (int)dtg_doan.CurrentRow.Cells[3].Value + (int)dtg_doan.CurrentRow.Cells[4].Value;
                numericUpDown1.Maximum = max;
                int x = dtg_doan.CurrentRow.Index;
                row = x;
                Rectangle rectangle = dtg_doan.GetCellDisplayRectangle(0, x, true);
                numericUpDown1.Location = new Point(465, rectangle.Y);
                numericUpDown1.Value = (int)dtg_doan.Rows[row].Cells[4].Value;
            }
            catch { }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            dtg_doan.Rows[row].Cells[4].Value = numericUpDown1.Value;
            dtg_doan.Rows[row].Cells[3].Value = max - numericUpDown1.Value;
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
