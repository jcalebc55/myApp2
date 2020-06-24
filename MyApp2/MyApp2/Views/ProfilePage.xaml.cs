using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyApp2.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ProfilePage : ContentPage
	{
		public ProfilePage ()
		{
            
			InitializeComponent ();
            //workemail.Text = "jabez@ndti.net";
        }

        private void OnPasswordChange(object sender, EventArgs e)
        {
             Navigation.PushAsync(new ProfileUpdatePasswordPage());
        }

        private void OnJobDesc(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ProfileJobDescription());
        }
    }
}