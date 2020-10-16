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
    public partial class FormCommon : Form
    {
        public FormCommon(string infor)
        {
            InitializeComponent();
            string sqlQuery = "";
            switch (infor)
            {
                case "account":
                    sqlQuery = "select * from TAIKHOAN";
                    break;
                case "room":
                    sqlQuery = "select * from PHONG";
                    break;

                default:
                    sqlQuery = "select MAKH as [Mã khách hàng], MAPHONG as [Mã phòng], " +
                    "NGNHANPHONG as [Ngày nhận phòng], NGTRAPHONG as[Ngày trả phòng], TRANGTHAIDON as [Trạng thái đơn]," +
                    "TGDOIPHONG as [Thời gian chờ phòng], GHICHU as [Ghi chú thêm] from DANGKI ";
                    break;
            };
            this.dataGridView1.DataSource = DataHelper.Instance.getDataTable(sqlQuery);
        }

        public void FormCommon_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;        
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
