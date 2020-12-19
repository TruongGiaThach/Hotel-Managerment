using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingManagement
{
    public class KhachHang
    {
        private string iD;
        private string hoTen;
        private string soDT;
        private string email;
        private string diaChi;
        string cmnd;
        public KhachHang()
        {
            this.iD = "";
            this.hoTen = "";
            this.email = "";
            this.soDT = "";
            this.diaChi = "";
            this.Cmnd = "";
        }
        public KhachHang(DataRow item)
        {
            this.iD = item["ID"].ToString();
            this.hoTen = item["HOTEN"].ToString();
            this.soDT = item["SODT"].ToString();
            this.email = item["EMAIL"].ToString();
            this.diaChi = item["DIACHI"].ToString();
            this.cmnd = item["CMND"].ToString();
        }
       
        public string ID { get => iD; set => iD = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string SoDT { get => soDT; set => soDT = value; }
        public string Email { get => email; set => email = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string Cmnd { get => cmnd; set => cmnd = value; }
    }
}
