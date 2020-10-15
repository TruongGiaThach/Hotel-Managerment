using System.Windows.Forms;

namespace Project
{
    partial class ManagerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Form MdiChild;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerForm));
            this.PanelMenu = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.label_menu = new System.Windows.Forms.Label();
            this.ButtonRoom = new System.Windows.Forms.Button();
            this.ButtonAccounts = new System.Windows.Forms.Button();
            this.MenuPanel_2 = new System.Windows.Forms.FlowLayoutPanel();
            this.gradientPanel3 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.group_notification = new System.Windows.Forms.GroupBox();
            this.ButtonCheckinNotice = new System.Windows.Forms.Button();
            this.ButtonCheckoutNotice = new System.Windows.Forms.Button();
            this.ButtonBookingNotice = new System.Windows.Forms.Button();
            this.kryptonSeparator1 = new ComponentFactory.Krypton.Toolkit.KryptonSeparator();
            this.group_comunicate = new System.Windows.Forms.GroupBox();
            this.ButtonSendText = new System.Windows.Forms.Button();
            this.ButtonSendEmail = new System.Windows.Forms.Button();
            this.ButtonCall = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PanelMenu)).BeginInit();
            this.PanelMenu.SuspendLayout();
            this.MenuPanel_2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel3)).BeginInit();
            this.gradientPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.group_notification.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSeparator1)).BeginInit();
            this.group_comunicate.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathEllipse, System.Drawing.Color.Aquamarine, System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(165))))));
            this.PanelMenu.Controls.Add(this.label_menu);
            this.PanelMenu.Controls.Add(this.ButtonRoom);
            this.PanelMenu.Controls.Add(this.ButtonAccounts);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 118);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(239, 479);
            this.PanelMenu.TabIndex = 8;
            // 
            // label_menu
            // 
            this.label_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(157)))), ((int)(((byte)(156)))));
            this.label_menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_menu.ForeColor = System.Drawing.SystemColors.Control;
            this.label_menu.Location = new System.Drawing.Point(0, 0);
            this.label_menu.Name = "label_menu";
            this.label_menu.Size = new System.Drawing.Size(235, 37);
            this.label_menu.TabIndex = 8;
            this.label_menu.Text = "Menu";
            this.label_menu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonRoom
            // 
            this.ButtonRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(178)))), ((int)(((byte)(160)))));
            this.ButtonRoom.Location = new System.Drawing.Point(25, 104);
            this.ButtonRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonRoom.Name = "ButtonRoom";
            this.ButtonRoom.Size = new System.Drawing.Size(183, 51);
            this.ButtonRoom.TabIndex = 6;
            this.ButtonRoom.Text = "Rooms";
            this.ButtonRoom.UseVisualStyleBackColor = true;
            // 
            // ButtonAccounts
            // 
            this.ButtonAccounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAccounts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(178)))), ((int)(((byte)(160)))));
            this.ButtonAccounts.Location = new System.Drawing.Point(25, 49);
            this.ButtonAccounts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonAccounts.Name = "ButtonAccounts";
            this.ButtonAccounts.Size = new System.Drawing.Size(183, 51);
            this.ButtonAccounts.TabIndex = 7;
            this.ButtonAccounts.Text = "Accounts";
            this.ButtonAccounts.UseVisualStyleBackColor = true;
            // 
            // MenuPanel_2
            // 
            this.MenuPanel_2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MenuPanel_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(178)))), ((int)(((byte)(160)))));
            this.MenuPanel_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MenuPanel_2.Controls.Add(this.gradientPanel3);
            this.MenuPanel_2.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuPanel_2.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel_2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MenuPanel_2.Name = "MenuPanel_2";
            this.MenuPanel_2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MenuPanel_2.Size = new System.Drawing.Size(1380, 118);
            this.MenuPanel_2.TabIndex = 7;
            // 
            // gradientPanel3
            // 
            this.gradientPanel3.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathEllipse, System.Drawing.Color.Aquamarine, System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(165))))));
            this.gradientPanel3.Controls.Add(this.bunifuImageButton1);
            this.gradientPanel3.Controls.Add(this.group_notification);
            this.gradientPanel3.Controls.Add(this.kryptonSeparator1);
            this.gradientPanel3.Controls.Add(this.group_comunicate);
            this.gradientPanel3.Location = new System.Drawing.Point(3, 2);
            this.gradientPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gradientPanel3.Name = "gradientPanel3";
            this.gradientPanel3.Size = new System.Drawing.Size(1376, 110);
            this.gradientPanel3.TabIndex = 0;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(1291, 7);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(71, 71);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 7;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // group_notification
            // 
            this.group_notification.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.group_notification.Controls.Add(this.ButtonCheckinNotice);
            this.group_notification.Controls.Add(this.ButtonCheckoutNotice);
            this.group_notification.Controls.Add(this.ButtonBookingNotice);
            this.group_notification.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group_notification.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(139)))), ((int)(((byte)(162)))));
            this.group_notification.Location = new System.Drawing.Point(364, 6);
            this.group_notification.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.group_notification.Name = "group_notification";
            this.group_notification.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.group_notification.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.group_notification.Size = new System.Drawing.Size(376, 91);
            this.group_notification.TabIndex = 6;
            this.group_notification.TabStop = false;
            this.group_notification.Text = "NOTIFICATION";
            // 
            // ButtonCheckinNotice
            // 
            this.ButtonCheckinNotice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(139)))), ((int)(((byte)(162)))));
            this.ButtonCheckinNotice.Location = new System.Drawing.Point(253, 25);
            this.ButtonCheckinNotice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonCheckinNotice.Name = "ButtonCheckinNotice";
            this.ButtonCheckinNotice.Size = new System.Drawing.Size(117, 58);
            this.ButtonCheckinNotice.TabIndex = 0;
            this.ButtonCheckinNotice.Text = "check-in notice";
            this.ButtonCheckinNotice.UseVisualStyleBackColor = true;
            // 
            // ButtonCheckoutNotice
            // 
            this.ButtonCheckoutNotice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(139)))), ((int)(((byte)(162)))));
            this.ButtonCheckoutNotice.Location = new System.Drawing.Point(130, 25);
            this.ButtonCheckoutNotice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonCheckoutNotice.Name = "ButtonCheckoutNotice";
            this.ButtonCheckoutNotice.Size = new System.Drawing.Size(117, 58);
            this.ButtonCheckoutNotice.TabIndex = 0;
            this.ButtonCheckoutNotice.Text = "Check-out Notice";
            this.ButtonCheckoutNotice.UseVisualStyleBackColor = true;
            // 
            // ButtonBookingNotice
            // 
            this.ButtonBookingNotice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(139)))), ((int)(((byte)(162)))));
            this.ButtonBookingNotice.Location = new System.Drawing.Point(7, 25);
            this.ButtonBookingNotice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonBookingNotice.Name = "ButtonBookingNotice";
            this.ButtonBookingNotice.Size = new System.Drawing.Size(117, 58);
            this.ButtonBookingNotice.TabIndex = 0;
            this.ButtonBookingNotice.Text = "Booking Notice";
            this.ButtonBookingNotice.UseVisualStyleBackColor = true;
            // 
            // kryptonSeparator1
            // 
            this.kryptonSeparator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonSeparator1.Location = new System.Drawing.Point(0, 94);
            this.kryptonSeparator1.Name = "kryptonSeparator1";
            this.kryptonSeparator1.Size = new System.Drawing.Size(1372, 12);
            this.kryptonSeparator1.TabIndex = 1;
            // 
            // group_comunicate
            // 
            this.group_comunicate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.group_comunicate.Controls.Add(this.ButtonSendText);
            this.group_comunicate.Controls.Add(this.ButtonSendEmail);
            this.group_comunicate.Controls.Add(this.ButtonCall);
            this.group_comunicate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group_comunicate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(139)))), ((int)(((byte)(162)))));
            this.group_comunicate.Location = new System.Drawing.Point(5, 6);
            this.group_comunicate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.group_comunicate.Name = "group_comunicate";
            this.group_comunicate.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.group_comunicate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.group_comunicate.Size = new System.Drawing.Size(344, 91);
            this.group_comunicate.TabIndex = 5;
            this.group_comunicate.TabStop = false;
            this.group_comunicate.Text = "COMUNICATE";
            // 
            // ButtonSendText
            // 
            this.ButtonSendText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(139)))), ((int)(((byte)(162)))));
            this.ButtonSendText.Location = new System.Drawing.Point(226, 22);
            this.ButtonSendText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonSendText.Name = "ButtonSendText";
            this.ButtonSendText.Size = new System.Drawing.Size(105, 61);
            this.ButtonSendText.TabIndex = 0;
            this.ButtonSendText.Text = "Send Text";
            this.ButtonSendText.UseVisualStyleBackColor = true;
            // 
            // ButtonSendEmail
            // 
            this.ButtonSendEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(139)))), ((int)(((byte)(162)))));
            this.ButtonSendEmail.Location = new System.Drawing.Point(114, 22);
            this.ButtonSendEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonSendEmail.Name = "ButtonSendEmail";
            this.ButtonSendEmail.Size = new System.Drawing.Size(105, 61);
            this.ButtonSendEmail.TabIndex = 0;
            this.ButtonSendEmail.Text = "Send Email";
            this.ButtonSendEmail.UseVisualStyleBackColor = true;
            // 
            // ButtonCall
            // 
            this.ButtonCall.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(139)))), ((int)(((byte)(162)))));
            this.ButtonCall.Location = new System.Drawing.Point(7, 22);
            this.ButtonCall.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonCall.Name = "ButtonCall";
            this.ButtonCall.Size = new System.Drawing.Size(103, 61);
            this.ButtonCall.TabIndex = 0;
            this.ButtonCall.Text = "CALL";
            this.ButtonCall.UseVisualStyleBackColor = true;
            // 
            // ManagerForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(80)))), ((int)(((byte)(84)))));
            this.ClientSize = new System.Drawing.Size(1380, 597);
            this.Controls.Add(this.PanelMenu);
            this.Controls.Add(this.MenuPanel_2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager_Form";
            this.Load += new System.EventHandler(this.Manager_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PanelMenu)).EndInit();
            this.PanelMenu.ResumeLayout(false);
            this.MenuPanel_2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel3)).EndInit();
            this.gradientPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.group_notification.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSeparator1)).EndInit();
            this.group_comunicate.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.GradientPanel PanelMenu;
        private Label label_menu;
        private Button ButtonRoom;
        private Button ButtonAccounts;
        private FlowLayoutPanel MenuPanel_2;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel3;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private GroupBox group_notification;
        private Button ButtonCheckinNotice;
        private Button ButtonCheckoutNotice;
        private Button ButtonBookingNotice;
        private ComponentFactory.Krypton.Toolkit.KryptonSeparator kryptonSeparator1;
        private GroupBox group_comunicate;
        private Button ButtonSendText;
        private Button ButtonSendEmail;
        private Button ButtonCall;
    }
}