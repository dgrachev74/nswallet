using NSWallet;
using NSWallet.iOS;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls.Compatibility.Platform.iOS;
using UIKit;

[assembly: ExportRenderer(typeof(CustomLabel), typeof(CustomLabelRenderer))]
namespace NSWallet.iOS
{
    public class CustomLabelRenderer : LabelRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);
            if (e.NewElement == null) return;

            var customLabel = e.NewElement as CustomLabel;

            if (Control != null)
            {
                this.Control.Lines = customLabel.MaxLines;
            }
        }
    }
}
