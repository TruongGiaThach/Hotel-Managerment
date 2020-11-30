using System.Collections.Generic;

namespace HotelBookingManagement
{
    partial class Room_Infor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private List<Phong> Data;
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
            this.idTextbox = new System.Windows.Forms.TextBox();
            this.priceTextbox = new System.Windows.Forms.TextBox();
            this.roomTypeTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // idTextbox
            // 
            this.idTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTextbox.Location = new System.Drawing.Point(178, 108);
            this.idTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.idTextbox.Name = "idTextbox";
            this.idTextbox.Size = new System.Drawing.Size(301, 35);
            this.idTextbox.TabIndex = 0;
            // 
            // priceTextbox
            // 
            this.priceTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTextbox.Location = new System.Drawing.Point(178, 282);
            this.priceTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.priceTextbox.Name = "priceTextbox";
            this.priceTextbox.Size = new System.Drawing.Size(301, 35);
            this.priceTextbox.TabIndex = 1;
            this.priceTextbox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // roomTypeTextbox
            // 
            this.roomTypeTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomTypeTextbox.Location = new System.Drawing.Point(178, 198);
            this.roomTypeTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.roomTypeTextbox.Name = "roomTypeTextbox";
            this.roomTypeTextbox.Size = new System.Drawing.Size(301, 35);
            this.roomTypeTextbox.TabIndex = 2;
            this.roomTypeTextbox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Giá phòng";
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(300, 367);
            this.addButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(127, 61);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "Thêm phòng";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(69, 367);
            this.exitButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(125, 61);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Thoát";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(152, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(241, 51);
            this.label4.TabIndex = 8;
            this.label4.Text = "Thêm Phòng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(48, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 22);
            this.label5.TabIndex = 3;
            this.label5.Text = "ID phòng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(48, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 22);
            this.label6.TabIndex = 4;
            this.label6.Text = "Loại phòng";
            // 
            // Room_Infor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 441);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.roomTypeTextbox);
            this.Controls.Add(this.priceTextbox);
            this.Controls.Add(this.idTextbox);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Room_Infor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Phòng";
            this.Load += new System.EventHandler(this.RoomInfor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox idTextbox;
        private System.Windows.Forms.TextBox priceTextbox;
        private System.Windows.Forms.TextBox roomTypeTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}