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
            //tabControl_Menu.SelectedIndex = 1;
            tabControl_Menu.SelectedIndex = 0;
            tabControl_Menu.SelectedIndex = 0;

        }

        private void Mouse_enter(object sender, EventArgs e)
        {

        }

        private void ButtonAccounts_Click(object sender, EventArgs e)
        {
            //check is null
            if (MdiChild != null)
                MdiChild.Close();
            //create Form
            MdiChild = new FormCommon("account", 0);
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
            MdiChild = new FormCommon("room", 1);
            MdiChild.MdiParent = this;
            MdiChild.Dock = System.Windows.Forms.DockStyle.Fill;
            MdiChild.Show();
        }

        private void Order_button_Click(object sender, EventArgs e)
        {
            if (MdiChild != null)
                MdiChild.Close();
            //create Form
            MdiChild = new FormCommon("default", 3);
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

        private void button_Customer_Click(object sender, EventArgs e)
        {
            if (MdiChild != null)
                MdiChild.Close();
            //create Form
            MdiChild = new FormCommon("customer", 2);
            MdiChild.MdiParent = this;
            MdiChild.Dock = System.Windows.Forms.DockStyle.Fill;
            MdiChild.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LayPhong LPForm = new LayPhong();
            LPForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TraPhong TPForm = new TraPhong();
            TPForm.Show();
        }

        private void tabControl_Menu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MdiChild != null)
                MdiChild.Close();
            string Data_path = "";
            switch (tabControl_Menu.SelectedIndex)
            {
                case 0:
                    Data_path = "account";
                    break;
                case 1:
                    Data_path = "room";
                    break;
                case 2:
                    Data_path = "default";
                    break;
                case 3:
                    Data_path = "customer";
                    break;
                case 4:
                    Data_path = "staff";
                    break;
            }
            FormCommon newFrm = new FormCommon(Data_path, tabControl_Menu.SelectedIndex)
            {
                MdiParent = this,
                Parent = tabControl_Menu.TabPages[tabControl_Menu.SelectedIndex]
            };
            newFrm.Dock = DockStyle.Fill;
            newFrm.Show();
        }
    }
}
