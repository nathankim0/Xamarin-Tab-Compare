using System;
using Xamarin.Forms;

namespace XamarinTabCompare.Fragments
{
    public class ThirdView : ContentView
    {
        public ThirdView()
        {
            var pageContents = new PageContents(3) { BackgroundColor = Color.LightPink };

            Content = pageContents;
        }
    }
}
