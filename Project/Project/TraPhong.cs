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
    public partial class TraPhong : Form
    {
        public TraPhong()
        {
            InitializeComponent();
            this.comboBoxTimKiem.SelectedItem = 0;
        }

        private void textBoxSoNguoi_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonLayThongTin_Click(object sender, EventArgs e)
        {
            getdata("NguyenTanTien/312465826/0909576289/217/12:10:17/4:00:00");
            ShowthongTin();
        }
    }
}
