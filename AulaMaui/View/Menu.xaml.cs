using AulaMaui.View;
namespace AulaMaui.View;


public partial class Menu : ContentPage
{
	public Menu()
	{
		InitializeComponent();
	}

    private async void btn_Cadastrar(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MainPage());
    }

    private async void btn_Listar(object sender, EventArgs e)
    {
       //await Navigation.PushAsync(new ListaAnimal());
    }
}