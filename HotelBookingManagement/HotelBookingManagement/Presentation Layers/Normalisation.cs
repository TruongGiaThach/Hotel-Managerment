using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelBookingManagement.Presentation_Layers
{
    public class Normalisation
    {
        public static string FormatProperCase(string str)  // Chuẩn hóa tên
        {
            CultureInfo cultureInfo = new CultureInfo("vi-VN");
            TextInfo textInfo = cultureInfo.TextInfo;
            str = textInfo.ToLower(str);
            // Replace multiple white space to 1 white  space
            str = System.Text.RegularExpressions.Regex.Replace(str, @"\s{2,}", " ");
            //Upcase like Title
            return textInfo.ToTitleCase(str);
        }
        public static  void TextboxOnlyDigit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)Keys.Back) || char.IsDigit(e.KeyChar))
            {
                return;
            }
            e.Handled = true;
        }
        public static void  TextboxOnlyLetter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || e.KeyChar == (char)Keys.Space)
            {
                return;
            }
            e.Handled = true;
        }
        public static void TextboxLetterAndDigitSpace_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || e.KeyChar == (char)Keys.Space || char.IsDigit(e.KeyChar))
            {
                return;
            }
            e.Handled = true;
        }
        public static void TextboxID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || char.IsDigit(e.KeyChar))
            {
                return;
            }
            e.Handled = true;
        }
    }
}
