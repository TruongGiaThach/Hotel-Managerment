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
    public partial class Manager_Form : Form
    {
        private Login_Form loginForm;
        public TaiKhoan currentUser;
        public Manager_Form()
        {
            InitializeComponent();
            this.Hide();
            Login_Form Login = new Login_Form(this);
            Login.ShowDialog();
        }
        private void Manager_Form_Load(object sender, EventArgs e)
        {
            if (this.currentUser == null)
            {
                Application.Exit();
            }
            this.DS_Phong = Phong_Data.GetDsPhong();
        }

        private void Mouse_enter(object sender, EventArgs e)
        {

        }


  
        private void button3_Click(object sender, EventArgs e)
        {
            Add_Receptionist LPForm = new Add_Receptionist();
            LPForm.Show();
        }



        private void tabControl_Menu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MdiChild != null)
                MdiChild.Close();
            string Data_path = "";
            switch (tabControl_Menu.SelectedIndex)
            {
                case 6:
                    Data_path = "account";
                    MdiChild = new Form_Common(Data_path, tabControl_Menu.SelectedIndex)
                    {
                        MdiParent = this,
                        Parent = tabControl_Menu.TabPages[tabControl_Menu.SelectedIndex]
                    };
                    break;
                case 1:
                    Data_path = "room";
                    MdiChild = new Room_Show(ref DS_Phong)
                    {
                        MdiParent = this,
                        Parent = tabControl_Menu.TabPages[tabControl_Menu.SelectedIndex]
                    };
                    break;
                case 2:
                    Data_path = "default";
                    MdiChild = new Form_Common(Data_path, tabControl_Menu.SelectedIndex)
                    {
                        MdiParent = this,
                        Parent = tabControl_Menu.TabPages[tabControl_Menu.SelectedIndex]
                    };
                    break;
                case 3:
                    Data_path = "customer";
                    MdiChild = new Form_Common(Data_path, tabControl_Menu.SelectedIndex)
                    {
                        MdiParent = this,
                        Parent = tabControl_Menu.TabPages[tabControl_Menu.SelectedIndex]
                    };
                    break;
                case 4:
                    Data_path = "staff";
                    MdiChild = new Form_Common(Data_path, tabControl_Menu.SelectedIndex)
                    {
                        MdiParent = this,
                        Parent = tabControl_Menu.TabPages[tabControl_Menu.SelectedIndex]
                    };
                    break;
                case 5:
                    MdiChild = new Presentation_Layers.Budget_Form()
                    {
                        MdiParent = this,
                        Parent = tabControl_Menu.TabPages[tabControl_Menu.SelectedIndex]
                    };
                    break;
                case 7:
                    MdiChild = new Setting()
                    {
                        MdiParent = this,
                        Parent = tabControl_Menu.TabPages[tabControl_Menu.SelectedIndex]
                    };
                    break;
                default:
                    break;
            }
            if (MdiChild != null && this.tabControl_Menu.SelectedIndex != 0)
            {
                MdiChild.Dock = DockStyle.Fill;
                MdiChild.Show();
            }
        }

        private void tabPage_TrangChu_Click(object sender, EventArgs e)
        {

        }

        private void Button_Back_Click(object sender, EventArgs e)
        {
            this.tabControl_Menu.SelectedIndex = 0;
        }

        private void Button_Refesh_Click(object sender, EventArgs e)
        {
            tabControl_Menu_SelectedIndexChanged(this.tabControl_Menu.SelectedTab, e);
        }

        private void button_Phong_Click(object sender, EventArgs e)
        {
            this.tabControl_Menu.SelectedIndex = 1;
        }

        private void button_HoaDon_Click(object sender, EventArgs e)
        {
            this.tabControl_Menu.SelectedIndex = 2;
        }

        private void button_KhachHang_Click(object sender, EventArgs e)
        {
            this.tabControl_Menu.SelectedIndex = 3;
        }

        private void button_NhanVien_Click(object sender, EventArgs e)
        {
            this.tabControl_Menu.SelectedIndex = 4;
        }

        private void button_HeThong_Click(object sender, EventArgs e)
        {
            this.tabControl_Menu.SelectedIndex = 5;
        }

        private void button_TaiKhoan_Click(object sender, EventArgs e)
        {
            this.tabControl_Menu.SelectedIndex = 6;
        }

        private void button_CaiDat_Click(object sender, EventArgs e)
        {
            this.tabControl_Menu.SelectedIndex = 7;
        }
    }
}
