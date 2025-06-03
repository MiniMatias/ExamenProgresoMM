﻿namespace ExamenProgresoMM
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnChisteClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ChistesPage());
        }

        private async void OnAboutClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AboutPage());
        }
    }
}
