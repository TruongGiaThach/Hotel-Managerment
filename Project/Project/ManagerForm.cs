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
    public partial class ManagerForm : Form
    {
        private LoginForm loginForm;
        private TaiKhoan currentUser;
        public ManagerForm(LoginForm form, TaiKhoan user)
        {
            InitializeComponent();
            this.loginForm = form;
            this.currentUser = user;
        }
        private void Manager_Form_Load(object sender, EventArgs e)
        {
            string sqlQuery = "select MAKH as [Mã khách hàng], MAPHONG as [Mã phòng], " +
                "NGNHANPHONG as [Ngày nhận phòng], NGTRAPHONG as[Ngày trả phòng], TRANGTHAIDON as [Trạng thái đơn]," +
                "TGDOIPHONG as [Thời gian chờ phòng], GHICHU as [Ghi chú thêm] from DANGKI ";
            this.dataGridView1.DataSource = DataHelper.Instance.getDataTable(sqlQuery);
        }

        private void Manager_Form_SizeChanged(object sender, EventArgs e)
        {

        }

        private void AddRoom_Click(object sender, EventArgs e)
        {

        }

        private void ButtonView_Click(object sender, EventArgs e)
        {

        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {

        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {

        }

        private void ButtonAddAccount_Click(object sender, EventArgs e)
        {

        }

        private void groupBox_ACTION_Enter(object sender, EventArgs e)
        {

        }

        private void ButtonCall_Click(object sender, EventArgs e)
        {

        }

        private void ButtonSendEmail_Click(object sender, EventArgs e)
        {

        }

        private void ButtonSendText_Click(object sender, EventArgs e)
        {

        }

        private void group_comunicate_Enter(object sender, EventArgs e)
        {

        }

        private void ButtonBookingNotice_Click(object sender, EventArgs e)
        {

        }

        private void ButtonCheckoutNotice_Click(object sender, EventArgs e)
        {

        }

        private void ButtonCheckinNotice_Click(object sender, EventArgs e)
        {

        }

        private void MenuPanel_2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void group_account_Enter(object sender, EventArgs e)
        {

        }

        private void PictureAccout_Click(object sender, EventArgs e)
        {

        }

        private void labelTypeAccount_Click(object sender, EventArgs e)
        {

        }

        private void linkAccountName_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkAccountName_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void AccountDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
