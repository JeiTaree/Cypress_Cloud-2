using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Cypress_Cloud
{
    public partial class PTIBooking : ContentPage
    {
		//TodoItemDatabase database = new TodoItemDatabase();

        public PTIBooking()
        {
            InitializeComponent();
			this.BackgroundImage = "ehem.png";
			/*
			if (database.GetItem(1).Done == false)
			{
				Name.Text = database.GetItem(1).Notes;
			}
			if (database.GetItem(2).Done == false)
			{
				UserID.Text = database.GetItem(2).Notes;
			}
			if (database.GetItem(3).Done == false)
			{
				Email.Text = database.GetItem(3).Notes;
			}*/
        }

        private void SaveData_Buton_Clicked(object sender, EventArgs args)
		{
			/*
			TodoItem Item = new TodoItem();
			Item.ID = 1;
			Item.Name = "Name";
			Item.Notes = Name.Text;
			Item.Done = false;

			database.SaveItem(Item);

			Item.ID = 2;
			Item.Name = "UserID";
			Item.Notes = UserID.Text;
			Item.Done = false;

			database.SaveItem(Item);

			Item.ID = 3;
			Item.Name = "Email";
			Item.Notes = Email.Text;
			Item.Done = false;

			database.SaveItem(Item);
*/
		}

    }
}
