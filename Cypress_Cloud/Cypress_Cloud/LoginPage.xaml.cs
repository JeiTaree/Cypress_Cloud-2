using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Cypress_Cloud
{
	public partial class LoginPage : ContentPage
	{
		public LoginPage()
		{
			InitializeComponent();
			submit.Clicked += Submit_Clicked;
			/*
			Login login = new Login
			{
				UserName = "Admin",
				Password = "Admin"
			};

			using (var data = new DataAccess())
			{
				data.InsertLogin(login);
			}
            */
		}

		async void Submit_Clicked(object sender, EventArgs e)
		{
			/*
			Login login = new Login
			{
				UserName = username.Text,
				Password = password.Text
			};

			using (var data = new DataAccess())
			{
				List<Login> Logins = data.GetLogins(0);
				for (int i = 0; i < Logins.Count; i++)
				{
					if (login.UserName == Logins[i].UserName
					   && login.Password == Logins[i].Password)
					{
						//Login Success?!
						break;
					}
				}
			}
			*/
			if (username.Text == "Admin" && password.Text == "Nimda")
			{ await Navigation.PushAsync(new MainPage()); }
			else
			{ await DisplayAlert("User not found", "Username or Password is not found in database", "Retry"); }
		}
	}
}
