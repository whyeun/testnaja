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
    public partial class NavPage1 : ContentPage
    {
        public NavPage1()
        {
            InitializeComponent();
            whyNext.Clicked += WhyNext_Clicked;

            
           
        }

       

       void WhyNext_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NavPage2());
            
        }
    }
}