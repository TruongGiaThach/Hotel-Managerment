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

namespace HotelBookingManagement
{
    public partial class Room_Show : Form
    {
        public Room_Show(ref List<Phong> phongs)
        {
            InitializeComponent();
            this.Data = phongs;
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

        private void buttonXoaPhong_Click(object sender, EventArgs e)
        {
            try
            {
                if (SelectedButton.Count > 0)
                {
                    if (MessageBox.Show("Bạn có muốn xóa phòng này", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        for (int i = 0; i < SelectedButton.Count; ++i)
                        {
                            if (Phong_DAL.Instance.xoaPhong((SelectedButton[i].Tag as Phong).ID))
                                Data.RemoveAt(int.Parse(SelectedButton[i].Name));                           
                        }
                        SelectedButton.Clear();
                        RoomShow_Load(sender, e);
                    }
                }
            }
            catch (SqlException sqlEx) { MessageBox.Show("Không thể xóa phòng này", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void RoomSelect(object sender, EventArgs e)
        {
            Button selected = sender as Button;
            if ((selected.Tag as Phong).IsSelect == false)
            {
                SelectedButton.Add(selected);
                selected.ForeColor = Color.BlueViolet;
                (selected.Tag as Phong).IsSelect = true;
                return;
            }

            for (int i = 0; i < SelectedButton.Count; ++i)
            {
                if (SelectedButton[i] == selected)
                {
                    selected.ForeColor = SystemColors.ControlText;
                    (selected.Tag as Phong).IsSelect = false;
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

        }
    }
}
