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
            MdiChild = new FormCommon();
            MdiChild.MdiParent = this;
            MdiChild.Dock = System.Windows.Forms.DockStyle.Fill;
            MdiChild.Show();
            string sqlQuery = "select MAKH as [Mã khách hàng], MAPHONG as [Mã phòng], " +
                "NGNHANPHONG as [Ngày nhận phòng], NGTRAPHONG as[Ngày trả phòng], TRANGTHAIDON as [Trạng thái đơn]," +
                "TGDOIPHONG as [Thời gian chờ phòng], GHICHU as [Ghi chú thêm] from DANGKI ";
            //this.dataGridView1.DataSource = DataHelper.Instance.getDataTable(sqlQuery);
        }

        private void ButtonAccounts_Click(object sender, EventArgs e)
        {
            //check is null
            if (MdiChild != null)
                MdiChild.Close();
            //create Form
            MdiChild = new FormCommon();
            MdiChild.MdiParent = this;
            MdiChild.Dock = System.Windows.Forms.DockStyle.Fill;
            MdiChild.Show();
        }
    }
}
