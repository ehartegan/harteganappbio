﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HarteganBioApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SkillsPage : ContentPage
	{
        public ObservableCollection<string> Skills { get; set; }

		public SkillsPage ()
		{
			InitializeComponent ();

            this.Skills = new ObservableCollection<string>();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            this.Skills.Add(skillEntry.Text);

            skillEntry.Text = "";

            skillsList.ItemsSource = this.Skills;
        }
    }
}