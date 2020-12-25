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
    public partial class Reset_Pass_Form : Form
    {
        public Reset_Pass_Form(Manager_Form m, TaiKhoan user)
        {
            InitializeComponent();
            this.main = m;
            this.user = user;
        }

        private void button_XacNhan_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.textBox_MkCu.Text != null)
                {
                    if (TaiKhoan_DAL.Instance.CheckMatKhau(user.tenDN, TaiKhoan.encode(this.textBox_MkCu.Text)))
                    {
                        if (this.textBox_MkMoi != null)
                        {
                            if (this.textBox_MkMoiLai.Text != null)
                            {
                                if (this.textBox_MkMoiLai.Text == this.textBox_MkMoi.Text)
                                {
                                    if (TaiKhoan_DAL.Instance.updateTaiKhoan(this.user.tenDN, TaiKhoan.encode(this.textBox_MkMoi.Text)))
                                        if (MessageBox.Show("Thay đổi mật khẩu thành công\ntiến hành đăng xuất để đăng nhập lại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                                            main.logout(sender, e);
                                }
                                else
                                {
                                    if (MessageBox.Show("Mật khẩu nhập lại không đúng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK)
                                        this.textBox_MkMoiLai.Clear();
                                }
                            }
                            else
                                MessageBox.Show("Vui lòng nhập lại mật khẩu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        MessageBox.Show("Vui lòng nhập mật khẩu mới", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                        MessageBox.Show("Mật khẩu cũ không đúng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);   
                }
                else
                    MessageBox.Show("vui lòng nhập mật khẩu cũ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void button_Huy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn hủy thay đổi mật khẩu", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }
    }
}
