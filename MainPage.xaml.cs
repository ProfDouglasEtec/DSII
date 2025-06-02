using System;
using Microsoft.Maui.Controls;

namespace MauiAppHotel
{
    public partial class MainPage : ContentPage
    {
        private string suiteSelecionada = string.Empty;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnSuiteSelecionada(object sender, EventArgs e)
        {
            if (suitePicker.SelectedItem != null)
            {
                suiteSelecionada = suitePicker.SelectedItem.ToString();
                suiteSelecionadaLabel.Text = $"Suíte selecionada: {suiteSelecionada}";
            }
        }

        private async void OnSobreClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SobrePage());
        }

        private void OnAdicionarAdulto(object sender, EventArgs e)
        {
            int valorAtual = int.TryParse(adultosEntry.Text, out int result) ? result : 0;
            valorAtual++;
            adultosEntry.Text = valorAtual.ToString();
        }

        private void OnRemoverAdulto(object sender, EventArgs e)
        {
            int valorAtual = int.TryParse(adultosEntry.Text, out int result) ? result : 0;
            valorAtual = Math.Max(0, valorAtual - 1);
            adultosEntry.Text = valorAtual.ToString();
        }

        private void OnAdicionarCrianca(object sender, EventArgs e)
        {
            int valorAtual = int.TryParse(criancasEntry.Text, out int result) ? result : 0;
            valorAtual++;
            criancasEntry.Text = valorAtual.ToString();
        }

        private void OnRemoverCrianca(object sender, EventArgs e)
        {
            int valorAtual = int.TryParse(criancasEntry.Text, out int result) ? result : 0;
            valorAtual = Math.Max(0, valorAtual - 1);
            criancasEntry.Text = valorAtual.ToString();
        }

        private async void OnAvancarClicked(object sender, EventArgs e)
        {
            int adultos = int.TryParse(adultosEntry.Text, out int a) ? a : 0;
            int criancas = int.TryParse(criancasEntry.Text, out int c) ? c : 0;
            string suite = string.IsNullOrEmpty(suiteSelecionada) ? "Não selecionada" : suiteSelecionada;
            string checkin = checkinDatePicker.Date.ToString("dd/MM/yyyy");
            string checkout = checkoutDatePicker.Date.ToString("dd/MM/yyyy");

            if (suite == "Não selecionada" || checkoutDatePicker.Date <= checkinDatePicker.Date)
            {
                await DisplayAlert("Erro", "Por favor, preencha todos os campos corretamente.", "OK");
                return;
            }

            await Navigation.PushAsync(new NewPage1(adultos, criancas, suite, checkin, checkout));
        }
    }
}
