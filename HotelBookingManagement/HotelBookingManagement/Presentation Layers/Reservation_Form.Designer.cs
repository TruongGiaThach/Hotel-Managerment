using System;
namespace HotelBookingManagement
{
    partial class Reservation_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.label_HoVaTen = new System.Windows.Forms.Label();
            this.textBox_HoVaTen = new System.Windows.Forms.TextBox();
            this.label_CMND = new System.Windows.Forms.Label();
            this.textBox_CMND = new System.Windows.Forms.TextBox();
            this.label_SDT = new System.Windows.Forms.Label();
            this.textBox_SDT = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox_ThongTinDatPhong = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_LoaiPhong = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_SoPhong = new System.Windows.Forms.TextBox();
            this.button_DatPhong = new System.Windows.Forms.Button();
            this.button_Huy = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox_ThongTinDatPhong.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_HoVaTen
            // 
            this.label_HoVaTen.AutoSize = true;
            this.label_HoVaTen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_HoVaTen.Location = new System.Drawing.Point(9, 45);
            this.label_HoVaTen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_HoVaTen.Name = "label_HoVaTen";
            this.label_HoVaTen.Size = new System.Drawing.Size(163, 26);
            this.label_HoVaTen.TabIndex = 0;
            this.label_HoVaTen.Text = "Tên Người Đặt";
            // 
            // textBox_HoVaTen
            // 
            this.textBox_HoVaTen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_HoVaTen.Location = new System.Drawing.Point(218, 40);
            this.textBox_HoVaTen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_HoVaTen.Name = "textBox_HoVaTen";
            this.textBox_HoVaTen.Size = new System.Drawing.Size(415, 35);
            this.textBox_HoVaTen.TabIndex = 1;
            // 
            // label_CMND
            // 
            this.label_CMND.AutoSize = true;
            this.label_CMND.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CMND.Location = new System.Drawing.Point(86, 111);
            this.label_CMND.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_CMND.Name = "label_CMND";
            this.label_CMND.Size = new System.Drawing.Size(86, 26);
            this.label_CMND.TabIndex = 0;
            this.label_CMND.Text = "CMND";
            // 
            // textBox_CMND
            // 
            this.textBox_CMND.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CMND.Location = new System.Drawing.Point(218, 106);
            this.textBox_CMND.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_CMND.Name = "textBox_CMND";
            this.textBox_CMND.Size = new System.Drawing.Size(415, 35);
            this.textBox_CMND.TabIndex = 1;
            // 
            // label_SDT
            // 
            this.label_SDT.AutoSize = true;
            this.label_SDT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SDT.Location = new System.Drawing.Point(116, 175);
            this.label_SDT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_SDT.Name = "label_SDT";
            this.label_SDT.Size = new System.Drawing.Size(57, 26);
            this.label_SDT.TabIndex = 0;
            this.label_SDT.Text = "SDT";
            // 
            // textBox_SDT
            // 
            this.textBox_SDT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_SDT.Location = new System.Drawing.Point(218, 171);
            this.textBox_SDT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_SDT.Name = "textBox_SDT";
            this.textBox_SDT.Size = new System.Drawing.Size(415, 35);
            this.textBox_SDT.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_HoVaTen);
            this.groupBox1.Controls.Add(this.textBox_SDT);
            this.groupBox1.Controls.Add(this.label_CMND);
            this.groupBox1.Controls.Add(this.textBox_CMND);
            this.groupBox1.Controls.Add(this.label_SDT);
            this.groupBox1.Controls.Add(this.textBox_HoVaTen);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(18, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(732, 245);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Người Thuê";
            // 
            // groupBox_ThongTinDatPhong
            // 
            this.groupBox_ThongTinDatPhong.Controls.Add(this.panel1);
            this.groupBox_ThongTinDatPhong.Controls.Add(this.label_LoaiPhong);
            this.groupBox_ThongTinDatPhong.Controls.Add(this.textBox1);
            this.groupBox_ThongTinDatPhong.Controls.Add(this.label1);
            this.groupBox_ThongTinDatPhong.Controls.Add(this.textBox_SoPhong);
            this.groupBox_ThongTinDatPhong.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_ThongTinDatPhong.Location = new System.Drawing.Point(759, 18);
            this.groupBox_ThongTinDatPhong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox_ThongTinDatPhong.Name = "groupBox_ThongTinDatPhong";
            this.groupBox_ThongTinDatPhong.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox_ThongTinDatPhong.Size = new System.Drawing.Size(638, 494);
            this.groupBox_ThongTinDatPhong.TabIndex = 2;
            this.groupBox_ThongTinDatPhong.TabStop = false;
            this.groupBox_ThongTinDatPhong.Text = "Thông Tin Đặt Phòng";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(32, 45);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(576, 300);
            this.panel1.TabIndex = 2;
            // 
            // label_LoaiPhong
            // 
            this.label_LoaiPhong.AutoSize = true;
            this.label_LoaiPhong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_LoaiPhong.Location = new System.Drawing.Point(74, 428);
            this.label_LoaiPhong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_LoaiPhong.Name = "label_LoaiPhong";
            this.label_LoaiPhong.Size = new System.Drawing.Size(130, 26);
            this.label_LoaiPhong.TabIndex = 0;
            this.label_LoaiPhong.Text = "Loại Phòng";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(256, 423);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(292, 35);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 368);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số Phòng";
            // 
            // textBox_SoPhong
            // 
            this.textBox_SoPhong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_SoPhong.Location = new System.Drawing.Point(256, 363);
            this.textBox_SoPhong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_SoPhong.Name = "textBox_SoPhong";
            this.textBox_SoPhong.Size = new System.Drawing.Size(292, 35);
            this.textBox_SoPhong.TabIndex = 1;
            // 
            // button_DatPhong
            // 
            this.button_DatPhong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_DatPhong.Location = new System.Drawing.Point(418, 323);
            this.button_DatPhong.Name = "button_DatPhong";
            this.button_DatPhong.Size = new System.Drawing.Size(159, 61);
            this.button_DatPhong.TabIndex = 3;
            this.button_DatPhong.Text = "Đặt Phòng";
            this.button_DatPhong.UseVisualStyleBackColor = true;
            // 
            // button_Huy
            // 
            this.button_Huy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Huy.Location = new System.Drawing.Point(176, 323);
            this.button_Huy.Name = "button_Huy";
            this.button_Huy.Size = new System.Drawing.Size(159, 61);
            this.button_Huy.TabIndex = 3;
            this.button_Huy.Text = "Hủy";
            this.button_Huy.UseVisualStyleBackColor = true;
            // 
            // Reservation_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1414, 522);
            this.Controls.Add(this.button_Huy);
            this.Controls.Add(this.button_DatPhong);
            this.Controls.Add(this.groupBox_ThongTinDatPhong);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Reservation_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đặt Phòng";
            this.Load += new System.EventHandler(this.Reservation_Form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox_ThongTinDatPhong.ResumeLayout(false);
            this.groupBox_ThongTinDatPhong.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_HoVaTen;
        private System.Windows.Forms.TextBox textBox_HoVaTen;
        private System.Windows.Forms.Label label_CMND;
        private System.Windows.Forms.TextBox textBox_CMND;
        private System.Windows.Forms.Label label_SDT;
        private System.Windows.Forms.TextBox textBox_SDT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox_ThongTinDatPhong;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_LoaiPhong;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_SoPhong;
        private System.Windows.Forms.Button button_DatPhong;
        private System.Windows.Forms.Button button_Huy;
    }
}