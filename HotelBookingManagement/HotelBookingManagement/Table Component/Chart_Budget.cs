using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelBookingManagement.Table_Component
{
    public partial class Chart_Budget : Control //
    {
        public Chart_Budget()
        {
            InitializeComponent();
        }

        public Chart_Budget(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public void Char_Fill(string Loai, DataSet data)
        {
            this.chart1.DataSource = data;
            switch (Loai)
            {
                case "Weeks":

                    break;
                case "Months":
                    //set data
                    this.chart1.Series[0].XValueMember = "Thang";
                    this.chart1.Series[0].YValueMembers = "Tien_thu";
                    this.chart1.Series[1].XValueMember = "Thang";
                    this.chart1.Series[1].YValueMembers = "Tien_Chi";
                    this.chart1.Series[2].XValueMember = "thang";
                    this.chart1.Series[2].YValueMembers = "Loi_Nhuan";
                    //secondary Axis
                    this.chart1.ChartAreas[0].AxisY2.MajorGrid.Enabled = false;
                    this.chart1.ChartAreas[0].AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
                    this.chart1.ChartAreas[0].AxisY2.IsStartedFromZero = this.chart1.ChartAreas[0].AxisY.IsStartedFromZero;
                    this.chart1.Series[2].YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
                    //set title
                    this.chart1.ChartAreas[0].AxisX.Title = "Tháng";
                    this.chart1.ChartAreas[0].AxisX.TitleAlignment = System.Drawing.StringAlignment.Near;
                    this.chart1.ChartAreas[0].AxisX.TitleFont = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.chart1.ChartAreas[0].AxisY.Title = "Thu Chi";
                    this.chart1.ChartAreas[0].AxisY.TitleAlignment = System.Drawing.StringAlignment.Center;
                    this.chart1.ChartAreas[0].AxisY.TitleFont = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.chart1.ChartAreas[0].AxisY2.Title = "Lợi Nhuận";
                    this.chart1.ChartAreas[0].AxisY2.TitleAlignment = System.Drawing.StringAlignment.Center;
                    this.chart1.ChartAreas[0].AxisY2.TitleFont = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    break;
                case "Years":

                    break;
            }
        }
    }
}
