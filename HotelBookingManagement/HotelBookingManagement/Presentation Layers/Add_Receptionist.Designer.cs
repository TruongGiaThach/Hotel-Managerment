namespace HotelBookingManagement
{
    partial class Add_Receptionist
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_NhapLai = new System.Windows.Forms.TextBox();
            this.mkNhanVien = new System.Windows.Forms.TextBox();
            this.label_NhapLai = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TaiKhoanNhanVien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox_Luong = new System.Windows.Forms.TextBox();
            this.CaTruc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ChucVuNhanVien = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label_Lương = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NgaySinhNhanVien = new System.Windows.Forms.DateTimePicker();
            this.ButtonHuy = new System.Windows.Forms.Button();
            this.ButtonThemNhanVien = new System.Windows.Forms.Button();
            this.mailNhanVien = new System.Windows.Forms.TextBox();
            this.AddressNhanVien = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.phoneNhanVien = new System.Windows.Forms.TextBox();
            this.CMTNhanVien = new System.Windows.Forms.TextBox();
            this.TenNhanVien = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1121, 671);
            this.splitContainer1.SplitterDistance = 200;
            this.splitContainer1.SplitterWidth = 2;
            this.splitContainer1.TabIndex = 2;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBox2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer2.Size = new System.Drawing.Size(1121, 200);
            this.splitContainer2.SplitterDistance = 388;
            this.splitContainer2.SplitterWidth = 5;
            this.splitContainer2.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_NhapLai);
            this.groupBox2.Controls.Add(this.mkNhanVien);
            this.groupBox2.Controls.Add(this.label_NhapLai);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.TaiKhoanNhanVien);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(388, 200);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cấp tài khoản";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // textBox_NhapLai
            // 
            this.textBox_NhapLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_NhapLai.Location = new System.Drawing.Point(129, 151);
            this.textBox_NhapLai.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_NhapLai.Name = "textBox_NhapLai";
            this.textBox_NhapLai.PasswordChar = '*';
            this.textBox_NhapLai.Size = new System.Drawing.Size(205, 30);
            this.textBox_NhapLai.TabIndex = 3;
            // 
            // mkNhanVien
            // 
            this.mkNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkNhanVien.Location = new System.Drawing.Point(129, 103);
            this.mkNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.mkNhanVien.Name = "mkNhanVien";
            this.mkNhanVien.PasswordChar = '*';
            this.mkNhanVien.Size = new System.Drawing.Size(205, 30);
            this.mkNhanVien.TabIndex = 3;
            // 
            // label_NhapLai
            // 
            this.label_NhapLai.AutoSize = true;
            this.label_NhapLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NhapLai.Location = new System.Drawing.Point(20, 151);
            this.label_NhapLai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_NhapLai.Name = "label_NhapLai";
            this.label_NhapLai.Size = new System.Drawing.Size(96, 25);
            this.label_NhapLai.TabIndex = 1;
            this.label_NhapLai.Text = "Nhập Lại:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu:";
            // 
            // TaiKhoanNhanVien
            // 
            this.TaiKhoanNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaiKhoanNhanVien.Location = new System.Drawing.Point(129, 52);
            this.TaiKhoanNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.TaiKhoanNhanVien.Name = "TaiKhoanNhanVien";
            this.TaiKhoanNhanVien.Size = new System.Drawing.Size(205, 30);
            this.TaiKhoanNhanVien.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài khoản:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox_Luong);
            this.groupBox3.Controls.Add(this.CaTruc);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.ChucVuNhanVien);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label_Lương);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(728, 200);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin công việc";
            // 
            // textBox_Luong
            // 
            this.textBox_Luong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Luong.Location = new System.Drawing.Point(236, 146);
            this.textBox_Luong.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Luong.Name = "textBox_Luong";
            this.textBox_Luong.Size = new System.Drawing.Size(237, 30);
            this.textBox_Luong.TabIndex = 5;
            // 
            // CaTruc
            // 
            this.CaTruc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaTruc.Location = new System.Drawing.Point(236, 100);
            this.CaTruc.Margin = new System.Windows.Forms.Padding(4);
            this.CaTruc.Name = "CaTruc";
            this.CaTruc.Size = new System.Drawing.Size(237, 30);
            this.CaTruc.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 103);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ca:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // ChucVuNhanVien
            // 
            this.ChucVuNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChucVuNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChucVuNhanVien.FormattingEnabled = true;
            this.ChucVuNhanVien.Items.AddRange(new object[] {
            "Bảo vệ",
            "Nhân viên vệ sinh",
            "Quản lí",
            "Tiếp tân",
            "Lễ tân"});
            this.ChucVuNhanVien.Location = new System.Drawing.Point(236, 52);
            this.ChucVuNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.ChucVuNhanVien.Name = "ChucVuNhanVien";
            this.ChucVuNhanVien.Size = new System.Drawing.Size(237, 33);
            this.ChucVuNhanVien.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 52);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Chức vụ:";
            // 
            // label_Lương
            // 
            this.label_Lương.AutoSize = true;
            this.label_Lương.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Lương.Location = new System.Drawing.Point(62, 152);
            this.label_Lương.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Lương.Name = "label_Lương";
            this.label_Lương.Size = new System.Drawing.Size(141, 25);
            this.label_Lương.TabIndex = 7;
            this.label_Lương.Text = "Lương theo giờ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NgaySinhNhanVien);
            this.groupBox1.Controls.Add(this.ButtonHuy);
            this.groupBox1.Controls.Add(this.ButtonThemNhanVien);
            this.groupBox1.Controls.Add(this.mailNhanVien);
            this.groupBox1.Controls.Add(this.AddressNhanVien);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.phoneNhanVien);
            this.groupBox1.Controls.Add(this.CMTNhanVien);
            this.groupBox1.Controls.Add(this.TenNhanVien);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1121, 469);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            // 
            // NgaySinhNhanVien
            // 
            this.NgaySinhNhanVien.CustomFormat = "dd-MM-yyyy";
            this.NgaySinhNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NgaySinhNhanVien.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.NgaySinhNhanVien.Location = new System.Drawing.Point(600, 177);
            this.NgaySinhNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.NgaySinhNhanVien.Name = "NgaySinhNhanVien";
            this.NgaySinhNhanVien.Size = new System.Drawing.Size(216, 30);
            this.NgaySinhNhanVien.TabIndex = 17;
            // 
            // ButtonHuy
            // 
            this.ButtonHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonHuy.Location = new System.Drawing.Point(930, 229);
            this.ButtonHuy.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonHuy.Name = "ButtonHuy";
            this.ButtonHuy.Size = new System.Drawing.Size(139, 34);
            this.ButtonHuy.TabIndex = 16;
            this.ButtonHuy.Text = "Hủy";
            this.ButtonHuy.UseVisualStyleBackColor = true;
            // 
            // ButtonThemNhanVien
            // 
            this.ButtonThemNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonThemNhanVien.Location = new System.Drawing.Point(930, 129);
            this.ButtonThemNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonThemNhanVien.Name = "ButtonThemNhanVien";
            this.ButtonThemNhanVien.Size = new System.Drawing.Size(139, 37);
            this.ButtonThemNhanVien.TabIndex = 15;
            this.ButtonThemNhanVien.Text = "Thêm";
            this.ButtonThemNhanVien.UseVisualStyleBackColor = true;
            this.ButtonThemNhanVien.Click += new System.EventHandler(this.ButtonThemNhanVien_Click);
            // 
            // mailNhanVien
            // 
            this.mailNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mailNhanVien.Location = new System.Drawing.Point(600, 219);
            this.mailNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.mailNhanVien.Name = "mailNhanVien";
            this.mailNhanVien.Size = new System.Drawing.Size(216, 30);
            this.mailNhanVien.TabIndex = 14;
            // 
            // AddressNhanVien
            // 
            this.AddressNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressNhanVien.Location = new System.Drawing.Point(199, 321);
            this.AddressNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.AddressNhanVien.Name = "AddressNhanVien";
            this.AddressNhanVien.Size = new System.Drawing.Size(617, 30);
            this.AddressNhanVien.TabIndex = 13;
            this.AddressNhanVien.Text = "Số nhà, phường, quận,...";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Giới tính thứ ba"});
            this.comboBox2.Location = new System.Drawing.Point(199, 171);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(214, 33);
            this.comboBox2.TabIndex = 12;
            // 
            // phoneNhanVien
            // 
            this.phoneNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNhanVien.Location = new System.Drawing.Point(199, 219);
            this.phoneNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.phoneNhanVien.Name = "phoneNhanVien";
            this.phoneNhanVien.Size = new System.Drawing.Size(214, 30);
            this.phoneNhanVien.TabIndex = 11;
            this.phoneNhanVien.TextChanged += new System.EventHandler(this.phoneNhanVien_TextChanged);
            // 
            // CMTNhanVien
            // 
            this.CMTNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMTNhanVien.Location = new System.Drawing.Point(199, 272);
            this.CMTNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.CMTNhanVien.Name = "CMTNhanVien";
            this.CMTNhanVien.Size = new System.Drawing.Size(617, 30);
            this.CMTNhanVien.TabIndex = 9;
            this.CMTNhanVien.TextChanged += new System.EventHandler(this.CMTNhanVien_TextChanged);
            // 
            // TenNhanVien
            // 
            this.TenNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenNhanVien.Location = new System.Drawing.Point(199, 120);
            this.TenNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.TenNhanVien.Name = "TenNhanVien";
            this.TenNhanVien.Size = new System.Drawing.Size(617, 30);
            this.TenNhanVien.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(486, 219);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 25);
            this.label11.TabIndex = 6;
            this.label11.Text = "Email:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(51, 221);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 25);
            this.label10.TabIndex = 5;
            this.label10.Text = "Số điện thoại:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(51, 325);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 25);
            this.label9.TabIndex = 4;
            this.label9.Text = "Địa chỉ:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(51, 279);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 25);
            this.label8.TabIndex = 3;
            this.label8.Text = "Số CMT/CCCD";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(486, 180);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = "Ngày sinh:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(51, 173);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "Giới tính:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(51, 123);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tên nhân viên:";
            // 
            // Add_Receptionist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 671);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Add_Receptionist";
            this.Text = "ThemNhanVien";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TaiKhoanNhanVien;
        private System.Windows.Forms.TextBox mkNhanVien;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox ChucVuNhanVien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CaTruc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox phoneNhanVien;
        private System.Windows.Forms.TextBox CMTNhanVien;
        private System.Windows.Forms.TextBox TenNhanVien;
        private System.Windows.Forms.Label label_Lương;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox mailNhanVien;
        private System.Windows.Forms.TextBox AddressNhanVien;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button ButtonHuy;
        private System.Windows.Forms.Button ButtonThemNhanVien;
        private System.Windows.Forms.DateTimePicker NgaySinhNhanVien;
        private System.Windows.Forms.TextBox textBox_NhapLai;
        private System.Windows.Forms.Label label_NhapLai;
        private System.Windows.Forms.TextBox textBox_Luong;
    }
}