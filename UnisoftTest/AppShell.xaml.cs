﻿using PropertyChanged;
using UnisoftTest.MVVM.Views;

namespace UnisoftTest
{
    [AddINotifyPropertyChangedInterface]
    public partial class AppShell : Shell
    {
        public bool isAdministrator { get; set; }
        public bool isAdministratorChecked { get; set; }
        public AppShell()
        {
            InitializeComponent();
            BindingContext = this;
            //Routing.RegisterRoute("ResultPageHome", typeof(ResultPage)); // Rejestracja trasy dla ResultPage
            //Routing.RegisterRoute("ConfigurationPageRoute", typeof(ConfigurationPage)); // Rejestracja trasy dla ConfigurationPage
            //App.BaseRepo.AddOrUpdateAppAdministrator(true);
            isAdministrator = false;
        }

        private async void SetAdministrator(object sender, EventArgs e)
        {


            if (isAdministrator == false && isAdministratorChecked==true)
            {
                string password = await Application.Current.MainPage.DisplayPromptAsync(
                                "Autoryzacja",
                                "Podaj hasło administratora:",
                                "OK", "Anuluj",
                                placeholder: "Hasło",
                                maxLength: 20,
                                keyboard: Keyboard.Text);
                if (password == "opat")
                {
                    isAdministrator = true;
                    lblAdministrator.Text = "Jesteś Administratorem! :)";
                    App.BaseRepo.AddOrUpdateAppAdministrator(true);
                    isAdministratorChecked = true;
                }
                else
                {
                    await Application.Current.MainPage.DisplayAlert(
                               "Autoryzacja",
                               "Chyba nie jesteś administratorem. :)",
                               "OK");
                    isAdministratorChecked = false;

                }
            } 
            else
            {
                isAdministrator = false;
                isAdministratorChecked = false;
                lblAdministrator.Text = "Czy jesteś Administratorem?";
                App.BaseRepo.AddOrUpdateAppAdministrator(false);
            }

        }
    }
}

//private async void SetAdministrator(object sender, EventArgs e)
//{


//    if (isAdministrator == false)
//    {
//        string password = await Application.Current.MainPage.DisplayPromptAsync(
//                        "Autoryzacja",
//                        "Podaj hasło administratora:",
//                        "OK", "Anuluj",
//                        placeholder: "Hasło",
//                        maxLength: 20,
//                        keyboard: Keyboard.Text);
//        if (password == "opat")
//        {
//            isAdministrator = true;
//            lblAdministrator.Text = "Jesteś Administratorem! :)";
//            App.BaseRepo.AddOrUpdateAppAdministrator(true);
//            isAdministratorChecked = true;
//        }
//        else
//        {
//            await Application.Current.MainPage.DisplayAlert(
//                       "Autoryzacja",
//                       "Chyba nie jesteś administratorem. :)",
//                       "OK");
//            isAdministratorChecked = false;

//        }
//    }
//    else
//    {
//        isAdministrator = false;
//        isAdministratorChecked = false;
//        lblAdministrator.Text = "Czy jesteś Administratorem?";
//        App.BaseRepo.AddOrUpdateAppAdministrator(false);
//    }

//}