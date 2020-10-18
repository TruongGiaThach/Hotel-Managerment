using Syncfusion.Windows.Forms.Events;
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
    public partial class SignUp : MaterialSkin.Controls.MaterialForm
    {
        Home homePage;
        TaiKhoan currentUser;
        public SignUp(Home form,ref TaiKhoan user)
        {
            InitializeComponent();
            this.homePage = form;
            this.currentUser = user;
        }

        private void button_Return_Click(object sender, EventArgs e) // when in sigup_panel
        {
            this.information_panel.Show();
            
        }
        private bool signUp(string user, string pass, string repass)
        {
            if (string.IsNullOrWhiteSpace(user) ||
              string.IsNullOrWhiteSpace(pass) || string.IsNullOrWhiteSpace(repass))
            {
                throw new Exception("Please Fill All The Fields");
            }
            return DSTaiKhoan.Instance.themTaiKhoan(user, pass);
        }

        private void button_NextPage_Click(object sender, EventArgs e)  
        {
            this.information_panel.Hide();
            
        }

        private void button_SignUp_Click(object sender, EventArgs e)
        {
            string user, pass, repass;
            try
            {
                user = this.textbox_Account.Text;
                pass = this.textbox_Password.Text;
                repass = this.textbox_Repassword.Text;
                if (signUp(user, pass, repass))
                {
                    MessageBox.Show("Thêm tài khoản thành công ><");
                    this.currentUser = DSTaiKhoan.Instance.getTaiKhoanbyName(user);
                    this.Close();
                    homePage.Show();
                }
                else throw new Exception("The username or password is incorrect...");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Access denied!!");
                textbox_Account.Text = string.Empty;
                textbox_Password.Text = string.Empty;
                textbox_Repassword.Text = string.Empty;
            }
        }

        private void gradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.homePage.Show();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }
    }
}
