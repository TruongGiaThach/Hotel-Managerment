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
            this.gradientPanelTheme = new System.Windows.Forms.Panel();
            this.ButtonXacNhan = new System.Windows.Forms.Button();
            this.buttonHuy = new System.Windows.Forms.Button();
            this.labelHoVaTen = new System.Windows.Forms.Label();
            this.labelSoDT = new System.Windows.Forms.Label();
            this.labelSoNguoi = new System.Windows.Forms.Label();
            this.labelLoaiPhong = new System.Windows.Forms.Label();
            this.labelSoPhong = new System.Windows.Forms.Label();
            this.labelCMND = new System.Windows.Forms.Label();
            this.textBoxHoTen = new System.Windows.Forms.TextBox();
            this.textBoxCMND = new System.Windows.Forms.TextBox();
            this.textBoxSDT = new System.Windows.Forms.TextBox();
            this.textBoxSoPhong = new System.Windows.Forms.TextBox();
            this.textBoxSoNguoi = new System.Windows.Forms.TextBox();
            this.comboBoxLoaiPhong = new System.Windows.Forms.ComboBox();
            this.labelThanhToan = new System.Windows.Forms.Label();
            this.comboBoxThanhToan = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanelTheme)).BeginInit();
            this.gradientPanelTheme.SuspendLayout();
            this.SuspendLayout();
            // 
            // gradientPanelTheme
            // 
            this.gradientPanelTheme.Controls.Add(this.comboBoxThanhToan);
            this.gradientPanelTheme.Controls.Add(this.comboBoxLoaiPhong);
            this.gradientPanelTheme.Controls.Add(this.textBoxSoNguoi);
            this.gradientPanelTheme.Controls.Add(this.textBoxSoPhong);
            this.gradientPanelTheme.Controls.Add(this.textBoxSDT);
            this.gradientPanelTheme.Controls.Add(this.textBoxCMND);
            this.gradientPanelTheme.Controls.Add(this.textBoxHoTen);
            this.gradientPanelTheme.Controls.Add(this.labelSoPhong);
            this.gradientPanelTheme.Controls.Add(this.labelThanhToan);
            this.gradientPanelTheme.Controls.Add(this.labelLoaiPhong);
            this.gradientPanelTheme.Controls.Add(this.labelSoNguoi);
            this.gradientPanelTheme.Controls.Add(this.labelCMND);
            this.gradientPanelTheme.Controls.Add(this.labelSoDT);
            this.gradientPanelTheme.Controls.Add(this.labelHoVaTen);
            this.gradientPanelTheme.Controls.Add(this.buttonHuy);
            this.gradientPanelTheme.Controls.Add(this.ButtonXacNhan);
            this.gradientPanelTheme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanelTheme.Location = new System.Drawing.Point(0, 0);
            this.gradientPanelTheme.Name = "gradientPanelTheme";
            this.gradientPanelTheme.Size = new System.Drawing.Size(769, 450);
            this.gradientPanelTheme.TabIndex = 0;
            this.gradientPanelTheme.Paint += new System.Windows.Forms.PaintEventHandler(this.gradientPanel1_Paint);
            // 
            // ButtonXacNhan
            // 
            this.ButtonXacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonXacNhan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(178)))), ((int)(((byte)(160)))));
            this.ButtonXacNhan.Location = new System.Drawing.Point(460, 373);
            this.ButtonXacNhan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonXacNhan.Name = "ButtonXacNhan";
            this.ButtonXacNhan.Size = new System.Drawing.Size(183, 51);
            this.ButtonXacNhan.TabIndex = 8;
            this.ButtonXacNhan.Text = "Xác Nhận";
            this.ButtonXacNhan.UseVisualStyleBackColor = true;
            // 
            // buttonHuy
            // 
            this.buttonHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHuy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(178)))), ((int)(((byte)(160)))));
            this.buttonHuy.Location = new System.Drawing.Point(140, 373);
            this.buttonHuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonHuy.Name = "buttonHuy";
            this.buttonHuy.Size = new System.Drawing.Size(183, 51);
            this.buttonHuy.TabIndex = 8;
            this.buttonHuy.Text = "Hủy";
            this.buttonHuy.UseVisualStyleBackColor = true;
            // 
            // labelHoVaTen
            // 
            this.labelHoVaTen.AutoSize = true;
            this.labelHoVaTen.BackColor = System.Drawing.Color.Transparent;
            this.labelHoVaTen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHoVaTen.ForeColor = System.Drawing.SystemColors.Control;
            this.labelHoVaTen.Location = new System.Drawing.Point(48, 49);
            this.labelHoVaTen.Name = "labelHoVaTen";
            this.labelHoVaTen.Size = new System.Drawing.Size(118, 26);
            this.labelHoVaTen.TabIndex = 9;
            this.labelHoVaTen.Text = "Họ và tên:";
            // 
            // labelSoDT
            // 
            this.labelSoDT.AutoSize = true;
            this.labelSoDT.BackColor = System.Drawing.Color.Transparent;
            this.labelSoDT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSoDT.ForeColor = System.Drawing.SystemColors.Control;
            this.labelSoDT.Location = new System.Drawing.Point(48, 141);
            this.labelSoDT.Name = "labelSoDT";
            this.labelSoDT.Size = new System.Drawing.Size(81, 26);
            this.labelSoDT.TabIndex = 9;
            this.labelSoDT.Text = "Số ĐT:";
            // 
            // labelSoNguoi
            // 
            this.labelSoNguoi.AutoSize = true;
            this.labelSoNguoi.BackColor = System.Drawing.Color.Transparent;
            this.labelSoNguoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSoNguoi.ForeColor = System.Drawing.SystemColors.Control;
            this.labelSoNguoi.Location = new System.Drawing.Point(48, 186);
            this.labelSoNguoi.Name = "labelSoNguoi";
            this.labelSoNguoi.Size = new System.Drawing.Size(110, 26);
            this.labelSoNguoi.TabIndex = 9;
            this.labelSoNguoi.Text = "Số người:";
            // 
            // labelLoaiPhong
            // 
            this.labelLoaiPhong.AutoSize = true;
            this.labelLoaiPhong.BackColor = System.Drawing.Color.Transparent;
            this.labelLoaiPhong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoaiPhong.ForeColor = System.Drawing.SystemColors.Control;
            this.labelLoaiPhong.Location = new System.Drawing.Point(48, 228);
            this.labelLoaiPhong.Name = "labelLoaiPhong";
            this.labelLoaiPhong.Size = new System.Drawing.Size(130, 26);
            this.labelLoaiPhong.TabIndex = 9;
            this.labelLoaiPhong.Text = "Loại Phòng";
            this.labelLoaiPhong.Click += new System.EventHandler(this.labelLoaiPhong_Click);
            // 
            // labelSoPhong
            // 
            this.labelSoPhong.AutoSize = true;
            this.labelSoPhong.BackColor = System.Drawing.Color.Transparent;
            this.labelSoPhong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSoPhong.ForeColor = System.Drawing.SystemColors.Control;
            this.labelSoPhong.Location = new System.Drawing.Point(48, 276);
            this.labelSoPhong.Name = "labelSoPhong";
            this.labelSoPhong.Size = new System.Drawing.Size(108, 26);
            this.labelSoPhong.TabIndex = 9;
            this.labelSoPhong.Text = "Số Phòng";
            // 
            // labelCMND
            // 
            this.labelCMND.AutoSize = true;
            this.labelCMND.BackColor = System.Drawing.Color.Transparent;
            this.labelCMND.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCMND.ForeColor = System.Drawing.SystemColors.Control;
            this.labelCMND.Location = new System.Drawing.Point(48, 92);
            this.labelCMND.Name = "labelCMND";
            this.labelCMND.Size = new System.Drawing.Size(94, 26);
            this.labelCMND.TabIndex = 9;
            this.labelCMND.Text = "CMND:";
            // 
            // textBoxHoTen
            // 
            this.textBoxHoTen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHoTen.Location = new System.Drawing.Point(202, 41);
            this.textBoxHoTen.Name = "textBoxHoTen";
            this.textBoxHoTen.Size = new System.Drawing.Size(494, 35);
            this.textBoxHoTen.TabIndex = 10;
            // 
            // textBoxCMND
            // 
            this.textBoxCMND.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCMND.Location = new System.Drawing.Point(202, 89);
            this.textBoxCMND.Name = "textBoxCMND";
            this.textBoxCMND.Size = new System.Drawing.Size(494, 35);
            this.textBoxCMND.TabIndex = 10;
            // 
            // textBoxSDT
            // 
            this.textBoxSDT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSDT.Location = new System.Drawing.Point(202, 138);
            this.textBoxSDT.Name = "textBoxSDT";
            this.textBoxSDT.Size = new System.Drawing.Size(494, 35);
            this.textBoxSDT.TabIndex = 10;
            // 
            // textBoxSoPhong
            // 
            this.textBoxSoPhong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSoPhong.Location = new System.Drawing.Point(202, 273);
            this.textBoxSoPhong.Name = "textBoxSoPhong";
            this.textBoxSoPhong.Size = new System.Drawing.Size(156, 35);
            this.textBoxSoPhong.TabIndex = 10;
            // 
            // textBoxSoNguoi
            // 
            this.textBoxSoNguoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSoNguoi.Location = new System.Drawing.Point(202, 183);
            this.textBoxSoNguoi.Name = "textBoxSoNguoi";
            this.textBoxSoNguoi.Size = new System.Drawing.Size(156, 35);
            this.textBoxSoNguoi.TabIndex = 10;
            // 
            // comboBoxLoaiPhong
            // 
            this.comboBoxLoaiPhong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(12)));
            this.comboBoxLoaiPhong.FormattingEnabled = true;
            this.comboBoxLoaiPhong.Location = new System.Drawing.Point(202, 230);
            this.comboBoxLoaiPhong.Name = "comboBoxLoaiPhong";
            this.comboBoxLoaiPhong.Size = new System.Drawing.Size(121, 35);
            this.comboBoxLoaiPhong.TabIndex = 11;
            // 
            // labelThanhToan
            // 
            this.labelThanhToan.AutoSize = true;
            this.labelThanhToan.BackColor = System.Drawing.Color.Transparent;
            this.labelThanhToan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelThanhToan.ForeColor = System.Drawing.SystemColors.Control;
            this.labelThanhToan.Location = new System.Drawing.Point(45, 318);
            this.labelThanhToan.Name = "labelThanhToan";
            this.labelThanhToan.Size = new System.Drawing.Size(134, 26);
            this.labelThanhToan.TabIndex = 9;
            this.labelThanhToan.Text = "Thanh Toán";
            this.labelThanhToan.Click += new System.EventHandler(this.labelLoaiPhong_Click);
            // 
            // comboBoxThanhToan
            // 
            this.comboBoxThanhToan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(12)));
            this.comboBoxThanhToan.FormattingEnabled = true;
            this.comboBoxThanhToan.Items.AddRange(new object[] {
            "Đã thanh toán",
            "chưa thanh toán"});
            this.comboBoxThanhToan.Location = new System.Drawing.Point(202, 315);
            this.comboBoxThanhToan.Name = "comboBoxThanhToan";
            this.comboBoxThanhToan.Size = new System.Drawing.Size(198, 35);
            this.comboBoxThanhToan.TabIndex = 11;
            // 
            // LayPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 450);
            this.Controls.Add(this.gradientPanelTheme);
            this.MaximizeBox = false;
            this.Name = "LayPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lấy Phòng";
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanelTheme)).EndInit();
            this.gradientPanelTheme.ResumeLayout(false);
            this.gradientPanelTheme.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel gradientPanelTheme;
        private System.Windows.Forms.Label labelSoPhong;
        private System.Windows.Forms.Label labelLoaiPhong;
        private System.Windows.Forms.Label labelSoNguoi;
        private System.Windows.Forms.Label labelCMND;
        private System.Windows.Forms.Label labelSoDT;
        private System.Windows.Forms.Label labelHoVaTen;
        private System.Windows.Forms.Button buttonHuy;
        private System.Windows.Forms.Button ButtonXacNhan;
        private System.Windows.Forms.ComboBox comboBoxLoaiPhong;
        private System.Windows.Forms.TextBox textBoxSoNguoi;
        private System.Windows.Forms.TextBox textBoxSoPhong;
        private System.Windows.Forms.TextBox textBoxSDT;
        private System.Windows.Forms.TextBox textBoxCMND;
        private System.Windows.Forms.TextBox textBoxHoTen;
        private System.Windows.Forms.ComboBox comboBoxThanhToan;
        private System.Windows.Forms.Label labelThanhToan;
    }
}