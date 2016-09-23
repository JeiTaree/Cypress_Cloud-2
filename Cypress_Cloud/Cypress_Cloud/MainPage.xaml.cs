using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Cypress_Cloud
{
    public partial class MainPage : ContentPage
    {

		static TodoItemDatabase database;

        public MainPage()
        {
            InitializeComponent();

			this.BackgroundImage = "ehem.png";
        }

		public static TodoItemDatabase Database
		{
			get
			{
				if (database == null)
				{
					database = new TodoItemDatabase();
				}
				return database;
			}
		}

        private async void First_Button_Clicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new AboutUs());
        }

		private async void Second_Button_Clicked(object sender, EventArgs args)
		{
			await Navigation.PushAsync(new ClassDetails());
		}

        private async void Third_Button_Clicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Tutors());
        }

		private async void Fourth_Button_Clicked(object sender, EventArgs args)
		{
			await Navigation.PushAsync(new PTIBooking());
		}

        private async void Fifth_Button_Clicked(object sender, EventArgs args)
        {
			await Navigation.PushAsync(new Feedback());
        }

        private async void Sixth_Button_Clicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new ContactUs());
        }

    }
}
