using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Cypress_Cloud
{
    public class App : Application
    {
        public App()
        {
			MainPage = new NavigationPage(new LoginPage());
        }

		protected override void OnStart()
		{
			//Debug.WriteLine("OnStart");
		}
		protected override void OnSleep()
		{
			//Debug.WriteLine("OnSleep saving ResumeAtTodoId = " + ResumeAtTodoId);
			// the app should keep updating this value, to
			// keep the "state" in case of a sleep/resume
		}

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
