using System;
using Xamarin.Forms;

namespace XamarinTabCompare.Fragments
{
    public class FirstPage : ContentPage
    {
        public FirstPage()
        {
            var pageContents = new PageContents(1);

            Content = pageContents;
        }
    }
}
