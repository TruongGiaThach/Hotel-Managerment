using HotelBookingManagement.Table_Component;

namespace HotelBookingManagement.Presentation_Layers
{
    partial class Budget_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        //private Budget_Table Table;
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Budget_Form));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.chart_Budget = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_NhapNam = new System.Windows.Forms.TextBox();
            this.radioButton_TheoNam = new System.Windows.Forms.RadioButton();
            this.radioButton_TheoThang = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_TongTien = new System.Windows.Forms.TextBox();
            this.button_XacNhan = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_TienNuoc = new System.Windows.Forms.TextBox();
            this.textBox_TienBaoTri = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_ChiPhiKhac = new System.Windows.Forms.TextBox();
            this.dateTimePicker_NgayThongKe = new System.Windows.Forms.DateTimePicker();
            this.textBox_TienDien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Budget)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "bank.png");
            this.imageList1.Images.SetKeyName(1, "money-bag.png");
            // 
            // chart_Budget
            // 
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.Name = "ChartArea1";
            this.chart_Budget.ChartAreas.Add(chartArea1);
            this.chart_Budget.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart_Budget.Legends.Add(legend1);
            this.chart_Budget.Location = new System.Drawing.Point(0, 299);
            this.chart_Budget.Name = "chart_Budget";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Thu Nhập";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Chi Tiêu";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Lợi Nhuận";
            this.chart_Budget.Series.Add(series1);
            this.chart_Budget.Series.Add(series2);
            this.chart_Budget.Series.Add(series3);
            this.chart_Budget.Size = new System.Drawing.Size(1280, 513);
            this.chart_Budget.TabIndex = 15;
            this.chart_Budget.Text = "chart1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1280, 299);
            this.panel2.TabIndex = 14;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.textBox_NhapNam);
            this.groupBox2.Controls.Add(this.radioButton_TheoNam);
            this.groupBox2.Controls.Add(this.radioButton_TheoThang);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(686, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(507, 266);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Xuất Biểu Đồ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(327, 37);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 20);
            this.label12.TabIndex = 8;
            this.label12.Text = "Nhập năm";
            // 
            // textBox_NhapNam
            // 
            this.textBox_NhapNam.Location = new System.Drawing.Point(283, 82);
            this.textBox_NhapNam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_NhapNam.Name = "textBox_NhapNam";
            this.textBox_NhapNam.Size = new System.Drawing.Size(199, 26);
            this.textBox_NhapNam.TabIndex = 9;
            // 
            // radioButton_TheoNam
            // 
            this.radioButton_TheoNam.AutoSize = true;
            this.radioButton_TheoNam.Location = new System.Drawing.Point(81, 85);
            this.radioButton_TheoNam.Name = "radioButton_TheoNam";
            this.radioButton_TheoNam.Size = new System.Drawing.Size(145, 24);
            this.radioButton_TheoNam.TabIndex = 8;
            this.radioButton_TheoNam.TabStop = true;
            this.radioButton_TheoNam.Text = "Xuất Theo Năm";
            this.radioButton_TheoNam.UseVisualStyleBackColor = true;
            this.radioButton_TheoNam.Click += new System.EventHandler(this.radioButton_TheoNam_CheckedChanged);
            // 
            // radioButton_TheoThang
            // 
            this.radioButton_TheoThang.AutoSize = true;
            this.radioButton_TheoThang.Location = new System.Drawing.Point(81, 42);
            this.radioButton_TheoThang.Name = "radioButton_TheoThang";
            this.radioButton_TheoThang.Size = new System.Drawing.Size(157, 24);
            this.radioButton_TheoThang.TabIndex = 7;
            this.radioButton_TheoThang.TabStop = true;
            this.radioButton_TheoThang.Text = "Xuất Theo Tháng";
            this.radioButton_TheoThang.UseVisualStyleBackColor = true;
            this.radioButton_TheoThang.Click += new System.EventHandler(this.radioButton_TheoThang_CheckedChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(184, 162);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 72);
            this.button2.TabIndex = 10;
            this.button2.Text = "Xem Biểu Đồ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_TongTien);
            this.groupBox1.Controls.Add(this.button_XacNhan);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_TienNuoc);
            this.groupBox1.Controls.Add(this.textBox_TienBaoTri);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox_ChiPhiKhac);
            this.groupBox1.Controls.Add(this.dateTimePicker_NgayThongKe);
            this.groupBox1.Controls.Add(this.textBox_TienDien);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(648, 266);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thống kê";
            // 
            // textBox_TongTien
            // 
            this.textBox_TongTien.Location = new System.Drawing.Point(418, 196);
            this.textBox_TongTien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_TongTien.Name = "textBox_TongTien";
            this.textBox_TongTien.ReadOnly = true;
            this.textBox_TongTien.Size = new System.Drawing.Size(194, 26);
            this.textBox_TongTien.TabIndex = 0;
            this.textBox_TongTien.TabStop = false;
            this.textBox_TongTien.Text = "0 đ";
            this.textBox_TongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button_XacNhan
            // 
            this.button_XacNhan.FlatAppearance.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.button_XacNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_XacNhan.Location = new System.Drawing.Point(433, 58);
            this.button_XacNhan.Name = "button_XacNhan";
            this.button_XacNhan.Size = new System.Drawing.Size(171, 56);
            this.button_XacNhan.TabIndex = 6;
            this.button_XacNhan.Text = "Xác Nhận";
            this.button_XacNhan.UseVisualStyleBackColor = true;
            this.button_XacNhan.Click += new System.EventHandler(this.button_XacNhan_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(465, 162);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tổng Chi";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 122);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 20);
            this.label10.TabIndex = 5;
            this.label10.Text = "Tiền Nước";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 162);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 20);
            this.label11.TabIndex = 5;
            this.label11.Text = "Tiền Bảo Trì";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 200);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Chi Phí Khác";
            // 
            // textBox_TienNuoc
            // 
            this.textBox_TienNuoc.Location = new System.Drawing.Point(191, 119);
            this.textBox_TienNuoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_TienNuoc.Name = "textBox_TienNuoc";
            this.textBox_TienNuoc.Size = new System.Drawing.Size(199, 26);
            this.textBox_TienNuoc.TabIndex = 3;
            this.textBox_TienNuoc.TextChanged += new System.EventHandler(this.TinhTong);
            // 
            // textBox_TienBaoTri
            // 
            this.textBox_TienBaoTri.Location = new System.Drawing.Point(191, 159);
            this.textBox_TienBaoTri.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_TienBaoTri.Name = "textBox_TienBaoTri";
            this.textBox_TienBaoTri.Size = new System.Drawing.Size(199, 26);
            this.textBox_TienBaoTri.TabIndex = 4;
            this.textBox_TienBaoTri.TextChanged += new System.EventHandler(this.TinhTong);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tiền Điện";
            // 
            // textBox_ChiPhiKhac
            // 
            this.textBox_ChiPhiKhac.Location = new System.Drawing.Point(191, 197);
            this.textBox_ChiPhiKhac.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_ChiPhiKhac.Name = "textBox_ChiPhiKhac";
            this.textBox_ChiPhiKhac.Size = new System.Drawing.Size(199, 26);
            this.textBox_ChiPhiKhac.TabIndex = 5;
            this.textBox_ChiPhiKhac.TextChanged += new System.EventHandler(this.TinhTong);
            // 
            // dateTimePicker_NgayThongKe
            // 
            this.dateTimePicker_NgayThongKe.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_NgayThongKe.Location = new System.Drawing.Point(191, 37);
            this.dateTimePicker_NgayThongKe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker_NgayThongKe.Name = "dateTimePicker_NgayThongKe";
            this.dateTimePicker_NgayThongKe.Size = new System.Drawing.Size(199, 26);
            this.dateTimePicker_NgayThongKe.TabIndex = 1;
            // 
            // textBox_TienDien
            // 
            this.textBox_TienDien.Location = new System.Drawing.Point(191, 79);
            this.textBox_TienDien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_TienDien.Name = "textBox_TienDien";
            this.textBox_TienDien.Size = new System.Drawing.Size(199, 26);
            this.textBox_TienDien.TabIndex = 2;
            this.textBox_TienDien.TextChanged += new System.EventHandler(this.TinhTong);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ngày Thống Kê:";
            // 
            // Budget_Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1280, 812);
            this.Controls.Add(this.chart_Budget);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Budget_Form";
            this.Text = "ThuChi";
            this.Load += new System.EventHandler(this.Budget_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart_Budget)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Budget;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox_NhapNam;
        private System.Windows.Forms.RadioButton radioButton_TheoNam;
        private System.Windows.Forms.RadioButton radioButton_TheoThang;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_TongTien;
        private System.Windows.Forms.Button button_XacNhan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_TienNuoc;
        private System.Windows.Forms.TextBox textBox_TienBaoTri;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_ChiPhiKhac;
        private System.Windows.Forms.DateTimePicker dateTimePicker_NgayThongKe;
        private System.Windows.Forms.TextBox textBox_TienDien;
        private System.Windows.Forms.Label label1;
    }
}