using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Project
{
    public partial class ManagerForm : Form
    {
        private LoginForm loginForm;
        private TaiKhoan currentUser;
        public ManagerForm(LoginForm form, TaiKhoan user)
        {
            InitializeComponent();
            this.loginForm = form;
            this.currentUser = user;
        }
        private void Manager_Form_Load(object sender, EventArgs e)
        {
            this.Order_button_Click(sender, e);
        }

        private void ButtonAccounts_Click(object sender, EventArgs e)
        {
            //check is null
            if (MdiChild != null)
                MdiChild.Close();
            //create Form
            MdiChild = new FormCommon("account");
            MdiChild.MdiParent = this;
            MdiChild.Dock = System.Windows.Forms.DockStyle.Fill;
            MdiChild.Show();
        }

        private void PanelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ButtonRoom_Click(object sender, EventArgs e)
        {
            if (MdiChild != null)
                MdiChild.Close();
            //create Form
            MdiChild = new FormCommon("room");
            MdiChild.MdiParent = this;
            MdiChild.Dock = System.Windows.Forms.DockStyle.Fill;
            MdiChild.Show();
        }

        private void Order_button_Click(object sender, EventArgs e)
        {
            if (MdiChild != null)
                MdiChild.Close();
            //create Form
            MdiChild = new FormCommon("default");
            MdiChild.MdiParent = this;
            MdiChild.Dock = System.Windows.Forms.DockStyle.Fill;
            MdiChild.Show();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.loginForm.B_Load(sender, e);
            this.loginForm.Show();
        }
    }
}
