using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using HotelBookingManagement.Data_Access_Layers;
using HotelBookingManagement.Busines_Logic_Layers.Data_Transfer_Objects;
using HotelBookingManagement.Presentation_Layers;
using HotelBookingManagement.Busines_Logic_Layers;

namespace HotelBookingManagement
{
    public partial class Room_Show : Form
    {
        private DateTime time;
        private TaiKhoan tk;

        public Room_Show(ref List<Phong> phongs,TaiKhoan tk)
        {
            InitializeComponent();
            this.Data = phongs;
            this.tk = tk;
            RoomShow_Load(new object { }, new EventArgs { });
        }

        private void RoomShow_Load(object sender, EventArgs e)
        {
            getData();
        }

        private void getData()
        {
            InitRoom();
        }

        private void buttonThemPhong_Click(object sender, EventArgs e)
        {
            Room_Infor roomInfor = new Room_Infor(this, ref Data);
            roomInfor.ShowDialog();
            this.RoomShow_Load(sender, e);
        }
        private void viewRoomInfor(ref Phong p)
        {
            if (p.TrangThai.Contains("trong"))
            {
                Room_Infor room_Infor = new Room_Infor(this, ref this.Data,p.ID,p.LoaiPhong,p.GiaPhong.ToString());
                room_Infor.ShowDialog();
                return;
            }
            Room_Information room_Information = new Room_Information(ref p);
            room_Information.ShowDialog();
        }

        private void buttonXoaPhong_Click(object sender, EventArgs e)
        {
            try
            {
                if (SelectedButton.Count > 0)
                {
                    if (MessageBox.Show("Bạn có chắc chắn muốn xóa các phòng đã chọn", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        for (int i = 0; i < SelectedButton.Count; ++i)
                        {
                            if (!(SelectedButton[i].Tag as Phong).TrangThai.Contains("trong"))
                                throw new Exception("Chỉ có thể xóa các phòng trống");
                            if (Phong_DAL.Instance.xoaPhong((SelectedButton[i].Tag as Phong).ID))
                                Data.RemoveAt(int.Parse(SelectedButton[i].Name));                           
                        }
                        SelectedButton.Clear();
                        RoomShow_Load(sender, e);
                    }
                }
            }
            catch (SqlException) { MessageBox.Show("Không thể xóa phòng này", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            catch(Exception ex) { MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void RoomSelect(object sender, EventArgs e)
        {
            Button selected = sender as Button;
            Phong p = selected.Tag as Phong;
            if (p.IsSelect == false)
            {
                SelectedButton.Add(selected);
                selected.ForeColor = Color.BlueViolet;
                p.IsSelect = true;
                time = DateTime.Now;
                return;
            }
            TimeSpan dist = DateTime.Now - time;
            if (dist.TotalMilliseconds <= 300)
                viewRoomInfor(ref p);
            for (int i = 0; i < SelectedButton.Count; ++i)
            {
                if (SelectedButton[i] == selected)
                {
                    selected.ForeColor = SystemColors.ControlText;
                    p.IsSelect = false;
                    SelectedButton.RemoveAt(i);
                    return;
                }
            }

        }

        private void button_ThuePhong_Click(object sender, EventArgs e)
        {
            int dem = 0;
            for (int i = 0; i < Data.Count; i++)
                if (Data[i].TrangThai.Contains("trong"))
                    dem++;
            if (dem <= 0)
                MessageBox.Show("Đã hết phòng (▀̿Ĺ̯▀̿ ̿)");
            else
            {
                Reservation_Form ThuePhong = new Reservation_Form(ref Data);
                ThuePhong.ShowDialog();
            }
            this.RoomShow_Load(sender, e);
        }

        private void button_TraPhong_Click(object sender, EventArgs e)
        {
            CheckOut_Controller.checkOut_openForm(SelectedButton,this.tk);
            this.RoomShow_Load(sender, e);
        }

        private void cancelReservationButton_Click(object sender, EventArgs e)
        {
            
            CancelReservation_Controller.excecute(ref this.SelectedButton);
            this.RoomShow_Load(sender, e);
        }

        private void button_NhanPhong_Click(object sender, EventArgs e)
        {
            int dem = 0;
            for (int i = 0; i < Data.Count; i++)
                if (Data[i].TrangThai.Contains("dang cho"))
                    dem++;
            if (dem <= 0)
                MessageBox.Show("Chưa có phòng nào được đặt");
            else
            {
                try
                {
                    int countSelectedRoom = SelectedButton.Count;
                    if (countSelectedRoom < 1)
                        throw new Exception("Cần chọn phòng để thực hiện");
                    else if (countSelectedRoom > 1)
                        throw new Exception("Hãy chắc chắn chỉ có 1 phòng được chọn");
                    Phong selectedRoom = SelectedButton[0].Tag as Phong;
                    if (!selectedRoom.TrangThai.Contains("dang cho"))
                        throw new Exception("Phòng đang ở hoặc vẫn chưa được đặt");
                    Room_Information room_Information = new Room_Information(ref selectedRoom);
                    room_Information.ShowDialog();
                    
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                
            }
            this.RoomShow_Load(sender, e);
        }
    }
}
