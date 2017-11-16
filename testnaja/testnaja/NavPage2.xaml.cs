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
    public partial class NavPage2 : ContentPage
    {
        public NavPage2()
        {
            InitializeComponent();
            whyNext.Clicked += WhyNext_Clicked;
            whyBack.Clicked += WhyBack_Clicked;
        }

        private void WhyBack_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NavPage3());
        }

        private void WhyNext_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}