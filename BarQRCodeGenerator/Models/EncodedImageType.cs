using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using BarcodeLib;
using Spire.License;

namespace BarQRCodeGenerator.Models
{
    public class EncodedImageType
    {
        public EncodedImageType()
        {

        }

        public EncodedImageType(int encodeId, string encodedName)
        {
            this.EncodeId = encodeId;
            this.ImageTypeName = encodedName;
        }
        public int EncodeId { get; set; }
        public string ImageTypeName { get; set; }
        public bool IsChoosen { get; set; }

        public Array LoadImageTypes()
        {
            List<EncodedImageType> encodedImages = new List<EncodedImageType>();

            //  encodedImages.Add(new EncodedImageType(0, "UNSPECIFIED"));
            encodedImages.Add(new EncodedImageType(1, "UPCA"));
            encodedImages.Add(new EncodedImageType(2, "UPCE"));
            encodedImages.Add(new EncodedImageType(3, "UPC_SUPPLEMENTAL_2DIGIT"));
            encodedImages.Add(new EncodedImageType(4, "UPC_SUPPLEMENTAL_5DIGIT"));
            encodedImages.Add(new EncodedImageType(5, "EAN13"));
            encodedImages.Add(new EncodedImageType(6, "EAN8"));
            encodedImages.Add(new EncodedImageType(7, "Interleaved2of5"));
            encodedImages.Add(new EncodedImageType(8, "Standard2of5"));
            encodedImages.Add(new EncodedImageType(9, "Industrial2of5"));
            encodedImages.Add(new EncodedImageType(10, "CODE39"));
            encodedImages.Add(new EncodedImageType(11, "CODE39Extended"));
            encodedImages.Add(new EncodedImageType(12, "CODE39_Mod43"));
            encodedImages.Add(new EncodedImageType(13, "Codabar"));
            encodedImages.Add(new EncodedImageType(14, "PostNet"));
            encodedImages.Add(new EncodedImageType(15, "BOOKLAND"));
            encodedImages.Add(new EncodedImageType(16, "ISBN"));
            encodedImages.Add(new EncodedImageType(17, "JAN13"));
            encodedImages.Add(new EncodedImageType(18, "MSI_Mod10"));
            encodedImages.Add(new EncodedImageType(19, "MSI_2Mod10"));
            encodedImages.Add(new EncodedImageType(20, "MSI_Mod11"));
            encodedImages.Add(new EncodedImageType(21, "MSI_Mod11_Mod10"));
            encodedImages.Add(new EncodedImageType(22, "Modified_Plessey"));
            encodedImages.Add(new EncodedImageType(23, "CODE11"));
            encodedImages.Add(new EncodedImageType(24, "USD8"));
            encodedImages.Add(new EncodedImageType(25, "UCC12"));
            encodedImages.Add(new EncodedImageType(26, "UCC13"));
            encodedImages.Add(new EncodedImageType(27, "LOGMARS"));
            encodedImages.Add(new EncodedImageType(28, "CODE128"));
            encodedImages.Add(new EncodedImageType(29, "CODE128A"));
            encodedImages.Add(new EncodedImageType(30, "CODE128B"));
            encodedImages.Add(new EncodedImageType(31, "CODE128C"));
            encodedImages.Add(new EncodedImageType(32, "ITF14"));
            encodedImages.Add(new EncodedImageType(33, "CODE93"));
            encodedImages.Add(new EncodedImageType(34, "TELEPEN"));
            encodedImages.Add(new EncodedImageType(35, "FIM"));
            encodedImages.Add(new EncodedImageType(36, "PHARMACODE"));

            var parsedEnum = Enum.GetValues(typeof(TYPE));

            return parsedEnum;
        }
    }
}
