using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using System.Windows.Forms;

namespace BarQRCodeGenerator.Helpers
{
    /// <summary>
    /// Helper class for checking correct sizes for Bar Codes & QR Codes
    /// 
    /// </summary>
    public static class GeneralHelper
    {
        public static bool CheckIfSizeValuesInRange(string width, string height)
        {
            if (width.Length > 3 || height.Length > 3)
            {
                width = string.Empty;
                height = string.Empty;
            }

            return true;
        }

        public static bool SetCorrectPictureBoxSizes(int width, int height, PictureBox picBox)
        {

            int pictureBoxWidth = 280;
            int pictureBoxHeight = 210;

            if (width > pictureBoxWidth || height > pictureBoxHeight)
            {
                width = pictureBoxWidth;
                height = pictureBoxHeight;
                picBox.Width = width;
                picBox.Height = height;

                return true;
            }
            
            return false;
        }

        public static bool CheckSizes(int width, int height)
        {
            const int constWidth = 99;
            const int constHeight = 99;

            if (width < constWidth || height < constHeight)
            {
                width = 0;
                height = 0;
                return true;
            }

            return false;
        }
    }
}
