using HotelBookingManagement.Data_Access_Layers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingManagement.Busines_Logic_Layers
{
    public class addStaff_Controller_
    {
        public static bool addStaff_Controller(string name,string cmnd,string phoneNum,string gender)
        {
            string begin = DateTime.Now.ToString();
            string last = "0";
            try
            {

                return NhanVien_DAL.Instance.themNhanVien(name, cmnd, phoneNum, gender, begin, last);
                    

            }
            catch(Exception ex)
            {
                throw new Exception("addStaff_Controller: " + ex.Message);
            }
        }
    }
}
