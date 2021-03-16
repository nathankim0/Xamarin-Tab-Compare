using System;
using Xamarin.Forms;
using Xamarin.CommunityToolkit;
using Xamarin.CommunityToolkit.UI.Views;
using XamarinTabCompare.Fragments;
using System.Collections.Generic;

namespace XamarinTabCompare.TabViewXCT
{
    public class NTabView : ContentPage
    {
        public NTabView()
        {
            var tabView = new TabView
            {
                TabStripPlacement = TabStripPlacement.Bottom,
                TabStripBackgroundColor = Color.White,
                TabStripHeight = 60,
                //TabIndicatorColor = Color.White,
                //TabContentBackgroundColor = Color.Yellow,
                
            };

            var tabViewItem1 = new TabViewItem
            {
                Text = "Tab 1",
                //TextColor = Color.White,
                //TextColorSelected = Color.Yellow,
                
            };
            tabViewItem1.Content = new FirstView();
            tabViewItem1.Icon = new FontImageSource
            {
                FontFamily = "materialdesignicons",
                Glyph = FontIcons.BookOpenVariant,
            };
            tabViewItem1.Icon.SetAppThemeColor(FontImageSource.ColorProperty, Color.Black, Color.White);

            var tabViewItem2 = new TabViewItem
            {
                Text = "Tab 2",
                //TextColor = Color.White,
                //TextColorSelected = Color.Yellow
            };
            tabViewItem2.Content = new SecondView();
            tabViewItem2.Icon = new FontImageSource
            {
                FontFamily = "materialdesignicons",
                Glyph = FontIcons.BookOpenVariant,
            };
            tabViewItem2.Icon.SetAppThemeColor(FontImageSource.ColorProperty, Color.Black, Color.White);

            var tabViewItem3 = new TabViewItem
            {
                Text = "Tab 3",
                //TextColor = Color.White,
                //TextColorSelected = Color.Yellow
            };
            tabViewItem3.Content = new ThirdView();
            tabViewItem3.Icon = new FontImageSource
            {
                FontFamily = "materialdesignicons",
                Glyph = FontIcons.BookOpenVariant,
            };
            tabViewItem3.Icon.SetAppThemeColor(FontImageSource.ColorProperty, Color.Black, Color.White);

            tabView.TabItems.Add(tabViewItem1);
            tabView.TabItems.Add(tabViewItem2);
            tabView.TabItems.Add(tabViewItem3);

            Content = new Grid
            {
                Children = { tabView }
            };
        }
    }
}
