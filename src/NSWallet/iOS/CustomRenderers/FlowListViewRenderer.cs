using System;
using DLToolkit.Forms.Controls;
using NSWallet.iOS;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls.Compatibility.Platform.iOS;
using UIKit;

[assembly: ExportRenderer(typeof(FlowListView), typeof(FlowListViewRenderer))]
namespace NSWallet.iOS
{
    public class FlowListViewRenderer : ListViewRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<ListView> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement == null)
                return;

            if (Control != null)
            {
                Control.ScrollEnabled = false;
            }
        }
    }
}
