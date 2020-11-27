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

namespace HotelBookingManagement
{
    public partial class Room_Show : Form
    {
        public Room_Show()
        {
            InitializeComponent();
            RoomShow_Load(new object { }, new EventArgs { });
        }

        private void RoomShow_Load(object sender, EventArgs e)
        {
            getData();
        }

        private void getData()
        {
            InitRoom(DataHelper.Instance.getDataTable("select * from PHONG"));
        }

        private void buttonThemPhong_Click(object sender, EventArgs e)
        {
            Room_Infor roomInfor = new Room_Infor(this);
            roomInfor.ShowDialog();
            this.RoomShow_Load(sender, e);
        }

        private void buttonXoaPhong_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn xóa thông tin này", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    for (int i = 0; i < SelectedButton.Count; ++i)
                    {
                        Phong_DAL.Instance.xoaPhong(SelectedButton[i].Name);
                    }
                }
                SelectedButton.Clear();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            RoomShow_Load(sender, e);
        }

        private void RoomSelect(object sender, EventArgs e)
        {
            Button selected = sender as Button;
            if (selected.Tag.Equals(false))
            {
                SelectedButton.Add(selected);
                selected.ForeColor = Color.AliceBlue;
                selected.Tag = true;
                return;
            }

            for (int i = 0; i < SelectedButton.Count; ++i)
            {
                if (SelectedButton[i] == selected)
                {
                    selected.ForeColor = SystemColors.ControlText;
                    selected.Tag = false;
                    SelectedButton.RemoveAt(i);
                    return;
                }
            }

        }

        private void panel_MenuBar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
