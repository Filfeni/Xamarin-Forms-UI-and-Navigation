using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin_UI_Navigation.Models;

namespace Xamarin_UI_Navigation.Viewmodels
{
    public class LoginViewModel
    {
        public User User { get; set; } = new User();
        public ICommand SignInCommand { get; }
        public ICommand RegisterCommand { get; }
        public LoginViewModel()
        {
            SignInCommand = new Command(SignIn);
            RegisterCommand = new Command(GoToRegister);
        }
        
        async void SignIn()
        {
            if (string.IsNullOrEmpty(User.Email) || string.IsNullOrEmpty(User.Password))
            {
                await App.Current.MainPage.DisplayAlert("Error", "Email or Password fields can't be empty", "Ok");
            }
            else
            {
                await App.Current.MainPage.Navigation.PushModalAsync(new Home());
                await App.Current.MainPage.DisplayAlert("Welcome", $"Hello {User.Email}", "Ok");
            }
        }
        async void GoToRegister()
        {
            await App.Current.MainPage.Navigation.PushAsync(new Register());
        }
       
    }
}
