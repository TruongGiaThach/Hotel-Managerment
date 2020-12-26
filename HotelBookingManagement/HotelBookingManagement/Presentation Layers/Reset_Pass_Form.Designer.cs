namespace HotelBookingManagement
{
    partial class Reset_Pass_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private TaiKhoan user;
        private Manager_Form main;

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
            this.label_MkMoiLai = new System.Windows.Forms.Label();
            this.textBox_MkMoiLai = new System.Windows.Forms.TextBox();
            this.label_MkMoi = new System.Windows.Forms.Label();
            this.textBox_MkMoi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_MkCu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_XacNhan = new System.Windows.Forms.Button();
            this.button_Huy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_MkMoiLai
            // 
            this.label_MkMoiLai.AutoSize = true;
            this.label_MkMoiLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MkMoiLai.Location = new System.Drawing.Point(68, 208);
            this.label_MkMoiLai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_MkMoiLai.Name = "label_MkMoiLai";
            this.label_MkMoiLai.Size = new System.Drawing.Size(168, 25);
            this.label_MkMoiLai.TabIndex = 8;
            this.label_MkMoiLai.Text = "Nhập lại mật khẩu";
            // 
            // textBox_MkMoiLai
            // 
            this.textBox_MkMoiLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_MkMoiLai.Location = new System.Drawing.Point(274, 206);
            this.textBox_MkMoiLai.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_MkMoiLai.Name = "textBox_MkMoiLai";
            this.textBox_MkMoiLai.Size = new System.Drawing.Size(230, 30);
            this.textBox_MkMoiLai.TabIndex = 3;
            this.textBox_MkMoiLai.UseSystemPasswordChar = true;
            // 
            // label_MkMoi
            // 
            this.label_MkMoi.AutoSize = true;
            this.label_MkMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MkMoi.Location = new System.Drawing.Point(112, 154);
            this.label_MkMoi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_MkMoi.Name = "label_MkMoi";
            this.label_MkMoi.Size = new System.Drawing.Size(129, 25);
            this.label_MkMoi.TabIndex = 9;
            this.label_MkMoi.Text = "Mật khẩu mới";
            // 
            // textBox_MkMoi
            // 
            this.textBox_MkMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_MkMoi.Location = new System.Drawing.Point(274, 154);
            this.textBox_MkMoi.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_MkMoi.Name = "textBox_MkMoi";
            this.textBox_MkMoi.Size = new System.Drawing.Size(230, 30);
            this.textBox_MkMoi.TabIndex = 2;
            this.textBox_MkMoi.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 103);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Mật khẩu cũ";
            // 
            // textBox_MkCu
            // 
            this.textBox_MkCu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_MkCu.Location = new System.Drawing.Point(274, 103);
            this.textBox_MkCu.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_MkCu.Name = "textBox_MkCu";
            this.textBox_MkCu.Size = new System.Drawing.Size(230, 30);
            this.textBox_MkCu.TabIndex = 1;
            this.textBox_MkCu.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(208, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 43);
            this.label2.TabIndex = 12;
            this.label2.Text = "Đổi Mật Khẩu";
            // 
            // button_XacNhan
            // 
            this.button_XacNhan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_XacNhan.Location = new System.Drawing.Point(326, 272);
            this.button_XacNhan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_XacNhan.Name = "button_XacNhan";
            this.button_XacNhan.Size = new System.Drawing.Size(118, 38);
            this.button_XacNhan.TabIndex = 4;
            this.button_XacNhan.Text = "Xác Nhận";
            this.button_XacNhan.UseVisualStyleBackColor = true;
            this.button_XacNhan.Click += new System.EventHandler(this.button_XacNhan_Click);
            // 
            // button_Huy
            // 
            this.button_Huy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Huy.Location = new System.Drawing.Point(128, 272);
            this.button_Huy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Huy.Name = "button_Huy";
            this.button_Huy.Size = new System.Drawing.Size(118, 38);
            this.button_Huy.TabIndex = 5;
            this.button_Huy.Text = "Hủy";
            this.button_Huy.UseVisualStyleBackColor = true;
            this.button_Huy.Click += new System.EventHandler(this.button_Huy_Click);
            // 
            // Reset_Pass_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 340);
            this.Controls.Add(this.button_Huy);
            this.Controls.Add(this.button_XacNhan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_MkCu);
            this.Controls.Add(this.label_MkMoiLai);
            this.Controls.Add(this.textBox_MkMoiLai);
            this.Controls.Add(this.label_MkMoi);
            this.Controls.Add(this.textBox_MkMoi);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Reset_Pass_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Đổi Mật Khẩu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_MkMoiLai;
        private System.Windows.Forms.TextBox textBox_MkMoiLai;
        private System.Windows.Forms.Label label_MkMoi;
        private System.Windows.Forms.TextBox textBox_MkMoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_MkCu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_XacNhan;
        private System.Windows.Forms.Button button_Huy;
    }
}
