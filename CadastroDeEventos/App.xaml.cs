using CadastroDeEventos.Views;

namespace CadastroDeEventos
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Cadastro());
        }
    }
}
