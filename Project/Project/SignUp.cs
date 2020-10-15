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
    public partial class SignUp : MaterialSkin.Controls.MaterialForm
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void button_Sign_up_Click(object sender, EventArgs e)
        {
            this.gradientPanel4.Show();
        }


        private void button_NextPage_Click(object sender, EventArgs e)
        {
            this.gradientPanel4.Hide();
        }
    }
}
