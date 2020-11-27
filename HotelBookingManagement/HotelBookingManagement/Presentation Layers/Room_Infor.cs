using HotelBookingManagement.Data_Access_Layers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelBookingManagement
{
    public partial class Room_Infor : Form
    {
        Form preForm = null;
        string id, loai, gia;
        string type;
        public Room_Infor(Form form)
        {
            InitializeComponent();
            this.preForm = form;
            this.id = string.Empty;
            this.loai = string.Empty;
            this.type = "them";
            this.gia = string.Empty;
        }
        public Room_Infor(Form form, string id, string loai, string gia)
        {
            InitializeComponent();
            this.preForm = form;
            this.id = id;
            this.loai = loai;
            this.gia = gia;
            this.type = "sua";
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private bool addRoom(string id, string loai, string gia)
        {

            return Phong_DAL.Instance.themPhong(id, Int32.Parse(loai), Int32.Parse(gia));
        }
        private bool updateRoom(string id, string gia)
        {
            return Phong_DAL.Instance.updatePrice(id, gia);
        }
        private void RoomInfor_Load(object sender, EventArgs e)
        {
            if (this.type == "sua")
            {
                this.idTextbox.Text = this.id;
                this.roomTypeTextbox.Text = this.loai;
                this.priceTextbox.Text = this.gia;
                this.addButton.Text = "Sửa";
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {

            try
            {
                string id = this.idTextbox.Text;
                string loai = this.roomTypeTextbox.Text;
                string gia = this.priceTextbox.Text;
                if (type == "them")
                    if (addRoom(id, loai, gia))
                    {
                        MessageBox.Show("Thêm phòng thành công ><");
                        exitButton_Click(sender, e);
                    }
                if (type == "sua")
                    if (updateRoom(this.id, gia))
                    {
                        MessageBox.Show("Sửa phòng thành công ><");
                        exitButton_Click(sender, e);
                    };

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                RoomInfor_Load(sender, e);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            this.preForm.Show();
        }
    }
}
