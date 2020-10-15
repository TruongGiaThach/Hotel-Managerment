namespace Project
{
    partial class TrangChu_MDIc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrangChu_MDIc));
            this.PanelTheme = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.CommonImage = new System.Windows.Forms.ImageList(this.components);
            this.timerPictureSlide = new System.Windows.Forms.Timer(this.components);
            this.imageSlideList = new Syncfusion.Windows.Forms.Tools.ImageListAdv(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PanelTheme)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelTheme
            // 
            this.PanelTheme.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathEllipse, System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(218))))), System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(225))))));
            this.PanelTheme.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PanelTheme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelTheme.Location = new System.Drawing.Point(0, 0);
            this.PanelTheme.Name = "PanelTheme";
            this.PanelTheme.Size = new System.Drawing.Size(1451, 749);
            this.PanelTheme.TabIndex = 0;
            // 
            // CommonImage
            // 
            this.CommonImage.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("CommonImage.ImageStream")));
            this.CommonImage.TransparentColor = System.Drawing.Color.Transparent;
            this.CommonImage.Images.SetKeyName(0, "profile_icon.png");
            this.CommonImage.Images.SetKeyName(1, "back-icon.png");
            this.CommonImage.Images.SetKeyName(2, "RoomIcon.png");
            this.CommonImage.Images.SetKeyName(3, "RoomIcon2.jpg");
            this.CommonImage.Images.SetKeyName(4, "RoomIcon3.png");
            // 
            // timerPictureSlide
            // 
            this.timerPictureSlide.Interval = 1000;
            this.timerPictureSlide.Tick += new System.EventHandler(this.timerPictureSlide_Tick);
            // 
            // imageSlideList
            // 
            this.imageSlideList.Images.AddRange(new System.Drawing.Image[] {
            ((System.Drawing.Image)(resources.GetObject("imageSlideList.Images"))),
            ((System.Drawing.Image)(resources.GetObject("imageSlideList.Images1"))),
            ((System.Drawing.Image)(resources.GetObject("imageSlideList.Images2"))),
            ((System.Drawing.Image)(resources.GetObject("imageSlideList.Images3"))),
            ((System.Drawing.Image)(resources.GetObject("imageSlideList.Images4")))});
            // 
            // TrangChu_MDIc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1451, 749);
            this.Controls.Add(this.PanelTheme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TrangChu_MDIc";
            this.Text = "TrangChu_MDIc";
            ((System.ComponentModel.ISupportInitialize)(this.PanelTheme)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        #region Picture Slide
        public int PictureSlideIndex = 0;
        public void InitialPictureSlide()
        {
            //timerPictureSlide.Interval = 5000;
            //if (!imageSlideList.Images.Empty)
            //    this.pictureSlideBox.Image = imageSlideList.Images[PictureSlideIndex];
            //timerPictureSlide.Start();
        }

        #endregion 

        private Syncfusion.Windows.Forms.Tools.GradientPanel PanelTheme;
        private System.Windows.Forms.Timer timerPictureSlide;
        private Syncfusion.Windows.Forms.Tools.ImageListAdv imageSlideList;
        private System.Windows.Forms.ImageList CommonImage;
    }
}