using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace lab08
{
    public partial class QRDemo : ContentPage
    {
        public QRDemo()
        {
            Title = "QR Code Scanner";

            StackLayout stack = new StackLayout();

            var button = new Button
            {
                Text = "Scan QR Code",
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
            };
            button.Clicked += async (sender, e) =>
            {
                var qrScanner = DependencyService.Get<IQRCodeScanner>();
                var result = await qrScanner.ScanQRCodeAsync();

                if (!string.IsNullOrEmpty(result))
                {
                    await DisplayAlert("QR Code Scanned", result, "OK");
                }
                else
                {
                    await DisplayAlert("QR Code Scanning", "No QR code detected.", "OK");
                }
            };

            stack.Children.Add(button);
            Content = stack;
        }
    }
}
