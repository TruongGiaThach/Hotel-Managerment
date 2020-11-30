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
    public partial class Reservation_Form : Form
    {
        public Reservation_Form(ref List<Phong> Rooms)
        {
            InitializeComponent();
            this.Data = Rooms;
            Reservation_Form_Load(new object { }, new EventArgs { });
        }

        private void Reservation_Form_Load(object sender, EventArgs e)
        {
            InitRoomFinder();
        }

        private void radioButtons_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton Selected = sender as RadioButton;
            if (Selected.Checked)
            {
                MessageBox.Show(Text = this.NgayDen.Value.ToString());
            }
        }

        private void HuyDatPhong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
