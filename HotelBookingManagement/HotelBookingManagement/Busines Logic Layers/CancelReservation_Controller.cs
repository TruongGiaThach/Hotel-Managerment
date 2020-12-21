using HotelBookingManagement.Data_Access_Layers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelBookingManagement.Busines_Logic_Layers
{
    class CancelReservation_Controller
    {
        public static void excecute( ref List<Button> selectedButton)
        {
            try
            {
                int countSelectedRoom = selectedButton.Count;
                if (countSelectedRoom < 1)
                    throw new Exception("Cần chọn phòng để thực hiện");
                else if (countSelectedRoom > 1)
                    throw new Exception("Hãy chắc chắn chỉ có 1 phòng được chọn");
                Phong selectedRoom = selectedButton[0].Tag as Phong;
                if (!selectedRoom.TrangThai.Contains("dang cho"))
                    throw new Exception("Phòng chưa được đặt, không thể thực hiện");
                if (MessageBox.Show("Bạn có muốn hủy đặt phòng này","Warning",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    CancelReservation_Controller.cancelOrder(ref selectedRoom);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public static void cancelOrder(ref Phong phong)
        {
            List<DangKi> dangKis = DatPhong_DAL.Instance.getByRoomAndStatus(phong.ID, "dang cho");
            if (dangKis.Count == 1)
            {
                DatPhong_DAL.Instance.xoaDangKi(dangKis[0].ID);
                Phong_DAL.Instance.updateStatus(phong.ID, "trong");
                phong.TrangThai = "trong";
            }
            MessageBox.Show("Hủy đặt phòng thành công");
        }
    }
}
