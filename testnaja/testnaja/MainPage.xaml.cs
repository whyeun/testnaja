using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace testnaja
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            whyButton.Clicked += WhyButton_Clicked;
      
            

            genderPicker.Items.Add("ชาย");
            genderPicker.Items.Add("หญิง");

            mySlider.ValueChanged += MySlider_ValueChanged;
            myStepper.ValueChanged += MyStepper_ValueChanged;
            

            
        }

        

        private void WhyButton_Clicked(object sender, EventArgs e)
        {
          
            firstNamelabel.Text = firstNameentry.Text;
            
        }
        private void MySlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            int value = (int)e.NewValue;
            valueLabel.Text = value.ToString();
        }
        private void MyStepper_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            int value = (int)e.NewValue;
            valueLabel.Text = value.ToString();
        }
    }
}
