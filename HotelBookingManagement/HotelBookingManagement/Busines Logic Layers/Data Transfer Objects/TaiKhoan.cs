using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelBookingManagement
{
    public class TaiKhoan
    {
        private string iD;
        private string ten_DN;
        private string matKhau;
        private string maNV;
        private string phanQuyen;
        private bool trangThai;
        public TaiKhoan()
        {
            this.ten_DN = "khach";
            this.matKhau = "1";
            this.phanQuyen = "khach";
        }
        public TaiKhoan(DataRow item)
        {
            this.iD = item["ID"].ToString();
            this.tenDN = item["TENDN"].ToString();
            this.matKhau = item["MATKHAU"].ToString();
            this.maNV = item["MANV"].ToString();
            this.phanQuyen = item["PHANQUYEN"].ToString();
            string tmp = item["TRANGTHAI"].ToString();
            if (tmp.Contains("False"))
                this.trangThai = false;
            else this.trangThai = true;
        }
        public TaiKhoan(string id, string tendn, string matkhau, string makh, string phanquyen,bool trangThai)
        {
            this.iD = id;
            this.tenDN = tendn;
            this.matKhau = matkhau;
            this.maNV = makh;
            this.phanQuyen = phanquyen;
            this.trangThai = trangThai;
        }
        public string PhanQuyen
        {
            get { return this.phanQuyen; }
            set { this.phanQuyen = value; }
        }
        public string ID
        {
            get { return this.iD; }
            set { this.iD = value; }
        }
        public string tenDN
        {
            get { return this.ten_DN; }
            set { this.ten_DN = value; }
        }
        public string MatKhau
        {
            get { return this.matKhau; }
            set { this.matKhau = value; }
        }

        public string MaNV { get => maNV; set => maNV = value; }
        public bool TrangThai { get => trangThai; set => trangThai = value; }

        public static string encode(string chuoi)
        {
            string str_md5 = "";
            byte[] mang = System.Text.Encoding.UTF8.GetBytes(chuoi);

            MD5CryptoServiceProvider my_md5 = new MD5CryptoServiceProvider();
            mang = my_md5.ComputeHash(mang);

            foreach (byte b in mang)
            {
                str_md5 += b.ToString("X2");
            }

            return str_md5;
        }
    }
}
