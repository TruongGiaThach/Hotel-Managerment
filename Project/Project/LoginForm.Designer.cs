using ReaLTaiizor.Extension;
using MaterialSkin;
using MaterialSkin.Controls;
namespace Project
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.bookingButton = new MaterialSkin.Controls.MaterialButton();
            this.gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.loadingGif = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.airSeparator1 = new ReaLTaiizor.Controls.AirSeparator();
            this.rememberUser = new MaterialSkin.Controls.MaterialCheckbox();
            this.resetPassword = new MaterialSkin.Controls.MaterialButton();
            this.UserTextBox = new ReaLTaiizor.Controls.MoonTextBox();
            this.PasswordTextBox = new ReaLTaiizor.Controls.MoonTextBox();
            this.loginAsAdmin = new MaterialSkin.Controls.MaterialButton();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.timerToLogin = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadingGif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bookingButton
            // 
            this.bookingButton.AutoSize = false;
            this.bookingButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bookingButton.BackColor = System.Drawing.Color.Transparent;
            this.bookingButton.Depth = 0;
            this.bookingButton.DialogResult = System.Windows.Forms.DialogResult.Retry;
            this.bookingButton.DrawShadows = true;
            this.bookingButton.Font = new System.Drawing.Font("Microsoft Himalaya", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookingButton.HighEmphasis = true;
            this.bookingButton.Icon = null;
            this.bookingButton.Location = new System.Drawing.Point(127, 470);
            this.bookingButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.bookingButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.bookingButton.Name = "bookingButton";
            this.bookingButton.Size = new System.Drawing.Size(741, 65);
            this.bookingButton.TabIndex = 1;
            this.bookingButton.Text = "Đặt phòng ngay....";
            this.bookingButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.bookingButton.UseAccentColor = false;
            this.bookingButton.UseVisualStyleBackColor = false;
            this.bookingButton.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.gradientPanel1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.ForwardDiagonal, new System.Drawing.Color[] {
            System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(127)))), ((int)(((byte)(246))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(222)))), ((int)(((byte)(222))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(213)))), ((int)(((byte)(245)))))});
            this.gradientPanel1.Border3DStyle = System.Windows.Forms.Border3DStyle.Adjust;
            this.gradientPanel1.Controls.Add(this.loadingGif);
            this.gradientPanel1.Controls.Add(this.pictureBox3);
            this.gradientPanel1.Controls.Add(this.pictureBox2);
            this.gradientPanel1.Controls.Add(this.pictureBox1);
            this.gradientPanel1.Controls.Add(this.airSeparator1);
            this.gradientPanel1.Controls.Add(this.bookingButton);
            this.gradientPanel1.Controls.Add(this.rememberUser);
            this.gradientPanel1.Controls.Add(this.resetPassword);
            this.gradientPanel1.Controls.Add(this.UserTextBox);
            this.gradientPanel1.Controls.Add(this.PasswordTextBox);
            this.gradientPanel1.Controls.Add(this.loginAsAdmin);
            this.gradientPanel1.Controls.Add(this.materialDivider1);
            this.gradientPanel1.Font = new System.Drawing.Font("Microsoft Himalaya", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradientPanel1.Location = new System.Drawing.Point(-1, 1);
            this.gradientPanel1.MinimumSize = new System.Drawing.Size(261, 65);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(1001, 582);
            this.gradientPanel1.TabIndex = 3;
            this.gradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.gradientPanel1_Paint);
            // 
            // loadingGif
            // 
            this.loadingGif.Image = ((System.Drawing.Image)(resources.GetObject("loadingGif.Image")));
            this.loadingGif.Location = new System.Drawing.Point(-2, 514);
            this.loadingGif.Name = "loadingGif";
            this.loadingGif.Size = new System.Drawing.Size(69, 66);
            this.loadingGif.TabIndex = 18;
            this.loadingGif.TabStop = false;
            this.loadingGif.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.Location = new System.Drawing.Point(572, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(296, 263);
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(77, 170);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(62, 56);
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(77, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 54);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // airSeparator1
            // 
            this.airSeparator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.airSeparator1.Colors = new ReaLTaiizor.Util.BloomAir[0];
            this.airSeparator1.Customization = "";
            this.airSeparator1.Font = new System.Drawing.Font("Verdana", 8F);
            this.airSeparator1.Image = null;
            this.airSeparator1.Location = new System.Drawing.Point(32, 439);
            this.airSeparator1.Name = "airSeparator1";
            this.airSeparator1.NoRounding = false;
            this.airSeparator1.Size = new System.Drawing.Size(931, 1);
            this.airSeparator1.TabIndex = 13;
            this.airSeparator1.Text = "airSeparator1";
            this.airSeparator1.Transparent = false;
            // 
            // rememberUser
            // 
            this.rememberUser.AutoSize = true;
            this.rememberUser.BackColor = System.Drawing.Color.Transparent;
            this.rememberUser.Depth = 0;
            this.rememberUser.Location = new System.Drawing.Point(626, 309);
            this.rememberUser.Margin = new System.Windows.Forms.Padding(0);
            this.rememberUser.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rememberUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.rememberUser.Name = "rememberUser";
            this.rememberUser.Ripple = true;
            this.rememberUser.Size = new System.Drawing.Size(149, 37);
            this.rememberUser.TabIndex = 10;
            this.rememberUser.Text = "Remember me   ";
            this.rememberUser.UseVisualStyleBackColor = false;
            // 
            // resetPassword
            // 
            this.resetPassword.AutoSize = false;
            this.resetPassword.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.resetPassword.BackColor = System.Drawing.Color.Transparent;
            this.resetPassword.Depth = 0;
            this.resetPassword.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.resetPassword.DrawShadows = true;
            this.resetPassword.Font = new System.Drawing.Font("Microsoft Himalaya", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetPassword.HighEmphasis = true;
            this.resetPassword.Icon = null;
            this.resetPassword.Location = new System.Drawing.Point(626, 376);
            this.resetPassword.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.resetPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.resetPassword.Name = "resetPassword";
            this.resetPassword.Size = new System.Drawing.Size(185, 29);
            this.resetPassword.TabIndex = 9;
            this.resetPassword.Text = "Reset password";
            this.resetPassword.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.resetPassword.UseAccentColor = false;
            this.resetPassword.UseVisualStyleBackColor = false;
            this.resetPassword.Click += new System.EventHandler(this.materialButton3_Click_1);
            // 
            // UserTextBox
            // 
            this.UserTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.UserTextBox.BorderColor = System.Drawing.Color.Transparent;
            this.UserTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserTextBox.ForeColor = System.Drawing.Color.Black;
            this.UserTextBox.Location = new System.Drawing.Point(168, 113);
            this.UserTextBox.Multiline = true;
            this.UserTextBox.Name = "UserTextBox";
            this.UserTextBox.Size = new System.Drawing.Size(256, 42);
            this.UserTextBox.TabIndex = 3;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PasswordTextBox.BorderColor = System.Drawing.Color.LightGray;
            this.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextBox.ForeColor = System.Drawing.Color.Black;
            this.PasswordTextBox.Location = new System.Drawing.Point(168, 186);
            this.PasswordTextBox.Multiline = true;
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '•';
            this.PasswordTextBox.Size = new System.Drawing.Size(256, 40);
            this.PasswordTextBox.TabIndex = 4;
            // 
            // loginAsAdmin
            // 
            this.loginAsAdmin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.loginAsAdmin.BackColor = System.Drawing.Color.Transparent;
            this.loginAsAdmin.Depth = 0;
            this.loginAsAdmin.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.loginAsAdmin.DrawShadows = true;
            this.loginAsAdmin.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginAsAdmin.HighEmphasis = true;
            this.loginAsAdmin.Icon = null;
            this.loginAsAdmin.Location = new System.Drawing.Point(108, 333);
            this.loginAsAdmin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.loginAsAdmin.MouseState = MaterialSkin.MouseState.HOVER;
            this.loginAsAdmin.Name = "loginAsAdmin";
            this.loginAsAdmin.Size = new System.Drawing.Size(105, 36);
            this.loginAsAdmin.TabIndex = 5;
            this.loginAsAdmin.Text = "Đăng nhập ";
            this.loginAsAdmin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.loginAsAdmin.UseAccentColor = false;
            this.loginAsAdmin.UseVisualStyleBackColor = false;
            this.loginAsAdmin.Click += new System.EventHandler(this.materialButton2_Click_1);
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(45, 278);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(895, 144);
            this.materialDivider1.TabIndex = 14;
            this.materialDivider1.Text = "materialDivider1";
            this.materialDivider1.Click += new System.EventHandler(this.materialDivider1_Click_1);
            // 
            // timerToLogin
            // 
            this.timerToLogin.Interval = 10;
            this.timerToLogin.Tick += new System.EventHandler(this.timerToLogin_Tick);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(999, 582);
            this.Controls.Add(this.gradientPanel1);
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dang nhap";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.B_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadingGif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton bookingButton;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel1;
        private ReaLTaiizor.Controls.MoonTextBox PasswordTextBox;
        private ReaLTaiizor.Controls.MoonTextBox UserTextBox;
        private MaterialSkin.Controls.MaterialButton loginAsAdmin;
        private MaterialCheckbox rememberUser;
        private MaterialButton resetPassword;
        private ReaLTaiizor.Controls.AirSeparator airSeparator1;
        private MaterialDivider materialDivider1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Timer timerToLogin;
        private System.Windows.Forms.PictureBox loadingGif;
    }
}

