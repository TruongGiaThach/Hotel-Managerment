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
            string luong = this.textBox_Luong.Text;
            string gt = this.comboBox2.SelectedItem.ToString();
            string diaChi = this.AddressNhanVien.Text;
            bool check_addStaff= false;
            try
            {
                if (ten.Length == 0 || sdt.Length == 0 || cmnd.Length == 0)
                    throw new Exception("Tên, số điện thoại, cmnd là bắt buộc");
                if (luong.Length > 12)
                    throw new Exception("Lương quá lớn");
                check_addStaff =  addStaff_Controller._run(ten, cmnd, sdt, gt,luong,diaChi);              
                string user = this.TaiKhoanNhanVien.Text;
                string pass = this.mkNhanVien.Text;
                string pass1 = this.textBox_NhapLai.Text;
                string staffID = NhanVien_DAL.Instance.getByCMND(cmnd).ID;
                if (user.Length == 0 || pass.Length == 0 || pass1.Length == 0)
                    throw new Exception("Hãy nhập đủ các trường thông tin tài khoản");
                SingUp_Controller.signUp(user, pass, pass1,staffID);
                MessageBox.Show("Thêm nhân viên thành công✌(◕‿-)✌");
                this.Close();
            }
            catch(Exception ex)
            {
                if (check_addStaff)
                    NhanVien_DAL.Instance.xoaTheoId(NhanVien_DAL.Instance.getByCMND(cmnd).ID);
                MessageBox.Show(ex.Message,"Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        
        private void ButtonHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
