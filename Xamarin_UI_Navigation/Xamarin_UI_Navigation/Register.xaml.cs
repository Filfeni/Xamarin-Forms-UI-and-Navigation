using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin_UI_Navigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Register : ContentPage
    {
        public Register()
        {
            InitializeComponent();
        }

        private async void RegisterUser(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameEntry.Text) || string.IsNullOrEmpty(emailEntry.Text) || string.IsNullOrEmpty(passwordEntry.Text) || string.IsNullOrEmpty(confirmPasswordEntry.Text))
            {
                await DisplayAlert("Error", "There are empty fields", "Ok");
            }else if(passwordEntry.Text != confirmPasswordEntry.Text)
            {
                await DisplayAlert("Error", "Passwords do not match", "Ok");
            }
            else
            {
                await Navigation.PushModalAsync(new Home());
            }

        }
    }
}