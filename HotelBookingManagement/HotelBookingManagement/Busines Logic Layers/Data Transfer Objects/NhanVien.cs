using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingManagement.Object
{
    class NhanVien
    {
        private string iD;
        private string hoTen;
        string cmnd;
        private string soDT;
        private string gioitinh;
        private string ngayBD;
        string tghd;
        public NhanVien()
        {

        }
        public NhanVien(DataRow item)
        {
            this.ID = item["ID"].ToString();
            this.HoTen = item["HOTEN"].ToString();
            this.Cmnd = item["CMND"].ToString();
            this.SoDT = item["SDT"].ToString();
            this.Gioitinh = item["GIOITINH"].ToString();
            this.NgayBD = item["NGBD"].ToString();
            this.Tghd = item["TGHOPDONG"].ToString();
        }

        public string ID { get => iD; set => iD = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string Cmnd { get => cmnd; set => cmnd = value; }
        public string SoDT { get => soDT; set => soDT = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string NgayBD { get => ngayBD; set => ngayBD = value; }
        public string Tghd { get => tghd; set => tghd = value; }
    }
}
