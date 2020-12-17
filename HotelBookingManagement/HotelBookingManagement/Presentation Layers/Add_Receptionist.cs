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
        }

        private void ButtonThemNhanVien_Click(object sender, EventArgs e)
        {
            string ten = this.TenNhanVien.Text;
            string cmnd = this.CMTNhanVien.Text;
            string sdt = this.phoneNhanVien.Text;
            string gt = this.comboBox2.SelectedItem.ToString();
            bool check_addStaff= false;
            try
            {                
                check_addStaff =  addStaff_Controller_.addStaff_Controller(ten, cmnd, sdt, gt);              
                string user = this.TaiKhoanNhanVien.Text;
                string pass = this.mkNhanVien.Text;
                string pass1 = this.textBox_NhapLai.Text;
                string staffID = NhanVien_DAL.Instance.getByCMND(cmnd).ID;
                SingUp_Controller.signUp(user, pass, pass1,staffID);
                MessageBox.Show("Thêm nhân viên thành công✌(◕‿-)✌");
                this.Close();
            }
            catch(Exception ex)
            {
                if (check_addStaff)
                    NhanVien_DAL.Instance.xoaTheoId(NhanVien_DAL.Instance.getByCMND(cmnd).ID);
                MessageBox.Show(ex.Message);
            }
        }

        
        private void ButtonHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
