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
	public partial class ProfileJobDescription : ContentPage
	{
		public ProfileJobDescription ()
		{
			InitializeComponent ();
		}

        private void onBack(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void OnJobUpdate(object sender, EventArgs e)
        {

        }
    }
}