using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Syncfusion.Windows.Forms;

namespace Project
{
    public partial class LoginForm : Form
    {
        private TaiKhoan currentUser;
        public LoginForm()
        {
            InitializeComponent();
            this.currentUser = new TaiKhoan();
        }

        public void B_Load(object sender, EventArgs e)
        {
            this.loadingGif.Visible = false;
            UserTextBox.Text = string.Empty;
            PasswordTextBox.Text = string.Empty;
        }

        private void materialButton1_Click(object sender, EventArgs e) //dat phong
        {
            this.Hide();
            Home home = new Home(this,null);
            home.Show();
        }

        private bool login(string user, string pass)
        {
            if (string.IsNullOrWhiteSpace(user) ||
               string.IsNullOrWhiteSpace(pass))
            {
                throw new Exception("Please Fill All The Fields");
            }
            return DSTaiKhoan.Instance.dangNhap(user, TaiKhoan.encode(pass) ) ;
        }
        private void Button_DangNhap_Click(object sender, EventArgs e) // dang nhap
        {
            string user;
            string pass;
            try
            {
                user = this.UserTextBox.Text;
                pass = this.PasswordTextBox.Text;
                if (login(user, pass))
                {
                    timerToLogin.Start();
                    this.currentUser = DSTaiKhoan.Instance.getTaiKhoanbyName(user);
                    this.loadingGif.Visible = true;
                }
                else throw new Exception("The username or password is incorrect...");
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "Access denied!!");
                UserTextBox.Text = string.Empty;
                PasswordTextBox.Text = string.Empty;
            }
            
        }

        private void timerToLogin_Tick(object sender, EventArgs e)
        {
            timerToLogin.Stop();
            switch (this.currentUser.PhanQuyen.Replace(" ",string.Empty)) 
            {
                case "admin":
                    ManagerForm managerForm = new ManagerForm(this, this.currentUser);
                    managerForm.Show();
                    this.Hide();
                    break;
                case "user":
                    Home homepage = new Home(this, this.currentUser);
                    homepage.Show();
                    this.Hide();
                    break;
                default:
                    MessageBox.Show("Clone account!!!");
                    B_Load(sender, e);
                    break;
            }
      
        }

    }
}
