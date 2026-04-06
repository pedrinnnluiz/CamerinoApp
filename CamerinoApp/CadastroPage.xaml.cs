
using System.Threading.Tasks;

namespace CamerinoApp;

public partial class CadastroPage : ContentPage
{
	public CadastroPage()
	{
		InitializeComponent();
	}

	private async void CadastrarClicked_Clicked(object sender, EventArgs e)
	{

        if (string.IsNullOrEmpty(SenhaEntry.Text)
        || string.IsNullOrEmpty(EmailEntry.Text))
        {
            await DisplayAlert("Alerta", "Preencha todos os dados", "Ok");
            return;
        }


        if(!EmailEntry.Text.Contains("@gmail.com")
           && !EmailEntry.Text.Contains("hotmail.com")
           &&  !EmailEntry.Text.Contains("@outlook.com"))
        {
            await DisplayAlert("Alerta", "Seu email deve ter enderaçamento", "Ok");
            return;
        }


        if (SenhaEntry.Text.Length < 8)  
        {
            await DisplayAlert("Alerta", " Sua senha deve conter 8 caracteres", "Ok"); 
            return;
        }
        else
        {
            await DisplayAlert("Sucesso", "Cadastro feito com sucesso", "Ok");
        }

        await Navigation.PushAsync(new SelecaoServico());

    }
}
