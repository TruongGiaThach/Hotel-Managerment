﻿using System;
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

        private void ribbonForm1_Click(object sender, EventArgs e)
        {

        }

        private void B_Load(object sender, EventArgs e)
        {

        }

        private void gradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e) //dat phong
        {
            this.Hide();
            BookingForm bookingForm = new BookingForm(this,this.currentUser);
            bookingForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void materialButton2_Click(object sender, EventArgs e)
        {

        }

        private void materialButton3_Click(object sender, EventArgs e)
        {

        }
        private bool login(string user, string pass)
        {
            return DSTaiKhoan.Instance.dangNhap(user, pass) ;
        }
        private void materialButton2_Click_1(object sender, EventArgs e) // dang nhap admin
        {
            string user;
            string pass;
            try
            {
                user = this.UserTextBox.Text;
                pass = this.PasswordTextBox.Text;
                if (login(user, pass))
                {
                    this.Hide();
                    ManagerForm managerForm = new ManagerForm(this, this.currentUser);
                    managerForm.Show();
                }
                else throw new Exception("Sai tài khoản hoặc mật khẩu...");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Access denied!!"); }
            
        }

        private void materialDivider1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void materialButton3_Click_1(object sender, EventArgs e)
        {

        }

        private void materialDivider1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
