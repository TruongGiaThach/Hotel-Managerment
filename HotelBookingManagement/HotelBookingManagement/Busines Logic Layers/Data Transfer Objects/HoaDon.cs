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
        private int chuaThanhToan;
        private int daThanhToan;
        public HoaDon()
        {
            this.ID = "";
            this.MaKH = "";
            this.MaNV = "";
            this.chuaThanhToan = 0;
            this.daThanhToan = 0;
        }
        public HoaDon(DataRow item)
        {
            this.ID = item["ID"].ToString();
            this.MaKH = item["MAKH"].ToString() ;
            this.MaNV = item["MANV"].ToString();
            this.chuaThanhToan = Int32.Parse(item["CHUATHANHTOAN"].ToString());
            
            this.daThanhToan  = Int32.Parse(item["DATHANHTOAN"].ToString());
            
        }

        public HoaDon(string iD, string maKH, string maNV, int chthanhtoan, int dathanhtoan)
        {
            this.ID = iD;
            this.MaKH = maKH;
            this.MaNV = maNV;
            this.chuaThanhToan = chthanhtoan;
            this.daThanhToan = dathanhtoan;
        }

        public string ID { get => iD; set => iD = value; }
        public string MaKH { get => maKH; set => maKH = value; }
        public string MaNV { get => maNV; set => maNV = value; }
        public int ChuaThanhToan { get => chuaThanhToan; set => chuaThanhToan = value; }
        public int DaThanhToan { get => daThanhToan; set => daThanhToan = value; }
    }
}
