using HotelBookingManagement.Data_Access_Layers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingManagement.Busines_Logic_Layers
{
    public class SingUp_Controller
    {
        public static void signUp(string user, string pass,string pass1,string staffID)
        {
            try
            {
                if (pass != pass1)
                    throw new  Exception("Repassword is wrong");
                TaiKhoan_DAL.Instance.themTaiKhoan(user, TaiKhoan.encode(pass), staffID);
            }
            catch(Exception ex)
            {
                throw new Exception("SignUp_Controller : " + ex.Message);
            }
        }
    }
}
