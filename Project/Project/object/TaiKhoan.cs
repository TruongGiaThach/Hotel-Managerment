using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class TaiKhoan
    {
        private string Id;
        private string ten_DN;
        private string matKhau;
        private KhachHang khachHang;
        private string phanQuyen;
        public TaiKhoan()
        {
            this.ten_DN = "khach";
            this.matKhau = "1";
            this.phanQuyen = "khach";
        }
        public string PhanQuyen
        {
            get { return this.phanQuyen; }
            set { this.phanQuyen = value;}
        }
        public string ID
        {
            get
            {
                return this.Id;
            }
            set
            {
                this.Id = value;
            }
        }
        public string tenDN
        {
            get
            {
                return this.ten_DN;
            }
            set
            {
                this.ten_DN = value;
            }
        }
        public string MatKhau
        {
            get
            {
                return this.matKhau;
            }
            set
            {
                this.matKhau = value;
            }
        }
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
