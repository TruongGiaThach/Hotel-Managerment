using HotelBookingManagement.Busines_Logic_Layers.Data_Transfer_Objects;
using HotelBookingManagement.Data_Access_Layers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingManagement.Busines_Logic_Layers
{
    class Reservation_Controller
    {
        public static bool execute(string ten,string gioitinh,string sdt,string email, string cmnd, bool isHasCustomer,
            DateTime ngbd, DateTime ngkt, string RoomID)
        {
            bool check_addCus = false;
            bool check_addOrder = false;
            if (isHasCustomer)
                check_addCus = true;
            else check_addCus = addCustomer_Controller.run(ten, gioitinh, sdt, email, cmnd);
            KhachHang khachHang = KhachHang_DAL.Instance.getByCMND(cmnd);
            //
            check_addOrder = DatPhong_DAL.Instance.themOrder(khachHang.ID, RoomID, ngbd.ToString(), ngkt.ToString(), "3", "Nothing");
            return check_addOrder;
        }
    }
}
