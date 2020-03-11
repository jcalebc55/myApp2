using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MyApp2.Models;

namespace MyApp2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {

        public LoginPage()
        {
            InitializeComponent();

        }

        //async 
        void OnSignUpButtonClicked(object sender, EventArgs e)
        {
            // await Navigation.PushAsync(new SignUpPage());
        }

         void OnLoginButtonClicked(object sender, EventArgs e)
        {
            var user = new User()
            {

                Username = usernameEntry.Text,
                Password = passwordEntry.Text
            };

            var isValid = AreCredentialsCorrect(user);
            if (isValid)
            {
                //App. = true;
                // Navigation.InsertPageBefore(new MainPage(), this);
                //NavigationPage nav = new NavigationPage(new MainPage());
                //await Navigation.PushAsync(new MainPage());
                App.Current.MainPage = new MainPage();
            }
            else
            {
                //messageLabel.Text = "Login failed";
                passwordEntry.Text = string.Empty;
            }
        }

        bool AreCredentialsCorrect(User user)
        {
            return user.Username == Constants.Username && user.Password == Constants.Password;
        }

       

        private void Forgot_Password(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ForgotPassword());
        }
    }
}