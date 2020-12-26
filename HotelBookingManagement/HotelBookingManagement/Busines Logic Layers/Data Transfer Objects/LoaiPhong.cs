using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingManagement.Busines_Logic_Layers.Data_Transfer_Objects
{
    public class LoaiPhong
    {

        private string iD;
        private string ten;
        private int gia;


        public LoaiPhong()
        {
            this.ID = "";
            this.ten = "";
            this.gia = 0;
        }
        public LoaiPhong(DataRow item)
        {
            this.ID = item["ID"].ToString();
            this.ten = item["TENLP"].ToString();
            string s = item["GIA"].ToString();
            s = s.Split('.')[0];
            this.gia = Int32.Parse(s);
        }
        public LoaiPhong(string id, string ten,  int gia)
        {
            this.ID = id;
            this.gia = gia;
            this.ten = ten;
        }

        public string ID { get => iD; set => iD = value; }
        public string Ten { get => ten; set => ten = value; }
        public int Gia { get => gia; set => gia = value; }
    }

}
