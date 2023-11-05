using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using lab08.Droid;
using System;
using System.Threading.Tasks;
using ZXing;
using ZXing.Mobile;

[assembly: Xamarin.Forms.Dependency(typeof(QRCodeScannerImplementation))]
namespace lab08.Droid
{
    public class QRCodeScannerImplementation : IQRCodeScanner
    {
        public QRCodeScannerImplementation()
        {
        }

        public async Task<string> ScanQRCodeAsync()
        {
            try
            {
                var options = new MobileBarcodeScanningOptions
                {
                    AutoRotate = false,
                    UseFrontCameraIfAvailable = false,
                    TryHarder = true,
                };

                var scanner = new MobileBarcodeScanner
                {
                    TopText = "Escanea el código QR",
                    BottomText = "Espera a que la cámara detecte el código",
                };

                var result = await scanner.Scan(options);

                if (result != null && !string.IsNullOrEmpty(result.Text))
                {
                    return result.Text;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error al escanear código QR: " + ex.Message);
            }

            return null;
        }
    }
}
