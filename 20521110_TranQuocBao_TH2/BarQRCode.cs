using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BarcodeLib;
using QRCoder;
using ZXing;

namespace testQRcodeBarCode
{
    public class BarQRCode
    {
        public static Image ConvertBarCode(string text)
        {
            Barcode code128 = new Barcode();

            Image barcode = code128.Encode(BarcodeLib.TYPE.CODE128, text);

            return barcode;
        }

        public static Image ConvertQRCode(string text)
        {
            QRCodeGenerator qRCodeGenerator = new QRCodeGenerator();

            QRCode qrCode = new QRCode(qRCodeGenerator.CreateQrCode(text, QRCodeGenerator.ECCLevel.Q));

            Image qrCodeImg = qrCode.GetGraphic(2, Color.Black, Color.White, false);

            qRCodeGenerator.Dispose();

            qrCode.Dispose();

            return qrCodeImg;
        }

        public static string DecodeBarCode(Image barcode)
        {
            string decoded = "";
            Bitmap bitmap = (Bitmap)barcode;
            if (bitmap != null)
            {
                try
                {
                    ZXing.BarcodeReader Reader = new ZXing.BarcodeReader();
                    Result result = Reader.Decode(bitmap);
                    decoded = result.ToString().Trim();
                    return decoded;

                }
                catch
                {
                    MessageBox.Show("Không thể chuyển.");
                }
            }
            return decoded;
        }
    }
}
