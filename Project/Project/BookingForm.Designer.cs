﻿using MaterialSkin.Properties;
using ReaLTaiizor.Controls;
using System.Collections;
using System.Windows.Forms;

namespace Project
{
    partial class BookingForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookingForm));
            this.gradientPanel_FormTheme = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.panel_PicturePreview = new System.Windows.Forms.Panel();
            this.flowLayoutPanelPicturePreview = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonMoveRight = new System.Windows.Forms.Button();
            this.gradientPanelPictureShow = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.pictureBoxShow = new System.Windows.Forms.PictureBox();
            this.buttonMoveLeft = new System.Windows.Forms.Button();
            this.Images = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialButtonReserver = new MaterialSkin.Controls.MaterialButton();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.comboBoxRoomType = new System.Windows.Forms.ComboBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelReservation = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel_FormTheme)).BeginInit();
            this.gradientPanel_FormTheme.SuspendLayout();
            this.panel_PicturePreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanelPictureShow)).BeginInit();
            this.gradientPanelPictureShow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShow)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gradientPanel_FormTheme
            // 
            this.gradientPanel_FormTheme.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.BackwardDiagonal, new System.Drawing.Color[] {
            System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(76)))), ((int)(((byte)(233))))),
            System.Drawing.Color.Aquamarine,
            System.Drawing.Color.Lime});
            this.gradientPanel_FormTheme.Border3DStyle = System.Windows.Forms.Border3DStyle.Raised;
            this.gradientPanel_FormTheme.Controls.Add(this.panel1);
            this.gradientPanel_FormTheme.Controls.Add(this.panel_PicturePreview);
            this.gradientPanel_FormTheme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel_FormTheme.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel_FormTheme.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gradientPanel_FormTheme.Name = "gradientPanel_FormTheme";
            this.gradientPanel_FormTheme.Size = new System.Drawing.Size(1502, 739);
            this.gradientPanel_FormTheme.TabIndex = 0;
            // 
            // panel_PicturePreview
            // 
            this.panel_PicturePreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_PicturePreview.AutoSize = true;
            this.panel_PicturePreview.BackColor = System.Drawing.Color.Gray;
            this.panel_PicturePreview.Controls.Add(this.flowLayoutPanelPicturePreview);
            this.panel_PicturePreview.Controls.Add(this.buttonMoveRight);
            this.panel_PicturePreview.Controls.Add(this.gradientPanelPictureShow);
            this.panel_PicturePreview.Controls.Add(this.buttonMoveLeft);
            this.panel_PicturePreview.Location = new System.Drawing.Point(601, -2);
            this.panel_PicturePreview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_PicturePreview.Name = "panel_PicturePreview";
            this.panel_PicturePreview.Size = new System.Drawing.Size(894, 728);
            this.panel_PicturePreview.TabIndex = 0;
            // 
            // flowLayoutPanelPicturePreview
            // 
            this.flowLayoutPanelPicturePreview.BackColor = System.Drawing.Color.DimGray;
            this.flowLayoutPanelPicturePreview.Location = new System.Drawing.Point(40, 585);
            this.flowLayoutPanelPicturePreview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanelPicturePreview.MaximumSize = new System.Drawing.Size(811, 139);
            this.flowLayoutPanelPicturePreview.Name = "flowLayoutPanelPicturePreview";
            this.flowLayoutPanelPicturePreview.Size = new System.Drawing.Size(811, 139);
            this.flowLayoutPanelPicturePreview.TabIndex = 7;
            this.flowLayoutPanelPicturePreview.WrapContents = false;
            // 
            // buttonMoveRight
            // 
            this.buttonMoveRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonMoveRight.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.buttonMoveRight.FlatAppearance.BorderSize = 0;
            this.buttonMoveRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMoveRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMoveRight.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonMoveRight.Location = new System.Drawing.Point(848, 585);
            this.buttonMoveRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonMoveRight.Name = "buttonMoveRight";
            this.buttonMoveRight.Size = new System.Drawing.Size(40, 140);
            this.buttonMoveRight.TabIndex = 6;
            this.buttonMoveRight.Text = ">";
            this.buttonMoveRight.UseVisualStyleBackColor = false;
            this.buttonMoveRight.Click += new System.EventHandler(this.buttonMoveRight_Click);
            // 
            // gradientPanelPictureShow
            // 
            this.gradientPanelPictureShow.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.gradientPanelPictureShow.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathEllipse, System.Drawing.Color.LightGray, System.Drawing.Color.DimGray);
            this.gradientPanelPictureShow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gradientPanelPictureShow.Controls.Add(this.pictureBoxShow);
            this.gradientPanelPictureShow.Location = new System.Drawing.Point(3, 2);
            this.gradientPanelPictureShow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gradientPanelPictureShow.Name = "gradientPanelPictureShow";
            this.gradientPanelPictureShow.Size = new System.Drawing.Size(888, 578);
            this.gradientPanelPictureShow.TabIndex = 5;
            // 
            // pictureBoxShow
            // 
            this.pictureBoxShow.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBoxShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxShow.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxShow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxShow.Name = "pictureBoxShow";
            this.pictureBoxShow.Size = new System.Drawing.Size(888, 578);
            this.pictureBoxShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxShow.TabIndex = 0;
            this.pictureBoxShow.TabStop = false;
            // 
            // buttonMoveLeft
            // 
            this.buttonMoveLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonMoveLeft.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.buttonMoveLeft.FlatAppearance.BorderSize = 0;
            this.buttonMoveLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMoveLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMoveLeft.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonMoveLeft.Location = new System.Drawing.Point(3, 585);
            this.buttonMoveLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonMoveLeft.Name = "buttonMoveLeft";
            this.buttonMoveLeft.Size = new System.Drawing.Size(40, 140);
            this.buttonMoveLeft.TabIndex = 4;
            this.buttonMoveLeft.Text = "<";
            this.buttonMoveLeft.UseVisualStyleBackColor = false;
            this.buttonMoveLeft.Click += new System.EventHandler(this.buttonMoveLeft_Click);
            // 
            // Images
            // 
            this.Images.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Images.ImageStream")));
            this.Images.TransparentColor = System.Drawing.Color.Transparent;
            this.Images.Images.SetKeyName(0, "Room1.jpg");
            this.Images.Images.SetKeyName(1, "Room2.jpg");
            this.Images.Images.SetKeyName(2, "Room3.jpg");
            this.Images.Images.SetKeyName(3, "Room4.jpg");
            this.Images.Images.SetKeyName(4, "Room5.jpeg");
            this.Images.Images.SetKeyName(5, "Room6.jpg");
            this.Images.Images.SetKeyName(6, "Room7.jpg");
            this.Images.Images.SetKeyName(7, "Room8.jpg");
            this.Images.Images.SetKeyName(8, "Room9.jpg");
            this.Images.Images.SetKeyName(9, "Room10.jpg");
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.materialButtonReserver);
            this.panel1.Controls.Add(this.dateTimePickerTo);
            this.panel1.Controls.Add(this.dateTimePickerFrom);
            this.panel1.Controls.Add(this.comboBoxRoomType);
            this.panel1.Controls.Add(this.textBoxEmail);
            this.panel1.Controls.Add(this.textBoxPhoneNumber);
            this.panel1.Controls.Add(this.textBoxName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.labelReservation);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(592, 723);
            this.panel1.TabIndex = 1;
            // 
            // materialButtonReserver
            // 
            this.materialButtonReserver.AutoEllipsis = true;
            this.materialButtonReserver.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonReserver.Depth = 0;
            this.materialButtonReserver.DrawShadows = true;
            this.materialButtonReserver.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialButtonReserver.HighEmphasis = true;
            this.materialButtonReserver.Icon = null;
            this.materialButtonReserver.Location = new System.Drawing.Point(252, 409);
            this.materialButtonReserver.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonReserver.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonReserver.Name = "materialButtonReserver";
            this.materialButtonReserver.Size = new System.Drawing.Size(95, 36);
            this.materialButtonReserver.TabIndex = 35;
            this.materialButtonReserver.Text = "Xác nhận";
            this.materialButtonReserver.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonReserver.UseAccentColor = false;
            this.materialButtonReserver.UseVisualStyleBackColor = false;
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerTo.Location = new System.Drawing.Point(359, 293);
            this.dateTimePickerTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(195, 30);
            this.dateTimePickerTo.TabIndex = 34;
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFrom.Location = new System.Drawing.Point(102, 293);
            this.dateTimePickerFrom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(200, 30);
            this.dateTimePickerFrom.TabIndex = 33;
            // 
            // comboBoxRoomType
            // 
            this.comboBoxRoomType.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRoomType.FormattingEnabled = true;
            this.comboBoxRoomType.Location = new System.Drawing.Point(223, 235);
            this.comboBoxRoomType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxRoomType.Name = "comboBoxRoomType";
            this.comboBoxRoomType.Size = new System.Drawing.Size(347, 30);
            this.comboBoxRoomType.TabIndex = 32;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxEmail.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.Location = new System.Drawing.Point(223, 189);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(347, 30);
            this.textBoxEmail.TabIndex = 31;
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxPhoneNumber.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(223, 139);
            this.textBoxPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(347, 30);
            this.textBoxPhoneNumber.TabIndex = 30;
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxName.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(223, 94);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(347, 30);
            this.textBoxName.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(23, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 27);
            this.label4.TabIndex = 23;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label5.Location = new System.Drawing.Point(23, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 27);
            this.label5.TabIndex = 24;
            this.label5.Text = "Room Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label6.Location = new System.Drawing.Point(23, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 27);
            this.label6.TabIndex = 25;
            this.label6.Text = "From";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(308, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 27);
            this.label3.TabIndex = 26;
            this.label3.Text = "To";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(23, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 27);
            this.label2.TabIndex = 27;
            this.label2.Text = "Phone Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(23, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 27);
            this.label1.TabIndex = 28;
            this.label1.Text = "Họ và Tên";
            // 
            // labelReservation
            // 
            this.labelReservation.AutoSize = true;
            this.labelReservation.BackColor = System.Drawing.Color.Transparent;
            this.labelReservation.Font = new System.Drawing.Font("Times", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReservation.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelReservation.Location = new System.Drawing.Point(169, 21);
            this.labelReservation.Name = "labelReservation";
            this.labelReservation.Size = new System.Drawing.Size(262, 52);
            this.labelReservation.TabIndex = 29;
            this.labelReservation.Text = "ĐẶT PHÒNG";
            // 
            // BookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1502, 739);
            this.Controls.Add(this.gradientPanel_FormTheme);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BookingForm";
            this.Text = "BookingForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel_FormTheme)).EndInit();
            this.gradientPanel_FormTheme.ResumeLayout(false);
            this.gradientPanel_FormTheme.PerformLayout();
            this.panel_PicturePreview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanelPictureShow)).EndInit();
            this.gradientPanelPictureShow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShow)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        #region Initaliaze Preview Panel
        System.Windows.Forms.Button[] ROOMS;
        public void SetupContainer()
        {

        }
        public void InitalizePreviewPanel()
        {
            ROOMS = new System.Windows.Forms.Button[Images.Images.Count];
            for (int i = 0; i < ROOMS.Length; ++i)
            {
                ROOMS[i] = new System.Windows.Forms.Button()
                {
                    Size = new System.Drawing.Size(128, 120),
                    BackgroundImage = Images.Images[i],
                };
                string PicturePath = Images.Images.Keys[i];
                ROOMS[i].Click += (s, e) =>
                {
                    pictureBoxShow.Image = System.Drawing.Image.FromFile(".\\Images\\" + PicturePath);
                };
            }
            for (int i = 0; i < 4 && i < Images.Images.Count; ++i)
            {
                flowLayoutPanelPicturePreview.Controls.Add(ROOMS[i]);
            }
            pictureBoxShow.Image = System.Drawing.Image.FromFile(".\\Images\\" + Images.Images.Keys[0]);
        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel_FormTheme;
        private System.Windows.Forms.Panel panel_PicturePreview;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelPicturePreview;
        private System.Windows.Forms.Button buttonMoveRight;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanelPictureShow;
        private System.Windows.Forms.Button buttonMoveLeft;
        private ImageList Images;
        private PictureBox pictureBoxShow;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialButton materialButtonReserver;
        private DateTimePicker dateTimePickerTo;
        private DateTimePicker dateTimePickerFrom;
        private ComboBox comboBoxRoomType;
        private TextBox textBoxEmail;
        private TextBox textBoxPhoneNumber;
        private TextBox textBoxName;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label labelReservation;
    }
}