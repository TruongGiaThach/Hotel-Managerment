namespace Project
{
    partial class Manager_Form
    {
        //global varible
        public float firstWidth;
        public float firstHeight;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager_Form));
            this.MenuPanel_2 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox_ACTION = new System.Windows.Forms.GroupBox();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_View = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.AddRoom = new System.Windows.Forms.Button();
            this.group_comunicate = new System.Windows.Forms.GroupBox();
            this.button_SendText = new System.Windows.Forms.Button();
            this.button_sendEmail = new System.Windows.Forms.Button();
            this.button_call = new System.Windows.Forms.Button();
            this.group_notification = new System.Windows.Forms.GroupBox();
            this.button_CheckinNotice = new System.Windows.Forms.Button();
            this.button_CheckoutNotice = new System.Windows.Forms.Button();
            this.button_BookingNotice = new System.Windows.Forms.Button();
            this.group_account = new System.Windows.Forms.GroupBox();
            this.label_TypeAccount = new System.Windows.Forms.Label();
            this.link_AccountName = new System.Windows.Forms.LinkLabel();
            this.picture_accout = new System.Windows.Forms.PictureBox();
            this.splitContainer_menu_dataview = new System.Windows.Forms.SplitContainer();
            this.label_menu = new System.Windows.Forms.Label();
            this.button_Room = new System.Windows.Forms.Button();
            this.button_accounts = new System.Windows.Forms.Button();
            this.kryptonDataGridView1 = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.Accout_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.account_PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Account_Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Account = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Account_Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MenuPanel_2.SuspendLayout();
            this.groupBox_ACTION.SuspendLayout();
            this.group_comunicate.SuspendLayout();
            this.group_notification.SuspendLayout();
            this.group_account.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_accout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_menu_dataview)).BeginInit();
            this.splitContainer_menu_dataview.Panel1.SuspendLayout();
            this.splitContainer_menu_dataview.Panel2.SuspendLayout();
            this.splitContainer_menu_dataview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.MenuPanel_2.Location = new System.Drawing.Point(3, 3);
            this.MenuPanel_2.Name = "MenuPanel_2";
            this.MenuPanel_2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MenuPanel_2.Size = new System.Drawing.Size(1521, 162);
            this.MenuPanel_2.TabIndex = 1;
            // 
            // groupBox_ACTION
            // 
            this.groupBox_ACTION.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.groupBox_ACTION.Controls.Add(this.button_Delete);
            this.groupBox_ACTION.Controls.Add(this.button_View);
            this.groupBox_ACTION.Controls.Add(this.button_edit);
            this.groupBox_ACTION.Controls.Add(this.button1);
            this.groupBox_ACTION.Controls.Add(this.AddRoom);
            this.groupBox_ACTION.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_ACTION.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(139)))), ((int)(((byte)(162)))));
            this.groupBox_ACTION.Location = new System.Drawing.Point(3, 3);
            this.groupBox_ACTION.Name = "groupBox_ACTION";
            this.groupBox_ACTION.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox_ACTION.Size = new System.Drawing.Size(358, 144);
            this.groupBox_ACTION.TabIndex = 0;
            this.groupBox_ACTION.TabStop = false;
            this.groupBox_ACTION.Text = "ACTION";
            // 
            // button_Delete
            // 
            this.button_Delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(139)))), ((int)(((byte)(162)))));
            this.button_Delete.Location = new System.Drawing.Point(128, 107);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(84, 34);
            this.button_Delete.TabIndex = 1;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = true;
            // 
            // button_View
            // 
            this.button_View.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(139)))), ((int)(((byte)(162)))));
            this.button_View.Location = new System.Drawing.Point(128, 24);
            this.button_View.Name = "button_View";
            this.button_View.Size = new System.Drawing.Size(84, 34);
            this.button_View.TabIndex = 1;
            this.button_View.Text = "View";
            this.button_View.UseVisualStyleBackColor = true;
            // 
            // button_edit
            // 
            this.button_edit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(139)))), ((int)(((byte)(162)))));
            this.button_edit.Location = new System.Drawing.Point(128, 66);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(84, 34);
            this.button_edit.TabIndex = 1;
            this.button_edit.Text = "Edit";
            this.button_edit.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(139)))), ((int)(((byte)(162)))));
            this.button1.Location = new System.Drawing.Point(219, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 110);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add Account";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // AddRoom
            // 
            this.AddRoom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.AddRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(139)))), ((int)(((byte)(162)))));
            this.AddRoom.Location = new System.Drawing.Point(7, 28);
            this.AddRoom.Name = "AddRoom";
            this.AddRoom.Size = new System.Drawing.Size(115, 110);
            this.AddRoom.TabIndex = 0;
            this.AddRoom.Text = "Add Room";
            this.AddRoom.UseVisualStyleBackColor = true;
            // 
            // group_comunicate
            // 
            this.group_comunicate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.group_comunicate.Controls.Add(this.button_SendText);
            this.group_comunicate.Controls.Add(this.button_sendEmail);
            this.group_comunicate.Controls.Add(this.button_call);
            this.group_comunicate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group_comunicate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(139)))), ((int)(((byte)(162)))));
            this.group_comunicate.Location = new System.Drawing.Point(367, 3);
            this.group_comunicate.Name = "group_comunicate";
            this.group_comunicate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.group_comunicate.Size = new System.Drawing.Size(387, 144);
            this.group_comunicate.TabIndex = 1;
            this.group_comunicate.TabStop = false;
            this.group_comunicate.Text = "COMUNICATE";
            // 
            // button_SendText
            // 
            this.button_SendText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(139)))), ((int)(((byte)(162)))));
            this.button_SendText.Location = new System.Drawing.Point(254, 28);
            this.button_SendText.Name = "button_SendText";
            this.button_SendText.Size = new System.Drawing.Size(119, 110);
            this.button_SendText.TabIndex = 0;
            this.button_SendText.Text = "Send Text";
            this.button_SendText.UseVisualStyleBackColor = true;
            // 
            // button_sendEmail
            // 
            this.button_sendEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(139)))), ((int)(((byte)(162)))));
            this.button_sendEmail.Location = new System.Drawing.Point(128, 28);
            this.button_sendEmail.Name = "button_sendEmail";
            this.button_sendEmail.Size = new System.Drawing.Size(119, 110);
            this.button_sendEmail.TabIndex = 0;
            this.button_sendEmail.Text = "Send Email";
            this.button_sendEmail.UseVisualStyleBackColor = true;
            // 
            // button_call
            // 
            this.button_call.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(139)))), ((int)(((byte)(162)))));
            this.button_call.Location = new System.Drawing.Point(7, 28);
            this.button_call.Name = "button_call";
            this.button_call.Size = new System.Drawing.Size(115, 110);
            this.button_call.TabIndex = 0;
            this.button_call.Text = "CALL";
            this.button_call.UseVisualStyleBackColor = true;
            // 
            // group_notification
            // 
            this.group_notification.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.group_notification.Controls.Add(this.button_CheckinNotice);
            this.group_notification.Controls.Add(this.button_CheckoutNotice);
            this.group_notification.Controls.Add(this.button_BookingNotice);
            this.group_notification.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group_notification.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(139)))), ((int)(((byte)(162)))));
            this.group_notification.Location = new System.Drawing.Point(760, 3);
            this.group_notification.Name = "group_notification";
            this.group_notification.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.group_notification.Size = new System.Drawing.Size(423, 144);
            this.group_notification.TabIndex = 2;
            this.group_notification.TabStop = false;
            this.group_notification.Text = "NOTIFICATION";
            // 
            // button_CheckinNotice
            // 
            this.button_CheckinNotice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(139)))), ((int)(((byte)(162)))));
            this.button_CheckinNotice.Location = new System.Drawing.Point(285, 31);
            this.button_CheckinNotice.Name = "button_CheckinNotice";
            this.button_CheckinNotice.Size = new System.Drawing.Size(132, 110);
            this.button_CheckinNotice.TabIndex = 0;
            this.button_CheckinNotice.Text = "check-in notice";
            this.button_CheckinNotice.UseVisualStyleBackColor = true;
            // 
            // button_CheckoutNotice
            // 
            this.button_CheckoutNotice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(139)))), ((int)(((byte)(162)))));
            this.button_CheckoutNotice.Location = new System.Drawing.Point(145, 31);
            this.button_CheckoutNotice.Name = "button_CheckoutNotice";
            this.button_CheckoutNotice.Size = new System.Drawing.Size(132, 110);
            this.button_CheckoutNotice.TabIndex = 0;
            this.button_CheckoutNotice.Text = "Check-out Notice";
            this.button_CheckoutNotice.UseVisualStyleBackColor = true;
            // 
            // button_BookingNotice
            // 
            this.button_BookingNotice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(139)))), ((int)(((byte)(162)))));
            this.button_BookingNotice.Location = new System.Drawing.Point(7, 31);
            this.button_BookingNotice.Name = "button_BookingNotice";
            this.button_BookingNotice.Size = new System.Drawing.Size(132, 110);
            this.button_BookingNotice.TabIndex = 0;
            this.button_BookingNotice.Text = "Booking Notice";
            this.button_BookingNotice.UseVisualStyleBackColor = true;
            // 
            // group_account
            // 
            this.group_account.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.group_account.Controls.Add(this.label_TypeAccount);
            this.group_account.Controls.Add(this.link_AccountName);
            this.group_account.Controls.Add(this.picture_accout);
            this.group_account.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group_account.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(139)))), ((int)(((byte)(162)))));
            this.group_account.Location = new System.Drawing.Point(1189, 3);
            this.group_account.Name = "group_account";
            this.group_account.Size = new System.Drawing.Size(320, 144);
            this.group_account.TabIndex = 3;
            this.group_account.TabStop = false;
            this.group_account.Text = "ACCOUNT";
            // 
            // label_TypeAccount
            // 
            this.label_TypeAccount.AutoSize = true;
            this.label_TypeAccount.BackColor = System.Drawing.Color.Transparent;
            this.label_TypeAccount.ForeColor = System.Drawing.Color.Red;
            this.label_TypeAccount.Location = new System.Drawing.Point(101, 43);
            this.label_TypeAccount.Name = "label_TypeAccount";
            this.label_TypeAccount.Size = new System.Drawing.Size(66, 20);
            this.label_TypeAccount.TabIndex = 2;
            this.label_TypeAccount.Text = "ADMIN";
            // 
            // link_AccountName
            // 
            this.link_AccountName.ActiveLinkColor = System.Drawing.Color.LimeGreen;
            this.link_AccountName.AutoSize = true;
            this.link_AccountName.Location = new System.Drawing.Point(97, 66);
            this.link_AccountName.Name = "link_AccountName";
            this.link_AccountName.Size = new System.Drawing.Size(126, 20);
            this.link_AccountName.TabIndex = 1;
            this.link_AccountName.TabStop = true;
            this.link_AccountName.Text = "Account Name";
            // 
            // picture_accout
            // 
            this.picture_accout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.picture_accout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picture_accout.Image = ((System.Drawing.Image)(resources.GetObject("picture_accout.Image")));
            this.picture_accout.Location = new System.Drawing.Point(17, 31);
            this.picture_accout.Name = "picture_accout";
            this.picture_accout.Size = new System.Drawing.Size(73, 69);
            this.picture_accout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_accout.TabIndex = 0;
            this.picture_accout.TabStop = false;
            // 
            // splitContainer_menu_dataview
            // 
            this.splitContainer_menu_dataview.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.splitContainer_menu_dataview.Location = new System.Drawing.Point(3, 172);
            this.splitContainer_menu_dataview.Name = "splitContainer_menu_dataview";
            // 
            // splitContainer_menu_dataview.Panel1
            // 
            this.splitContainer_menu_dataview.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(178)))), ((int)(((byte)(160)))));
            this.splitContainer_menu_dataview.Panel1.Controls.Add(this.label_menu);
            this.splitContainer_menu_dataview.Panel1.Controls.Add(this.button_Room);
            this.splitContainer_menu_dataview.Panel1.Controls.Add(this.button_accounts);
            this.splitContainer_menu_dataview.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer_menu_dataview.Panel2
            // 
            this.splitContainer_menu_dataview.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(197)))), ((int)(((byte)(150)))));
            this.splitContainer_menu_dataview.Panel2.Controls.Add(this.kryptonDataGridView1);
            this.splitContainer_menu_dataview.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer_menu_dataview.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer_menu_dataview.Size = new System.Drawing.Size(1521, 586);
            this.splitContainer_menu_dataview.SplitterDistance = 239;
            this.splitContainer_menu_dataview.TabIndex = 2;
            // 
            // label_menu
            // 
            this.label_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(157)))), ((int)(((byte)(156)))));
            this.label_menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_menu.ForeColor = System.Drawing.SystemColors.Control;
            this.label_menu.Location = new System.Drawing.Point(3, 0);
            this.label_menu.Name = "label_menu";
            this.label_menu.Size = new System.Drawing.Size(233, 46);
            this.label_menu.TabIndex = 2;
            this.label_menu.Text = "Menu";
            this.label_menu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_Room
            // 
            this.button_Room.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Room.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(178)))), ((int)(((byte)(160)))));
            this.button_Room.Location = new System.Drawing.Point(11, 107);
            this.button_Room.Name = "button_Room";
            this.button_Room.Size = new System.Drawing.Size(205, 42);
            this.button_Room.TabIndex = 0;
            this.button_Room.Text = "Rooms";
            this.button_Room.UseVisualStyleBackColor = true;
            // 
            // button_accounts
            // 
            this.button_accounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_accounts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(178)))), ((int)(((byte)(160)))));
            this.button_accounts.Location = new System.Drawing.Point(11, 59);
            this.button_accounts.Name = "button_accounts";
            this.button_accounts.Size = new System.Drawing.Size(205, 42);
            this.button_accounts.TabIndex = 0;
            this.button_accounts.Text = "Accounts";
            this.button_accounts.UseVisualStyleBackColor = true;
            // 
            // kryptonDataGridView1
            // 
            this.kryptonDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kryptonDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Accout_Name,
            this.account_PhoneNumber,
            this.Account_Email,
            this.Account,
            this.Account_Password});
            this.kryptonDataGridView1.Location = new System.Drawing.Point(21, 18);
            this.kryptonDataGridView1.Name = "kryptonDataGridView1";
            this.kryptonDataGridView1.RowHeadersWidth = 62;
            this.kryptonDataGridView1.RowTemplate.Height = 28;
            this.kryptonDataGridView1.Size = new System.Drawing.Size(1233, 543);
            this.kryptonDataGridView1.TabIndex = 0;
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
            // Manager_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(80)))), ((int)(((byte)(84)))));
            this.ClientSize = new System.Drawing.Size(1530, 765);
            this.Controls.Add(this.splitContainer_menu_dataview);
            this.Controls.Add(this.MenuPanel_2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Manager_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager_Form";
            this.Load += new System.EventHandler(this.Manager_Form_Load);
            this.SizeChanged += new System.EventHandler(this.Manager_Form_SizeChanged);
            this.MenuPanel_2.ResumeLayout(false);
            this.groupBox_ACTION.ResumeLayout(false);
            this.group_comunicate.ResumeLayout(false);
            this.group_notification.ResumeLayout(false);
            this.group_account.ResumeLayout(false);
            this.group_account.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_accout)).EndInit();
            this.splitContainer_menu_dataview.Panel1.ResumeLayout(false);
            this.splitContainer_menu_dataview.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_menu_dataview)).EndInit();
            this.splitContainer_menu_dataview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel MenuPanel_2;
        private System.Windows.Forms.GroupBox groupBox_ACTION;
        private System.Windows.Forms.Button AddRoom;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox group_comunicate;
        private System.Windows.Forms.Button button_BookingNotice;
        private System.Windows.Forms.Button button_SendText;
        private System.Windows.Forms.Button button_sendEmail;
        private System.Windows.Forms.Button button_call;
        private System.Windows.Forms.GroupBox group_notification;
        private System.Windows.Forms.Button button_CheckoutNotice;
        private System.Windows.Forms.SplitContainer splitContainer_menu_dataview;
        private System.Windows.Forms.Button button_View;
        private System.Windows.Forms.Button button_CheckinNotice;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView kryptonDataGridView1;
        private System.Windows.Forms.GroupBox group_account;
        private System.Windows.Forms.LinkLabel link_AccountName;
        private System.Windows.Forms.PictureBox picture_accout;
        private System.Windows.Forms.DataGridViewTextBoxColumn Accout_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn account_PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Account_Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Account;
        private System.Windows.Forms.DataGridViewTextBoxColumn Account_Password;
        private System.Windows.Forms.Label label_TypeAccount;
        private System.Windows.Forms.Label label_menu;
        private System.Windows.Forms.Button button_Room;
        private System.Windows.Forms.Button button_accounts;
    }
}