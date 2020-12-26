using HotelBookingManagement.Data_Access_Layers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelBookingManagement.Busines_Logic_Layers.Data_Transfer_Objects
{
    public class addCustomer_Controller
    {
        public static bool run(string ten,string gioitinh,string sdt, string email,string cmnd,string diachi)
        {
            try
            {
                return KhachHang_DAL.Instance.themKhachHang(ten, email, sdt, diachi, cmnd);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }
    }
}
