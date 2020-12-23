using HotelBookingManagement.Data_Access_Layers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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
            this.loginForm = Login;
            Login.ShowDialog();
        }
        private void Manager_Form_Load(object sender, EventArgs e)
        {
            //GraphicsPath gp = new GraphicsPath();
            //gp.AddEllipse(1, 1, button_Phong.Width - 4, button_Phong.Height - 4);
            //button_Phong.Region = new Region(gp);
            //gp.Dispose();
            if (this.currentUser == null)
            {
                Application.Exit();
            }
            this.DS_Phong = Phong_DAL.Instance.GetDsPhong();
            if (this.currentUser != null)
            switch((this.currentUser.PhanQuyen))
            {
                case "user":
                    this.label1.Text = "NHÂN VIÊN";
                    this.InitTabPage("user");
                    this.InitTabButton("user");
                    break;
                case "admin":
                    this.label1.Text = "QUẢN LÍ";
                    this.InitTabPage("admin");
                    this.InitTabButton("admin");
                    break;
            }
            this.tabControl_Menu.SelectedIndex = 0;
        }
        public void logout(object sender,EventArgs e)
        {
            this.currentUser = null;
            this.Hide();
            this.loginForm.ShowDialog();
            this.Manager_Form_Load(sender, e);
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
            if (tabControl_Menu.TabPages.Count != 0)
            {
                string Data_path = "";
                switch (tabControl_Menu.SelectedTab.Name)
                {
                    case "tabPage_TaiKhoan":
                        Data_path = "account";
                        MdiChild = new Form_Common(Data_path, tabControl_Menu.SelectedIndex, currentUser)
                        {
                            MdiParent = this,
                            Parent = tabControl_Menu.TabPages[tabControl_Menu.SelectedIndex]
                        };
                        break;
                    case "tabPage_Phong":
                        Data_path = "room";
                        this.DS_Phong = Phong_DAL.Instance.GetDsPhong();
                        MdiChild = new Room_Show(ref DS_Phong, this.currentUser)
                        {
                            MdiParent = this,
                            Parent = tabControl_Menu.TabPages[tabControl_Menu.SelectedIndex]
                        };
                        break;
                    case "tabPage_Oder_Room":
                        Data_path = "default";
                        MdiChild = new Form_Common(Data_path, tabControl_Menu.SelectedIndex, currentUser)
                        {
                            MdiParent = this,
                            Parent = tabControl_Menu.TabPages[tabControl_Menu.SelectedIndex]
                        };
                        break;
                    case "tabPage_Customer":
                        Data_path = "customer";
                        MdiChild = new Form_Common(Data_path, tabControl_Menu.SelectedIndex, currentUser)
                        {
                            MdiParent = this,
                            Parent = tabControl_Menu.TabPages[tabControl_Menu.SelectedIndex]
                        };
                        break;
                    case "tabPage_NhanVien":
                        Data_path = "staff";
                        MdiChild = new Form_Common(Data_path, tabControl_Menu.SelectedIndex, currentUser)
                        {
                            MdiParent = this,
                            Parent = tabControl_Menu.TabPages[tabControl_Menu.SelectedIndex]
                        };
                        break;
                    case "tabPage_ThongKe":
                        MdiChild = new Presentation_Layers.Budget_Form()
                        {
                            MdiParent = this,
                            Parent = tabControl_Menu.TabPages[tabControl_Menu.SelectedIndex]
                        };
                        break;
                    case "tabPage_Settings":
                        MdiChild = new Setting(this, this.loginForm)
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
            this.tabControl_Menu.SelectedTab = this.tabControl_Menu.TabPages["tabPage_Phong"];
        }

        private void button_HoaDon_Click(object sender, EventArgs e)
        {
            this.tabControl_Menu.SelectedTab = this.tabControl_Menu.TabPages["tabPage_Oder_Room"];
        }

        private void button_KhachHang_Click(object sender, EventArgs e)
        {
            this.tabControl_Menu.SelectedTab = this.tabControl_Menu.TabPages["tabPage_Customer"];
        }

        private void button_NhanVien_Click(object sender, EventArgs e)
        {
            this.tabControl_Menu.SelectedTab = this.tabControl_Menu.TabPages["tabPage_NhanVien"];
        }

        private void button_HeThong_Click(object sender, EventArgs e)
        {
            this.tabControl_Menu.SelectedTab = this.tabControl_Menu.TabPages["tabPage_ThongKe"];
        }

        private void button_TaiKhoan_Click(object sender, EventArgs e)
        {
            this.tabControl_Menu.SelectedTab = this.tabControl_Menu.TabPages["tabPage_TaiKhoan"];
        }

        private void button_CaiDat_Click(object sender, EventArgs e)
        {
            this.tabControl_Menu.SelectedTab = this.tabControl_Menu.TabPages["tabPage_Settings"];
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
