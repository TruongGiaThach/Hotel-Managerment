using HotelBookingManagement.Busines_Logic_Layers;
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
    public partial class Add_Receptionist : Form
    {
        public Add_Receptionist()
        {
            InitializeComponent();
            DoubleBuffered = true;

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void ButtonThemNhanVien_Click(object sender, EventArgs e)
        {
            string ten = this.TenNhanVien.Text;
            string cmnd = this.CMTNhanVien.Text;
            string sdt = this.phoneNhanVien.Text;
            string gt = this.comboBox2.SelectedItem.ToString();
            try
            {
                
                addStaff_Controller_.addStaff_Controller(ten, cmnd, sdt, gt);              
                //
                string user = this.TaiKhoanNhanVien.Text;
                string pass = this.mkNhanVien.Text;
                string pass1 = this.textBox_NhapLai.Text;
                string staffID = NhanVien_DAL.Instance.getByCMND(cmnd).ID;
                SingUp_Controller.signUp(user, pass, pass1,staffID);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void phoneNhanVien_TextChanged(object sender, EventArgs e)
        {
            
                if (System.Text.RegularExpressions.Regex.IsMatch(phoneNhanVien.Text, "[^0-9]"))
                {
                    phoneNhanVien.Text = phoneNhanVien.Text.Remove(phoneNhanVien.Text.Length - 1);
                }
            
        }

        private void CMTNhanVien_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(phoneNhanVien.Text, "[^0-9]"))
            {
                 CMTNhanVien.Text = CMTNhanVien.Text.Remove(CMTNhanVien.Text.Length - 1);
            }
        }
    }
}
