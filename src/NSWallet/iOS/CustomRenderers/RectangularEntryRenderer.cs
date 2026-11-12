using NSWallet;
using NSWallet.iOS;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls.Compatibility.Platform.iOS;
using UIKit;

[assembly: ExportRenderer(typeof(RectangularEntry), typeof(RectangularEntryRenderer))]
namespace NSWallet.iOS
{
    public class RectangularEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.BackgroundColor = UIColor.White;
                Control.BorderStyle = UITextBorderStyle.None;
                Control.TextAlignment = UITextAlignment.Center;
            }
        }
    }
}

