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
    public partial class MyPage1 : ContentPage
    {
        public MyPage1()
        {
            InitializeComponent();
            whyNext.Clicked += WhyNext_Clicked;
        }

        private void WhyNext_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new MyPage2());
        }
    }
}