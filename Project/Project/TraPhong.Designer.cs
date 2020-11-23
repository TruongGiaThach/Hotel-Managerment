namespace Project
{
    partial class TraPhong
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
            this.gradientPanelTheme = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.comboBoxTimKiem = new System.Windows.Forms.ComboBox();
            this.buttonHuy = new System.Windows.Forms.Button();
            this.ButtonThanhToan = new System.Windows.Forms.Button();
            this.panelKhungThongTin = new System.Windows.Forms.Panel();
            this.ButtonLayThongTin = new System.Windows.Forms.Button();
            this.textBoxSoNguoi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanelTheme)).BeginInit();
            this.gradientPanelTheme.SuspendLayout();
            this.SuspendLayout();
            // 
            // gradientPanelTheme
            // 
            this.gradientPanelTheme.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathEllipse, System.Drawing.Color.Aquamarine, System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(165))))));
            this.gradientPanelTheme.Controls.Add(this.comboBoxTimKiem);
            this.gradientPanelTheme.Controls.Add(this.buttonHuy);
            this.gradientPanelTheme.Controls.Add(this.ButtonThanhToan);
            this.gradientPanelTheme.Controls.Add(this.panelKhungThongTin);
            this.gradientPanelTheme.Controls.Add(this.ButtonLayThongTin);
            this.gradientPanelTheme.Controls.Add(this.textBoxSoNguoi);
            this.gradientPanelTheme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanelTheme.Location = new System.Drawing.Point(0, 0);
            this.gradientPanelTheme.Name = "gradientPanelTheme";
            this.gradientPanelTheme.Size = new System.Drawing.Size(800, 655);
            this.gradientPanelTheme.TabIndex = 1;
            // 
            // comboBoxTimKiem
            // 
            this.comboBoxTimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(12)));
            this.comboBoxTimKiem.FormattingEnabled = true;
            this.comboBoxTimKiem.Items.AddRange(new object[] {
            "Số Phòng",
            "CMND",
            "Họ Tên"});
            this.comboBoxTimKiem.Location = new System.Drawing.Point(22, 24);
            this.comboBoxTimKiem.Name = "comboBoxTimKiem";
            this.comboBoxTimKiem.Size = new System.Drawing.Size(198, 35);
            this.comboBoxTimKiem.TabIndex = 19;
            // 
            // buttonHuy
            // 
            this.buttonHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHuy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(178)))), ((int)(((byte)(160)))));
            this.buttonHuy.Location = new System.Drawing.Point(89, 576);
            this.buttonHuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonHuy.Name = "buttonHuy";
            this.buttonHuy.Size = new System.Drawing.Size(183, 51);
            this.buttonHuy.TabIndex = 18;
            this.buttonHuy.Text = "Hủy";
            this.buttonHuy.UseVisualStyleBackColor = true;
            // 
            // ButtonThanhToan
            // 
            this.ButtonThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonThanhToan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(178)))), ((int)(((byte)(160)))));
            this.ButtonThanhToan.Location = new System.Drawing.Point(524, 576);
            this.ButtonThanhToan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonThanhToan.Name = "ButtonThanhToan";
            this.ButtonThanhToan.Size = new System.Drawing.Size(183, 51);
            this.ButtonThanhToan.TabIndex = 17;
            this.ButtonThanhToan.Text = "Thanh Toán";
            this.ButtonThanhToan.UseVisualStyleBackColor = true;
            // 
            // panelKhungThongTin
            // 
            this.panelKhungThongTin.Location = new System.Drawing.Point(10, 118);
            this.panelKhungThongTin.Name = "panelKhungThongTin";
            this.panelKhungThongTin.Size = new System.Drawing.Size(776, 431);
            this.panelKhungThongTin.TabIndex = 16;
            // 
            // ButtonLayThongTin
            // 
            this.ButtonLayThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonLayThongTin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(178)))), ((int)(((byte)(160)))));
            this.ButtonLayThongTin.Location = new System.Drawing.Point(299, 75);
            this.ButtonLayThongTin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonLayThongTin.Name = "ButtonLayThongTin";
            this.ButtonLayThongTin.Size = new System.Drawing.Size(183, 38);
            this.ButtonLayThongTin.TabIndex = 15;
            this.ButtonLayThongTin.Text = "Lấy thông tin";
            this.ButtonLayThongTin.UseVisualStyleBackColor = true;
            this.ButtonLayThongTin.Click += new System.EventHandler(this.ButtonLayThongTin_Click);
            // 
            // textBoxSoNguoi
            // 
            this.textBoxSoNguoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSoNguoi.Location = new System.Drawing.Point(252, 24);
            this.textBoxSoNguoi.Name = "textBoxSoNguoi";
            this.textBoxSoNguoi.Size = new System.Drawing.Size(356, 35);
            this.textBoxSoNguoi.TabIndex = 12;
            this.textBoxSoNguoi.TextChanged += new System.EventHandler(this.textBoxSoNguoi_TextChanged);
            // 
            // TraPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 655);
            this.Controls.Add(this.gradientPanelTheme);
            this.MaximizeBox = false;
            this.Name = "TraPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TraPhong";
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanelTheme)).EndInit();
            this.gradientPanelTheme.ResumeLayout(false);
            this.gradientPanelTheme.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        #region Khung Thông Tin
        #region Thông Tin
        private bool CoThongTin = false;
        private string CName = null;
        private string CMND = null;
        private string SDT = null;
        private string SoPhong = null;
        private string OTu = null;
        private string Den = null;
        private int Sotien = 0;
        #endregion

        private void selectedChoice()
        {
            switch (this.comboBoxTimKiem.SelectedIndex)
            {
                case 0:

                    break;
                case 1:

                    break;
                case 2:

                    break;
            }
        }
        private void getdata(string Data) // Data = "CName/CMND/SDT/SoPhong/OTu/Den"
        {
            if (Data != null)
            {
                string[] Datas = Data.Split('/');
                this.CName = Datas[0];
                this.CMND = Datas[1];
                this.SDT = Datas[2];
                this.SoPhong = Datas[3];
                this.OTu = Datas[4];
                this.Den = Datas[5];
                CoThongTin = true;
            }
        }

        private void ShowthongTin()
        {
            if (CoThongTin)
            {
                //
                // Khung Thong Tin
                //
                this.panelKhungThongTin.Controls.Add(this.labelHoVaTen);
                this.panelKhungThongTin.Controls.Add(this.labelCMND);
                this.panelKhungThongTin.Controls.Add(this.labelSDT);
                this.panelKhungThongTin.Controls.Add(this.labelSoPhong);
                this.panelKhungThongTin.Controls.Add(this.labelOTu);
                this.panelKhungThongTin.Controls.Add(this.labelDen);
                //
                // Label HoVaTen
                //
                this.labelHoVaTen.AutoSize = true;
                this.labelHoVaTen.BackColor = System.Drawing.Color.Transparent;
                this.labelHoVaTen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.labelHoVaTen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(178)))), ((int)(((byte)(160)))));
                this.labelHoVaTen.Location = new System.Drawing.Point(11, 10);
                this.labelHoVaTen.Name = "labelHoVaTen";
                this.labelHoVaTen.Size = new System.Drawing.Size(118, 26);
                this.labelHoVaTen.TabIndex = 9;
                this.labelHoVaTen.Text = "Họ và tên: " + CName;
                //
                // label CMND
                //
                this.labelCMND.AutoSize = true;
                this.labelCMND.BackColor = System.Drawing.Color.Transparent;
                this.labelCMND.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.labelCMND.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(178)))), ((int)(((byte)(160)))));
                this.labelCMND.Location = new System.Drawing.Point(11, 41);
                this.labelCMND.Name = "labelCMND";
                this.labelCMND.Size = new System.Drawing.Size(118, 26);
                this.labelCMND.TabIndex = 9;
                this.labelCMND.Text = "CMND: " + CMND;
                //
                // label SDT
                //
                this.labelSDT.AutoSize = true;
                this.labelSDT.BackColor = System.Drawing.Color.Transparent;
                this.labelSDT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.labelSDT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(178)))), ((int)(((byte)(160)))));
                this.labelSDT.Location = new System.Drawing.Point(11, 73);
                this.labelSDT.Name = "labelSDT";
                this.labelSDT.Size = new System.Drawing.Size(118, 26);
                this.labelSDT.TabIndex = 9;
                this.labelSDT.Text = "SDT: " + SDT;
                //
                // label SoPhong
                //
                this.labelSoPhong.AutoSize = true;
                this.labelSoPhong.BackColor = System.Drawing.Color.Transparent;
                this.labelSoPhong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.labelSoPhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(178)))), ((int)(((byte)(160)))));
                this.labelSoPhong.Location = new System.Drawing.Point(11, 104);
                this.labelSoPhong.Name = "labelSoPhong";
                this.labelSoPhong.Size = new System.Drawing.Size(118, 26);
                this.labelSoPhong.TabIndex = 9;
                this.labelSoPhong.Text = "Số Phòng: " + SoPhong;
                //
                // label OTu
                //
                this.labelOTu.AutoSize = true;
                this.labelOTu.BackColor = System.Drawing.Color.Transparent;
                this.labelOTu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.labelOTu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(178)))), ((int)(((byte)(160)))));
                this.labelOTu.Location = new System.Drawing.Point(11, 135);
                this.labelOTu.Name = "labelOTu";
                this.labelOTu.Size = new System.Drawing.Size(118, 26);
                this.labelOTu.TabIndex = 9;
                this.labelOTu.Text = "Ở Từ: " + OTu;
                //
                // label Den
                //
                this.labelDen.AutoSize = true;
                this.labelDen.BackColor = System.Drawing.Color.Transparent;
                this.labelDen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.labelDen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(178)))), ((int)(((byte)(160)))));
                this.labelDen.Location = new System.Drawing.Point(11, 166);
                this.labelDen.Name = "labelDen";
                this.labelDen.Size = new System.Drawing.Size(118, 26);
                this.labelDen.TabIndex = 9;
                this.labelDen.Text = "Đến: " + Den;
            }
            else
            {
                //
                // Khung Thong Tin
                //
                this.panelKhungThongTin.Controls.Add(this.labelKhongTimThay);
                //
                // label KhongTimThay
                //
                this.labelKhongTimThay.AutoSize = true;
                this.labelKhongTimThay.BackColor = System.Drawing.Color.Transparent;
                this.labelKhongTimThay.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.labelKhongTimThay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(178)))), ((int)(((byte)(160)))));
                this.labelKhongTimThay.Location = new System.Drawing.Point(120, 130);
                this.labelKhongTimThay.Name = "labelKhongTimThay";
                this.labelKhongTimThay.Size = new System.Drawing.Size(118, 26);
                this.labelKhongTimThay.TabIndex = 9;
                this.labelKhongTimThay.Text = "Không Tìm Thấy Thông Tin" + Den;
            }
        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanelTheme;
        private System.Windows.Forms.TextBox textBoxSoNguoi;
        private System.Windows.Forms.Panel panelKhungThongTin;
        private System.Windows.Forms.Button ButtonLayThongTin;
        private System.Windows.Forms.Button ButtonThanhToan;
        private System.Windows.Forms.Button buttonHuy;
        private System.Windows.Forms.ComboBox comboBoxTimKiem;
        //
        // Khung Thong Tin Control
        //
        System.Windows.Forms.Label labelHoVaTen = new System.Windows.Forms.Label();
        System.Windows.Forms.Label labelCMND = new System.Windows.Forms.Label();
        System.Windows.Forms.Label labelSoPhong = new System.Windows.Forms.Label();
        System.Windows.Forms.Label labelSDT = new System.Windows.Forms.Label();
        System.Windows.Forms.Label labelOTu = new System.Windows.Forms.Label();
        System.Windows.Forms.Label labelDen = new System.Windows.Forms.Label();
        System.Windows.Forms.Label labelKhongTimThay = new System.Windows.Forms.Label();
    }
}