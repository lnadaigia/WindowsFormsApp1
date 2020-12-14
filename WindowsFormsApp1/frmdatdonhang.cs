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
        DAOHoaDon hd = new DAOHoaDon();
        void loadhoadon()
        {
            DataTable dh = hd.getHoaDonbyban(1);
            dt = dh.Clone();
            foreach (DataRow row in dh.Rows)
            {
                dt.Rows.Add(row[0],row[1],row[2],row[3],row[4]);
            }
            dtg_chitiet.DataSource = dt;
            foreach (DataGridViewRow row in dtg_doan.Rows)
            {
                int soluong = 0;
                foreach (DataGridViewRow r in dtg_chitiet.Rows)
                {
                    if (r.Cells[0].Value.ToString() == row.Cells[0].Value.ToString())
                    {
                        soluong = (int)r.Cells[2].Value;
                    }
                }
                row.Cells[4].Value = soluong;
            }

        }
        DataTable dt = new DataTable();
       
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                dtg_doan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dtg_chitiet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dtg_doan.AllowUserToAddRows = false;
                dtg_chitiet.AllowUserToAddRows = false;
                dtg_doan.ReadOnly = true;
                dtg_chitiet.ReadOnly = true;
                numericUpDown1.Visible = false;
                loadkhach();
                loadmonan();
                loadhoadon();

                /*
                dt.Columns.Add(new DataColumn("mamonan", typeof(int)));
                dt.Columns.Add(new DataColumn("tenmonan", typeof(string)));
                dt.Columns.Add(new DataColumn("soluong", typeof(int)));
                dt.Columns.Add(new DataColumn("gia", typeof(float)));
                dt.Columns.Add(new DataColumn("thanhtien", typeof(float)));
                */
                
             

            }
            catch { }

           

        }
        int row=1;
        int max = 0;
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            try
            {
                numericUpDown1.Visible = true;
           
                max = (int)dtg_doan.CurrentRow.Cells[3].Value + (int)dtg_doan.CurrentRow.Cells[4].Value;
                numericUpDown1.Maximum = max;
                row= dtg_doan.CurrentRow.Index;


                Rectangle rectangle = dtg_doan.GetCellDisplayRectangle(0, row, true);
                numericUpDown1.Location = new Point(465, rectangle.Y);
                //numericUpDown1.Value = (int)dtg_doan.Rows[row].Cells[4].Value;
                numericUpDown1.Value = (int)dtg_doan.CurrentRow.Cells[4].Value;
            }
            catch (Exception ex){ MessageBox.Show(ex.ToString()); }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                //MessageBox.Show("" + max+" "+ dtg_doan.Rows[row].Cells[3].Value+" "+ dtg_doan.Rows[row].Cells[4].Value);
                if (max == (int)dtg_doan.Rows[row].Cells[3].Value + (int)dtg_doan.Rows[row].Cells[4].Value)
                {
                    dtg_doan.Rows[row].Cells[4].Value = numericUpDown1.Value;
                    dtg_doan.Rows[row].Cells[3].Value = max - numericUpDown1.Value;
                    loaddonhang();
                }
                
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); 
        }
    }
 
        //int hang = 0;
        void loaddonhang()
        {
            int mamonan = (int)dtg_doan.Rows[row].Cells[0].Value;
            string tenmonan = dtg_doan.Rows[row].Cells[1].Value.ToString();
            int soluong = (int)dtg_doan.Rows[row].Cells[4].Value;
            float gia = float.Parse(dtg_doan.Rows[row].Cells[2].Value.ToString());
            float thanhtien = gia * soluong;
            int dem = 0;
            foreach(DataRow row in dt.Rows)
            {
                if (row.ItemArray[0].ToString() == mamonan.ToString())
                {
                    row[2] = soluong;
                    row[4] = thanhtien;
                }
                else
                    dem++;
            }
            if(dt.Rows.Count==dem)
                dt.Rows.Add(mamonan, tenmonan, soluong, gia, thanhtien);
            float tong = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow row = dt.Rows[i];
                if (row[4].ToString() == "0")
                {
                    row.Delete();
                }
                else
                    tong = tong + float.Parse(row[4].ToString());
            }
            dtg_chitiet.DataSource = dt;
            txt_tongtien.Text = tong.ToString();

        }
        private void btn_xemdonhang_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_dathang_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable ct = new DataTable();
                ct.Columns.Add(new DataColumn("mamonan", typeof(int)));
                ct.Columns.Add(new DataColumn("soluong", typeof(int)));
                foreach (DataRow row in dt.Rows)
                {
                    ct.Rows.Add(row[0],row[2]);
                }
                //hd.updatect(ct,1);
                hd.themchitiet(ct, 15);
                loadkhach();
                loadmonan();
                loadhoadon();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }

        private void btn_thanhtoan_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("bạn có muốn thanh toán hóa đơn không", "thanh toán", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (hd.thanhtoan(1))
                    {
                        MessageBox.Show("thanh toán thành công");
                        loadkhach();
                        loadhoadon();
                        loadmonan();
                    }
                    else
                        MessageBox.Show("thanh toán thất bại");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }
    }
}
