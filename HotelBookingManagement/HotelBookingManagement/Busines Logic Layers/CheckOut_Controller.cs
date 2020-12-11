using HotelBookingManagement.Data_Access_Layers;
using HotelBookingManagement.Presentation_Layers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelBookingManagement.Busines_Logic_Layers
{
    public class CheckOut_Controller
    {
        public static void checkOut_openForm(List<Button> selectedButton)
        {
            try
            {
                int countSelectedRoom = selectedButton.Count;
                if (countSelectedRoom < 1)
                    throw new Exception("Cần chọn phòng để thực hiện");
                else if (countSelectedRoom > 1)
                    throw new Exception("Hãy chắc chắn chỉ có 1 phòng được chọn");
                Phong selectedRoom = selectedButton[0].Tag as Phong;
                if (selectedRoom.TrangThai.Contains("dang cho"))
                    throw new Exception("Phòng đang chờ, không thể thực hiện trả phòng");
                CheckOut_Form checkOut_Form = new CheckOut_Form();
                checkOut_Form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public static void checkOut_Execute()
        {

        }
    }
}
