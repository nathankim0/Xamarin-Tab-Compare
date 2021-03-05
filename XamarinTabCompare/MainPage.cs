using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinTabCompare
{
    public partial class MainPage : ContentPage
    {
        private ScrollView scrollView;

        public MainPage()
        {
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

            scrollView = new ScrollView()
            {
                Padding = 10,
                Content = new StackLayout()
                {
                    Children = {tabbedPageButton, tabbedPageBottomButton }
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
    }
}
