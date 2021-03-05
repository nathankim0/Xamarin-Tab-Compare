using System;
using Xamarin.Forms;

namespace XamarinTabCompare.Fragments
{
    public class FirstView : ContentView
    {
        public FirstView()
        {
            var pageContents = new PageContents(1) { BackgroundColor = Color.AliceBlue };

            Content = pageContents;
        }
    }
}
