﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Body_Exercise
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new Page1();

            MainPage=new NavigationPage(new MainPage());
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