using HotelBookingManagement.Data_Access_Layers;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HotelBookingManagement
{
    partial class Manager_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Phong_DAL Phong_Data = new Phong_DAL();
        private List<Phong> DS_Phong;
        private Form MdiChild;
        private Button isSelect;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager_Form));
            this.imageList_Menu_Icon = new System.Windows.Forms.ImageList(this.components);
            this.tabControl_Menu = new System.Windows.Forms.TabControl();
            this.tabPage_TrangChu = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_CaiDat = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_TaiKhoan = new System.Windows.Forms.Button();
            this.button_NhanVien = new System.Windows.Forms.Button();
            this.button_ThongKe = new System.Windows.Forms.Button();
            this.button_KhachHang = new System.Windows.Forms.Button();
            this.button_Phong = new System.Windows.Forms.Button();
            this.button_HoaDon = new System.Windows.Forms.Button();
            this.tabPage_Phong = new System.Windows.Forms.TabPage();
            this.tabPage_Oder_Room = new System.Windows.Forms.TabPage();
            this.tabPage_Customer = new System.Windows.Forms.TabPage();
            this.tabPage_NhanVien = new System.Windows.Forms.TabPage();
            this.tabPage_ThongKe = new System.Windows.Forms.TabPage();
            this.tabPage_TaiKhoan = new System.Windows.Forms.TabPage();
            this.tabPage_Settings = new System.Windows.Forms.TabPage();
            this.button_Refesh = new System.Windows.Forms.Button();
            this.button_Back = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.time_Control1 = new HotelBookingManagement.Presentation_Layers.Time_Control();
            this.tabControl_Menu.SuspendLayout();
            this.tabPage_TrangChu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList_Menu_Icon
            // 
            this.imageList_Menu_Icon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_Menu_Icon.ImageStream")));
            this.imageList_Menu_Icon.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_Menu_Icon.Images.SetKeyName(0, "homepage.png");
            this.imageList_Menu_Icon.Images.SetKeyName(1, "room.png");
            this.imageList_Menu_Icon.Images.SetKeyName(2, "hoadon.png");
            this.imageList_Menu_Icon.Images.SetKeyName(3, "Khachhang.png");
            this.imageList_Menu_Icon.Images.SetKeyName(4, "nhanvien.png");
            this.imageList_Menu_Icon.Images.SetKeyName(5, "thongke.png");
            this.imageList_Menu_Icon.Images.SetKeyName(6, "hethong.png");
            this.imageList_Menu_Icon.Images.SetKeyName(7, "supply-chain-management.png");
            this.imageList_Menu_Icon.Images.SetKeyName(8, "back.png");
            this.imageList_Menu_Icon.Images.SetKeyName(9, "refresh.png");
            // 
            // tabControl_Menu
            // 
            this.tabControl_Menu.Controls.Add(this.tabPage_TrangChu);
            this.tabControl_Menu.Controls.Add(this.tabPage_Phong);
            this.tabControl_Menu.Controls.Add(this.tabPage_Oder_Room);
            this.tabControl_Menu.Controls.Add(this.tabPage_Customer);
            this.tabControl_Menu.Controls.Add(this.tabPage_NhanVien);
            this.tabControl_Menu.Controls.Add(this.tabPage_ThongKe);
            this.tabControl_Menu.Controls.Add(this.tabPage_TaiKhoan);
            this.tabControl_Menu.Controls.Add(this.tabPage_Settings);
            this.tabControl_Menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_Menu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl_Menu.ImageList = this.imageList_Menu_Icon;
            this.tabControl_Menu.Location = new System.Drawing.Point(0, 0);
            this.tabControl_Menu.Name = "tabControl_Menu";
            this.tabControl_Menu.SelectedIndex = 0;
            this.tabControl_Menu.Size = new System.Drawing.Size(1380, 735);
            this.tabControl_Menu.TabIndex = 1;
            this.tabControl_Menu.SelectedIndexChanged += new System.EventHandler(this.tabControl_Menu_SelectedIndexChanged);
            // 
            // tabPage_TrangChu
            // 
            this.tabPage_TrangChu.AutoScroll = true;
            this.tabPage_TrangChu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tabPage_TrangChu.Controls.Add(this.pictureBox2);
            this.tabPage_TrangChu.Controls.Add(this.panel2);
            this.tabPage_TrangChu.ImageIndex = 0;
            this.tabPage_TrangChu.Location = new System.Drawing.Point(4, 32);
            this.tabPage_TrangChu.Name = "tabPage_TrangChu";
            this.tabPage_TrangChu.Size = new System.Drawing.Size(1372, 699);
            this.tabPage_TrangChu.TabIndex = 0;
            this.tabPage_TrangChu.Text = "Trang Chủ";
            this.tabPage_TrangChu.Click += new System.EventHandler(this.tabPage_TrangChu_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(734, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(638, 699);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button_CaiDat);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.button_TaiKhoan);
            this.panel2.Controls.Add(this.button_NhanVien);
            this.panel2.Controls.Add(this.button_ThongKe);
            this.panel2.Controls.Add(this.button_KhachHang);
            this.panel2.Controls.Add(this.button_Phong);
            this.panel2.Controls.Add(this.button_HoaDon);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(734, 699);
            this.panel2.TabIndex = 2;
            // 
            // button_CaiDat
            // 
            this.button_CaiDat.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_CaiDat.FlatAppearance.BorderColor = System.Drawing.Color.Fuchsia;
            this.button_CaiDat.FlatAppearance.BorderSize = 2;
            this.button_CaiDat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button_CaiDat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Fuchsia;
            this.button_CaiDat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_CaiDat.Location = new System.Drawing.Point(237, 500);
            this.button_CaiDat.Name = "button_CaiDat";
            this.button_CaiDat.Size = new System.Drawing.Size(198, 67);
            this.button_CaiDat.TabIndex = 1;
            this.button_CaiDat.Text = "Cài Đặt";
            this.button_CaiDat.UseVisualStyleBackColor = false;
            this.button_CaiDat.Click += new System.EventHandler(this.button_CaiDat_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(297, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // button_TaiKhoan
            // 
            this.button_TaiKhoan.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_TaiKhoan.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.button_TaiKhoan.FlatAppearance.BorderSize = 2;
            this.button_TaiKhoan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button_TaiKhoan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.button_TaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_TaiKhoan.Location = new System.Drawing.Point(368, 398);
            this.button_TaiKhoan.Name = "button_TaiKhoan";
            this.button_TaiKhoan.Size = new System.Drawing.Size(198, 67);
            this.button_TaiKhoan.TabIndex = 2;
            this.button_TaiKhoan.Text = "Tài Khoản";
            this.button_TaiKhoan.UseVisualStyleBackColor = false;
            this.button_TaiKhoan.Click += new System.EventHandler(this.button_TaiKhoan_Click);
            // 
            // button_NhanVien
            // 
            this.button_NhanVien.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_NhanVien.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.button_NhanVien.FlatAppearance.BorderSize = 2;
            this.button_NhanVien.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button_NhanVien.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.button_NhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_NhanVien.Location = new System.Drawing.Point(368, 294);
            this.button_NhanVien.Name = "button_NhanVien";
            this.button_NhanVien.Size = new System.Drawing.Size(198, 67);
            this.button_NhanVien.TabIndex = 3;
            this.button_NhanVien.Text = "Nhân Viên";
            this.button_NhanVien.UseVisualStyleBackColor = false;
            this.button_NhanVien.Click += new System.EventHandler(this.button_NhanVien_Click);
            // 
            // button_ThongKe
            // 
            this.button_ThongKe.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_ThongKe.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.button_ThongKe.FlatAppearance.BorderSize = 2;
            this.button_ThongKe.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button_ThongKe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.button_ThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ThongKe.Location = new System.Drawing.Point(105, 398);
            this.button_ThongKe.Name = "button_ThongKe";
            this.button_ThongKe.Size = new System.Drawing.Size(198, 67);
            this.button_ThongKe.TabIndex = 4;
            this.button_ThongKe.Text = "Thống Kê";
            this.button_ThongKe.UseVisualStyleBackColor = false;
            this.button_ThongKe.Click += new System.EventHandler(this.button_HeThong_Click);
            // 
            // button_KhachHang
            // 
            this.button_KhachHang.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_KhachHang.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.button_KhachHang.FlatAppearance.BorderSize = 2;
            this.button_KhachHang.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button_KhachHang.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.button_KhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_KhachHang.Location = new System.Drawing.Point(105, 294);
            this.button_KhachHang.Name = "button_KhachHang";
            this.button_KhachHang.Size = new System.Drawing.Size(198, 67);
            this.button_KhachHang.TabIndex = 5;
            this.button_KhachHang.Text = "Khách Hàng";
            this.button_KhachHang.UseVisualStyleBackColor = false;
            this.button_KhachHang.Click += new System.EventHandler(this.button_KhachHang_Click);
            // 
            // button_Phong
            // 
            this.button_Phong.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_Phong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_Phong.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button_Phong.FlatAppearance.BorderSize = 2;
            this.button_Phong.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_Phong.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button_Phong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Phong.Location = new System.Drawing.Point(105, 192);
            this.button_Phong.Name = "button_Phong";
            this.button_Phong.Size = new System.Drawing.Size(198, 67);
            this.button_Phong.TabIndex = 6;
            this.button_Phong.Text = "Phòng";
            this.button_Phong.UseVisualStyleBackColor = false;
            this.button_Phong.Click += new System.EventHandler(this.button_Phong_Click);
            // 
            // button_HoaDon
            // 
            this.button_HoaDon.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_HoaDon.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_HoaDon.FlatAppearance.BorderSize = 2;
            this.button_HoaDon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button_HoaDon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_HoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_HoaDon.Location = new System.Drawing.Point(368, 192);
            this.button_HoaDon.Name = "button_HoaDon";
            this.button_HoaDon.Size = new System.Drawing.Size(198, 67);
            this.button_HoaDon.TabIndex = 7;
            this.button_HoaDon.Text = "Hóa Đơn";
            this.button_HoaDon.UseVisualStyleBackColor = false;
            this.button_HoaDon.Click += new System.EventHandler(this.button_HoaDon_Click);
            // 
            // tabPage_Phong
            // 
            this.tabPage_Phong.AutoScroll = true;
            this.tabPage_Phong.ImageIndex = 1;
            this.tabPage_Phong.Location = new System.Drawing.Point(4, 32);
            this.tabPage_Phong.Name = "tabPage_Phong";
            this.tabPage_Phong.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Phong.Size = new System.Drawing.Size(1372, 699);
            this.tabPage_Phong.TabIndex = 1;
            this.tabPage_Phong.Text = "Phòng";
            this.tabPage_Phong.UseVisualStyleBackColor = true;
            // 
            // tabPage_Oder_Room
            // 
            this.tabPage_Oder_Room.AutoScroll = true;
            this.tabPage_Oder_Room.ImageIndex = 2;
            this.tabPage_Oder_Room.Location = new System.Drawing.Point(4, 32);
            this.tabPage_Oder_Room.Name = "tabPage_Oder_Room";
            this.tabPage_Oder_Room.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Oder_Room.Size = new System.Drawing.Size(1372, 699);
            this.tabPage_Oder_Room.TabIndex = 2;
            this.tabPage_Oder_Room.Text = "Hóa Đơn";
            this.tabPage_Oder_Room.UseVisualStyleBackColor = true;
            // 
            // tabPage_Customer
            // 
            this.tabPage_Customer.AutoScroll = true;
            this.tabPage_Customer.ImageIndex = 3;
            this.tabPage_Customer.Location = new System.Drawing.Point(4, 32);
            this.tabPage_Customer.Name = "tabPage_Customer";
            this.tabPage_Customer.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Customer.Size = new System.Drawing.Size(1372, 699);
            this.tabPage_Customer.TabIndex = 3;
            this.tabPage_Customer.Text = "Khách Hàng";
            this.tabPage_Customer.UseVisualStyleBackColor = true;
            // 
            // tabPage_NhanVien
            // 
            this.tabPage_NhanVien.AutoScroll = true;
            this.tabPage_NhanVien.ImageIndex = 4;
            this.tabPage_NhanVien.Location = new System.Drawing.Point(4, 32);
            this.tabPage_NhanVien.Name = "tabPage_NhanVien";
            this.tabPage_NhanVien.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_NhanVien.Size = new System.Drawing.Size(1372, 699);
            this.tabPage_NhanVien.TabIndex = 4;
            this.tabPage_NhanVien.Text = "Nhân Viên";
            this.tabPage_NhanVien.UseVisualStyleBackColor = true;
            // 
            // tabPage_ThongKe
            // 
            this.tabPage_ThongKe.AutoScroll = true;
            this.tabPage_ThongKe.ImageIndex = 5;
            this.tabPage_ThongKe.Location = new System.Drawing.Point(4, 32);
            this.tabPage_ThongKe.Name = "tabPage_ThongKe";
            this.tabPage_ThongKe.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_ThongKe.Size = new System.Drawing.Size(1372, 699);
            this.tabPage_ThongKe.TabIndex = 5;
            this.tabPage_ThongKe.Text = "Thống Kê";
            this.tabPage_ThongKe.UseVisualStyleBackColor = true;
            // 
            // tabPage_TaiKhoan
            // 
            this.tabPage_TaiKhoan.AutoScroll = true;
            this.tabPage_TaiKhoan.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage_TaiKhoan.ImageIndex = 6;
            this.tabPage_TaiKhoan.Location = new System.Drawing.Point(4, 32);
            this.tabPage_TaiKhoan.Name = "tabPage_TaiKhoan";
            this.tabPage_TaiKhoan.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_TaiKhoan.Size = new System.Drawing.Size(1372, 699);
            this.tabPage_TaiKhoan.TabIndex = 6;
            this.tabPage_TaiKhoan.Text = "Tài Khoản";
            this.tabPage_TaiKhoan.UseVisualStyleBackColor = true;
            // 
            // tabPage_Settings
            // 
            this.tabPage_Settings.AutoScroll = true;
            this.tabPage_Settings.ImageIndex = 7;
            this.tabPage_Settings.Location = new System.Drawing.Point(4, 32);
            this.tabPage_Settings.Name = "tabPage_Settings";
            this.tabPage_Settings.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Settings.Size = new System.Drawing.Size(1372, 699);
            this.tabPage_Settings.TabIndex = 6;
            this.tabPage_Settings.Text = "Settings";
            this.tabPage_Settings.UseVisualStyleBackColor = true;
            // 
            // button_Refesh
            // 
            this.button_Refesh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Refesh.BackgroundImage")));
            this.button_Refesh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Refesh.Location = new System.Drawing.Point(49, 3);
            this.button_Refesh.Name = "button_Refesh";
            this.button_Refesh.Size = new System.Drawing.Size(39, 34);
            this.button_Refesh.TabIndex = 0;
            this.button_Refesh.UseVisualStyleBackColor = true;
            this.button_Refesh.Click += new System.EventHandler(this.Button_Refesh_Click);
            // 
            // button_Back
            // 
            this.button_Back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Back.BackgroundImage")));
            this.button_Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Back.Location = new System.Drawing.Point(4, 3);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(39, 34);
            this.button_Back.TabIndex = 0;
            this.button_Back.UseVisualStyleBackColor = true;
            this.button_Back.Click += new System.EventHandler(this.Button_Back_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_Refesh);
            this.panel1.Controls.Add(this.time_Control1);
            this.panel1.Controls.Add(this.button_Back);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 735);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1380, 41);
            this.panel1.TabIndex = 3;
            // 
            // time_Control1
            // 
            this.time_Control1.Location = new System.Drawing.Point(94, 10);
            this.time_Control1.Name = "time_Control1";
            this.time_Control1.Size = new System.Drawing.Size(179, 24);
            this.time_Control1.TabIndex = 0;
            this.time_Control1.Text = "time_Control1";
            // 
            // Manager_Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1380, 776);
            this.Controls.Add(this.tabControl_Menu);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Manager_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager_Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Manager_Form_Load);
            this.tabControl_Menu.ResumeLayout(false);
            this.tabPage_TrangChu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private ImageList imageList_Menu_Icon;
        private TabControl tabControl_Menu;
        private TabPage tabPage_TrangChu;
        private TabPage tabPage_Phong;
        private TabPage tabPage_Oder_Room;
        private TabPage tabPage_Customer;
        private TabPage tabPage_NhanVien;
        private TabPage tabPage_ThongKe;
        private TabPage tabPage_TaiKhoan;
        private TabPage tabPage_Settings;
        private Panel panel1;
        private Presentation_Layers.Time_Control time_Control1;
        private Button button_Refesh;
        private Button button_Back;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Button button_CaiDat;
        private Button button_TaiKhoan;
        private Button button_NhanVien;
        private Button button_ThongKe;
        private Button button_KhachHang;
        private Button button_Phong;
        private Button button_HoaDon;
        private PictureBox pictureBox2;
    }
}