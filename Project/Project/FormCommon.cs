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
        private string infor;
        public FormCommon(string infor)
        {
            InitializeComponent();
            this.infor = infor;
            FormCommon_Load(new object { }, new EventArgs { });
        }

        public void FormCommon_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            string sqlQuery = "";
           
            switch (infor)
            {
                case "account":
                    sqlQuery = "select * from TAIKHOAN";
                    this.button_Add.Visible = false;
                    this.buttonChange.Visible = false;
                    break;
                case "room":
                    sqlQuery = "select * from PHONG";
                    break;

                default:
                    sqlQuery = "select MAKH as [Mã khách hàng], MAPHONG as [Mã phòng], " +
                    "NGNHANPHONG as [Ngày nhận phòng], NGTRAPHONG as[Ngày trả phòng], TRANGTHAIDON as [Trạng thái đơn]," +
                    "TGDOIPHONG as [Thời gian chờ phòng], GHICHU as [Ghi chú thêm] from DANGKI ";
                    this.button_Add.Visible = false;
                    this.buttonChange.Visible = false;
                    this.button_Delete.Visible = false;
                    break;
            };
            this.dataGridView1.DataSource = DataHelper.Instance.getDataTable(sqlQuery);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            switch (this.infor)
            {
                case"account":

                    break;
                default:
                    break;
            }
        }
    }
}
