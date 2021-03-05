using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinTabCompare.TabViewXCT;

namespace XamarinTabCompare
{
    public partial class MainPage : ContentPage
    {
        private ScrollView scrollView;

        public MainPage()
        {
            Title = "Nathan Tab Compare";

            var tabbedPageButton = new Button()
            {
                Text = "Tabbed Page (Top)",
                FontSize = 20,
                Padding = 20
            };
            tabbedPageButton.Clicked += OnTabbedPageButtonClicked;

            var tabbedPageBottomButton = new Button()
            {
                Text = "Tabbed Page (Bottom)",
                FontSize = 20,
                Padding = 20
            };
            tabbedPageBottomButton.Clicked += OnTabbedPageBottomButtonClicked;

            var tabViewButton = new Button()
            {
                Text = "TabView (XCT)",
                FontSize = 20,
                Padding = 20
            };
            tabViewButton.Clicked += OnTabViewButtonClicked;

            var tabViewXamlButton = new Button()
            {
                Text = "TabView with Xaml (fab) (XCT)",
                FontSize = 20,
                Padding = 20
            };
            tabViewXamlButton.Clicked += OnTabViewXamlButtonClicked;

            scrollView = new ScrollView()
            {
                Padding = 10,
                Content = new StackLayout()
                {
                    Children =
                    {
                        tabbedPageButton,
                        tabbedPageBottomButton,
                        tabViewButton,
                        tabViewXamlButton
                    }
                }
            };

            Content = scrollView;
        }

        private async void OnTabbedPageButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NTabbedPage());
        }

        private async void OnTabbedPageBottomButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NTabbedPageBottom());
        }

        private async void OnTabViewButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NTabView());
        }

        private async void OnTabViewXamlButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NTabViewWithXaml());
        }
    }
}
