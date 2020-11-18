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
    public partial class Login : TabbedPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void SignIn(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(emailEntry.Text) || string.IsNullOrEmpty(passwordEntry.Text))
            {
                await DisplayAlert("Error", "Email or Password fields can't be empty", "Ok");
            }
            else
            {
                await DisplayAlert("Welcome", $"Hello {emailEntry.Text}", "Ok");
            }
        }

        private async void GoToRegister(object sender, EventArgs e)
        {
            var registerPage = new NavigationPage(new Register());
            registerPage.BarBackgroundColor = Color.FromHex("#ffffff");
            registerPage.Title = "Register";
            await Navigation.PushModalAsync(registerPage);
        }
    }
}