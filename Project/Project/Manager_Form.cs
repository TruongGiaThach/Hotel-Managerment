using System;
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
    public partial class Manager_Form : Form
    {

        public Manager_Form()
        {
            InitializeComponent();

        }
        private void Manager_Form_Load(object sender, EventArgs e)
        {

        }

        private void Manager_Form_SizeChanged(object sender, EventArgs e)
        {
            //float size1 = this.Size.Width / firstWidth;
            //float size2 = this.Size.Height / firstHeight;

            //SizeF scale = new SizeF(size1, size2);
            //firstWidth = this.Size.Width;
            //firstHeight = this.Size.Height;

            //foreach (Control control in this.Controls)
            //{

            //    control.Font = new Font(control.Font.FontFamily, control.Font.Size * ((size1 + size2) / 2));

            //    control.Scale(scale);


            //}
        }
    }
}
