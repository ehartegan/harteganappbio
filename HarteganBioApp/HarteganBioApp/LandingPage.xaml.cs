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
	public partial class LandingPage : ContentPage
	{
		public LandingPage ()
		{
			InitializeComponent ();
		}

        private void AboutTapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AboutPage());
        }

        private void SkillsTapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
           // Navigation.PushAsync(new SkillsPage());
        }
        private void ContactTapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ContactPage());
        }
    }
}