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
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            InitializeComponent();
            viewButton.Clicked += ViewButton_Clicked;
            stackButton.Clicked += StackButton_Clicked;
            gridButton.Clicked += GridButton_Clicked;
            absoluteButton.Clicked += AbsoluteButton_Clicked;
            contentButton.Clicked += ContentButton_Clicked;
            navButton.Clicked += NavButton_Clicked;
            tebButton.Clicked += TebButton_Clicked;
            carouselButton.Clicked += CarouselButton_Clicked;
        }

        private void ViewButton_Clicked(object sender, EventArgs e)
        {
            var mp = Parent as MasterDetailPage;
            var np = new NavigationPage(new MainPage());
            mp.Detail = np;
            mp.IsPresented = false;
        }
   
        private void StackButton_Clicked(object sender, EventArgs e)
        {
            var mp = Parent as MasterDetailPage;
            var np = new NavigationPage(new StackPage());
            mp.Detail = np;
            mp.IsPresented = false;
        }
        private void GridButton_Clicked(object sender, EventArgs e)
        {
            var mp = Parent as MasterDetailPage;
            var np = new NavigationPage(new GridPage());
            mp.Detail = np;
            mp.IsPresented = false;
        }

        private void AbsoluteButton_Clicked(object sender, EventArgs e)
        {
            var mp = Parent as MasterDetailPage;
            var np = new NavigationPage(new AbsolutePage());
            mp.Detail = np;
            mp.IsPresented = false;

        }
        private void ContentButton_Clicked(object sender, EventArgs e)
        {
            var mp = Parent as MasterDetailPage;
            var np = new NavigationPage(new MyPage1());
            mp.Detail = np;
            mp.IsPresented = false;

        }
        private void NavButton_Clicked(object sender, EventArgs e)
        {
            var mp = Parent as MasterDetailPage;
            var np = new NavigationPage(new NavPage1());
            mp.Detail = np;
            mp.IsPresented = false;

        }

        private void TebButton_Clicked(object sender, EventArgs e)
        {
            var mp = Parent as MasterDetailPage;
            var tp = new TabbedPage();
            tp.Children.Add(new TebPage1());
            tp.Children.Add(new TebPage2());
            tp.Children.Add(new TebPage3());
            var np = new NavigationPage(tp);
            mp.Detail = np;
            mp.IsPresented = false;


        }
        private void CarouselButton_Clicked(object sender, EventArgs e)
        {
            var mp = Parent as MasterDetailPage;
            var cp = new CarouselPage();
            cp.Children.Add(new TebPage1());
            cp.Children.Add(new TebPage2());
            cp.Children.Add(new TebPage3());
            var np = new NavigationPage(cp);
            mp.Detail = np;
            mp.IsPresented = false;
        }

    }
}