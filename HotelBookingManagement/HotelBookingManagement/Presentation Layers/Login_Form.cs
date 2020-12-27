using HotelBookingManagement.Data_Access_Layers;
using HotelBookingManagement.Presentation_Layers;
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
            this.UserTextBox.KeyPress += Normalisation.TextboxID_KeyPress;
            this.PasswordTextBox.KeyPress += Normalisation.TextboxID_KeyPress;
            this.Frm = Frm;
        }

        public void B_Load(object sender, EventArgs e)
        {
            this.loadingGif.Visible = false;
            UserTextBox.Text = string.Empty;
            PasswordTextBox.Text = string.Empty;
            this.falseMessage.Text = string.Empty;
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
                    if (TaiKhoan_DAL.Instance.isOnline(user) == true)
                        throw new Exception("Tài khoản đã đăng nhập ở nơi khác.");
                    TaiKhoan_DAL.Instance.updateStatus(user, true);
                    this.loadingGif.Visible = true;
                    this.currentUser = TaiKhoan_DAL.Instance.getTaiKhoanbyName(user);               
                    timerToLogin.Start();
                }
                else throw new Exception("The username or password is incorrect...");
            }
            catch (Exception ex)
            {
                this.falseMessage.Location = new Point(this.ClientSize.Width - 6*ex.Message.Length, this.falseMessage.Location.Y);
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
                case "user":
                    Frm.currentUser = this.currentUser;
                    Frm.Show();
                    this.Close();
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void loadingGif_Click(object sender, EventArgs e)
        {

        }
    }
}
