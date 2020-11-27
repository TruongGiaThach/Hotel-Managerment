using Project.dataComu;
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

namespace Project
{
    public partial class RoomShow : Form
    {
        public RoomShow()
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
            RoomInfor roomInfor = new RoomInfor(this);
            roomInfor.ShowDialog();
            this.RoomShow_Load(sender, e);
        }

        private void buttonXoaPhong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa thông tin này", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                for (int i = 0; i < SelectedButton.Count; ++i)
                {
                    DSPhong.Instance.xoaPhong(SelectedButton[i].Name);

                }
            }
            SelectedButton.Clear();
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
    }
}
