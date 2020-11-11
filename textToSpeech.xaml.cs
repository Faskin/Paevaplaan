using System;
using System.Collections.Generic;
using Xamarin.Essentials;

using Xamarin.Forms;

namespace Paevaplaan
{
    public partial class textToSpeech : ContentPage
    {
        float Volume_;
        float Pitch_;

        public textToSpeech()
        {
            InitializeComponent();
            Volume_ = (float)Volume.Value;
            Pitch_ = (float)Pitch.Value;
        }

       private async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            SpeechOptions settings = new SpeechOptions()
            {
                Volume = Volume_,
                Pitch = Pitch_,
            };
            if (text.Text != null) { await Xamarin.Essentials.TextToSpeech.SpeakAsync(text.Text, settings); }
            else if (text.Placeholder != null) { await Xamarin.Essentials.TextToSpeech.SpeakAsync(text.Placeholder, settings); }
        }

        private void speek_ValueChanged(System.Object sender, Xamarin.Forms.ValueChangedEventArgs e)
        {
            Volume_ = (float)Volume.Value;
        }

        void Pitch_ValueChanged(System.Object sender, Xamarin.Forms.ValueChangedEventArgs e)
        {
            Pitch_ = (float)Pitch.Value;
        }
    }
}
