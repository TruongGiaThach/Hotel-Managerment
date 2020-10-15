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
    public partial class Home : Form
    {
        private LoginForm loginForm;
        private TaiKhoan currentUser;
        public Home()
        {
            InitializeComponent();
            InitalizeMdiChild();
        }
        private void Home_Load(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
            //load Trang chu
            //TC_MdiChild = new TrangChu_MDIc();
            //TC_MdiChild.MdiParent = this;
            //TC_MdiChild.Dock = System.Windows.Forms.DockStyle.Fill;
            TC_MdiChild.Show();
            //load phong
        }

        //Button Event Handle
        private void ButtonTrangChu_Click(object sender, EventArgs e)
        {
            //check is null
            if (TC_MdiChild != null)
                TC_MdiChild.Close();
            //create Form
            TC_MdiChild = new TrangChu_MDIc();
            TC_MdiChild.MdiParent = this;
            TC_MdiChild.Dock = System.Windows.Forms.DockStyle.Fill;
            TC_MdiChild.Show();
        }

        private void ButtonDatPhong_Click(object sender, EventArgs e)
        {
            //check is null
            if (BK_MdiChild != null)
                BK_MdiChild.Close();
            //create Form
            BK_MdiChild = new BookingForm(loginForm, currentUser);
            BK_MdiChild.MdiParent = this;
            BK_MdiChild.Dock = System.Windows.Forms.DockStyle.Fill;
            BK_MdiChild.Show();
        }
    }
}
