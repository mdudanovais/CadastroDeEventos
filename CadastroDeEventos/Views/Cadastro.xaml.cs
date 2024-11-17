using CadastroDeEventos.Models;

namespace CadastroDeEventos.Views;

public partial class Cadastro : ContentPage
{
	public Cadastro()
	{
		InitializeComponent();

        DataInicioPicker.Date = DateTime.Now;
        DataTerminoPicker.Date = DateTime.Now.AddDays(1);
    }

    private void OnDataInicioChanged(object sender, DateChangedEventArgs e)
    {
        if (DataTerminoPicker.Date < e.NewDate)
        {
            DataTerminoPicker.Date = e.NewDate;
            DisplayAlert("Erro", "Não é possível adicionar uma data de término anterior à data de início.", "OK");
        }
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        try
        {

            var evento = new Evento
            {
                NomeEvento = NomeEventoEntry.Text,
                DataInicio = DataInicioPicker.Date,
                DataTermino = DataTerminoPicker.Date,
                NumeroParticipantes = int.Parse(NumeroParticipantesEntry.Text),
                LocalEvento = LocalEventoEntry.Text,
                ParticipanteCusto = decimal.Parse(ParticipanteCustoEntry.Text)
            };


            if (string.IsNullOrWhiteSpace(evento.NomeEvento) || string.IsNullOrWhiteSpace(evento.LocalEvento))
            {
                await DisplayAlert("Erro", "Algum campo não foi preenchido", "OK");
                return;
            }

            if (evento.DataTermino < evento.DataInicio)
            {
                await DisplayAlert("Erro", "A data de término não pode ser antes da data de início.", "OK");
                return;
            }


            await Navigation.PushAsync(new Resumo(evento));
        }
        catch (Exception ex)
        {
            await DisplayAlert("Erro", "Verifique os dados informados! " + ex.Message, "OK");
        }
    }
}