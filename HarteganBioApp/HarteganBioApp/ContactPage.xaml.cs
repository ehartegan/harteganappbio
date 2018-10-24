using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HarteganBioApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ContactPage : ContentPage
	{
		public ContactPage ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(nameEntry.Text))
            {
                DisplayAlert("Error", "Please enter a name!", "OK");
                return;
            }

            if (string.IsNullOrEmpty(emailEntry.Text))
            {
                DisplayAlert("Error", "Please enter an email!", "OK");
                return;
            }

            if (string.IsNullOrEmpty(messageEditor.Text))
            {
                DisplayAlert("Error", "Please enter a message!", "OK");
                return;
            }

            DisplayAlert("Thank you!", "Your message was submitted.", "OK");
        }
    }
}