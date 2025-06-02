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
            criancasLabel.Text = $"Crian�as: {criancas}";
            suiteSelecionadaLabel.Text = $"Su�te escolhida: {suite}";
            checkinLabel.Text = $"Check-in: {checkin}";
            checkoutLabel.Text = $"Check-out: {checkout}";

            // Mensagem de sucesso vis�vel
            reservaStatusLabel.Text = "Reserva conclu�da com sucesso!";
            reservaStatusLabel.IsVisible = true;
        }

        private async void OnVoltarInicioClicked(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }
    }
}
