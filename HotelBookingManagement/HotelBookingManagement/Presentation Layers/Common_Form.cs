using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using HotelBookingManagement.Data_Access_Layers;

namespace HotelBookingManagement
{
    public partial class Form_Common : Form
    {
        private int tabPage;
        private TaiKhoan currentUser;
        private string infor;
        public Form_Common(string infor, int tabPage, TaiKhoan tk)
        {
            InitializeComponent();
            this.currentUser = tk;
            this.tabPage = tabPage;
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
                    this.button_Delete_staff.Visible = true;
                    this.button_Change.Visible = false;
                    break;
                case "customer":
                    sqlQuery = "select HOTEN as [Tên khách hàng], SODT as [Số điện thoại], EMAIL as [Email]," +
                        "DIACHI as [Địa chỉ], CMND as [Số CMND] from KHACHHANG";
                    this.button_Add.Visible = false;
                    this.button_Delete_staff.Visible = false;
                    this.button_Change.Visible = false;
                    break;
                case "staff":
                    sqlQuery = "select ID as [Mã nhân viên], HOTEN as [Họ tên], CMND as [Số CMND], SDT as [Số điện thoại]," +
                        "GIOITINH as [Giới tính], NGBD as [Ngày vào làm], TGHOPDONG as [Thời gian hợp đồng] from NHANVIEN ";
                    this.button_Add.Visible = true;
                    this.button_Delete_staff.Visible = true;
                    this.button_Change.Visible = false;
                    break;
                default:
                    sqlQuery = "select MAKH as [Mã khách hàng], MAPHONG as [Mã phòng], " +
                    "NGNHANPHONG as [Ngày nhận phòng], NGTRAPHONG as[Ngày trả phòng], TRANGTHAIDON as [Trạng thái đơn]," +
                    "TGDOIPHONG as [Thời gian chờ phòng], GHICHU as [Ghi chú thêm] from DANGKI ";
                    this.button_Add.Visible = false;
                    this.button_Change.Visible = false;
                    this.button_Delete_staff.Visible = false;
                    break;

            };
            if (this.currentUser.PhanQuyen.Contains("user"))
            {
                this.button_Add.Visible = false;
                this.button_Change.Visible = false;
                this.button_Delete_staff.Visible = false;
            }
            // tạo function riêng trong mỗi DAL để lấy data, bỏ root khi hiển thị
            this.dataGridView1.DataSource = DataHelper.Instance.getDataTable(sqlQuery);
            if (this.dataGridView1.Rows.Count == 1 )
            {
                this.button_Delete_staff.Enabled = false;
                this.button_Change.Enabled = false;
            }
            else
            {
                this.button_Delete_staff.Enabled = true;
                this.button_Change.Enabled = true;
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
            if (MessageBox.Show("Bạn có muốn xóa thông tin này", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int index = 0;
                if (this.dataGridView1.SelectedRows.Count > 0)
                {
                    index = this.dataGridView1.SelectedRows[0].Index;
                }
                
                string id = this.dataGridView1.Rows[index].Cells[0].Value.ToString();
                if (index > 0)
                    switch (this.infor)
                    {
                        case "staff":
                            NhanVien_DAL.Instance.xoaTheoId(id);
                            break;
                        case "account":
                            TaiKhoan_DAL.Instance.xoaTaiKhoanID(id);
                            break;
                    }
                    
                this.FormCommon_Load(sender, e);
                
            }
        }

        //private void button_Change_Click(object sender, EventArgs e)
        //{
        //    int index = 0;
        //    if (this.dataGridView1.SelectedRows.Count > 0)
        //    {
        //        index = this.dataGridView1.SelectedRows[0].Index;
        //    }
        //    string id = this.dataGridView1.Rows[index].Cells[0].Value.ToString();
        //    string loai = this.dataGridView1.Rows[index].Cells[1].Value.ToString();
        //    string gia = this.dataGridView1.Rows[index].Cells[3].Value.ToString();
        //    Room_Infor room = new Room_Infor(this, id, loai, gia);
        //    room.ShowDialog();
        //    this.FormCommon_Load(sender, e);
        //}

        #region Search bar
        private DataGridViewCell GetCellWhereTextExistsInGridView(string searchText, DataGridView dataGridView, int columnIndex)
        {
            DataGridViewCell cellWhereTextIsMet = null;

            // For every row in the grid (obviously)
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                // I did not test this case, but cell.Value is an object, and objects can be null
                // So check if the cell is null before using .ToString()
                if (row.Cells[columnIndex].Value != null && searchText == row.Cells[columnIndex].Value.ToString())
                {
                    // the searchText is equals to the text in this cell.
                    cellWhereTextIsMet = row.Cells[columnIndex];
                    break;
                }
            }

            return cellWhereTextIsMet;
        }

        private void button_Search_Click(object sender, EventArgs e)
        {

            DataGridViewCell cell = GetCellWhereTextExistsInGridView(textBox1.Text, this.dataGridView1, 2);
            if (cell != null)
            {
                // Value exists in the grid
                // you can do extra stuff on the cell
                cell.Style = new DataGridViewCellStyle { ForeColor = Color.Red };
            }
            else
            {
                // Value does not exist in the grid
            }
        }

        #endregion

        private void button_Change_Click(object sender, EventArgs e)
        {

        }

        private void button_Add_Click_1(object sender, EventArgs e)
        {

            Add_Receptionist add_Receptionist = new Add_Receptionist();
            add_Receptionist.ShowDialog();
            this.FormCommon_Load(sender, e);
        }
    }
}
