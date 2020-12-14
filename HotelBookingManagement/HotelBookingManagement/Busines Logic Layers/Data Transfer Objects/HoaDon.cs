using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingManagement
{
    public class HoaDon
    {
        private string iD;
        private string maKH;
        private string maNV;
        private int triGia;
        public HoaDon()
        {
            this.ID = "";
            this.MaKH = "";
            this.MaNV = "";
            this.TriGia = 0;
        }
        public HoaDon(DataRow item)
        {
            this.ID = item["ID"].ToString();
            this.MaKH = item["MAKH"].ToString() ;
            this.MaNV = item["MANV"].ToString();
            this.TriGia = Int32.Parse(item["TRIGIA"].ToString());
        }

        public HoaDon(string iD, string maKH, string maNV, int triGia)
        {
            this.ID = iD;
            this.MaKH = maKH;
            this.MaNV = maNV;
            this.TriGia = triGia;
        }

        public string ID { get => iD; set => iD = value; }
        public string MaKH { get => maKH; set => maKH = value; }
        public string MaNV { get => maNV; set => maNV = value; }
        public int TriGia { get => triGia; set => triGia = value; }
    }
}
