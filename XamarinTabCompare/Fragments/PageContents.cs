using System;
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
                Padding = 30,
                Children = { contentLabel }
            };

            Content = stackLayout;
        }
    }
}
