using System;
using System.Threading;
using Xamarin.Forms;

namespace XamarinTabCompare.Fragments
{
    public class SecondPage : ContentPage
    {
        public PageContents pageContents;
        public SecondPage()
        {
            pageContents = new PageContents(2) { BackgroundColor = Color.Beige };

            new Thread(() => Run()).Start();

            Content = pageContents;

            System.Diagnostics.Debug.WriteLine("SecondPage Loaded!");
        }

        public void Run()
        {
            System.Diagnostics.Debug.WriteLine("Second Page Running...");

            for (int i = 0; i < 100000; i++)
            {
                (pageContents.BindingContext as MonkeysViewModel).Monkeys.Add(new Monkey
                {
                    Name = "Squirrel Monkey",
                    Location = "Central & South America",
                    Details = "The squirrel monkeys are the New World monkeys of the genus Saimiri. They are the only genus in the subfamily Saimirinae. The name of the genus Saimiri is of Tupi origin, and was also used as an English name by early researchers.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/20/Saimiri_sciureus-1_Luc_Viatour.jpg/220px-Saimiri_sciureus-1_Luc_Viatour.jpg"
                });
                //Console.WriteLine("added! i: "+ i);
                //Thread.Sleep(100);
            }
            System.Diagnostics.Debug.WriteLine("Second Page Done!");
        }
    }
}