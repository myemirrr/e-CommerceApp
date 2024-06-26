﻿using eCommerce.UI.Pages;

namespace eCommerce.UI
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var accesstoken = Preferences.Get("accesstoken", string.Empty);
            if (string.IsNullOrEmpty(accesstoken))
            {
                MainPage = new NavigationPage(new SignupPage());
            }
            else
            {
                MainPage = new AppShell();
            }
        }
    }
}
