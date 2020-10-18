using Project.dataComu;
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
                    this.button_Delete.Visible = false;
                    this.buttonChange.Visible = false;
                    break;
                case "room":
                    sqlQuery = "select * from PHONG";
                    break;
                case "customer":
                    sqlQuery = "select * from KHACHHANG";
                    this.button_Add.Visible = false;
                    this.button_Delete.Visible = false;
                    this.buttonChange.Visible = false;
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
            if (this.dataGridView1.Rows.Count == 1)
            {
                this.button_Delete.Enabled = false;
                this.buttonChange.Enabled = false;
            }
            else
            {
                this.button_Delete.Enabled = true;
                this.buttonChange.Enabled = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            int index = 0;
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                index = this.dataGridView1.SelectedRows[0].Index;
            }
            switch (this.infor)
            {
                case"account":
                    string user = this.dataGridView1.Rows[index].Cells[1].Value.ToString();
                    DSTaiKhoan.Instance.xoaTaiKhoan(user);
                    this.FormCommon_Load(sender, e);
                    break;
                case "room":
                    string id = this.dataGridView1.Rows[index].Cells[0].Value.ToString();
                    DSPhong.Instance.xoaPhong(id);
                    this.FormCommon_Load(sender, e);
                    break;
                default:
                    break;
            }
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            RoomInfor roomInfor = new RoomInfor(this);
            roomInfor.ShowDialog();
            this.FormCommon_Load(sender, e);
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            int index = 0;
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                index = this.dataGridView1.SelectedRows[0].Index;
            }
            string id = this.dataGridView1.Rows[index].Cells[0].Value.ToString();
            string loai = this.dataGridView1.Rows[index].Cells[1].Value.ToString();
            string gia = this.dataGridView1.Rows[index].Cells[3].Value.ToString();
            RoomInfor room = new RoomInfor(this,id,loai,gia);
            room.ShowDialog();
            this.FormCommon_Load(sender, e);
        }
    }
}
