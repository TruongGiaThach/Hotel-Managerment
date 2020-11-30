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
            this.tabPage_TaiKhoan = new System.Windows.Forms.TabPage();
            this.tabPage_Phong = new System.Windows.Forms.TabPage();
            this.tabPage_Oder_Room = new System.Windows.Forms.TabPage();
            this.tabPage_Customer = new System.Windows.Forms.TabPage();
            this.tabPage_NhanVien = new System.Windows.Forms.TabPage();
            this.tabPage_ThongKe = new System.Windows.Forms.TabPage();
            this.tabPage_Settings = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tabControl_Menu.SuspendLayout();
            this.tabPage_Settings.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList_Menu_Icon
            // 
            this.imageList_Menu_Icon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_Menu_Icon.ImageStream")));
            this.imageList_Menu_Icon.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_Menu_Icon.Images.SetKeyName(0, "hethong.png");
            this.imageList_Menu_Icon.Images.SetKeyName(1, "room.png");
            this.imageList_Menu_Icon.Images.SetKeyName(2, "hoadon.png");
            this.imageList_Menu_Icon.Images.SetKeyName(3, "Khachhang.png");
            this.imageList_Menu_Icon.Images.SetKeyName(4, "nhanvien.png");
            this.imageList_Menu_Icon.Images.SetKeyName(5, "thongke.png");
            this.imageList_Menu_Icon.Images.SetKeyName(6, "supply-chain-management.png");
            // 
            // tabControl_Menu
            // 
            this.tabControl_Menu.Controls.Add(this.tabPage_TaiKhoan);
            this.tabControl_Menu.Controls.Add(this.tabPage_Phong);
            this.tabControl_Menu.Controls.Add(this.tabPage_Oder_Room);
            this.tabControl_Menu.Controls.Add(this.tabPage_Customer);
            this.tabControl_Menu.Controls.Add(this.tabPage_NhanVien);
            this.tabControl_Menu.Controls.Add(this.tabPage_ThongKe);
            this.tabControl_Menu.Controls.Add(this.tabPage_Settings);
            this.tabControl_Menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_Menu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl_Menu.ImageList = this.imageList_Menu_Icon;
            this.tabControl_Menu.Location = new System.Drawing.Point(0, 0);
            this.tabControl_Menu.Name = "tabControl_Menu";
            this.tabControl_Menu.SelectedIndex = 0;
            this.tabControl_Menu.Size = new System.Drawing.Size(749, 407);
            this.tabControl_Menu.TabIndex = 1;
            this.tabControl_Menu.SelectedIndexChanged += new System.EventHandler(this.tabControl_Menu_SelectedIndexChanged);
            // 
            // tabPage_TaiKhoan
            // 
            this.tabPage_TaiKhoan.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage_TaiKhoan.ImageIndex = 0;
            this.tabPage_TaiKhoan.Location = new System.Drawing.Point(4, 32);
            this.tabPage_TaiKhoan.Name = "tabPage_TaiKhoan";
            this.tabPage_TaiKhoan.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_TaiKhoan.Size = new System.Drawing.Size(741, 371);
            this.tabPage_TaiKhoan.TabIndex = 0;
            this.tabPage_TaiKhoan.Text = "Tài Khoản";
            this.tabPage_TaiKhoan.UseVisualStyleBackColor = true;
            // 
            // tabPage_Phong
            // 
            this.tabPage_Phong.ImageIndex = 1;
            this.tabPage_Phong.Location = new System.Drawing.Point(4, 32);
            this.tabPage_Phong.Name = "tabPage_Phong";
            this.tabPage_Phong.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Phong.Size = new System.Drawing.Size(1372, 561);
            this.tabPage_Phong.TabIndex = 1;
            this.tabPage_Phong.Text = "Phòng";
            this.tabPage_Phong.UseVisualStyleBackColor = true;
            // 
            // tabPage_Oder_Room
            // 
            this.tabPage_Oder_Room.ImageIndex = 2;
            this.tabPage_Oder_Room.Location = new System.Drawing.Point(4, 32);
            this.tabPage_Oder_Room.Name = "tabPage_Oder_Room";
            this.tabPage_Oder_Room.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Oder_Room.Size = new System.Drawing.Size(1372, 561);
            this.tabPage_Oder_Room.TabIndex = 2;
            this.tabPage_Oder_Room.Text = "Hóa Đơn";
            this.tabPage_Oder_Room.UseVisualStyleBackColor = true;
            // 
            // tabPage_Customer
            // 
            this.tabPage_Customer.ImageIndex = 3;
            this.tabPage_Customer.Location = new System.Drawing.Point(4, 32);
            this.tabPage_Customer.Name = "tabPage_Customer";
            this.tabPage_Customer.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Customer.Size = new System.Drawing.Size(1372, 561);
            this.tabPage_Customer.TabIndex = 3;
            this.tabPage_Customer.Text = "Khách Hàng";
            this.tabPage_Customer.UseVisualStyleBackColor = true;
            // 
            // tabPage_NhanVien
            // 
            this.tabPage_NhanVien.ImageIndex = 4;
            this.tabPage_NhanVien.Location = new System.Drawing.Point(4, 32);
            this.tabPage_NhanVien.Name = "tabPage_NhanVien";
            this.tabPage_NhanVien.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_NhanVien.Size = new System.Drawing.Size(1372, 561);
            this.tabPage_NhanVien.TabIndex = 4;
            this.tabPage_NhanVien.Text = "Nhân Viên";
            this.tabPage_NhanVien.UseVisualStyleBackColor = true;
            // 
            // tabPage_ThongKe
            // 
            this.tabPage_ThongKe.ImageIndex = 5;
            this.tabPage_ThongKe.Location = new System.Drawing.Point(4, 32);
            this.tabPage_ThongKe.Name = "tabPage_ThongKe";
            this.tabPage_ThongKe.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_ThongKe.Size = new System.Drawing.Size(741, 371);
            this.tabPage_ThongKe.TabIndex = 5;
            this.tabPage_ThongKe.Text = "Thống Kê";
            this.tabPage_ThongKe.UseVisualStyleBackColor = true;
            // 
            // tabPage_Settings
            // 
            this.tabPage_Settings.Controls.Add(this.tableLayoutPanel1);
            this.tabPage_Settings.ImageIndex = 6;
            this.tabPage_Settings.Location = new System.Drawing.Point(4, 32);
            this.tabPage_Settings.Name = "tabPage_Settings";
            this.tabPage_Settings.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Settings.Size = new System.Drawing.Size(741, 371);
            this.tabPage_Settings.TabIndex = 6;
            this.tabPage_Settings.Text = "Settings";
            this.tabPage_Settings.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.21918F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.78082F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(735, 365);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(729, 242);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tài khoản";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(18, 107);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 99);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tài khoản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(389, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Chức vụ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(394, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ca trực";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(157, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Địa chỉ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(249, 87);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(117, 26);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(249, 136);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(117, 26);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(249, 192);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(321, 26);
            this.textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(470, 136);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 26);
            this.textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(470, 84);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 26);
            this.textBox5.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 251);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(729, 111);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(398, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Đăng xuất";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(570, 36);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 38);
            this.button2.TabIndex = 1;
            this.button2.Text = "Đổi mật khẩu";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(632, 236);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Manager_Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(749, 407);
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
            this.tabPage_Settings.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private ImageList imageList_Menu_Icon;
        private TabControl tabControl_Menu;
        private TabPage tabPage_TaiKhoan;
        private TabPage tabPage_Phong;
        private TabPage tabPage_Oder_Room;
        private TabPage tabPage_Customer;
        private TabPage tabPage_NhanVien;
        private TabPage tabPage_ThongKe;
        private TabPage tabPage_Settings;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox1;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label1;
        private GroupBox groupBox2;
        private Button button2;
        private Button button1;
        private Button button3;
    }
}