namespace FormDatPhong
{
    partial class Form1
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
            this.dataGridViewTimPhong = new System.Windows.Forms.DataGridView();
            this.TimPhongTrong = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTimPhong)).BeginInit();
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
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 232);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đặt phòng";
            // 
            // LoaiPhong
            // 
            this.LoaiPhong.FormattingEnabled = true;
            this.LoaiPhong.Items.AddRange(new object[] {
            "Normal",
            "Vip1",
            "Vip2",
            "Vip3"});
            this.LoaiPhong.Location = new System.Drawing.Point(120, 35);
            this.LoaiPhong.Name = "LoaiPhong";
            this.LoaiPhong.Size = new System.Drawing.Size(150, 24);
            this.LoaiPhong.TabIndex = 17;
            // 
            // NgayDi
            // 
            this.NgayDi.Location = new System.Drawing.Point(120, 114);
            this.NgayDi.Name = "NgayDi";
            this.NgayDi.Size = new System.Drawing.Size(150, 22);
            this.NgayDi.TabIndex = 15;
            // 
            // NgayDen
            // 
            this.NgayDen.Location = new System.Drawing.Point(120, 76);
            this.NgayDen.Name = "NgayDen";
            this.NgayDen.Size = new System.Drawing.Size(150, 22);
            this.NgayDen.TabIndex = 14;
            // 
            // TienCoc
            // 
            this.TienCoc.Location = new System.Drawing.Point(120, 153);
            this.TienCoc.Name = "TienCoc";
            this.TienCoc.Size = new System.Drawing.Size(150, 22);
            this.TienCoc.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tiền cọc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày đi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày đến: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loại phòng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giới tính:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tên khách hàng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(244, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ngày sinh:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Điện thoại:";
            // 
            // Phone
            // 
            this.Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone.Location = new System.Drawing.Point(113, 108);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(125, 22);
            this.Phone.TabIndex = 10;
            // 
            // TenKhachHang
            // 
            this.TenKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenKhachHang.Location = new System.Drawing.Point(113, 41);
            this.TenKhachHang.Name = "TenKhachHang";
            this.TenKhachHang.Size = new System.Drawing.Size(350, 22);
            this.TenKhachHang.TabIndex = 11;
            // 
            // Email
            // 
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(328, 109);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(135, 22);
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
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(332, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(495, 524);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin khách hàng";
            // 
            // NgayCapCMT
            // 
            this.NgayCapCMT.Location = new System.Drawing.Point(328, 141);
            this.NgayCapCMT.Name = "NgayCapCMT";
            this.NgayCapCMT.Size = new System.Drawing.Size(135, 22);
            this.NgayCapCMT.TabIndex = 29;
            // 
            // NgaySinh
            // 
            this.NgaySinh.Location = new System.Drawing.Point(328, 76);
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.Size = new System.Drawing.Size(135, 22);
            this.NgaySinh.TabIndex = 28;
            // 
            // HuyDatPhong
            // 
            this.HuyDatPhong.Location = new System.Drawing.Point(373, 415);
            this.HuyDatPhong.Name = "HuyDatPhong";
            this.HuyDatPhong.Size = new System.Drawing.Size(75, 23);
            this.HuyDatPhong.TabIndex = 27;
            this.HuyDatPhong.Text = "Hủy";
            this.HuyDatPhong.UseVisualStyleBackColor = true;
            // 
            // SaveDatPhong
            // 
            this.SaveDatPhong.Location = new System.Drawing.Point(248, 415);
            this.SaveDatPhong.Name = "SaveDatPhong";
            this.SaveDatPhong.Size = new System.Drawing.Size(75, 23);
            this.SaveDatPhong.TabIndex = 26;
            this.SaveDatPhong.Text = "Lưu";
            this.SaveDatPhong.UseVisualStyleBackColor = true;
            // 
            // GhiChu
            // 
            this.GhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GhiChu.Location = new System.Drawing.Point(113, 272);
            this.GhiChu.Multiline = true;
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.Size = new System.Drawing.Size(350, 71);
            this.GhiChu.TabIndex = 25;
            // 
            // QuocTich
            // 
            this.QuocTich.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuocTich.Location = new System.Drawing.Point(113, 230);
            this.QuocTich.Name = "QuocTich";
            this.QuocTich.Size = new System.Drawing.Size(350, 22);
            this.QuocTich.TabIndex = 24;
            // 
            // DiaChiNg
            // 
            this.DiaChiNg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiaChiNg.Location = new System.Drawing.Point(114, 187);
            this.DiaChiNg.Name = "DiaChiNg";
            this.DiaChiNg.Size = new System.Drawing.Size(349, 22);
            this.DiaChiNg.TabIndex = 23;
            // 
            // CMT
            // 
            this.CMT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMT.Location = new System.Drawing.Point(114, 143);
            this.CMT.Name = "CMT";
            this.CMT.Size = new System.Drawing.Size(125, 22);
            this.CMT.TabIndex = 21;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(33, 278);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 16);
            this.label14.TabIndex = 20;
            this.label14.Text = "Ghi chú:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(29, 233);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 16);
            this.label13.TabIndex = 19;
            this.label13.Text = "Quốc tịch:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(33, 191);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 16);
            this.label12.TabIndex = 18;
            this.label12.Text = "Địa chỉ:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(245, 146);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 16);
            this.label11.TabIndex = 17;
            this.label11.Text = "Ngày cấp:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(7, 147);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 16);
            this.label10.TabIndex = 16;
            this.label10.Text = "Số CMT/CCCD:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(262, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "email:";
            // 
            // GioiTinh
            // 
            this.GioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GioiTinh.FormattingEnabled = true;
            this.GioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.GioiTinh.Location = new System.Drawing.Point(113, 72);
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.Size = new System.Drawing.Size(125, 24);
            this.GioiTinh.TabIndex = 13;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.AutoSize = true;
            this.groupBox3.Controls.Add(this.dataGridViewTimPhong);
            this.groupBox3.Controls.Add(this.TimPhongTrong);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(0, 238);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(326, 286);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "tìm phòng còn trống";
            // 
            // dataGridViewTimPhong
            // 
            this.dataGridViewTimPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTimPhong.Location = new System.Drawing.Point(32, 87);
            this.dataGridViewTimPhong.Name = "dataGridViewTimPhong";
            this.dataGridViewTimPhong.Size = new System.Drawing.Size(247, 155);
            this.dataGridViewTimPhong.TabIndex = 1;
            // 
            // TimPhongTrong
            // 
            this.TimPhongTrong.FlatAppearance.BorderSize = 5;
            this.TimPhongTrong.Location = new System.Drawing.Point(120, 45);
            this.TimPhongTrong.Name = "TimPhongTrong";
            this.TimPhongTrong.Size = new System.Drawing.Size(75, 23);
            this.TimPhongTrong.TabIndex = 0;
            this.TimPhongTrong.Text = "Tìm";
            this.TimPhongTrong.UseVisualStyleBackColor = true;
            this.TimPhongTrong.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 524);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTimPhong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.DataGridView dataGridViewTimPhong;
        private System.Windows.Forms.Button TimPhongTrong;
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
    }
}

