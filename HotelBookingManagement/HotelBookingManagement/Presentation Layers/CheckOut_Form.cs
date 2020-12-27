using HotelBookingManagement.Busines_Logic_Layers;
using HotelBookingManagement.Data_Access_Layers;
using HotelBookingManagement.Object;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelBookingManagement.Presentation_Layers
{
    public partial class CheckOut_Form : Form
    {
        private Phong p;
        private List<DangKi> dsDangki=new List<DangKi>();
        private List<Phong> dsPhong= new List<Phong>();
        private KhachHang kh;
        private HoaDon hd;
        private TaiKhoan tk;
        public CheckOut_Form(Phong p,TaiKhoan tk)
        {
            InitializeComponent();
            this.p = p;
            this.tk = tk;
        }

        private void CheckOut_Form_Load(object sender, EventArgs e)
        {
            this.textBox1.KeyPress += Normalisation.TextboxOnlyDigit_KeyPress;
            this.textBox6.KeyPress += Normalisation.TextboxOnlyDigit_KeyPress;
            List<DangKi> lists = DatPhong_DAL.Instance.getByRoomAndStatus(this.p.ID, "da nhan");
            DangKi tmp = null;
            if (lists.Count == 1)
                tmp = lists[0];
            lists = DatPhong_DAL.Instance.getByMaKH(tmp.MaKH);
            this.kh = KhachHang_DAL.Instance.getByID(tmp.MaKH);
            this.hd = HoaDon_DAL.Instance.getById(tmp.MaHD);
            foreach (DangKi dangKi in lists)
            {
                if (dangKi.TrangThaiDon.Contains("da nhan"))
                {
                    this.dsDangki.Add(dangKi);
                    Phong tmpPhong = Phong_DAL.Instance.getPhongbyId(dangKi.MaPhong);
                    this.dsPhong.Add(tmpPhong);
                }
            };
            initListRoom();
            initBillInfor();
        }
        private void initListRoom()
        {
            try
            {
                if (this.dsPhong == null) return;
                if (this.dsPhong.Count > 0)
                {
                    foreach (Phong phong in dsPhong)
                    {
                        List<DangKi> lists = DatPhong_DAL.Instance.getByRoomAndStatus(phong.ID, "da nhan");
                        DangKi dk = null;
                        if (lists.Count == 1)
                            dk = lists[0];
                        this.tablePhong.Rows.Add(phong.ID, phong.GiaPhong, Math.Ceiling((dk.NgayTraPhong - dk.NgayNhanPhong).TotalDays), phong.TienCoc);
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Lỗi bất ngờ trong lúc tạo ds phòng \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void initBillInfor()
        {
            try
            {
                this.textBox2.Text = this.kh.HoTen;
                this.textBox3.Text = (string.Format(kh.SoDT).Length < 2) ? kh.Email : kh.SoDT;
                int tienPhong = calculateRoomCost();
                if (tienPhong != this.hd.ChuaThanhToan)
                    throw new Exception("Conflict with database ");
                this.textBox4.Text = tienPhong.ToString();
                this.textBox5.Text = tienPhong.ToString();
                NhanVien nv = NhanVien_DAL.Instance.getNhanVienByID(tk.MaNV);
                this.textBox8.Text = string.Format(this.tk.MaNV) + " - " + nv.HoTen;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi bất ngờ trong lúc lấy thông tin hóa đơn \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private int calculateRoomCost()
        {
            int sum = 0;
            foreach (DangKi dangKi in this.dsDangki)
            {
                Phong phong = Phong_DAL.Instance.getPhongbyId(dangKi.MaPhong);
                int soNgay = (int)Math.Ceiling((dangKi.NgayTraPhong - dangKi.NgayNhanPhong).TotalDays);
                sum += soNgay * phong.GiaPhong;
            }
            return sum;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int num = 0;
            try
            {
                num = Int32.Parse(this.textBox1.Text);
                this.textBox5.Text = (num + Int32.Parse(textBox5.Text)).ToString();
            }
            catch (Exception) { };
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            int num = 0;
            try
            {
                num = Int32.Parse(this.textBox6.Text);
                this.textBox7.Text = (num - Int32.Parse(textBox5.Text)).ToString();
            }
            catch (Exception) { };
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            int num = 0;
            try
            {
                num = Int32.Parse(this.textBox6.Text);
                this.textBox7.Text = (num - Int32.Parse(textBox5.Text)).ToString();
            }
            catch (Exception) { };
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tienThanhToan = -1;
            try { tienThanhToan = Int32.Parse(this.textBox7.Text); }
            catch (Exception) { };
            if (tienThanhToan < 0)
            {
                MessageBox.Show("Tiền thanh toán chưa đủ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (CheckOut_Controller._Execute(this.dsPhong, this.dsDangki, this.textBox5.Text, this.hd, this.tk.MaNV))
            {
                MessageBox.Show("Thanh toán thành công", "Status");
                if (MessageBox.Show("Bạn có muốn in hóa đơn?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    PrintBill printBill = new PrintBill(this.dsPhong, this.dsDangki, this.textBox5.Text, this.hd, richTextBox1.Text, textBox1.Text);
                    printBill.ShowDialog();
                }
            }
            else MessageBox.Show("Thanh toán không thành công", "Status");
            this.Close();
        }
    }
}
