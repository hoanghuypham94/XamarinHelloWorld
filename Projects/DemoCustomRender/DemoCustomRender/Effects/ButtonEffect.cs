using System;
using Xamarin.Forms;

namespace DemoCustomRender.Effects
{
    public class ButtonEffect : RoutingEffect
    {
        public ButtonEffect() : base("DemoCustomRender.ButtonEffect")
        {
        }

        public float Radius { get; set; }

        public Color Color { get; set; }

        public float DistanceX { get; set; }

        public float DistanceY { get; set; }
    }
}
