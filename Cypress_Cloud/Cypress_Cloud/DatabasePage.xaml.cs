using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Cypress_Cloud
{
    public partial class DatabasePage : ContentPage
    {
        public DatabasePage()
        {
            InitializeComponent();
			this.BackgroundImage = "ehem.png";

		}

        private async void SaveData_Button_Clicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new SaveDataPage());
        }
        private async void ReadData_Button_Clicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new ReadDataPage());
        }
    }
}
