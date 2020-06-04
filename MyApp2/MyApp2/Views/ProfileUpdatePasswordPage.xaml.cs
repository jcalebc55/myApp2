using MyApp2.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyApp2.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ProfileUpdatePasswordPage : ContentPage
	{
		public ProfileUpdatePasswordPage ()
		{
			InitializeComponent ();

		}

        private void OnPasswordUpdate(object sender, EventArgs e)
        {
             DisplayAlert("Alert", "Password has been changed", "OK");
            Navigation.PopAsync();
        }

        private void OnCancel(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}