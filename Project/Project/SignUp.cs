using Project.dataComu;
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
        LoginForm loginForm;
        TaiKhoan currentUser;
        string custumerID;
        public SignUp(LoginForm form1 ,Home form,ref TaiKhoan user)
        {
            InitializeComponent();
            this.loginForm = form1;
            this.homePage = form;
            this.currentUser = user;
        }

        private void button_Return_Click(object sender, EventArgs e) // when in sigup_panel
        {
            this.information_panel.Show();
            
        }
        private bool signUp(string user, string pass, string repass,string cusID)
        {
            if (string.IsNullOrWhiteSpace(user) ||
              string.IsNullOrWhiteSpace(pass) || string.IsNullOrWhiteSpace(repass))
            {
                throw new Exception("Please Fill All The Fields");
            }
            return DSTaiKhoan.Instance.themTaiKhoan(user, TaiKhoan.encode(pass),cusID);
        }
        private bool addCustumer(string name, string email)
        {
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email))
            {
                throw new Exception("Please Fill All The Fields");
            }
            return DSKhachHang.Instance.themKhachHang(name, email,"","");
        }
        private void button_NextPage_Click(object sender, EventArgs e)  
        {
            string name, email;
            try
            {
                name = this.textbox_Name.Text;
                email = this.textbox_EmailPhone.Text;
                if (addCustumer(name,email))
                {
                    this.information_panel.Hide();
                    MessageBox.Show("Đã thêm khách hàng thành công ><");
                    this.custumerID = DSKhachHang.Instance.getByEmail(email).ID;
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.textbox_Name.Text = string.Empty;
                this.textbox_EmailPhone.Text = string.Empty;
            }
            
        }

        private void button_SignUp_Click(object sender, EventArgs e)
        {
            string user, pass, repass;
            try
            {
                user = this.textbox_Account.Text;
                pass = this.textbox_Password.Text;
                repass = this.textbox_Repassword.Text;
                if (signUp(user, pass, repass,this.custumerID))
                {
                    MessageBox.Show("Thêm tài khoản thành công ><");
                    this.currentUser = DSTaiKhoan.Instance.getTaiKhoanbyName(user);
                    this.Close();
                    this.loginForm.B_Load(sender, e);
                    this.loginForm.Show();
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
