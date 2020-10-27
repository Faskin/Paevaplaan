using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Paevaplaan
{
    public partial class Teisipaev : ContentPage
    {
        public Teisipaev()
        {
            string[] tasks = new string[] { "Tõusen püsti", "Coding", "Coding", "Coding", "Coding", "Söön", "Magan" };

            InitializeComponent();
            ListView list = new ListView();
            list.ItemsSource = tasks;
            Content = new StackLayout { Children = { list } };
            list.ItemSelected += List_ItemSelected;
            /*var Template = new DataTemplate(() =>
            {
                var grid = new Grid();

                var nametasks = new Label { FontAttributes = FontAttributes.Bold };
                var namekell = new Label { HorizontalTextAlignment = TextAlignment.End };

                nametasks.SetBinding(Label.TextProperty, "Task");
                namekell.SetBinding(Label.TextProperty, "kell");

                grid.Children.Add(nametasks);
                grid.Children.Add(namekell, 2, 0);

                return new ViewCell { View = grid };
            });
            
            Content = new StackLayout
            {
                Margin = new Thickness(20),
                Children = {
                new ListView  { ItemsSource = tasks, ItemTemplate = Template, Margin = new Thickness(0, 20, 0, 0) }
            }
            };*/
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
