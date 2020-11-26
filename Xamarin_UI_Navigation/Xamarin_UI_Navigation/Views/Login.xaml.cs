﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin_UI_Navigation.Viewmodels;

namespace Xamarin_UI_Navigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : TabbedPage
    {
        public Login()
        {
            InitializeComponent();
            BindingContext = new LoginViewModel();
        }
    }
}