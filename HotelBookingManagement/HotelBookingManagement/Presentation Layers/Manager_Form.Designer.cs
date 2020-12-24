using HotelBookingManagement.Data_Access_Layers;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HotelBookingManagement
{
    partial class Manager_Form
    {
        /// <summary>
        /// Required designer variable.
        System.Drawing.Font Button_Font;
        /// </summary>
        private System.ComponentModel.IContainer components = null;
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
            this.tabPage_Phong = new System.Windows.Forms.TabPage();
            this.tabPage_Oder_Room = new System.Windows.Forms.TabPage();
            this.tabPage_Customer = new System.Windows.Forms.TabPage();
            this.tabPage_NhanVien = new System.Windows.Forms.TabPage();
            this.tabPage_ThongKe = new System.Windows.Forms.TabPage();
            this.tabPage_TaiKhoan = new System.Windows.Forms.TabPage();
            this.tabPage_Settings = new System.Windows.Forms.TabPage();
            this.Button_CaiDat = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Button_TaiKhoan = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Button_NhanVien = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Button_DangKi = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Button_ThongKe = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Button_KhachHang = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Button_Phong = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_Refesh = new System.Windows.Forms.Button();
            this.button_Back = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.time_Control1 = new HotelBookingManagement.Presentation_Layers.Time_Control();
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ToolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl_Menu.SuspendLayout();
            this.tabPage_TrangChu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.tabControl_Menu.ItemSize = new System.Drawing.Size(132, 40);
            this.tabControl_Menu.Location = new System.Drawing.Point(0, 0);
            this.tabControl_Menu.Name = "tabControl_Menu";
            this.tabControl_Menu.SelectedIndex = 0;
            this.tabControl_Menu.Size = new System.Drawing.Size(1380, 721);
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
            this.tabPage_TrangChu.Location = new System.Drawing.Point(4, 44);
            this.tabPage_TrangChu.Name = "tabPage_TrangChu";
            this.tabPage_TrangChu.Size = new System.Drawing.Size(1372, 673);
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
            this.pictureBox2.Size = new System.Drawing.Size(638, 673);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(734, 673);
            this.panel2.TabIndex = 2;
            // 
            // tabPage_Phong
            // 
            this.tabPage_Phong.AutoScroll = true;
            this.tabPage_Phong.ImageIndex = 1;
            this.tabPage_Phong.Location = new System.Drawing.Point(4, 44);
            this.tabPage_Phong.Name = "tabPage_Phong";
            this.tabPage_Phong.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Phong.Size = new System.Drawing.Size(1372, 673);
            this.tabPage_Phong.TabIndex = 1;
            this.tabPage_Phong.Text = "Phòng";
            this.tabPage_Phong.UseVisualStyleBackColor = true;
            // 
            // tabPage_Oder_Room
            // 
            this.tabPage_Oder_Room.AutoScroll = true;
            this.tabPage_Oder_Room.ImageIndex = 2;
            this.tabPage_Oder_Room.Location = new System.Drawing.Point(4, 44);
            this.tabPage_Oder_Room.Name = "tabPage_Oder_Room";
            this.tabPage_Oder_Room.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Oder_Room.Size = new System.Drawing.Size(1372, 673);
            this.tabPage_Oder_Room.TabIndex = 9;
            this.tabPage_Oder_Room.Text = "Đăng kí";
            this.tabPage_Oder_Room.UseVisualStyleBackColor = true;
            // 
            // tabPage_Customer
            // 
            this.tabPage_Customer.AutoScroll = true;
            this.tabPage_Customer.ImageIndex = 3;
            this.tabPage_Customer.Location = new System.Drawing.Point(4, 44);
            this.tabPage_Customer.Name = "tabPage_Customer";
            this.tabPage_Customer.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Customer.Size = new System.Drawing.Size(1372, 673);
            this.tabPage_Customer.TabIndex = 10;
            this.tabPage_Customer.Text = "Khách Hàng";
            this.tabPage_Customer.UseVisualStyleBackColor = true;
            // 
            // tabPage_NhanVien
            // 
            this.tabPage_NhanVien.AutoScroll = true;
            this.tabPage_NhanVien.ImageIndex = 4;
            this.tabPage_NhanVien.Location = new System.Drawing.Point(4, 44);
            this.tabPage_NhanVien.Name = "tabPage_NhanVien";
            this.tabPage_NhanVien.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_NhanVien.Size = new System.Drawing.Size(1372, 673);
            this.tabPage_NhanVien.TabIndex = 11;
            this.tabPage_NhanVien.Text = "Nhân Viên";
            this.tabPage_NhanVien.UseVisualStyleBackColor = true;
            // 
            // tabPage_ThongKe
            // 
            this.tabPage_ThongKe.AutoScroll = true;
            this.tabPage_ThongKe.ImageIndex = 5;
            this.tabPage_ThongKe.Location = new System.Drawing.Point(4, 44);
            this.tabPage_ThongKe.Name = "tabPage_ThongKe";
            this.tabPage_ThongKe.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_ThongKe.Size = new System.Drawing.Size(1372, 673);
            this.tabPage_ThongKe.TabIndex = 12;
            this.tabPage_ThongKe.Text = "Thống Kê";
            this.tabPage_ThongKe.UseVisualStyleBackColor = true;
            // 
            // tabPage_TaiKhoan
            // 
            this.tabPage_TaiKhoan.AutoScroll = true;
            this.tabPage_TaiKhoan.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage_TaiKhoan.ImageIndex = 6;
            this.tabPage_TaiKhoan.Location = new System.Drawing.Point(4, 44);
            this.tabPage_TaiKhoan.Name = "tabPage_TaiKhoan";
            this.tabPage_TaiKhoan.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_TaiKhoan.Size = new System.Drawing.Size(1372, 673);
            this.tabPage_TaiKhoan.TabIndex = 13;
            this.tabPage_TaiKhoan.Text = "Tài Khoản";
            this.tabPage_TaiKhoan.UseVisualStyleBackColor = true;
            // 
            // tabPage_Settings
            // 
            this.tabPage_Settings.AutoScroll = true;
            this.tabPage_Settings.ImageIndex = 7;
            this.tabPage_Settings.Location = new System.Drawing.Point(4, 44);
            this.tabPage_Settings.Name = "tabPage_Settings";
            this.tabPage_Settings.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Settings.Size = new System.Drawing.Size(1372, 673);
            this.tabPage_Settings.TabIndex = 14;
            this.tabPage_Settings.Text = "Settings";
            this.tabPage_Settings.UseVisualStyleBackColor = true;
            // 
            // Button_CaiDat
            // 
            this.Button_CaiDat.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Gallery;
            this.Button_CaiDat.Location = new System.Drawing.Point(231, 460);
            this.Button_CaiDat.Name = "Button_CaiDat";
            this.Button_CaiDat.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.Button_CaiDat.Size = new System.Drawing.Size(198, 67);
            this.Button_CaiDat.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Button_CaiDat.StateCommon.Border.Rounding = 8;
            this.Button_CaiDat.StateNormal.Border.Color1 = System.Drawing.Color.Magenta;
            this.Button_CaiDat.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Button_CaiDat.StateNormal.Border.Rounding = 7;
            this.Button_CaiDat.StateNormal.Border.Width = 1;
            this.Button_CaiDat.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_CaiDat.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Button_CaiDat.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Button_CaiDat.StatePressed.Border.Color1 = System.Drawing.Color.Magenta;
            this.Button_CaiDat.StatePressed.Border.Color2 = System.Drawing.Color.Magenta;
            this.Button_CaiDat.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Button_CaiDat.StatePressed.Border.Rounding = 7;
            this.Button_CaiDat.StatePressed.Border.Width = 1;
            this.Button_CaiDat.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_CaiDat.StateTracking.Back.Color1 = System.Drawing.Color.Magenta;
            this.Button_CaiDat.StateTracking.Back.Color2 = System.Drawing.Color.Magenta;
            this.Button_CaiDat.StateTracking.Border.Color1 = System.Drawing.Color.Magenta;
            this.Button_CaiDat.StateTracking.Border.Color2 = System.Drawing.Color.Magenta;
            this.Button_CaiDat.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Button_CaiDat.StateTracking.Border.Rounding = 7;
            this.Button_CaiDat.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_CaiDat.TabIndex = 7;
            this.Button_CaiDat.Values.Text = "Cài Đặt";
            this.Button_CaiDat.Click += new System.EventHandler(this.button_CaiDat_Click);
            // 
            // Button_TaiKhoan
            // 
            this.Button_TaiKhoan.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Gallery;
            this.Button_TaiKhoan.Location = new System.Drawing.Point(365, 374);
            this.Button_TaiKhoan.Name = "Button_TaiKhoan";
            this.Button_TaiKhoan.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.Button_TaiKhoan.Size = new System.Drawing.Size(198, 67);
            this.Button_TaiKhoan.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Button_TaiKhoan.StateCommon.Border.Rounding = 8;
            this.Button_TaiKhoan.StateNormal.Border.Color1 = System.Drawing.Color.Blue;
            this.Button_TaiKhoan.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Button_TaiKhoan.StateNormal.Border.Rounding = 7;
            this.Button_TaiKhoan.StateNormal.Border.Width = 1;
            this.Button_TaiKhoan.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_TaiKhoan.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Button_TaiKhoan.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Button_TaiKhoan.StatePressed.Border.Color1 = System.Drawing.Color.Blue;
            this.Button_TaiKhoan.StatePressed.Border.Color2 = System.Drawing.Color.Blue;
            this.Button_TaiKhoan.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Button_TaiKhoan.StatePressed.Border.Rounding = 7;
            this.Button_TaiKhoan.StatePressed.Border.Width = 1;
            this.Button_TaiKhoan.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_TaiKhoan.StateTracking.Back.Color1 = System.Drawing.Color.Blue;
            this.Button_TaiKhoan.StateTracking.Back.Color2 = System.Drawing.Color.Blue;
            this.Button_TaiKhoan.StateTracking.Border.Color1 = System.Drawing.Color.Blue;
            this.Button_TaiKhoan.StateTracking.Border.Color2 = System.Drawing.Color.Blue;
            this.Button_TaiKhoan.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Button_TaiKhoan.StateTracking.Border.Rounding = 7;
            this.Button_TaiKhoan.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_TaiKhoan.TabIndex = 6;
            this.Button_TaiKhoan.Values.Text = "Tài Khoản";
            this.Button_TaiKhoan.Click += new System.EventHandler(this.button_TaiKhoan_Click);
            // 
            // Button_NhanVien
            // 
            this.Button_NhanVien.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Gallery;
            this.Button_NhanVien.Location = new System.Drawing.Point(365, 270);
            this.Button_NhanVien.Name = "Button_NhanVien";
            this.Button_NhanVien.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.Button_NhanVien.Size = new System.Drawing.Size(198, 67);
            this.Button_NhanVien.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Button_NhanVien.StateCommon.Border.Rounding = 8;
            this.Button_NhanVien.StateNormal.Border.Color1 = System.Drawing.Color.Lime;
            this.Button_NhanVien.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Button_NhanVien.StateNormal.Border.Rounding = 7;
            this.Button_NhanVien.StateNormal.Border.Width = 1;
            this.Button_NhanVien.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_NhanVien.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Button_NhanVien.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Button_NhanVien.StatePressed.Border.Color1 = System.Drawing.Color.Lime;
            this.Button_NhanVien.StatePressed.Border.Color2 = System.Drawing.Color.Lime;
            this.Button_NhanVien.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Button_NhanVien.StatePressed.Border.Rounding = 7;
            this.Button_NhanVien.StatePressed.Border.Width = 1;
            this.Button_NhanVien.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_NhanVien.StateTracking.Back.Color1 = System.Drawing.Color.Lime;
            this.Button_NhanVien.StateTracking.Back.Color2 = System.Drawing.Color.Lime;
            this.Button_NhanVien.StateTracking.Border.Color1 = System.Drawing.Color.Lime;
            this.Button_NhanVien.StateTracking.Border.Color2 = System.Drawing.Color.Lime;
            this.Button_NhanVien.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Button_NhanVien.StateTracking.Border.Rounding = 7;
            this.Button_NhanVien.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_NhanVien.TabIndex = 5;
            this.Button_NhanVien.Values.Text = "Nhân Viên";
            this.Button_NhanVien.Click += new System.EventHandler(this.button_NhanVien_Click);
            // 
            // Button_DangKi
            // 
            this.Button_DangKi.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Gallery;
            this.Button_DangKi.Location = new System.Drawing.Point(365, 168);
            this.Button_DangKi.Name = "Button_DangKi";
            this.Button_DangKi.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.Button_DangKi.Size = new System.Drawing.Size(198, 67);
            this.Button_DangKi.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Button_DangKi.StateCommon.Border.Rounding = 8;
            this.Button_DangKi.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Button_DangKi.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Button_DangKi.StateNormal.Border.Rounding = 7;
            this.Button_DangKi.StateNormal.Border.Width = 1;
            this.Button_DangKi.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_DangKi.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Button_DangKi.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Button_DangKi.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Button_DangKi.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Button_DangKi.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Button_DangKi.StatePressed.Border.Rounding = 7;
            this.Button_DangKi.StatePressed.Border.Width = 1;
            this.Button_DangKi.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_DangKi.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Button_DangKi.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Button_DangKi.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Button_DangKi.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Button_DangKi.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Button_DangKi.StateTracking.Border.Rounding = 7;
            this.Button_DangKi.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_DangKi.TabIndex = 4;
            this.Button_DangKi.Values.Text = "Đăng Kí";
            this.Button_DangKi.Click += new System.EventHandler(this.button_HoaDon_Click);
            // 
            // Button_ThongKe
            // 
            this.Button_ThongKe.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Gallery;
            this.Button_ThongKe.Location = new System.Drawing.Point(102, 374);
            this.Button_ThongKe.Name = "Button_ThongKe";
            this.Button_ThongKe.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.Button_ThongKe.Size = new System.Drawing.Size(198, 67);
            this.Button_ThongKe.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Button_ThongKe.StateCommon.Border.Rounding = 8;
            this.Button_ThongKe.StateNormal.Border.Color1 = System.Drawing.Color.Cyan;
            this.Button_ThongKe.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Button_ThongKe.StateNormal.Border.Rounding = 7;
            this.Button_ThongKe.StateNormal.Border.Width = 1;
            this.Button_ThongKe.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_ThongKe.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Button_ThongKe.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Button_ThongKe.StatePressed.Border.Color1 = System.Drawing.Color.Cyan;
            this.Button_ThongKe.StatePressed.Border.Color2 = System.Drawing.Color.Cyan;
            this.Button_ThongKe.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Button_ThongKe.StatePressed.Border.Rounding = 7;
            this.Button_ThongKe.StatePressed.Border.Width = 1;
            this.Button_ThongKe.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_ThongKe.StateTracking.Back.Color1 = System.Drawing.Color.Cyan;
            this.Button_ThongKe.StateTracking.Back.Color2 = System.Drawing.Color.Cyan;
            this.Button_ThongKe.StateTracking.Border.Color1 = System.Drawing.Color.Cyan;
            this.Button_ThongKe.StateTracking.Border.Color2 = System.Drawing.Color.Cyan;
            this.Button_ThongKe.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Button_ThongKe.StateTracking.Border.Rounding = 7;
            this.Button_ThongKe.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_ThongKe.TabIndex = 3;
            this.Button_ThongKe.Values.Text = "Thống Kê";
            this.Button_ThongKe.Click += new System.EventHandler(this.button_HeThong_Click);
            // 
            // Button_KhachHang
            // 
            this.Button_KhachHang.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Gallery;
            this.Button_KhachHang.Location = new System.Drawing.Point(102, 270);
            this.Button_KhachHang.Name = "Button_KhachHang";
            this.Button_KhachHang.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.Button_KhachHang.Size = new System.Drawing.Size(198, 67);
            this.Button_KhachHang.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Button_KhachHang.StateCommon.Border.Rounding = 8;
            this.Button_KhachHang.StateNormal.Border.Color1 = System.Drawing.Color.Yellow;
            this.Button_KhachHang.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Button_KhachHang.StateNormal.Border.Rounding = 7;
            this.Button_KhachHang.StateNormal.Border.Width = 1;
            this.Button_KhachHang.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_KhachHang.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Button_KhachHang.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Button_KhachHang.StatePressed.Border.Color1 = System.Drawing.Color.Yellow;
            this.Button_KhachHang.StatePressed.Border.Color2 = System.Drawing.Color.Yellow;
            this.Button_KhachHang.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Button_KhachHang.StatePressed.Border.Rounding = 7;
            this.Button_KhachHang.StatePressed.Border.Width = 1;
            this.Button_KhachHang.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_KhachHang.StateTracking.Back.Color1 = System.Drawing.Color.Yellow;
            this.Button_KhachHang.StateTracking.Back.Color2 = System.Drawing.Color.Yellow;
            this.Button_KhachHang.StateTracking.Border.Color1 = System.Drawing.Color.Yellow;
            this.Button_KhachHang.StateTracking.Border.Color2 = System.Drawing.Color.Yellow;
            this.Button_KhachHang.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Button_KhachHang.StateTracking.Border.Rounding = 7;
            this.Button_KhachHang.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_KhachHang.TabIndex = 2;
            this.Button_KhachHang.Values.Text = "Khách Hàng";
            this.Button_KhachHang.Click += new System.EventHandler(this.button_KhachHang_Click);
            // 
            // Button_Phong
            // 
            this.Button_Phong.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Gallery;
            this.Button_Phong.Location = new System.Drawing.Point(102, 168);
            this.Button_Phong.Name = "Button_Phong";
            this.Button_Phong.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.Button_Phong.Size = new System.Drawing.Size(198, 67);
            this.Button_Phong.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Button_Phong.StateCommon.Border.Rounding = 8;
            this.Button_Phong.StateNormal.Border.Color1 = System.Drawing.Color.Red;
            this.Button_Phong.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Button_Phong.StateNormal.Border.Rounding = 7;
            this.Button_Phong.StateNormal.Border.Width = 1;
            this.Button_Phong.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Phong.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_Phong.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_Phong.StatePressed.Border.Color1 = System.Drawing.Color.Red;
            this.Button_Phong.StatePressed.Border.Color2 = System.Drawing.Color.Red;
            this.Button_Phong.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Button_Phong.StatePressed.Border.Rounding = 7;
            this.Button_Phong.StatePressed.Border.Width = 1;
            this.Button_Phong.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Phong.StateTracking.Back.Color1 = System.Drawing.Color.Red;
            this.Button_Phong.StateTracking.Back.Color2 = System.Drawing.Color.Red;
            this.Button_Phong.StateTracking.Border.Color1 = System.Drawing.Color.Red;
            this.Button_Phong.StateTracking.Border.Color2 = System.Drawing.Color.Red;
            this.Button_Phong.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Button_Phong.StateTracking.Border.Rounding = 7;
            this.Button_Phong.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Phong.TabIndex = 1;
            this.Button_Phong.Values.Text = "Phòng";
            this.Button_Phong.Click += new System.EventHandler(this.button_Phong_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(294, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button_Refesh
            // 
            this.button_Refesh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Refesh.BackgroundImage")));
            this.button_Refesh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Refesh.FlatAppearance.BorderSize = 0;
            this.button_Refesh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Refesh.Location = new System.Drawing.Point(63, 2);
            this.button_Refesh.Name = "button_Refesh";
            this.button_Refesh.Size = new System.Drawing.Size(51, 49);
            this.button_Refesh.TabIndex = 20;
            this.ToolTip1.SetToolTip(this.button_Refesh, "Tải lại trang này");
            this.button_Refesh.UseVisualStyleBackColor = true;
            this.button_Refesh.Click += new System.EventHandler(this.Button_Refesh_Click);
            // 
            // button_Back
            // 
            this.button_Back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Back.BackgroundImage")));
            this.button_Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Back.FlatAppearance.BorderSize = 0;
            this.button_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Back.Location = new System.Drawing.Point(4, 3);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(53, 49);
            this.button_Back.TabIndex = 21;
            this.ToolTip1.SetToolTip(this.button_Back, "Về trang chủ");
            this.button_Back.UseVisualStyleBackColor = true;
            this.button_Back.Click += new System.EventHandler(this.Button_Back_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button_Refesh);
            this.panel1.Controls.Add(this.time_Control1);
            this.panel1.Controls.Add(this.button_Back);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 721);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1380, 55);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(641, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 29);
            this.label1.TabIndex = 0;
            // 
            // time_Control1
            // 
            this.time_Control1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.time_Control1.Location = new System.Drawing.Point(1189, 16);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        #region add tabpage

        public void InitTabPage(string UserPiot)
        {
            this.tabControl_Menu.TabPages.Clear();
            switch (UserPiot)
            {
                case "user":
                    this.tabControl_Menu.Controls.Add(this.tabPage_TrangChu);
                    this.tabControl_Menu.Controls.Add(this.tabPage_Phong);
                    this.tabControl_Menu.Controls.Add(this.tabPage_Oder_Room);
                    this.tabControl_Menu.Controls.Add(this.tabPage_Customer);
                    this.tabControl_Menu.Controls.Add(this.tabPage_Settings);
                    break;
                case "admin":
                    this.tabControl_Menu.Controls.Add(this.tabPage_TrangChu);
                    this.tabControl_Menu.Controls.Add(this.tabPage_Phong);
                    this.tabControl_Menu.Controls.Add(this.tabPage_Oder_Room);
                    this.tabControl_Menu.Controls.Add(this.tabPage_Customer);
                    this.tabControl_Menu.Controls.Add(this.tabPage_NhanVien);
                    this.tabControl_Menu.Controls.Add(this.tabPage_ThongKe);
                    this.tabControl_Menu.Controls.Add(this.tabPage_TaiKhoan);
                    this.tabControl_Menu.Controls.Add(this.tabPage_Settings);
                    break;
            }
        }

        public void InitTabButton(string UserPiot)
        {
            this.panel2.Controls.Clear();
            switch (UserPiot)
            {
                case "user":
                    this.panel2.Controls.Add(this.pictureBox1);
                    this.panel2.Controls.Add(this.Button_Phong);
                    this.panel2.Controls.Add(this.Button_KhachHang);
                    this.panel2.Controls.Add(this.Button_DangKi);
                    this.panel2.Controls.Add(this.Button_CaiDat);
                    this.Button_CaiDat.Location = new System.Drawing.Point(365, 270);
                    break;
                case "admin":
                    this.panel2.Controls.Add(this.pictureBox1);
                    this.panel2.Controls.Add(this.Button_Phong);
                    this.panel2.Controls.Add(this.Button_KhachHang);
                    this.panel2.Controls.Add(this.Button_ThongKe);
                    this.panel2.Controls.Add(this.Button_DangKi);
                    this.panel2.Controls.Add(this.Button_TaiKhoan);
                    this.panel2.Controls.Add(this.Button_NhanVien);
                    this.panel2.Controls.Add(this.Button_CaiDat);
                    this.Button_CaiDat.Location = new System.Drawing.Point(231, 460);
                    break;
            }
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
        private PictureBox pictureBox2;
        private Label label1;
        private ToolTip ToolTip1;
        private ToolTip ToolTip2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Button_Phong;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Button_TaiKhoan;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Button_NhanVien;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Button_DangKi;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Button_ThongKe;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Button_KhachHang;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Button_CaiDat;
    }
}