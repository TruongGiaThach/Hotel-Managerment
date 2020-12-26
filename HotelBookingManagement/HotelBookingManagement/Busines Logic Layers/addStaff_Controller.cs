using HotelBookingManagement.Data_Access_Layers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingManagement.Busines_Logic_Layers
{
    public class addStaff_Controller
    {
        public static bool _run(string name,string cmnd,string phoneNum,string gender,string luong,string diaChi)
        {
            string begin = DateTime.Now.ToString();
            string last = "0";
            long l = 0;
            try
            {
                l = Int64.Parse(luong);
            }
            catch (Exception) { };
            try
            {
                return NhanVien_DAL.Instance.themNhanVien(name, cmnd, phoneNum, gender, begin, last,l,diaChi);                  
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
