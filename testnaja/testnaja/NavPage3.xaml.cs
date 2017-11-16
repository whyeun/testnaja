using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace testnaja
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NavPage3 : ContentPage
    {
        public NavPage3()
        {
            InitializeComponent();
            whyBack.Clicked += WhyBack_Clicked;
            whyBacktoRoot.Clicked += WhyBacktoRoot_Clicked;

        }

        private void WhyBacktoRoot_Clicked(object sender, EventArgs e)
        {
            Navigation.PopToRootAsync();
        }

        private void WhyBack_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}