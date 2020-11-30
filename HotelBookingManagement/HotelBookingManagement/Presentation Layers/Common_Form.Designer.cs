using System.Windows.Forms;

namespace HotelBookingManagement
{
    partial class Form_Common
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Common));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_Search_Bar = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_Search = new System.Windows.Forms.Button();
            this.button_Change = new System.Windows.Forms.Button();
            this.button_Delete_staff = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel_Search_Bar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.panel_Search_Bar);
            this.panel1.Controls.Add(this.button_Change);
            this.panel1.Controls.Add(this.button_Delete_staff);
            this.panel1.Controls.Add(this.button_Add);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1068, 39);
            this.panel1.TabIndex = 8;
            // 
            // panel_Search_Bar
            // 
            this.panel_Search_Bar.Controls.Add(this.textBox1);
            this.panel_Search_Bar.Controls.Add(this.button_Search);
            this.panel_Search_Bar.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_Search_Bar.Location = new System.Drawing.Point(493, 0);
            this.panel_Search_Bar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_Search_Bar.Name = "panel_Search_Bar";
            this.panel_Search_Bar.Size = new System.Drawing.Size(575, 39);
            this.panel_Search_Bar.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(3, 2);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(529, 34);
            this.textBox1.TabIndex = 1;
            // 
            // button_Search
            // 
            this.button_Search.BackColor = System.Drawing.SystemColors.Control;
            this.button_Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Search.Location = new System.Drawing.Point(537, 2);
            this.button_Search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(36, 32);
            this.button_Search.TabIndex = 0;
            this.button_Search.UseVisualStyleBackColor = false;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // button_Change
            // 
            this.button_Change.BackColor = System.Drawing.SystemColors.Control;
            this.button_Change.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Change.Location = new System.Drawing.Point(90, 2);
            this.button_Change.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Change.Name = "button_Change";
            this.button_Change.Size = new System.Drawing.Size(36, 32);
            this.button_Change.TabIndex = 0;
            this.button_Change.UseVisualStyleBackColor = false;
            this.button_Change.Click += new System.EventHandler(this.button_Change_Click);
            // 
            // button_Delete_staff
            // 
            this.button_Delete_staff.BackColor = System.Drawing.SystemColors.Control;
            this.button_Delete_staff.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Delete_staff.BackgroundImage")));
            this.button_Delete_staff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Delete_staff.Location = new System.Drawing.Point(49, 2);
            this.button_Delete_staff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Delete_staff.Name = "button_Delete_staff";
            this.button_Delete_staff.Size = new System.Drawing.Size(36, 32);
            this.button_Delete_staff.TabIndex = 0;
            this.button_Delete_staff.UseVisualStyleBackColor = false;
            this.button_Delete_staff.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Add
            // 
            this.button_Add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Add.BackgroundImage")));
            this.button_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Add.Location = new System.Drawing.Point(8, 2);
            this.button_Add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(36, 32);
            this.button_Add.TabIndex = 0;
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1068, 515);
            this.dataGridView1.TabIndex = 9;
            // 
            // Form_Common
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1068, 554);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_Common";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormCommon_Load);
            this.panel1.ResumeLayout(false);
            this.panel_Search_Bar.ResumeLayout(false);
            this.panel_Search_Bar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel1;
        private Panel panel_Search_Bar;
        private TextBox textBox1;
        private Button button_Search;
        private Button button_Change;
        private Button button_Delete_staff;
        private Button button_Add;
        private DataGridView dataGridView1;
    }
}