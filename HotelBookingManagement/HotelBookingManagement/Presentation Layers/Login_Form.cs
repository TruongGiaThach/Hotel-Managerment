using HotelBookingManagement.Data_Access_Layers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelBookingManagement
{
    public partial class Login_Form : Form
    {
        private TaiKhoan currentUser;
        private Manager_Form Frm;
        public Login_Form(Manager_Form Frm)
        {
            InitializeComponent();
            this.Frm = Frm;
        }

        public void B_Load(object sender, EventArgs e)
        {
            this.loadingGif.Visible = false;
            UserTextBox.Text = string.Empty;
            PasswordTextBox.Text = string.Empty;
        }


        private bool login(string user, string pass)
        {
            if (string.IsNullOrWhiteSpace(user) ||
               string.IsNullOrWhiteSpace(pass))
            {
                throw new Exception("Please Fill All The Fields");
            }
            return TaiKhoan_DAL.Instance.dangNhap(user, TaiKhoan.encode(pass));
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
                    this.currentUser = TaiKhoan_DAL.Instance.getTaiKhoanbyName(user);
                    this.loadingGif.Visible = true;
                }
                else throw new Exception("The username or password is incorrect...");
            }
            catch (Exception ex)
            {
                this.falseMessage.Location = new Point(this.ClientSize.Width - 5*ex.Message.Length, this.falseMessage.Location.Y);
                this.falseMessage.Text = ex.Message;
                UserTextBox.Text = string.Empty;
                PasswordTextBox.Text = string.Empty;
            }

        }

        private void timerToLogin_Tick(object sender, EventArgs e)
        {
            timerToLogin.Stop();
            switch (this.currentUser.PhanQuyen.Replace(" ", string.Empty))
            {
                case "admin":
                    Frm.currentUser = this.currentUser;
                    Frm.Show();
                    this.Close();
                    break;
                case "user":
                    Frm.currentUser = this.currentUser;
                    Frm.Show();
                    this.Hide();
                    break;
                default:
                    MessageBox.Show("Clone account!!!");
                    B_Load(sender, e);
                    break;
            }

        }

        private void button_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
