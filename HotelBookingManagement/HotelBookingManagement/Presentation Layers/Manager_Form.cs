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
        private TaiKhoan currentUser;
        public Manager_Form()
        {
            InitializeComponent();
            this.Hide();
            Login_Form Login = new Login_Form(this,ref currentUser);
            Login.ShowDialog();
        }
        private void Manager_Form_Load(object sender, EventArgs e)
        {
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
            Form newFrm = null;
            switch (tabControl_Menu.SelectedIndex)
            {
                case 6:
                    Data_path = "account";
                    newFrm = new Form_Common(Data_path, tabControl_Menu.SelectedIndex)
                    {
                        MdiParent = this,
                        Parent = tabControl_Menu.TabPages[tabControl_Menu.SelectedIndex]
                    };
                    break;
                case 1:
                    Data_path = "room";
                    newFrm = new Room_Show(ref DS_Phong)
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
                case 5:
                    newFrm = new Presentation_Layers.Budget_Form()
                    {
                        MdiParent = this,
                        Parent = tabControl_Menu.TabPages[tabControl_Menu.SelectedIndex]
                    };
                    break;
                case 7:
                    newFrm = new Setting()
                    {
                        MdiParent = this,
                        Parent = tabControl_Menu.TabPages[tabControl_Menu.SelectedIndex]
                    };
                    break;
                default:
                    break;
            }
            if (newFrm != null)
            {
                newFrm.Dock = DockStyle.Fill;
                newFrm.Show();
            }
        }

        private void tabPage_TrangChu_Click(object sender, EventArgs e)
        {

        }
    }
}
