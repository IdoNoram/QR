using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using System.Windows.Forms;

namespace BarQRCodeGenerator.Helpers
{
    //Static Helper class for setting RichTextBox control properties
    //in separated class - not in Form(s). 
    //Set up any anothers as you go.
    public static class RichTextBoxControlHelper
    {
        public static RichTextBox SetUpProperties(RichTextBox control)
        {
            control.AutoWordSelection = true;
            control.DetectUrls = true;
            control.EnableAutoDragDrop = true;
            control.Multiline = true;
            control.ShowSelectionMargin = true;

            return control;
        }
    }
}
