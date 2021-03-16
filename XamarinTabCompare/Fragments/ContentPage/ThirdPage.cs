using System;
using Xamarin.Forms;

namespace XamarinTabCompare.Fragments
{
    public class ThirdPage : ContentPage
    {
        public ThirdPage()
        {
            var pageContents = new PageContents(3) { BackgroundColor = Color.LightPink };

            Content = pageContents;

            System.Diagnostics.Debug.WriteLine("ThirdPage Loaded!");
        }
    }
}
