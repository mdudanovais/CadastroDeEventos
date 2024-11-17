using CadastroDeEventos.Models;

namespace CadastroDeEventos.Views;

public partial class Resumo : ContentPage
{
	public Resumo(Evento evento)
	{
		InitializeComponent();
        BindingContext = evento;
    }
}