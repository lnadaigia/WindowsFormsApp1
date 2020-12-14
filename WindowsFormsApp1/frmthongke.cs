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
using System.Windows.Forms.DataVisualization.Charting;
using WindowsFormsApp1.DAO;

namespace WindowsFormsApp1
{
    public partial class frmthongke : Form
    {
        public frmthongke()
        {
            InitializeComponent();
        }
        DAOMonAn ma = new DAOMonAn();
        DAOHoaDon hd = new DAOHoaDon();
        void loaddothi(string query)
        {
            chart1.ChartAreas.Clear();
            chart1.ChartAreas.Add("ChartArea1");
            chart1.Series.Clear();
            chart2.Series.Clear();
            chart1.Series.Add("Salary");
            chart2.Series.Add("Salary");

            DateTime ngay = dt_ngay.Value;
            DateTime dau = dt_dau.Value;
            DateTime sau = dt_sau.Value;
            int thang = (int)comboBox1.SelectedValue;
            DataTable table = ma.thongkemonan(query,dau,sau,ngay,thang);
            int a = 1;
            if (rdb_gia.Checked)
                a = 2; 
            foreach (DataRow row in table.Rows)
            {
                chart1.Series["Salary"].Points.AddXY(row.ItemArray[0].ToString(), float.Parse(row.ItemArray[a].ToString()));
                chart2.Series["Salary"].Points.AddXY(row.ItemArray[0].ToString(), float.Parse(row.ItemArray[a].ToString()));
            }

            chart2.Series[0].ChartType = SeriesChartType.Pie;
        }
        void loadtong_doanhthu(int thang)
        {
            chart3.Series.Clear();
            chart3.Series.Add("Salary");
           
            DataTable table =hd.thongkedoanhthu(thang);
            dataGridView1.DataSource = table;
            foreach (DataRow row in table.Rows)
            {
                DateTime ngay = (DateTime)row.ItemArray[0];
                chart3.Series["Salary"].Points.AddXY(ngay, float.Parse(row.ItemArray[1].ToString()));
            }
        }
        private void frmthongke_Load(object sender, EventArgs e)
        {
            try
            {
                int[] thang = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
                comboBox1.DataSource = thang;
                loaddothi(" and CONVERT(date, hd.Thoigian) = convert(date, GETDATE())");
                loadtong_doanhthu((int)DateTime.Today.Month);
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "";
               

                if (rdb_chonngay.Checked)
                {
                    query = " and CONVERT(date,hd.Thoigian)=@ngay";

                }
                else if (rdb_chonkhoang.Checked)
                {
                    query = " and CONVERT(date,hd.Thoigian) between @dau and @sau";
                }
                else
                {
                    query = " and YEAR(hd.Thoigian)=YEAR(GETDATE()) and month(hd.Thoigian)=@thang";
                    loadtong_doanhthu((int)comboBox1.SelectedValue);
                }
                loaddothi(query);
                
            }
            catch (Exception ex){ MessageBox.Show(ex.ToString()); }
        }
    }
}
