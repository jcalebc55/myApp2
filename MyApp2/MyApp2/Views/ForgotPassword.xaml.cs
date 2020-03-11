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
	public partial class ForgotPassword : ContentPage
	{
		public ForgotPassword ()
		{
			InitializeComponent ();
		}

        private void Forgot_Password_Submit(object sender, EventArgs e)
        {

        }

        private void Login_Page(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}