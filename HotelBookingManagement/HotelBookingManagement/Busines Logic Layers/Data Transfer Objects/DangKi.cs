using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingManagement
{
    public class DangKi
    {
        private string iD;
        private string maKH;
        private string maPhong;
        private DateTime ngayNhanPhong;
        private DateTime ngayTraPhong;
        private string trangThaiDon;
        private int tgChoPhong;
        private string ghiChu;
        private string maHD;
        public DangKi(DataRow item)
        {
            this.ID = item["ID"].ToString();
            this.maKH = item["MAKH"].ToString();
            this.maPhong = item["MAPHONG"].ToString();
            this.NgayNhanPhong = DateTime.Parse(item["NGNHANPHONG"].ToString());
            this.ngayTraPhong = DateTime.Parse(item["NGTRAPHONG"].ToString());
            this.trangThaiDon = item["TRANGTHAIDON"].ToString();
            this.tgChoPhong = Int32.Parse(item["TGDOIPHONG"].ToString());
            this.ghiChu = item["GHICHU"].ToString();
            this.maHD = item["MAHD"].ToString();

        }
        public string MaKH { get => maKH; set => maKH = value; }
        public string MaPhong { get => maPhong; set => maPhong = value; }
        public DateTime NgayNhanPhong { get => ngayNhanPhong; set => ngayNhanPhong = value; }
        public DateTime NgayTraPhong { get => ngayTraPhong; set => ngayTraPhong = value; }
        public string TrangThaiDon { get => trangThaiDon; set => trangThaiDon = value; }
        public int TgChoPhong { get => tgChoPhong; set => tgChoPhong = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
        public string ID { get => iD; set => iD = value; }
        public string MaHD { get => maHD; set => maHD = value; }
    }
}
