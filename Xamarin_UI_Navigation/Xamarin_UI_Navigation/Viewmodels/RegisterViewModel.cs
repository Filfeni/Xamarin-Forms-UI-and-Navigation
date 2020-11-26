using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin_UI_Navigation.Models;

namespace Xamarin_UI_Navigation.Viewmodels
{
    public class RegisterViewModel
    {
        public UserRegistration User { get; set; } = new UserRegistration();
        public ICommand RegisterCommand { get; }
        public RegisterViewModel()
        {
            RegisterCommand = new Command(RegisterUser);
        }
        private async void RegisterUser()
        {
            if (string.IsNullOrEmpty(User.Name) || string.IsNullOrEmpty(User.Email) || string.IsNullOrEmpty(User.Password) || string.IsNullOrEmpty(User.ConfirmPassword))
            {
                await App.Current.MainPage.DisplayAlert("Error", "There are empty fields", "Ok");
            }
            else if (User.Password != User.ConfirmPassword)
            {
                await App.Current.MainPage.DisplayAlert("Error", "Passwords do not match", "Ok");
            }
            else
            {
                await App.Current.MainPage.Navigation.PushModalAsync(new Home());
            }

        }
    }
}
