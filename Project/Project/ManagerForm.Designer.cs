namespace Project
{
    partial class ManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerForm));
            this.gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.splitContainerMenuDataview = new System.Windows.Forms.SplitContainer();
            this.label_menu = new System.Windows.Forms.Label();
            this.ButtonRoom = new System.Windows.Forms.Button();
            this.ButtonAccounts = new System.Windows.Forms.Button();
            this.AccountDataView = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.Accout_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.account_PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Account_Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Account = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Account_Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MenuPanel_2 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox_ACTION = new System.Windows.Forms.GroupBox();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.ButtonView = new System.Windows.Forms.Button();
            this.ButtonEdit = new System.Windows.Forms.Button();
            this.ButtonAddAccount = new System.Windows.Forms.Button();
            this.AddRoom = new System.Windows.Forms.Button();
            this.group_comunicate = new System.Windows.Forms.GroupBox();
            this.ButtonSendText = new System.Windows.Forms.Button();
            this.ButtonSendEmail = new System.Windows.Forms.Button();
            this.ButtonCall = new System.Windows.Forms.Button();
            this.group_notification = new System.Windows.Forms.GroupBox();
            this.ButtonCheckinNotice = new System.Windows.Forms.Button();
            this.ButtonCheckoutNotice = new System.Windows.Forms.Button();
            this.ButtonBookingNotice = new System.Windows.Forms.Button();
            this.group_account = new System.Windows.Forms.GroupBox();
            this.labelTypeAccount = new System.Windows.Forms.Label();
            this.linkAccountName = new System.Windows.Forms.LinkLabel();
            this.PictureAccout = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMenuDataview)).BeginInit();
            this.splitContainerMenuDataview.Panel1.SuspendLayout();
            this.splitContainerMenuDataview.Panel2.SuspendLayout();
            this.splitContainerMenuDataview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AccountDataView)).BeginInit();
            this.MenuPanel_2.SuspendLayout();
            this.groupBox_ACTION.SuspendLayout();
            this.group_comunicate.SuspendLayout();
            this.group_notification.SuspendLayout();
            this.group_account.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureAccout)).BeginInit();
            this.SuspendLayout();
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BackColor = System.Drawing.Color.Black;
            this.gradientPanel1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.ForwardDiagonal, System.Drawing.Color.Gray, System.Drawing.Color.Black);
            this.gradientPanel1.Controls.Add(this.splitContainerMenuDataview);
            this.gradientPanel1.Controls.Add(this.MenuPanel_2);
            this.gradientPanel1.Location = new System.Drawing.Point(1, 2);
            this.gradientPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(1521, 709);
            this.gradientPanel1.TabIndex = 0;
            // 
            // splitContainerMenuDataview
            // 
            this.splitContainerMenuDataview.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.splitContainerMenuDataview.Location = new System.Drawing.Point(-3, 145);
            this.splitContainerMenuDataview.Name = "splitContainerMenuDataview";
            // 
            // splitContainerMenuDataview.Panel1
            // 
            this.splitContainerMenuDataview.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(178)))), ((int)(((byte)(160)))));
            this.splitContainerMenuDataview.Panel1.Controls.Add(this.label_menu);
            this.splitContainerMenuDataview.Panel1.Controls.Add(this.ButtonRoom);
            this.splitContainerMenuDataview.Panel1.Controls.Add(this.ButtonAccounts);
            this.splitContainerMenuDataview.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainerMenuDataview.Panel2
            // 
            this.splitContainerMenuDataview.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(197)))), ((int)(((byte)(150)))));
            this.splitContainerMenuDataview.Panel2.Controls.Add(this.AccountDataView);
            this.splitContainerMenuDataview.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainerMenuDataview.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainerMenuDataview.Size = new System.Drawing.Size(1521, 586);
            this.splitContainerMenuDataview.SplitterDistance = 237;
            this.splitContainerMenuDataview.TabIndex = 6;
            // 
            // label_menu
            // 
            this.label_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(157)))), ((int)(((byte)(156)))));
            this.label_menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_menu.ForeColor = System.Drawing.SystemColors.Control;
            this.label_menu.Location = new System.Drawing.Point(3, 0);
            this.label_menu.Name = "label_menu";
            this.label_menu.Size = new System.Drawing.Size(232, 46);
            this.label_menu.TabIndex = 2;
            this.label_menu.Text = "Menu";
            this.label_menu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonRoom
            // 
            this.ButtonRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(178)))), ((int)(((byte)(160)))));
            this.ButtonRoom.Location = new System.Drawing.Point(10, 108);
            this.ButtonRoom.Name = "ButtonRoom";
            this.ButtonRoom.Size = new System.Drawing.Size(206, 42);
            this.ButtonRoom.TabIndex = 0;
            this.ButtonRoom.Text = "Rooms";
            this.ButtonRoom.UseVisualStyleBackColor = true;
            // 
            // ButtonAccounts
            // 
            this.ButtonAccounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAccounts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(178)))), ((int)(((byte)(160)))));
            this.ButtonAccounts.Location = new System.Drawing.Point(10, 58);
            this.ButtonAccounts.Name = "ButtonAccounts";
            this.ButtonAccounts.Size = new System.Drawing.Size(206, 42);
            this.ButtonAccounts.TabIndex = 0;
            this.ButtonAccounts.Text = "Accounts";
            this.ButtonAccounts.UseVisualStyleBackColor = true;
            // 
            // AccountDataView
            // 
            this.AccountDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AccountDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Accout_Name,
            this.account_PhoneNumber,
            this.Account_Email,
            this.Account,
            this.Account_Password});
            this.AccountDataView.Location = new System.Drawing.Point(21, 18);
            this.AccountDataView.Name = "AccountDataView";
            this.AccountDataView.RowHeadersWidth = 62;
            this.AccountDataView.RowTemplate.Height = 28;
            this.AccountDataView.Size = new System.Drawing.Size(1233, 543);
            this.AccountDataView.TabIndex = 0;
            // 
            // Accout_Name
            // 
            this.Accout_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Accout_Name.HeaderText = "Name";
            this.Accout_Name.MinimumWidth = 8;
            this.Accout_Name.Name = "Accout_Name";
            // 
            // account_PhoneNumber
            // 
            this.account_PhoneNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.account_PhoneNumber.HeaderText = "Phone Number";
            this.account_PhoneNumber.MinimumWidth = 8;
            this.account_PhoneNumber.Name = "account_PhoneNumber";
            // 
            // Account_Email
            // 
            this.Account_Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Account_Email.HeaderText = "Email";
            this.Account_Email.MinimumWidth = 8;
            this.Account_Email.Name = "Account_Email";
            // 
            // Account
            // 
            this.Account.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Account.HeaderText = "Account";
            this.Account.MinimumWidth = 8;
            this.Account.Name = "Account";
            // 
            // Account_Password
            // 
            this.Account_Password.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Account_Password.HeaderText = "Password";
            this.Account_Password.MinimumWidth = 8;
            this.Account_Password.Name = "Account_Password";
            // 
            // MenuPanel_2
            // 
            this.MenuPanel_2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MenuPanel_2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MenuPanel_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(178)))), ((int)(((byte)(160)))));
            this.MenuPanel_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MenuPanel_2.Controls.Add(this.groupBox_ACTION);
            this.MenuPanel_2.Controls.Add(this.group_comunicate);
            this.MenuPanel_2.Controls.Add(this.group_notification);
            this.MenuPanel_2.Controls.Add(this.group_account);
            this.MenuPanel_2.Location = new System.Drawing.Point(-3, -25);
            this.MenuPanel_2.Name = "MenuPanel_2";
            this.MenuPanel_2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MenuPanel_2.Size = new System.Drawing.Size(1522, 162);
            this.MenuPanel_2.TabIndex = 5;
            // 
            // groupBox_ACTION
            // 
            this.groupBox_ACTION.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.groupBox_ACTION.Controls.Add(this.ButtonDelete);
            this.groupBox_ACTION.Controls.Add(this.ButtonView);
            this.groupBox_ACTION.Controls.Add(this.ButtonEdit);
            this.groupBox_ACTION.Controls.Add(this.ButtonAddAccount);
            this.groupBox_ACTION.Controls.Add(this.AddRoom);
            this.groupBox_ACTION.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_ACTION.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(139)))), ((int)(((byte)(162)))));
            this.groupBox_ACTION.Location = new System.Drawing.Point(3, 3);
            this.groupBox_ACTION.Name = "groupBox_ACTION";
            this.groupBox_ACTION.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox_ACTION.Size = new System.Drawing.Size(358, 145);
            this.groupBox_ACTION.TabIndex = 0;
            this.groupBox_ACTION.TabStop = false;
            this.groupBox_ACTION.Text = "ACTION";
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(139)))), ((int)(((byte)(162)))));
            this.ButtonDelete.Location = new System.Drawing.Point(128, 108);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(84, 34);
            this.ButtonDelete.TabIndex = 1;
            this.ButtonDelete.Text = "Delete";
            this.ButtonDelete.UseVisualStyleBackColor = true;
            // 
            // ButtonView
            // 
            this.ButtonView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(139)))), ((int)(((byte)(162)))));
            this.ButtonView.Location = new System.Drawing.Point(128, 25);
            this.ButtonView.Name = "ButtonView";
            this.ButtonView.Size = new System.Drawing.Size(84, 34);
            this.ButtonView.TabIndex = 1;
            this.ButtonView.Text = "View";
            this.ButtonView.UseVisualStyleBackColor = true;
            // 
            // ButtonEdit
            // 
            this.ButtonEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(139)))), ((int)(((byte)(162)))));
            this.ButtonEdit.Location = new System.Drawing.Point(128, 66);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.Size = new System.Drawing.Size(84, 34);
            this.ButtonEdit.TabIndex = 1;
            this.ButtonEdit.Text = "Edit";
            this.ButtonEdit.UseVisualStyleBackColor = true;
            // 
            // ButtonAddAccount
            // 
            this.ButtonAddAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(139)))), ((int)(((byte)(162)))));
            this.ButtonAddAccount.Location = new System.Drawing.Point(219, 28);
            this.ButtonAddAccount.Name = "ButtonAddAccount";
            this.ButtonAddAccount.Size = new System.Drawing.Size(118, 109);
            this.ButtonAddAccount.TabIndex = 0;
            this.ButtonAddAccount.Text = "Add Account";
            this.ButtonAddAccount.UseVisualStyleBackColor = true;
            // 
            // AddRoom
            // 
            this.AddRoom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.AddRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(139)))), ((int)(((byte)(162)))));
            this.AddRoom.Location = new System.Drawing.Point(8, 28);
            this.AddRoom.Name = "AddRoom";
            this.AddRoom.Size = new System.Drawing.Size(116, 109);
            this.AddRoom.TabIndex = 0;
            this.AddRoom.Text = "Add Room";
            this.AddRoom.UseVisualStyleBackColor = true;
            // 
            // group_comunicate
            // 
            this.group_comunicate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.group_comunicate.Controls.Add(this.ButtonSendText);
            this.group_comunicate.Controls.Add(this.ButtonSendEmail);
            this.group_comunicate.Controls.Add(this.ButtonCall);
            this.group_comunicate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group_comunicate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(139)))), ((int)(((byte)(162)))));
            this.group_comunicate.Location = new System.Drawing.Point(367, 3);
            this.group_comunicate.Name = "group_comunicate";
            this.group_comunicate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.group_comunicate.Size = new System.Drawing.Size(387, 145);
            this.group_comunicate.TabIndex = 1;
            this.group_comunicate.TabStop = false;
            this.group_comunicate.Text = "COMUNICATE";
            // 
            // ButtonSendText
            // 
            this.ButtonSendText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(139)))), ((int)(((byte)(162)))));
            this.ButtonSendText.Location = new System.Drawing.Point(254, 28);
            this.ButtonSendText.Name = "ButtonSendText";
            this.ButtonSendText.Size = new System.Drawing.Size(118, 109);
            this.ButtonSendText.TabIndex = 0;
            this.ButtonSendText.Text = "Send Text";
            this.ButtonSendText.UseVisualStyleBackColor = true;
            // 
            // ButtonSendEmail
            // 
            this.ButtonSendEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(139)))), ((int)(((byte)(162)))));
            this.ButtonSendEmail.Location = new System.Drawing.Point(128, 28);
            this.ButtonSendEmail.Name = "ButtonSendEmail";
            this.ButtonSendEmail.Size = new System.Drawing.Size(118, 109);
            this.ButtonSendEmail.TabIndex = 0;
            this.ButtonSendEmail.Text = "Send Email";
            this.ButtonSendEmail.UseVisualStyleBackColor = true;
            // 
            // ButtonCall
            // 
            this.ButtonCall.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(139)))), ((int)(((byte)(162)))));
            this.ButtonCall.Location = new System.Drawing.Point(8, 28);
            this.ButtonCall.Name = "ButtonCall";
            this.ButtonCall.Size = new System.Drawing.Size(116, 109);
            this.ButtonCall.TabIndex = 0;
            this.ButtonCall.Text = "CALL";
            this.ButtonCall.UseVisualStyleBackColor = true;
            // 
            // group_notification
            // 
            this.group_notification.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.group_notification.Controls.Add(this.ButtonCheckinNotice);
            this.group_notification.Controls.Add(this.ButtonCheckoutNotice);
            this.group_notification.Controls.Add(this.ButtonBookingNotice);
            this.group_notification.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group_notification.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(139)))), ((int)(((byte)(162)))));
            this.group_notification.Location = new System.Drawing.Point(760, 3);
            this.group_notification.Name = "group_notification";
            this.group_notification.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.group_notification.Size = new System.Drawing.Size(423, 145);
            this.group_notification.TabIndex = 2;
            this.group_notification.TabStop = false;
            this.group_notification.Text = "NOTIFICATION";
            // 
            // ButtonCheckinNotice
            // 
            this.ButtonCheckinNotice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(139)))), ((int)(((byte)(162)))));
            this.ButtonCheckinNotice.Location = new System.Drawing.Point(285, 31);
            this.ButtonCheckinNotice.Name = "ButtonCheckinNotice";
            this.ButtonCheckinNotice.Size = new System.Drawing.Size(132, 109);
            this.ButtonCheckinNotice.TabIndex = 0;
            this.ButtonCheckinNotice.Text = "check-in notice";
            this.ButtonCheckinNotice.UseVisualStyleBackColor = true;
            // 
            // ButtonCheckoutNotice
            // 
            this.ButtonCheckoutNotice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(139)))), ((int)(((byte)(162)))));
            this.ButtonCheckoutNotice.Location = new System.Drawing.Point(146, 31);
            this.ButtonCheckoutNotice.Name = "ButtonCheckoutNotice";
            this.ButtonCheckoutNotice.Size = new System.Drawing.Size(132, 109);
            this.ButtonCheckoutNotice.TabIndex = 0;
            this.ButtonCheckoutNotice.Text = "Check-out Notice";
            this.ButtonCheckoutNotice.UseVisualStyleBackColor = true;
            // 
            // ButtonBookingNotice
            // 
            this.ButtonBookingNotice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(139)))), ((int)(((byte)(162)))));
            this.ButtonBookingNotice.Location = new System.Drawing.Point(8, 31);
            this.ButtonBookingNotice.Name = "ButtonBookingNotice";
            this.ButtonBookingNotice.Size = new System.Drawing.Size(132, 109);
            this.ButtonBookingNotice.TabIndex = 0;
            this.ButtonBookingNotice.Text = "Booking Notice";
            this.ButtonBookingNotice.UseVisualStyleBackColor = true;
            // 
            // group_account
            // 
            this.group_account.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.group_account.Controls.Add(this.labelTypeAccount);
            this.group_account.Controls.Add(this.linkAccountName);
            this.group_account.Controls.Add(this.PictureAccout);
            this.group_account.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group_account.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(139)))), ((int)(((byte)(162)))));
            this.group_account.Location = new System.Drawing.Point(1189, 3);
            this.group_account.Name = "group_account";
            this.group_account.Size = new System.Drawing.Size(320, 145);
            this.group_account.TabIndex = 3;
            this.group_account.TabStop = false;
            this.group_account.Text = "ACCOUNT";
            // 
            // labelTypeAccount
            // 
            this.labelTypeAccount.AutoSize = true;
            this.labelTypeAccount.BackColor = System.Drawing.Color.Transparent;
            this.labelTypeAccount.ForeColor = System.Drawing.Color.Red;
            this.labelTypeAccount.Location = new System.Drawing.Point(100, 43);
            this.labelTypeAccount.Name = "labelTypeAccount";
            this.labelTypeAccount.Size = new System.Drawing.Size(66, 20);
            this.labelTypeAccount.TabIndex = 2;
            this.labelTypeAccount.Text = "ADMIN";
            // 
            // linkAccountName
            // 
            this.linkAccountName.ActiveLinkColor = System.Drawing.Color.LimeGreen;
            this.linkAccountName.AutoSize = true;
            this.linkAccountName.Location = new System.Drawing.Point(98, 66);
            this.linkAccountName.Name = "linkAccountName";
            this.linkAccountName.Size = new System.Drawing.Size(126, 20);
            this.linkAccountName.TabIndex = 1;
            this.linkAccountName.TabStop = true;
            this.linkAccountName.Text = "Account Name";
            // 
            // PictureAccout
            // 
            this.PictureAccout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.PictureAccout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureAccout.Image = ((System.Drawing.Image)(resources.GetObject("PictureAccout.Image")));
            this.PictureAccout.Location = new System.Drawing.Point(16, 31);
            this.PictureAccout.Name = "PictureAccout";
            this.PictureAccout.Size = new System.Drawing.Size(72, 70);
            this.PictureAccout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureAccout.TabIndex = 0;
            this.PictureAccout.TabStop = false;
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(80)))), ((int)(((byte)(84)))));
            this.ClientSize = new System.Drawing.Size(1527, 718);
            this.Controls.Add(this.gradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "ManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager_Form";
            this.Load += new System.EventHandler(this.Manager_Form_Load);
            this.SizeChanged += new System.EventHandler(this.Manager_Form_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            this.splitContainerMenuDataview.Panel1.ResumeLayout(false);
            this.splitContainerMenuDataview.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMenuDataview)).EndInit();
            this.splitContainerMenuDataview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AccountDataView)).EndInit();
            this.MenuPanel_2.ResumeLayout(false);
            this.groupBox_ACTION.ResumeLayout(false);
            this.group_comunicate.ResumeLayout(false);
            this.group_notification.ResumeLayout(false);
            this.group_account.ResumeLayout(false);
            this.group_account.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureAccout)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel1;
        private System.Windows.Forms.SplitContainer splitContainerMenuDataview;
        private System.Windows.Forms.Label label_menu;
        private System.Windows.Forms.Button ButtonRoom;
        private System.Windows.Forms.Button ButtonAccounts;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView AccountDataView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Accout_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn account_PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Account_Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Account;
        private System.Windows.Forms.DataGridViewTextBoxColumn Account_Password;
        private System.Windows.Forms.FlowLayoutPanel MenuPanel_2;
        private System.Windows.Forms.GroupBox groupBox_ACTION;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Button ButtonView;
        private System.Windows.Forms.Button ButtonEdit;
        private System.Windows.Forms.Button ButtonAddAccount;
        private System.Windows.Forms.Button AddRoom;
        private System.Windows.Forms.GroupBox group_comunicate;
        private System.Windows.Forms.Button ButtonSendText;
        private System.Windows.Forms.Button ButtonSendEmail;
        private System.Windows.Forms.Button ButtonCall;
        private System.Windows.Forms.GroupBox group_notification;
        private System.Windows.Forms.Button ButtonCheckinNotice;
        private System.Windows.Forms.Button ButtonCheckoutNotice;
        private System.Windows.Forms.Button ButtonBookingNotice;
        private System.Windows.Forms.GroupBox group_account;
        private System.Windows.Forms.Label labelTypeAccount;
        private System.Windows.Forms.LinkLabel linkAccountName;
        private System.Windows.Forms.PictureBox PictureAccout;
    }
}