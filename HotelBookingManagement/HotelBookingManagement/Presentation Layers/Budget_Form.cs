using HotelBookingManagement.Busines_Logic_Layers;
using HotelBookingManagement.Data_Access_Layers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelBookingManagement.Presentation_Layers
{
    public partial class Budget_Form : Form
    {
        public Budget_Form()
        {
            InitializeComponent();
            this.radioButton_TheoThang.Checked = true;
            this.textBox_NhapNam.Text = DateTime.Now.Year.ToString();
        }

        private void Budget_Form_Load(object sender, EventArgs e)
        {
            this.textBox_TienDien.KeyPress += Normalisation.TextboxOnlyDigit_KeyPress;
            this.textBox_TienNuoc.KeyPress += Normalisation.TextboxOnlyDigit_KeyPress;
            this.textBox_TienBaoTri.KeyPress += Normalisation.TextboxOnlyDigit_KeyPress;
            this.textBox_ChiPhiKhac.KeyPress += Normalisation.TextboxOnlyDigit_KeyPress;
            this.textBox_NhapNam.KeyPress += Normalisation.TextboxOnlyDigit_KeyPress;
        }
        private void TinhTong(object sender, EventArgs e)
        {
            int T_Dien = 0, T_Nuoc = 0, T_BaoTri = 0, T_Khac = 0;
            try
            {
                if (textBox_TienDien.Text != null) T_Dien = int.Parse(textBox_TienDien.Text);
                if (textBox_TienNuoc.Text != null) T_Nuoc = int.Parse(textBox_TienNuoc.Text);
                if (textBox_TienBaoTri.Text != null) T_BaoTri = int.Parse(textBox_TienBaoTri.Text);
                if (textBox_ChiPhiKhac.Text != null) T_Khac = int.Parse(textBox_ChiPhiKhac.Text);
            }
            catch
            {

            }
            textBox_TongTien.Text = (T_Dien + T_Nuoc + T_BaoTri + T_Khac).ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button_XacNhan_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Xác nhận thống kê chi tiêu", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    ProfitStatistics_Controller.ThemChiTieu(textBox_TienDien.Text, textBox_TienNuoc.Text, textBox_TongTien.Text, textBox_TienBaoTri.Text, textBox_ChiPhiKhac.Text, dateTimePicker_NgayThongKe.Value);
                }
            }
            catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void radioButton_TheoThang_CheckedChanged(object sender, EventArgs e)
        {
            this.textBox_NhapNam.Enabled = true;
        }

        private void radioButton_TheoNam_CheckedChanged(object sender, EventArgs e)
        {
            this.textBox_NhapNam.Enabled = false;
        }

        private void Normalize(object sender, KeyPressEventArgs e)
        {
            Normalisation.TextboxOnlyDigit_KeyPress(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var CheckButton = this.groupBox2.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
                switch (CheckButton.Name)
                {
                    case "radioButton_TheoThang":
                        this.Char_Fill("Months", ThuChi_DAL.Instance.getChartData(this.textBox_NhapNam.Text));
                        break;
                    case "radioButton_TheoNam":
                        this.Char_Fill("Months", ThuChi_DAL.Instance.getChartData());
                        break;
                }

            }
            catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        private void Char_Fill(string Loai, DataSet data)
        {
            this.chart_Budget.DataSource = data;
            switch (Loai)
            {
                case "Weeks":

                    break;
                case "Months":
                    //set data
                    this.chart_Budget.Series[0].XValueMember = "Thang";
                    this.chart_Budget.Series[0].YValueMembers = "Tien_thu";
                    this.chart_Budget.Series[1].XValueMember = "Thang";
                    this.chart_Budget.Series[1].YValueMembers = "Tien_Chi";
                    this.chart_Budget.Series[2].XValueMember = "thang";
                    this.chart_Budget.Series[2].YValueMembers = "Loi_Nhuan";
                    //secondary Axis
                    this.chart_Budget.ChartAreas[0].AxisY2.MajorGrid.Enabled = false;
                    this.chart_Budget.ChartAreas[0].AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
                    this.chart_Budget.ChartAreas[0].AxisY2.IsStartedFromZero = this.chart_Budget.ChartAreas[0].AxisY.IsStartedFromZero;
                    this.chart_Budget.Series[2].YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
                    //set title
                    this.chart_Budget.ChartAreas[0].AxisX.Title = "Tháng";
                    this.chart_Budget.ChartAreas[0].AxisX.TitleAlignment = System.Drawing.StringAlignment.Near;
                    this.chart_Budget.ChartAreas[0].AxisX.TitleFont = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.chart_Budget.ChartAreas[0].AxisY.Title = "Thu Chi";
                    this.chart_Budget.ChartAreas[0].AxisY.TitleAlignment = System.Drawing.StringAlignment.Center;
                    this.chart_Budget.ChartAreas[0].AxisY.TitleFont = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.chart_Budget.ChartAreas[0].AxisY2.Title = "Lợi Nhuận";
                    this.chart_Budget.ChartAreas[0].AxisY2.TitleAlignment = System.Drawing.StringAlignment.Center;
                    this.chart_Budget.ChartAreas[0].AxisY2.TitleFont = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    break;
                case "Years":

                    break;
            }
        }
    }
}
