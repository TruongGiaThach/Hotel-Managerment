using System.Windows.Forms;

namespace HotelBookingManagement
{
    partial class Manager_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
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
            this.tabControl_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList_Menu_Icon
            // 
            this.imageList_Menu_Icon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_Menu_Icon.ImageStream")));
            this.imageList_Menu_Icon.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_Menu_Icon.Images.SetKeyName(0, "Account.jpg");
            this.imageList_Menu_Icon.Images.SetKeyName(1, "room.png");
            this.imageList_Menu_Icon.Images.SetKeyName(2, "Order_room.jpg");
            this.imageList_Menu_Icon.Images.SetKeyName(3, "Customer.jpg");
            this.imageList_Menu_Icon.Images.SetKeyName(4, "staff.jpg");
            this.imageList_Menu_Icon.Images.SetKeyName(5, "Money.png");
            // 
            // tabControl_Menu
            // 
            this.tabControl_Menu.Controls.Add(this.tabPage_TaiKhoan);
            this.tabControl_Menu.Controls.Add(this.tabPage_Phong);
            this.tabControl_Menu.Controls.Add(this.tabPage_Oder_Room);
            this.tabControl_Menu.Controls.Add(this.tabPage_Customer);
            this.tabControl_Menu.Controls.Add(this.tabPage_NhanVien);
            this.tabControl_Menu.Controls.Add(this.tabPage_ThongKe);
            this.tabControl_Menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_Menu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl_Menu.ImageList = this.imageList_Menu_Icon;
            this.tabControl_Menu.Location = new System.Drawing.Point(0, 0);
            this.tabControl_Menu.Name = "tabControl_Menu";
            this.tabControl_Menu.SelectedIndex = 0;
            this.tabControl_Menu.Size = new System.Drawing.Size(1380, 597);
            this.tabControl_Menu.TabIndex = 15;
            this.tabControl_Menu.SelectedIndexChanged += new System.EventHandler(this.tabControl_Menu_SelectedIndexChanged);
            // 
            // tabPage_TaiKhoan
            // 
            this.tabPage_TaiKhoan.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage_TaiKhoan.ImageIndex = 0;
            this.tabPage_TaiKhoan.Location = new System.Drawing.Point(4, 35);
            this.tabPage_TaiKhoan.Name = "tabPage_TaiKhoan";
            this.tabPage_TaiKhoan.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_TaiKhoan.Size = new System.Drawing.Size(1372, 558);
            this.tabPage_TaiKhoan.TabIndex = 0;
            this.tabPage_TaiKhoan.Text = "Tài Khoản";
            this.tabPage_TaiKhoan.UseVisualStyleBackColor = true;
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
            // ManagerForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1380, 597);
            this.Controls.Add(this.tabControl_Menu);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager_Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Manager_Form_Load);
            this.tabControl_Menu.ResumeLayout(false);
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
    }
}