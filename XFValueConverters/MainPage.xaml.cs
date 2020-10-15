using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XFValueConverters
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            ResultLabel.BindingContext = new RandomObject
            {
                Color = "BlaColor",
                Name = "Subscribe now"
            };
        }
    }
}
