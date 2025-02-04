﻿using UnisoftTest.MVVM.Views;
using UnisoftTest.Repositories;

namespace UnisoftTest
{
    public partial class App : Application
    {
        public static BaseRepository BaseRepo { get; private set; }

        public App(BaseRepository repo)
        {
            InitializeComponent();
            BaseRepo = repo;

            //MainPage = new NavigationPage( new ResultPage());
            MainPage = new AppShell();
            //NavigationPage.SetHasNavigationBar(this, false);

        }
        protected override Window CreateWindow(IActivationState activationState)
        {
            var window = base.CreateWindow(activationState);
            const int newWidth = 1000;
            const int newHeight = 870;

            window.MaximumWidth = newWidth;
            window.MaximumHeight = newHeight;
            window.MinimumWidth = newWidth;
            window.MinimumHeight = newHeight;

            return window;


        }

    }
}
