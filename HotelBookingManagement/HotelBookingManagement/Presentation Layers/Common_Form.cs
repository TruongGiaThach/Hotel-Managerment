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
using HotelBookingManagement.Object;

namespace HotelBookingManagement
{
    public partial class Form_Common : Form
    {
        private int tabPage;
        private TaiKhoan currentUser;
        private string infor;
        private string valOfSelectedCell;
        private int indexOfSeclectedCell;

        public Form_Common(string infor, int tabPage, TaiKhoan tk)
        {
            InitializeComponent();
            this.currentUser = tk;
            this.tabPage = tabPage;
            this.infor = infor;
            FormCommon_Load(new object { }, new EventArgs { });
            valOfSelectedCell = "";
            indexOfSeclectedCell = 0;
        }
        public void FormCommon_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            string sqlQuery = "";
           
            switch (infor)
            {
                case "account":
                    sqlQuery = "select TAIKHOAN.ID as [ID], TAIKHOAN.TENDN as [Tên đăng nhập] ," +
                        " NHANVIEN.HOTEN as [Tên nhân viên], TAIKHOAN.PHANQUYEN as [Phân Quyền] " +
                        "from TAIKHOAN left join NHANVIEN on TAIKHOAN.MANV = NHANVIEN.ID " ;
                    this.button_Add.Visible = false;
                    this.button_Delete_staff.Visible = false;
                    this.button_Change.Visible = false;
                    this.dataGridView1.DataSource = DataHelper.Instance.getDataTable(sqlQuery);
                    break;
                case "customer":
                    sqlQuery = "select HOTEN as [Tên khách hàng], SODT as [Số điện thoại], EMAIL as [Email]," +
                        "DIACHI as [Địa chỉ], CMND as [Số CMND] from KHACHHANG";
                    this.button_Add.Visible = false;
                    this.button_Delete_staff.Visible = false;
                    this.button_Change.Visible = false;
                    this.dataGridView1.DataSource = DataHelper.Instance.getDataTable(sqlQuery);
                    break;
                case "staff":
                    sqlQuery = "select ID as [Mã nhân viên], HOTEN as [Họ tên], CMND as [Số CMND], SDT as [Số điện thoại]," +
                        "GIOITINH as [Giới tính], NGBD as [Ngày vào làm], TGHOPDONG as [Thời gian hợp đồng] from NHANVIEN ";
                    this.button_Add.Visible = true;
                    this.button_Delete_staff.Visible = true;
                    this.button_Change.Visible = false;
                    this.dataGridView1.DataSource = DataHelper.Instance.getDataTable(sqlQuery);
                    break;
                default:
                    sqlQuery = "select MAKH as [Mã khách hàng], MAPHONG as [Mã phòng], " +
                    "NGNHANPHONG as [Ngày nhận phòng], NGTRAPHONG as[Ngày trả phòng], TRANGTHAIDON as [Trạng thái đơn]," +
                    "TGDOIPHONG as [Thời gian chờ phòng], GHICHU as [Ghi chú thêm] from DANGKI";
                    this.button_Add.Visible = false;
                    this.button_Change.Visible = false;
                    this.button_Delete_staff.Visible = false;
                    this.dataGridView1.DataSource = DataHelper.Instance.getDataTable(sqlQuery);
                    break;

            };
            if (this.currentUser.PhanQuyen.Contains("user"))
            {
                this.button_Add.Visible = false;
                this.button_Change.Visible = false;
                this.button_Delete_staff.Visible = false;
            }
            // tạo function riêng trong mỗi DAL để lấy data, bỏ root khi hiển thị
            
            if (this.dataGridView1.Rows.Count == 0 )
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
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (e.ColumnIndex == 0)
                     this.valOfSelectedCell = this.dataGridView1[e.ColumnIndex, e.RowIndex].Value.ToString();
                this.indexOfSeclectedCell = e.ColumnIndex;
            }
        }
        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa thông tin này", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
           
                switch (this.infor)
                {
                    case "staff":
                        NhanVien_DAL.Instance.xoaTheoId(valOfSelectedCell);
                        break;
                    case "account":
                        TaiKhoan_DAL.Instance.xoaTaiKhoanID(valOfSelectedCell);
                        break;
                }
                    
                this.FormCommon_Load(sender, e);
                
            }
        }


        #region Search bar
        private List<DataGridViewCell> GetCellWhereTextExistsInGridView(string searchText, DataGridView dataGridView, int columnIndex)
        {
            List<DataGridViewCell> cellWhereTextIsMet = new List<DataGridViewCell>();

            // For every row in the grid (obviously)
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                // I did not test this case, but cell.Value is an object, and objects can be null
                // So check if the cell is null before using .ToString()
                if (row.Cells[columnIndex].Value != null && row.Cells[columnIndex].Value.ToString().Contains(searchText))
                {
                    // the searchText is equals to the text in this cell.
                    cellWhereTextIsMet.Add(row.Cells[columnIndex]);
                }
            }
            if (cellWhereTextIsMet.Count != 0)
                return cellWhereTextIsMet;
            else return null;
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            this.FormCommon_Load(sender, e);
            if (textBox1.Text == "")
                return;
            List<DataGridViewCell> cells = GetCellWhereTextExistsInGridView(textBox1.Text, this.dataGridView1, indexOfSeclectedCell);
            if (cells != null)
            {
                // Value exists in the grid
                // you can do extra stuff on the cell
                foreach (DataGridViewCell cell in cells)
                {
                    foreach(DataGridViewCell c in this.dataGridView1.Rows[cell.RowIndex].Cells)
                        c.Style = new DataGridViewCellStyle { ForeColor = Color.Red };
                }
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
