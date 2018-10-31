using System;
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
        public ObservableCollection<Skill> Skills { get; set; }

        public SkillsPage()
        {
            InitializeComponent();

            this.Skills = new ObservableCollection<Skill>();


            Skill visualBasic = new Skill
            {
                Description = "Basic knowledge working with Visual Basic",
                Name = "Visual Basic",
                ImageURL = "VisualBasic.png"
            };
            this.Skills.Add(visualBasic);

            Skill C = new Skill
            {
                Description = "Basic knowledge working with C++",
                Name = "C++",
                ImageURL = "C.png"
            };
            this.Skills.Add(C);

            Skill Csharp = new Skill
            {
                Description = "Little knowledge working with C#",
                Name = "C#",
                ImageURL = "CSharp.png"
            };
            this.Skills.Add(Csharp);

            this.skillsList.ItemsSource = this.Skills;
        }


        public class Skill {
            public string ImageURL { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
        }
    }
}