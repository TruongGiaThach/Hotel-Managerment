using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HotelBookingManagement
{
    partial class Reservation_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private List<Phong> Data;
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LoaiPhong = new System.Windows.Forms.ComboBox();
            this.NgayDi = new System.Windows.Forms.DateTimePicker();
            this.NgayDen = new System.Windows.Forms.DateTimePicker();
            this.TienCoc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.TextBox();
            this.TenKhachHang = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.NgayCapCMT = new System.Windows.Forms.DateTimePicker();
            this.NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.HuyDatPhong = new System.Windows.Forms.Button();
            this.SaveDatPhong = new System.Windows.Forms.Button();
            this.GhiChu = new System.Windows.Forms.TextBox();
            this.QuocTich = new System.Windows.Forms.TextBox();
            this.DiaChiNg = new System.Windows.Forms.TextBox();
            this.CMT = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.GioiTinh = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel_Find_Room = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.LoaiPhong);
            this.groupBox1.Controls.Add(this.NgayDi);
            this.groupBox1.Controls.Add(this.NgayDen);
            this.groupBox1.Controls.Add(this.TienCoc);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(435, 286);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đặt phòng";
            // 
            // LoaiPhong
            // 
            this.LoaiPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LoaiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoaiPhong.FormattingEnabled = true;
            this.LoaiPhong.Items.AddRange(new object[] {
            "Nomal1",
            "Nomal2",
            "Vip1",
            "Vip2"});
            this.LoaiPhong.Location = new System.Drawing.Point(160, 43);
            this.LoaiPhong.Margin = new System.Windows.Forms.Padding(4);
            this.LoaiPhong.Name = "LoaiPhong";
            this.LoaiPhong.Size = new System.Drawing.Size(199, 28);
            this.LoaiPhong.TabIndex = 17;
            // 
            // NgayDi
            // 
            this.NgayDi.CustomFormat = "dd-MM-yyyy";
            this.NgayDi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NgayDi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.NgayDi.Location = new System.Drawing.Point(160, 140);
            this.NgayDi.Margin = new System.Windows.Forms.Padding(4);
            this.NgayDi.Name = "NgayDi";
            this.NgayDi.Size = new System.Drawing.Size(199, 27);
            this.NgayDi.TabIndex = 15;
            // 
            // NgayDen
            // 
            this.NgayDen.CustomFormat = "dd-MM-yyyy";
            this.NgayDen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NgayDen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.NgayDen.Location = new System.Drawing.Point(160, 94);
            this.NgayDen.Margin = new System.Windows.Forms.Padding(4);
            this.NgayDen.Name = "NgayDen";
            this.NgayDen.Size = new System.Drawing.Size(199, 27);
            this.NgayDen.TabIndex = 14;
            // 
            // TienCoc
            // 
            this.TienCoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TienCoc.Location = new System.Drawing.Point(160, 188);
            this.TienCoc.Margin = new System.Windows.Forms.Padding(4);
            this.TienCoc.Name = "TienCoc";
            this.TienCoc.Size = new System.Drawing.Size(199, 27);
            this.TienCoc.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 188);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tiền cọc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 137);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày đi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày đến: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loại phòng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 101);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giới tính:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 54);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tên khách hàng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(325, 94);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ngày sinh:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(34, 142);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Điện thoại:";
            // 
            // Phone
            // 
            this.Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone.Location = new System.Drawing.Point(151, 133);
            this.Phone.Margin = new System.Windows.Forms.Padding(4);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(166, 27);
            this.Phone.TabIndex = 10;
            // 
            // TenKhachHang
            // 
            this.TenKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenKhachHang.Location = new System.Drawing.Point(151, 50);
            this.TenKhachHang.Margin = new System.Windows.Forms.Padding(4);
            this.TenKhachHang.Name = "TenKhachHang";
            this.TenKhachHang.Size = new System.Drawing.Size(465, 27);
            this.TenKhachHang.TabIndex = 11;
            // 
            // Email
            // 
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(437, 134);
            this.Email.Margin = new System.Windows.Forms.Padding(4);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(178, 27);
            this.Email.TabIndex = 12;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.NgayCapCMT);
            this.groupBox2.Controls.Add(this.NgaySinh);
            this.groupBox2.Controls.Add(this.HuyDatPhong);
            this.groupBox2.Controls.Add(this.SaveDatPhong);
            this.groupBox2.Controls.Add(this.GhiChu);
            this.groupBox2.Controls.Add(this.QuocTich);
            this.groupBox2.Controls.Add(this.DiaChiNg);
            this.groupBox2.Controls.Add(this.CMT);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.GioiTinh);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.Email);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.TenKhachHang);
            this.groupBox2.Controls.Add(this.Phone);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(443, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(660, 645);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin khách hàng";
            // 
            // NgayCapCMT
            // 
            this.NgayCapCMT.CustomFormat = "dd-MM-yyyy";
            this.NgayCapCMT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NgayCapCMT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.NgayCapCMT.Location = new System.Drawing.Point(437, 174);
            this.NgayCapCMT.Margin = new System.Windows.Forms.Padding(4);
            this.NgayCapCMT.Name = "NgayCapCMT";
            this.NgayCapCMT.Size = new System.Drawing.Size(178, 27);
            this.NgayCapCMT.TabIndex = 29;
            // 
            // NgaySinh
            // 
            this.NgaySinh.CustomFormat = "dd-MM-yyyy";
            this.NgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.NgaySinh.Location = new System.Drawing.Point(437, 94);
            this.NgaySinh.Margin = new System.Windows.Forms.Padding(4);
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.Size = new System.Drawing.Size(178, 27);
            this.NgaySinh.TabIndex = 28;
            // 
            // HuyDatPhong
            // 
            this.HuyDatPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HuyDatPhong.Location = new System.Drawing.Point(473, 551);
            this.HuyDatPhong.Margin = new System.Windows.Forms.Padding(4);
            this.HuyDatPhong.Name = "HuyDatPhong";
            this.HuyDatPhong.Size = new System.Drawing.Size(117, 45);
            this.HuyDatPhong.TabIndex = 27;
            this.HuyDatPhong.Text = "Hủy";
            this.HuyDatPhong.UseVisualStyleBackColor = true;
            this.HuyDatPhong.Click += new System.EventHandler(this.HuyDatPhong_Click);
            // 
            // SaveDatPhong
            // 
            this.SaveDatPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveDatPhong.Location = new System.Drawing.Point(306, 551);
            this.SaveDatPhong.Margin = new System.Windows.Forms.Padding(4);
            this.SaveDatPhong.Name = "SaveDatPhong";
            this.SaveDatPhong.Size = new System.Drawing.Size(117, 45);
            this.SaveDatPhong.TabIndex = 26;
            this.SaveDatPhong.Text = "Lưu";
            this.SaveDatPhong.UseVisualStyleBackColor = true;
            this.SaveDatPhong.Click += new System.EventHandler(this.SaveDatPhong_Click);
            // 
            // GhiChu
            // 
            this.GhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GhiChu.Location = new System.Drawing.Point(151, 334);
            this.GhiChu.Margin = new System.Windows.Forms.Padding(4);
            this.GhiChu.Multiline = true;
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.Size = new System.Drawing.Size(465, 86);
            this.GhiChu.TabIndex = 25;
            // 
            // QuocTich
            // 
            this.QuocTich.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuocTich.Location = new System.Drawing.Point(151, 283);
            this.QuocTich.Margin = new System.Windows.Forms.Padding(4);
            this.QuocTich.Name = "QuocTich";
            this.QuocTich.Size = new System.Drawing.Size(465, 27);
            this.QuocTich.TabIndex = 24;
            // 
            // DiaChiNg
            // 
            this.DiaChiNg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiaChiNg.Location = new System.Drawing.Point(152, 230);
            this.DiaChiNg.Margin = new System.Windows.Forms.Padding(4);
            this.DiaChiNg.Name = "DiaChiNg";
            this.DiaChiNg.Size = new System.Drawing.Size(464, 27);
            this.DiaChiNg.TabIndex = 23;
            // 
            // CMT
            // 
            this.CMT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMT.Location = new System.Drawing.Point(152, 176);
            this.CMT.Margin = new System.Windows.Forms.Padding(4);
            this.CMT.Name = "CMT";
            this.CMT.Size = new System.Drawing.Size(166, 27);
            this.CMT.TabIndex = 21;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(44, 342);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 20);
            this.label14.TabIndex = 20;
            this.label14.Text = "Ghi chú:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(39, 286);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 20);
            this.label13.TabIndex = 19;
            this.label13.Text = "Quốc tịch:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(44, 235);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 20);
            this.label12.TabIndex = 18;
            this.label12.Text = "Địa chỉ:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(327, 180);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 20);
            this.label11.TabIndex = 17;
            this.label11.Text = "Ngày cấp:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(9, 181);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 20);
            this.label10.TabIndex = 16;
            this.label10.Text = "Số CMT/CCCD:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(349, 137);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "email:";
            // 
            // GioiTinh
            // 
            this.GioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GioiTinh.FormattingEnabled = true;
            this.GioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.GioiTinh.Location = new System.Drawing.Point(151, 89);
            this.GioiTinh.Margin = new System.Windows.Forms.Padding(4);
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.Size = new System.Drawing.Size(166, 28);
            this.GioiTinh.TabIndex = 13;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.AutoSize = true;
            this.groupBox3.Controls.Add(this.panel_Find_Room);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(0, 291);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(435, 354);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm phòng còn trống";
            // 
            // panel_Find_Room
            // 
            this.panel_Find_Room.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel_Find_Room.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_Find_Room.Location = new System.Drawing.Point(29, 98);
            this.panel_Find_Room.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_Find_Room.Name = "panel_Find_Room";
            this.panel_Find_Room.Size = new System.Drawing.Size(378, 230);
            this.panel_Find_Room.TabIndex = 1;
            // 
            // Reservation_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 652);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1124, 699);
            this.MinimumSize = new System.Drawing.Size(1124, 699);
            this.Name = "Reservation_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đặt Phòng";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        #region Room Finder
        private int MaxNumOfRoom = 5;
        public int NumOfRoom;
        private int margin = 10;
        List<System.Windows.Forms.RadioButton> Rooms = new List<System.Windows.Forms.RadioButton>();
        public void InitRoomFinder()
        {
            Rooms.Clear();
            this.panel_Find_Room.Controls.Clear();
            NumOfRoom = Data.Count;
            int drawPointX = this.margin;
            int drawPointY = this.margin;
            int j = 0;
            for (int i = 0; i < NumOfRoom; ++i)//create Rooms Buttom
            {
                if (Data[i].TrangThai.Contains("trong"))
                {
                    this.Rooms.Add(new System.Windows.Forms.RadioButton());      //Add a Button in Rooms Button list
                    // set Button Properties
                    if (Data[i].IsSelect == true) this.Rooms[j].Checked = true;
                    this.Rooms[j].Tag = Data[i];
                    this.Rooms[j].Name = i.ToString();
                    this.Rooms[j].Text = Data[i].ID;
                    this.Rooms[j].ForeColor = System.Drawing.SystemColors.Control;
                    this.Rooms[j].Tag = Data[i];
                    this.Rooms[j].Size = new System.Drawing.Size(100, (this.panel_Find_Room.Height - ((MaxNumOfRoom + 1) * margin)) / MaxNumOfRoom);
                    if (j % MaxNumOfRoom != 0 || j == 0) drawPointY = ((j % MaxNumOfRoom) * Rooms[j].Height) + margin;
                    else
                    {
                        drawPointX += Rooms[j].Width + margin;
                        drawPointY = margin;
                    }
                    this.Rooms[j].TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
                    this.Rooms[j].Location = new System.Drawing.Point(drawPointX, drawPointY);
                    this.Rooms[j].CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
                    this.panel_Find_Room.Controls.Add(Rooms[j]);
                    j++;
                }
            }
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox LoaiPhong;
        private System.Windows.Forms.DateTimePicker NgayDi;
        private System.Windows.Forms.DateTimePicker NgayDen;
        private System.Windows.Forms.TextBox TienCoc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Phone;
        private System.Windows.Forms.TextBox TenKhachHang;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox GhiChu;
        private System.Windows.Forms.TextBox QuocTich;
        private System.Windows.Forms.TextBox DiaChiNg;
        private System.Windows.Forms.TextBox CMT;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox GioiTinh;
        private System.Windows.Forms.Button HuyDatPhong;
        private System.Windows.Forms.Button SaveDatPhong;
        private System.Windows.Forms.DateTimePicker NgayCapCMT;
        private System.Windows.Forms.DateTimePicker NgaySinh;
        private System.Windows.Forms.Panel panel_Find_Room;
    }
}