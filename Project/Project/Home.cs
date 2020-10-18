using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Home : Form
    {
        BackgroundWorker BackWorker = new BackgroundWorker();
        private LoginForm loginForm;
        private TaiKhoan currentUser;
        public Home(LoginForm form, TaiKhoan user)
        {
            InitializeComponent();
            InitalizeMdiChild();
            this.loginForm = form;
            this.currentUser = user;
        }
        private void Home_Load(object sender, EventArgs e)
        {
            MdiChild = new TrangChu_MDIc();
            MdiChild.MdiParent = this;
            MdiChild.Dock = System.Windows.Forms.DockStyle.Fill;
            MdiChild.Show();
            //--------------
            this.userNameLable.Text = (this.currentUser == null)? "Tạo tài khoản mới" : this.currentUser.tenDN;

        }

        //Button Event Handle
        private void ButtonTrangChu_Click(object sender, EventArgs e)
        {
            //check is null
            if (MdiChild != null)
                MdiChild.Close();
            //create Form
            MdiChild = new TrangChu_MDIc();
            MdiChild.MdiParent = this;
            MdiChild.Dock = System.Windows.Forms.DockStyle.Fill;
            MdiChild.Show();
        }

        private void ButtonDatPhong_Click(object sender, EventArgs e)
        {
            //check is null
            if (MdiChild != null)
            {
                MdiChild.Hide();
                MdiChild.Close();
                MdiChild = null;
            }
            //create Form
            if (MdiChild == null)
            {
                MdiChild = new BookingForm(loginForm, currentUser);
                MdiChild.MdiParent = this;
                MdiChild.Dock = System.Windows.Forms.DockStyle.Fill;
            }
            MdiChild.Show();
        }

        private void BackWorker_DoWork_LoadDatPhong(object sender, DoWorkEventArgs e)
        {

        }

        private void BackWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)// go to login
        {
            this.Close();
            this.loginForm.B_Load(sender, e);
            this.loginForm.Show();
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            TaiKhoan tmp;
            SignUp signUp = new SignUp(this, tmp);
            
            signUp.ShowDialog();
            MessageBox.Show(tmp.ID);
            Home_Load(sender, e);
        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }
    }
}
