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

namespace HotelBookingManagement.Presentation_Layers
{
    public partial class Room_Information : Form
    {
        private KhachHang khachHang;
        private Phong phong;
        private DangKi dangKi;
        public Room_Information(Phong p)
        {
            InitializeComponent();
            this.phong = p;
            if (phong.TrangThai.Contains("dang cho"))
            {
                this.dangKi = DatPhong_DAL.Instance.getByRoomAndStatus(p.ID, "dang cho");
            }
            else if (phong.TrangThai.Contains("da nhan"))
            {
                this.dangKi = DatPhong_DAL.Instance.getByRoomAndStatus(p.ID, "da nhan");
                this.SaveDatPhong.Enabled = false;
            }
            this.khachHang = KhachHang_DAL.Instance.getByID(dangKi.MaKH);
        }
        private void initCustomerInfor()
        {
            if (khachHang != null)
            {
                this.TenKhachHang.Text = khachHang.HoTen;
                this.Phone.Text = khachHang.SoDT;
                this.Email.Text = khachHang.Email;
                this.CMT.Text = khachHang.Cmnd;
                this.DiaChiNg.Text = khachHang.DiaChi;
                this.GhiChu.Text = dangKi.GhiChu;
            }
        }
        private void initRoomInfor()
        {
            this.LoaiPhong.Text = phong.LoaiPhong;
            this.NgayDen.Text = dangKi.NgayNhanPhong.ToString("dd - mm - yyyy");
            this.NgayDi.Text = dangKi.NgayTraPhong.ToString("dd - mm - yyyy");
            this.TienCoc.Text = phong.ID;
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Room_Information_Load(object sender, EventArgs e)
        {
            initCustomerInfor();
        }
    }
}
