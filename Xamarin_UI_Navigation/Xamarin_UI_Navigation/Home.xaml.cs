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
    public partial class Home : TabbedPage
    {
        public Home()
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

        private void Register(object sender, EventArgs e)
        {

        }
    }
}