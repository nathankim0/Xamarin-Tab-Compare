using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace XamarinTabCompare.Fragments
{
    public class PageContents : ContentView
    {
        private Label contentLabel;
        public int pageNum = 0;
        public PageContents(int pageNum)
        {
            this.pageNum = pageNum;

            contentLabel = new Label
            {
                Text = $"Hello this is Page {pageNum}"
            };

            var stackLayout = new StackLayout
            {
                Children = { contentLabel }
            };

            BindingContext = new MonkeysViewModel();

            CollectionView collectionView = new CollectionView();
            collectionView.SetBinding(ItemsView.ItemsSourceProperty, "Monkeys");

            collectionView.ItemTemplate = new DataTemplate(() =>
            {
                Grid grid = new Grid { Padding = 10 };
                grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
                grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });
                grid.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Auto });
                grid.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Auto });

                Image image = new Image { Aspect = Aspect.AspectFill, HeightRequest = 60, WidthRequest = 60 };
                image.SetBinding(Image.SourceProperty, "ImageUrl");

                Label nameLabel = new Label { FontAttributes = FontAttributes.Bold };
                nameLabel.SetBinding(Label.TextProperty, "Name");

                Label locationLabel = new Label { FontAttributes = FontAttributes.Italic, VerticalOptions = LayoutOptions.End };
                locationLabel.SetBinding(Label.TextProperty, "Location");

                Grid.SetRowSpan(image, 2);

                grid.Children.Add(image);
                grid.Children.Add(nameLabel, 1, 0);
                grid.Children.Add(locationLabel, 1, 1);

                return grid;
            });

            stackLayout.Children.Add(collectionView);

            Content = stackLayout;
        }
    }

    public class CustomCell : ViewCell
    {
        public CustomCell()
        {
            //instantiate each of our views
            var image = new Image();
            StackLayout cellWrapper = new StackLayout();
            StackLayout horizontalLayout = new StackLayout();
            Label left = new Label();
            Label right = new Label();

            //set bindings
            left.SetBinding(Label.TextProperty, "Name");
            right.SetBinding(Label.TextProperty, "Status");
            image.SetBinding(Image.SourceProperty, "ImageUri");

            //Set properties for desired design
            cellWrapper.BackgroundColor = Color.FromHex("#eee");
            horizontalLayout.Orientation = StackOrientation.Horizontal;
            right.HorizontalOptions = LayoutOptions.EndAndExpand;
            left.TextColor = Color.FromHex("#f35e20");
            right.TextColor = Color.FromHex("503026");

            //add views to the view hierarchy
            horizontalLayout.Children.Add(image);
            horizontalLayout.Children.Add(left);
            horizontalLayout.Children.Add(right);
            cellWrapper.Children.Add(horizontalLayout);
            View = cellWrapper;
        }
    }
}
