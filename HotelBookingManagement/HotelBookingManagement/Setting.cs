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
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)

        {

            Graphics g = e.Graphics;

            Brush _textBrush;
            _textBrush = Brushes.Black;


            // Get the item from the collection.

            TabPage _tabPage = tabControl1.TabPages[e.Index];



            // Get the real bounds for the tab rectangle.

            Rectangle _tabBounds = tabControl1.GetTabRect(e.Index);



           



            // Use our own font.

            Font _tabFont = new Font("Microsoft Sans Serif", (float)16.0, FontStyle.Bold, GraphicsUnit.Pixel);



            // Draw string. Center the text.

            StringFormat _stringFlags = new StringFormat();

            _stringFlags.Alignment = StringAlignment.Center;

            _stringFlags.LineAlignment = StringAlignment.Center;

            g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));



        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}