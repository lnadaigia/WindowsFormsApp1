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
    public partial class frmdsdoan : Form
    {
        public frmdsdoan()
        {
            InitializeComponent();
        }
       
        void loaddoan()
        {
            DAOMonAn monan = new DAOMonAn();
            DataTable tb = new DataTable();
            tb = monan.getMonAn();
            dataGridView1.DataSource = tb;
            dataGridView1.AllowUserToAddRows = false;
        }
        void loadnguyenlieu()
        {

            DAONguyenLieu nl = new DAONguyenLieu();
            DataTable tb1 = new DataTable();

            tb1 = nl.getNguyenLieu();

            tb1.Columns.Add("check", typeof(bool));
            foreach (DataRow row in tb1.Rows)
            {
                row["check"] = false;
            }
            tb1.Columns.Add("soluong", typeof(float));
            foreach (DataRow row in tb1.Rows)
            {
                row["soluong"] = 0;
            }
            dataGridView2.DataSource = tb1;
            dataGridView2.AllowUserToAddRows = false;
        }

        int id_doan = 0;
        DAOMonAn ma = new DAOMonAn();
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    row.Cells[2].Value = false;
                    row.Cells[3].Value = 0;
                }
                id_doan = (int)dataGridView1.CurrentRow.Cells[0].Value;
                txt_tendoan.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();

                DataTable table = ma.getNguyenlieutheomonan(id_doan);
                foreach (DataGridViewRow gridViewRow in dataGridView2.Rows)
                {
                    
                    int id_nguyenlieu = (int)gridViewRow.Cells[0].Value;
                    foreach (DataRow row in table.Rows)
                    {
                        int id_nl = (int)row.ItemArray[1];
                        if (id_nguyenlieu == id_nl)
                        {
                            gridViewRow.Cells[2].Value = true;
                            gridViewRow.Cells[3].Value = row.ItemArray[2];
                            break;
                        }
                    }
                }
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
            
            
        }

        private void frmthemdoan_nguyenlieu_Load(object sender, EventArgs e)
        {
			try
			{
                loaddoan();
                loadnguyenlieu();

			}
			catch
			{

			}
        }

        private void btn_themdoan_Click(object sender, EventArgs e)
        {
            try
            {
                MonAn m = new MonAn();
                m.Tenmonan = txt_tendoan.Text;
                if (ma.themmonan(m))
                {
                    MessageBox.Show("thêm món ăn thành công");
                }
                else
                {
                    MessageBox.Show("thêm món ăn thất bại");
                }
                loaddoan();
            }
            catch { }
        }

        private void btn_xoadoan_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("bạn có muốn xóa "+ txt_tendoan.Text, "xóa món ăn", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    MonAn m = new MonAn();
                    m.Tenmonan = txt_tendoan.Text;
                    m.Mamonan = id_doan;
                    if (ma.xoamonan(m))
                    {
                        MessageBox.Show("xóa món ăn thành công");
                    }
                    else
                    {
                        MessageBox.Show("xóa món ăn thất bại");
                    }
                    loaddoan();
                }
            }
            catch { }
        }

        private void btn_suadoan_Click(object sender, EventArgs e)
        {
            try
            {
                MonAn m = new MonAn();
                m.Tenmonan = txt_tendoan.Text;
                m.Mamonan = id_doan;
                if (ma.suamonan(m))
                {
                    MessageBox.Show("sửa món ăn thành công");
                }
                else
                {
                    MessageBox.Show("sửa món ăn thất bại");
                }
                loaddoan();
            }
            catch(Exception ex) { MessageBox.Show(ex.ToString()); }



        }
        DAONguyenLieu nl = new DAONguyenLieu();
        private void txt_themnl_Click(object sender, EventArgs e)
        {
            try
            {
                NguyenLieu m = new NguyenLieu();
                m.Tennguyenlieu = txt_tennl.Text;
                if (nl.themnl(m))
                {
                    MessageBox.Show("thêm nguyên liệu thành công");
                }
                else
                {
                    MessageBox.Show("thêm nguyên liệu thất bại");
                }
                loadnguyenlieu();
            }
            catch { }
        }

        private void btn_xoanl_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("bạn có muốn xóa " + txt_tennl.Text, "xóa nguyên liệu", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    NguyenLieu m = new NguyenLieu();
                    m.Tennguyenlieu = txt_tennl.Text;
                    m.Manguyenlieu = id_nl;
                    if (nl.xoanl(m))
                    {
                        MessageBox.Show("xóa nguyên liệu thành công");
                    }
                    else
                    {
                        MessageBox.Show("xóa nguyên liệu thất bại");
                    }
                    loadnguyenlieu();
                }
            }
            catch { }
        }
        
        private void btn_suanl_Click(object sender, EventArgs e)
        {
            try
            {
                NguyenLieu m = new NguyenLieu();
                m.Tennguyenlieu = txt_tennl.Text;
                m.Manguyenlieu = id_nl;
                if (nl.suanl(m))
                {
                    MessageBox.Show("sửa nguyên liệu thành công");
                }
                else
                {
                    MessageBox.Show("sửa nguyên liệu thất bại");
                }
                loadnguyenlieu();
            }
            catch { }
        }
        int id_nl = 0;
        private void dataGridView2_Click(object sender, EventArgs e)
        {
            try
            {
                id_nl = (int)dataGridView2.CurrentRow.Cells[0].Value;
                txt_tennl.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            }
            catch { }
        }

        private void btn_chinhsua_Click(object sender, EventArgs e)
        {
            try
            {
                if (id_doan != 0)
                {
                    DataTable dt = new DataTable();
                    dt.Columns.Add(new DataColumn("manl", typeof(int)));
                    dt.Columns.Add(new DataColumn("mamonan", typeof(int)));
                    dt.Columns.Add(new DataColumn("soluong", typeof(float)));
                    DataTable dt2 = new DataTable();
                    dt2.Columns.Add(new DataColumn("manl", typeof(int)));
                    dt2.Columns.Add(new DataColumn("mamonan", typeof(int)));
                    dt2.Columns.Add(new DataColumn("soluong", typeof(float)));
                    foreach (DataGridViewRow row in dataGridView2.Rows)
                    {
                        if ((bool)row.Cells[2].Value)
                        {
                            dt.Rows.Add((int)row.Cells[0].Value, id_doan, float.Parse(row.Cells[3].Value.ToString()));
                        }
                        else
                        {
                            dt2.Rows.Add((int)row.Cells[0].Value, id_doan, float.Parse(row.Cells[3].Value.ToString()));
                        }
                    }
                   
                    ma.xoact(dt2,id_doan);
                    ma.updatect(dt,id_doan);

                    
                }
                loaddoan();
                loadnguyenlieu();
            }
            catch (Exception ex){ MessageBox.Show(ex.Message); }
        }

        private void txt_tennl_Validating(object sender, CancelEventArgs e)
        {
            
        }
	}
}
