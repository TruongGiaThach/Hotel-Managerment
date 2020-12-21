using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingManagement
{
    public class Phong
    {
        private string iD;
        private string loaiPhong;
        private string trangThai;
        private int giaPhong;
        private int tienCoc;
        private bool isSelect;

        public Phong()
        {
            this.iD = "";
            this.loaiPhong = "";
            this.trangThai = "";
            this.giaPhong = 0;
            this.TienCoc = 0;
            this.isSelect = false;
        }
        public Phong(DataRow item)
        {
            this.iD = item["ID"].ToString();
            this.loaiPhong = item["LOAI"].ToString();
            this.trangThai = item["TRANGTHAI"].ToString();
            string s = item["GIAPHONG"].ToString();
            s = s.Split('.')[0];
            this.giaPhong = Int32.Parse(s);
            
            s = item["TIENCOC"].ToString();
            s = s.Split('.')[0];
            this.TienCoc = Int32.Parse(s);
            this.isSelect = false;
        }
        public Phong(string id, string loaiphong, string trangthai, int giaphong , int tienCoc)
        {
            this.iD = id;
            this.loaiPhong = loaiphong;
            this.trangThai = trangthai;
            this.giaPhong = giaphong;
            this.TienCoc = tienCoc;
            this.isSelect = false;
        }
        public string ID { get => iD; set => iD = value; }
        public string LoaiPhong { get => loaiPhong; set => loaiPhong = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
        public int GiaPhong { get => giaPhong; set => giaPhong = value; }
        public bool IsSelect { get => isSelect; set => isSelect = value; }
        public int TienCoc { get => tienCoc; set => tienCoc = value; }
    }
}
