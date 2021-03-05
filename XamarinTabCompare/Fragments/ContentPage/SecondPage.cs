using System;
using Xamarin.Forms;

namespace XamarinTabCompare.Fragments
{
    public class SecondPage : ContentPage
    {
        public SecondPage()
        {
            var pageContents = new PageContents(2) { BackgroundColor = Color.Beige };

            Content = pageContents;
        }
    }
}
