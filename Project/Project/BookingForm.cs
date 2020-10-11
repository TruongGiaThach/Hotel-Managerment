using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class BookingForm : Form
    {
        public BookingForm()
        {
            InitializeComponent();
            InitalizePreviewPanel();
        }

        #region Rooms Preview Control
        private int MinIndex = 0;
        private int MoveIndex = 0;
        private int MaxIndex = 3;
        private void buttonMoveLeft_Click(object sender, EventArgs e)
        {
            if (MoveIndex == MinIndex && MinIndex != 0)
            {
                flowLayoutPanelPicturePreview.Controls.Clear();
                for (int i = MinIndex - 1; i < i+3 && i < ROOMS.Length; ++i)
                {

                    flowLayoutPanelPicturePreview.Controls.Add(ROOMS[i]);
                }
                MinIndex--;
                MaxIndex--;
                MoveIndex--;
                ROOMS[MoveIndex].Select();
            }
            else if (MoveIndex > MinIndex)
            {
                MoveIndex--;
                ROOMS[MoveIndex].Select();
            }
        }

        private void buttonMoveRight_Click(object sender, EventArgs e)
        {
            if (MoveIndex == MaxIndex && MaxIndex != ROOMS.Length - 1)
            {
                flowLayoutPanelPicturePreview.Controls.Clear();
                for (int i = MinIndex + 1; i < i+3 && i < ROOMS.Length; ++i)
                {
                    flowLayoutPanelPicturePreview.Controls.Add(ROOMS[i]);
                }
                MinIndex++;
                MaxIndex++;
                MoveIndex++;
                ROOMS[MoveIndex].Select();
            }
            else if (MoveIndex < MaxIndex)
            {
                MoveIndex++;
                ROOMS[MoveIndex].Select();
            }
        }

        #endregion
    }
}
