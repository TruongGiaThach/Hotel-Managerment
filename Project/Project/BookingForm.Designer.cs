using MaterialSkin.Properties;
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
        private int MinIndex;
        private int MoveIndex;
        private int MaxIndex;
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
            this.panel_Right = new System.Windows.Forms.Panel();
            this.panel_PicturePreview = new System.Windows.Forms.Panel();
            this.flowLayoutPanelPicturePreview = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonMoveRight = new System.Windows.Forms.Button();
            this.gradientPanelPictureShow = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.pictureBoxShow = new System.Windows.Forms.PictureBox();
            this.buttonMoveLeft = new System.Windows.Forms.Button();
            this.Images = new System.Windows.Forms.ImageList(this.components);
            this.materialButtonReserver = new MaterialSkin.Controls.MaterialButton();
            this.labelReservation = new System.Windows.Forms.Label();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.labelHoTen = new System.Windows.Forms.Label();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.labelSDT = new System.Windows.Forms.Label();
            this.comboBoxRoomType = new System.Windows.Forms.ComboBox();
            this.labelTo = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelFrom = new System.Windows.Forms.Label();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.labelLoaiPhong = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel_FormTheme)).BeginInit();
            this.gradientPanel_FormTheme.SuspendLayout();
            this.panel_Right.SuspendLayout();
            this.panel_PicturePreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanelPictureShow)).BeginInit();
            this.gradientPanelPictureShow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShow)).BeginInit();
            this.SuspendLayout();
            // 
            // gradientPanel_FormTheme
            // 
            this.gradientPanel_FormTheme.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.BackwardDiagonal, new System.Drawing.Color[] {
            System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(76)))), ((int)(((byte)(233))))),
            System.Drawing.Color.Aquamarine,
            System.Drawing.Color.Lime});
            this.gradientPanel_FormTheme.Border3DStyle = System.Windows.Forms.Border3DStyle.Raised;
            this.gradientPanel_FormTheme.Controls.Add(this.materialButtonReserver);
            this.gradientPanel_FormTheme.Controls.Add(this.panel_Right);
            this.gradientPanel_FormTheme.Controls.Add(this.labelReservation);
            this.gradientPanel_FormTheme.Controls.Add(this.dateTimePickerTo);
            this.gradientPanel_FormTheme.Controls.Add(this.labelEmail);
            this.gradientPanel_FormTheme.Controls.Add(this.labelHoTen);
            this.gradientPanel_FormTheme.Controls.Add(this.textBoxName);
            this.gradientPanel_FormTheme.Controls.Add(this.dateTimePickerFrom);
            this.gradientPanel_FormTheme.Controls.Add(this.labelLoaiPhong);
            this.gradientPanel_FormTheme.Controls.Add(this.labelSDT);
            this.gradientPanel_FormTheme.Controls.Add(this.textBoxPhoneNumber);
            this.gradientPanel_FormTheme.Controls.Add(this.comboBoxRoomType);
            this.gradientPanel_FormTheme.Controls.Add(this.labelFrom);
            this.gradientPanel_FormTheme.Controls.Add(this.labelTo);
            this.gradientPanel_FormTheme.Controls.Add(this.textBoxEmail);
            this.gradientPanel_FormTheme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel_FormTheme.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel_FormTheme.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gradientPanel_FormTheme.Name = "gradientPanel_FormTheme";
            this.gradientPanel_FormTheme.Size = new System.Drawing.Size(1335, 591);
            this.gradientPanel_FormTheme.TabIndex = 0;
            // 
            // panel_Right
            // 
            this.panel_Right.BackColor = System.Drawing.Color.Transparent;
            this.panel_Right.Controls.Add(this.panel_PicturePreview);
            this.panel_Right.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_Right.Location = new System.Drawing.Point(526, 0);
            this.panel_Right.Name = "panel_Right";
            this.panel_Right.Size = new System.Drawing.Size(805, 587);
            this.panel_Right.TabIndex = 2;
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
            this.panel_PicturePreview.Location = new System.Drawing.Point(3, 2);
            this.panel_PicturePreview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_PicturePreview.Name = "panel_PicturePreview";
            this.panel_PicturePreview.Size = new System.Drawing.Size(798, 587);
            this.panel_PicturePreview.TabIndex = 1;
            // 
            // flowLayoutPanelPicturePreview
            // 
            this.flowLayoutPanelPicturePreview.BackColor = System.Drawing.Color.DimGray;
            this.flowLayoutPanelPicturePreview.Location = new System.Drawing.Point(36, 468);
            this.flowLayoutPanelPicturePreview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanelPicturePreview.MaximumSize = new System.Drawing.Size(721, 111);
            this.flowLayoutPanelPicturePreview.Name = "flowLayoutPanelPicturePreview";
            this.flowLayoutPanelPicturePreview.Size = new System.Drawing.Size(721, 111);
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
            this.buttonMoveRight.Location = new System.Drawing.Point(754, 468);
            this.buttonMoveRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonMoveRight.Name = "buttonMoveRight";
            this.buttonMoveRight.Size = new System.Drawing.Size(36, 112);
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
            this.gradientPanelPictureShow.Size = new System.Drawing.Size(789, 462);
            this.gradientPanelPictureShow.TabIndex = 5;
            // 
            // pictureBoxShow
            // 
            this.pictureBoxShow.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBoxShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxShow.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxShow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxShow.Name = "pictureBoxShow";
            this.pictureBoxShow.Size = new System.Drawing.Size(789, 462);
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
            this.buttonMoveLeft.Location = new System.Drawing.Point(3, 468);
            this.buttonMoveLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonMoveLeft.Name = "buttonMoveLeft";
            this.buttonMoveLeft.Size = new System.Drawing.Size(36, 112);
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
            // materialButtonReserver
            // 
            this.materialButtonReserver.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialButtonReserver.AutoEllipsis = true;
            this.materialButtonReserver.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonReserver.Depth = 0;
            this.materialButtonReserver.DrawShadows = true;
            this.materialButtonReserver.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialButtonReserver.HighEmphasis = true;
            this.materialButtonReserver.Icon = null;
            this.materialButtonReserver.Location = new System.Drawing.Point(216, 331);
            this.materialButtonReserver.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.materialButtonReserver.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonReserver.Name = "materialButtonReserver";
            this.materialButtonReserver.Size = new System.Drawing.Size(95, 36);
            this.materialButtonReserver.TabIndex = 91;
            this.materialButtonReserver.Text = "Xác nhận";
            this.materialButtonReserver.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonReserver.UseAccentColor = false;
            this.materialButtonReserver.UseVisualStyleBackColor = false;
            // 
            // labelReservation
            // 
            this.labelReservation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelReservation.AutoSize = true;
            this.labelReservation.BackColor = System.Drawing.Color.Transparent;
            this.labelReservation.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReservation.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelReservation.Location = new System.Drawing.Point(142, 21);
            this.labelReservation.Name = "labelReservation";
            this.labelReservation.Size = new System.Drawing.Size(221, 38);
            this.labelReservation.TabIndex = 85;
            this.labelReservation.Text = "ĐẶT PHÒNG";
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerTo.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerTo.Location = new System.Drawing.Point(311, 238);
            this.dateTimePickerTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(174, 27);
            this.dateTimePickerTo.TabIndex = 90;
            // 
            // labelHoTen
            // 
            this.labelHoTen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelHoTen.AutoSize = true;
            this.labelHoTen.BackColor = System.Drawing.Color.Transparent;
            this.labelHoTen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHoTen.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelHoTen.Location = new System.Drawing.Point(12, 85);
            this.labelHoTen.Name = "labelHoTen";
            this.labelHoTen.Size = new System.Drawing.Size(93, 22);
            this.labelHoTen.TabIndex = 84;
            this.labelHoTen.Text = "Họ và Tên";
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerFrom.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFrom.Location = new System.Drawing.Point(83, 238);
            this.dateTimePickerFrom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(178, 27);
            this.dateTimePickerFrom.TabIndex = 89;
            // 
            // labelSDT
            // 
            this.labelSDT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSDT.AutoSize = true;
            this.labelSDT.BackColor = System.Drawing.Color.Transparent;
            this.labelSDT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSDT.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelSDT.Location = new System.Drawing.Point(12, 120);
            this.labelSDT.Name = "labelSDT";
            this.labelSDT.Size = new System.Drawing.Size(126, 22);
            this.labelSDT.TabIndex = 83;
            this.labelSDT.Text = "Phone Number";
            // 
            // comboBoxRoomType
            // 
            this.comboBoxRoomType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxRoomType.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRoomType.FormattingEnabled = true;
            this.comboBoxRoomType.Location = new System.Drawing.Point(190, 192);
            this.comboBoxRoomType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxRoomType.Name = "comboBoxRoomType";
            this.comboBoxRoomType.Size = new System.Drawing.Size(309, 27);
            this.comboBoxRoomType.TabIndex = 88;
            // 
            // labelTo
            // 
            this.labelTo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTo.AutoSize = true;
            this.labelTo.BackColor = System.Drawing.Color.Transparent;
            this.labelTo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTo.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelTo.Location = new System.Drawing.Point(266, 237);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(31, 22);
            this.labelTo.TabIndex = 82;
            this.labelTo.Text = "To";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxEmail.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxEmail.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.Location = new System.Drawing.Point(190, 155);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(309, 27);
            this.textBoxEmail.TabIndex = 87;
            // 
            // labelFrom
            // 
            this.labelFrom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelFrom.AutoSize = true;
            this.labelFrom.BackColor = System.Drawing.Color.Transparent;
            this.labelFrom.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFrom.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelFrom.Location = new System.Drawing.Point(12, 237);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(52, 22);
            this.labelFrom.TabIndex = 81;
            this.labelFrom.Text = "From";
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPhoneNumber.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxPhoneNumber.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(190, 115);
            this.textBoxPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(309, 27);
            this.textBoxPhoneNumber.TabIndex = 86;
            // 
            // labelLoaiPhong
            // 
            this.labelLoaiPhong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelLoaiPhong.AutoSize = true;
            this.labelLoaiPhong.BackColor = System.Drawing.Color.Transparent;
            this.labelLoaiPhong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoaiPhong.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelLoaiPhong.Location = new System.Drawing.Point(12, 198);
            this.labelLoaiPhong.Name = "labelLoaiPhong";
            this.labelLoaiPhong.Size = new System.Drawing.Size(98, 22);
            this.labelLoaiPhong.TabIndex = 80;
            this.labelLoaiPhong.Text = "Loại phòng";
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxName.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxName.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(190, 79);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(309, 27);
            this.textBoxName.TabIndex = 78;
            // 
            // labelEmail
            // 
            this.labelEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelEmail.AutoSize = true;
            this.labelEmail.BackColor = System.Drawing.Color.Transparent;
            this.labelEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelEmail.Location = new System.Drawing.Point(12, 160);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(57, 22);
            this.labelEmail.TabIndex = 79;
            this.labelEmail.Text = "Email";
            // 
            // BookingForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1335, 591);
            this.Controls.Add(this.gradientPanel_FormTheme);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BookingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BookingForm";
            this.Load += new System.EventHandler(this.BookingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel_FormTheme)).EndInit();
            this.gradientPanel_FormTheme.ResumeLayout(false);
            this.gradientPanel_FormTheme.PerformLayout();
            this.panel_Right.ResumeLayout(false);
            this.panel_Right.PerformLayout();
            this.panel_PicturePreview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanelPictureShow)).EndInit();
            this.gradientPanelPictureShow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShow)).EndInit();
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
            for (int i = 0; i < (flowLayoutPanelPicturePreview.Width / 128) && i < Images.Images.Count; ++i)
            {
                flowLayoutPanelPicturePreview.Controls.Add(ROOMS[i]);
            }
            pictureBoxShow.Image = System.Drawing.Image.FromFile(".\\Images\\" + Images.Images.Keys[0]);
        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel_FormTheme;
        private ImageList Images;
        private System.Windows.Forms.Panel panel_Right;
        private System.Windows.Forms.Panel panel_PicturePreview;
        private FlowLayoutPanel flowLayoutPanelPicturePreview;
        private System.Windows.Forms.Button buttonMoveRight;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanelPictureShow;
        private PictureBox pictureBoxShow;
        private System.Windows.Forms.Button buttonMoveLeft;
        private MaterialSkin.Controls.MaterialButton materialButtonReserver;
        private Label labelReservation;
        private DateTimePicker dateTimePickerTo;
        private Label labelEmail;
        private Label labelHoTen;
        private TextBox textBoxName;
        private DateTimePicker dateTimePickerFrom;
        private Label labelLoaiPhong;
        private Label labelSDT;
        private TextBox textBoxPhoneNumber;
        private ComboBox comboBoxRoomType;
        private Label labelFrom;
        private Label labelTo;
        private TextBox textBoxEmail;
    }
}