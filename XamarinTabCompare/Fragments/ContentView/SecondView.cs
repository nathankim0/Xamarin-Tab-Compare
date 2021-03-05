using System;
using Xamarin.Forms;
namespace XamarinTabCompare.Fragments
{
    public class SecondView : ContentView
    {
        public SecondView()
        {
            var pageContents = new PageContents(2) { BackgroundColor = Color.Beige };

            Content = pageContents;
        }
    }
}
