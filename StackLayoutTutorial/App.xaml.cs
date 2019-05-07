using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StackLayoutTutorial
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
            Console.WriteLine("OnStart");
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
            Console.WriteLine("OnSleep");

        }

        protected override void OnResume()
        {
            Console.WriteLine("OnResume");
        }
    }
}
