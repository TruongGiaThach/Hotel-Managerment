using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Phong
    {
        private string iD;
        private int loaiPhong;
        private string trangThai;
        private int giaPhong;

        public Phong() 
        {
            this.iD = "";
            this.loaiPhong = 0;
            this.trangThai = "";
            this.giaPhong = 0;
        }
        public Phong(string id, int loaiphong, string trangthai, int giaphong)
        {
            this.iD = id;
            this.loaiPhong = loaiphong;
            this.trangThai = trangthai;
            this.giaPhong = giaphong;
        }
        public string ID { get => iD; set => iD = value; }
        public int LoaiPhong { get => loaiPhong; set => loaiPhong = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
        public int GiaPhong { get => giaPhong; set => giaPhong = value; }
    }
}
