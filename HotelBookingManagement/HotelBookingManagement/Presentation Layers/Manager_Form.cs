﻿using System;
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
    public partial class Manager_Form : Form
    {
        private Login_Form loginForm;
        private TaiKhoan currentUser;
        public Manager_Form(Login_Form form, TaiKhoan user)
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

       
   
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.loginForm.B_Load(sender, e);
            this.loginForm.Show();
        }

  
        private void button3_Click(object sender, EventArgs e)
        {
            Add_Receptionist LPForm = new Add_Receptionist();
            LPForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Room_Information TPForm = new Room_Information();
            //TPForm.Show();
        }

        private void tabControl_Menu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MdiChild != null)
                MdiChild.Close();
            string Data_path = "";
            Form newFrm = null;
            switch (tabControl_Menu.SelectedIndex)
            {
                case 0:
                    Data_path = "account";
                    newFrm = new Form_Common(Data_path, tabControl_Menu.SelectedIndex)
                    {
                        MdiParent = this,
                        Parent = tabControl_Menu.TabPages[tabControl_Menu.SelectedIndex]
                    };
                    break;
                case 1:
                    Data_path = "room";
                    newFrm = new Room_Show()
                    {
                        MdiParent = this,
                        Parent = tabControl_Menu.TabPages[tabControl_Menu.SelectedIndex]
                    };
                    break;
                case 2:
                    Data_path = "default";
                    newFrm = new Form_Common(Data_path, tabControl_Menu.SelectedIndex)
                    {
                        MdiParent = this,
                        Parent = tabControl_Menu.TabPages[tabControl_Menu.SelectedIndex]
                    };
                    break;
                case 3:
                    Data_path = "customer";
                    newFrm = new Form_Common(Data_path, tabControl_Menu.SelectedIndex)
                    {
                        MdiParent = this,
                        Parent = tabControl_Menu.TabPages[tabControl_Menu.SelectedIndex]
                    };
                    break;
                case 4:
                    Data_path = "staff";
                    newFrm = new Form_Common(Data_path, tabControl_Menu.SelectedIndex)
                    {
                        MdiParent = this,
                        Parent = tabControl_Menu.TabPages[tabControl_Menu.SelectedIndex]
                    };
                    break;
                default:
                    break;
            }
            newFrm.Dock = DockStyle.Fill;
            newFrm.Show();
        }
    }
}