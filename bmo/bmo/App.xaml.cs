﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace bmo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
<<<<<<< Updated upstream

=======
            //root page
            //MainPage = new MainPage();
>>>>>>> Stashed changes
            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
