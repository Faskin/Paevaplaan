using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Paevaplaan
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            
        }

        async void Button_Clicked1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Esmaspaev());
        }



        async void Button_Clicked2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Teisipaev());
        }



        async void Button_Clicked3(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Kolmapaev());
        }



        async void Button_Clicked4(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Neljapaev());
        }


        async void Button_Clicked5(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Reede());
        }


        async void Button_Clicked6(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Laupaev());
        }


        async void Button_Clicked7(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Puhapaev());
        }
    }
}
