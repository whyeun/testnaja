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
    public partial class MyPage3 : ContentPage
    {
        public MyPage3()
        {
            InitializeComponent();
            whyBack.Clicked += WhyBack_Clicked;

           
        }

        private void WhyBack_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }
    }
}