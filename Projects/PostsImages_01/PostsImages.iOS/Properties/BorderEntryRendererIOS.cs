using System;
using PostsImages.iOS;
using PostsImages.Services;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(BorderEntry), typeof(BorderEntryRendererIOS))]
namespace PostsImages.iOS
{
    public class BorderEntryRendererIOS : LabelRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);
            if (e.OldElement == null)
            {
                Control.Layer.CornerRadius = 3f;

                Control.Layer.BorderWidth = 10;
                Control.Layer.BorderColor = Color.BlueViolet.ToCGColor();
                Control.TextAlignment = UITextAlignment.Right;
            }
        }
    }
    


}
