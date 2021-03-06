﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyApp2.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LeavePage : ContentPage
	{
		public LeavePage ()
		{
			InitializeComponent ();
		}

        private void OnSubmitLeave(object sender, EventArgs e)
        {
            DisplayAlert("Alert", "Leave Requested has been submitted", "OK");
        }

        private void OnCancel(object sender, EventArgs e)
        {
            DisplayAlert("Alert", "Leave Requested has been Cancelled", "OK");
        }

    }
}