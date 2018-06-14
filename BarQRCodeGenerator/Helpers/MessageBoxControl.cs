using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarQRCodeGenerator.Helpers
{
    public static class MessageBoxControl
    {
        public static void SetExceptionControl(Control control, string text, AccessibleRole role, bool autoSize)
        {
            var nameControl = control;
            nameControl.Text = text;
            nameControl.AccessibleRole = role;
            nameControl.AutoSize = autoSize;
        }
    }
}
