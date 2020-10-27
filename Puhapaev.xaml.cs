using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Paevaplaan
{
    public partial class Puhapaev : ContentPage
    {
        public Puhapaev()
        {
            string[] tasks = new string[] { "Tõusen püsti", "Coding", "Coding", "Coding", "Coding", "Söön", "Magan" };

            ListView list = new ListView();
            {

                list.BackgroundColor = Color.SkyBlue;
                
            }
            list.ItemsSource = tasks;
            Content = new StackLayout { Children = { list } };
            list.ItemSelected += List_ItemSelected;
            InitializeComponent();
        }

        string kell;
        private async void List_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                string text = e.SelectedItem.ToString();
                if (e.SelectedItemIndex == 0)
                {
                    kell = "7:00";
                }
                else if (e.SelectedItemIndex == 1)
                {
                    kell = "8:00";

                }

                else if (e.SelectedItemIndex == 2)
                {
                    kell = "9:00";

                }

                else if (e.SelectedItemIndex == 3)
                {
                    kell = "12:00";

                }

                else if (e.SelectedItemIndex == 4)
                {
                    kell = "15:00";

                }

                else if (e.SelectedItemIndex == 5)
                {
                    kell = "19:00";

                }

                else if (e.SelectedItemIndex == 6)
                {
                    kell = "22:00";

                }

                await DisplayAlert(kell, text, "Jah");
            }
        }
    }
}
