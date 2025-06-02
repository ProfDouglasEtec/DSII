using Microsoft.Maui.Controls;

namespace MauiAppHotel
{
    public partial class NewPage1 : ContentPage
    {
        public NewPage1(int adultos, int criancas, string suite, string checkin, string checkout)
        {
            InitializeComponent();

            // Preenche os dados na tela
            adultosLabel.Text = $"Adultos: {adultos}";
            criancasLabel.Text = $"Crianças: {criancas}";
            suiteSelecionadaLabel.Text = $"Suíte escolhida: {suite}";
            checkinLabel.Text = $"Check-in: {checkin}";
            checkoutLabel.Text = $"Check-out: {checkout}";

            // Mensagem de sucesso visível
            reservaStatusLabel.Text = "Reserva concluída com sucesso!";
            reservaStatusLabel.IsVisible = true;
        }

        private async void OnVoltarInicioClicked(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }
    }
}
