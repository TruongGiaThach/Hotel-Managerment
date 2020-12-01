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
            this.tabPage_Phong = new System.Windows.Forms.TabPage();
            this.tabPage_Oder_Room = new System.Windows.Forms.TabPage();
            this.tabPage_Customer = new System.Windows.Forms.TabPage();
            this.tabPage_NhanVien = new System.Windows.Forms.TabPage();
            this.tabPage_ThongKe = new System.Windows.Forms.TabPage();
            this.tabPage_TaiKhoan = new System.Windows.Forms.TabPage();
            this.tabPage_Settings = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.time_Control1 = new HotelBookingManagement.Presentation_Layers.Time_Control();
            this.tabControl_Menu.SuspendLayout();
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
            this.tabControl_Menu.Size = new System.Drawing.Size(1380, 597);
            this.tabControl_Menu.TabIndex = 1;
            this.tabControl_Menu.SelectedIndexChanged += new System.EventHandler(this.tabControl_Menu_SelectedIndexChanged);
            // 
            // tabPage_TrangChu
            // 
            this.tabPage_TrangChu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tabPage_TrangChu.ImageIndex = 0;
            this.tabPage_TrangChu.Location = new System.Drawing.Point(4, 35);
            this.tabPage_TrangChu.Name = "tabPage_TrangChu";
            this.tabPage_TrangChu.Size = new System.Drawing.Size(1372, 558);
            this.tabPage_TrangChu.TabIndex = 0;
            this.tabPage_TrangChu.Text = "Trang Chủ";
            this.tabPage_TrangChu.Click += new System.EventHandler(this.tabPage_TrangChu_Click);
            // 
            // tabPage_Phong
            // 
            this.tabPage_Phong.ImageIndex = 1;
            this.tabPage_Phong.Location = new System.Drawing.Point(4, 35);
            this.tabPage_Phong.Name = "tabPage_Phong";
            this.tabPage_Phong.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Phong.Size = new System.Drawing.Size(1372, 558);
            this.tabPage_Phong.TabIndex = 1;
            this.tabPage_Phong.Text = "Phòng";
            this.tabPage_Phong.UseVisualStyleBackColor = true;
            // 
            // tabPage_Oder_Room
            // 
            this.tabPage_Oder_Room.ImageIndex = 2;
            this.tabPage_Oder_Room.Location = new System.Drawing.Point(4, 35);
            this.tabPage_Oder_Room.Name = "tabPage_Oder_Room";
            this.tabPage_Oder_Room.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Oder_Room.Size = new System.Drawing.Size(1372, 558);
            this.tabPage_Oder_Room.TabIndex = 2;
            this.tabPage_Oder_Room.Text = "Hóa Đơn";
            this.tabPage_Oder_Room.UseVisualStyleBackColor = true;
            // 
            // tabPage_Customer
            // 
            this.tabPage_Customer.ImageIndex = 3;
            this.tabPage_Customer.Location = new System.Drawing.Point(4, 35);
            this.tabPage_Customer.Name = "tabPage_Customer";
            this.tabPage_Customer.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Customer.Size = new System.Drawing.Size(1372, 558);
            this.tabPage_Customer.TabIndex = 3;
            this.tabPage_Customer.Text = "Khách Hàng";
            this.tabPage_Customer.UseVisualStyleBackColor = true;
            // 
            // tabPage_NhanVien
            // 
            this.tabPage_NhanVien.ImageIndex = 4;
            this.tabPage_NhanVien.Location = new System.Drawing.Point(4, 35);
            this.tabPage_NhanVien.Name = "tabPage_NhanVien";
            this.tabPage_NhanVien.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_NhanVien.Size = new System.Drawing.Size(1372, 558);
            this.tabPage_NhanVien.TabIndex = 4;
            this.tabPage_NhanVien.Text = "Nhân Viên";
            this.tabPage_NhanVien.UseVisualStyleBackColor = true;
            // 
            // tabPage_ThongKe
            // 
            this.tabPage_ThongKe.ImageIndex = 5;
            this.tabPage_ThongKe.Location = new System.Drawing.Point(4, 35);
            this.tabPage_ThongKe.Name = "tabPage_ThongKe";
            this.tabPage_ThongKe.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_ThongKe.Size = new System.Drawing.Size(1372, 558);
            this.tabPage_ThongKe.TabIndex = 5;
            this.tabPage_ThongKe.Text = "Thống Kê";
            this.tabPage_ThongKe.UseVisualStyleBackColor = true;
            // 
            // tabPage_TaiKhoan
            // 
            this.tabPage_TaiKhoan.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage_TaiKhoan.ImageIndex = 6;
            this.tabPage_TaiKhoan.Location = new System.Drawing.Point(4, 35);
            this.tabPage_TaiKhoan.Name = "tabPage_TaiKhoan";
            this.tabPage_TaiKhoan.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_TaiKhoan.Size = new System.Drawing.Size(1372, 558);
            this.tabPage_TaiKhoan.TabIndex = 6;
            this.tabPage_TaiKhoan.Text = "Tài Khoản";
            this.tabPage_TaiKhoan.UseVisualStyleBackColor = true;
            // 
            // tabPage_Settings
            // 
            this.tabPage_Settings.ImageIndex = 7;
            this.tabPage_Settings.Location = new System.Drawing.Point(4, 35);
            this.tabPage_Settings.Name = "tabPage_Settings";
            this.tabPage_Settings.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Settings.Size = new System.Drawing.Size(1372, 558);
            this.tabPage_Settings.TabIndex = 6;
            this.tabPage_Settings.Text = "Settings";
            this.tabPage_Settings.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.time_Control1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 566);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1380, 31);
            this.panel1.TabIndex = 3;
            // 
            // time_Control1
            // 
            this.time_Control1.Location = new System.Drawing.Point(0, 3);
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
            this.ClientSize = new System.Drawing.Size(1380, 597);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl_Menu);
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
    }
}