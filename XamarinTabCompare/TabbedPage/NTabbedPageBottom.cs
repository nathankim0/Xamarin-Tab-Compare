using System;
using Xamarin.Forms;
using XamarinTabCompare.Fragments;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using NavigationPage = Xamarin.Forms.NavigationPage;
using TabbedPage = Xamarin.Forms.TabbedPage;

namespace XamarinTabCompare
{
    public class NTabbedPageBottom : TabbedPage
    {
        public NTabbedPageBottom()
        {
            On<Android>().DisableSwipePaging();
            On<Android>().SetOffscreenPageLimit(4);
            On<Android>().SetToolbarPlacement(ToolbarPlacement.Bottom);

            var firstPage = new NavigationPage(new FirstPage())
            {
                Title = "Page1"
            };
            firstPage.IconImageSource = new FontImageSource
            {
                FontFamily = "materialdesignicons",
                Glyph = FontIcons.BookOpenVariant,
            };
            firstPage.IconImageSource.SetAppThemeColor(FontImageSource.ColorProperty, Color.Black, Color.White);

            var secondPage = new NavigationPage(new SecondPage())
            {
                Title = "Page2"
            };
            secondPage.IconImageSource = new FontImageSource
            {
                FontFamily = "materialdesignicons",
                Glyph = FontIcons.BookOpenVariant,
            };
            secondPage.IconImageSource.SetAppThemeColor(FontImageSource.ColorProperty, Color.Black, Color.White);

            var thirdPage = new NavigationPage(new ThirdPage())
            {
                Title = "Page3"
            };
            thirdPage.IconImageSource = new FontImageSource
            {
                FontFamily = "materialdesignicons",
                Glyph = FontIcons.BookOpenVariant,
            };
            thirdPage.IconImageSource.SetAppThemeColor(FontImageSource.ColorProperty, Color.Black, Color.White);

            Children.Add(firstPage);
            Children.Add(secondPage);
            Children.Add(thirdPage);
        }
    }
}
