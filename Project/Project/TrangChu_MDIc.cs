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
    public partial class TrangChu_MDIc : Form
    {
        public TrangChu_MDIc()
        {
            InitializeComponent();
            InitialPictureSlide();
        }

        #region 
        private void timerPictureSlide_Tick(object sender, EventArgs e)
        {
            //PictureSlideIndex++;
            //if (PictureSlideIndex == imageSlideList.Images.Count) PictureSlideIndex = 0;
            //pictureSlideBox.Image = imageSlideList.Images[PictureSlideIndex];
        }
        #endregion
    }
}
