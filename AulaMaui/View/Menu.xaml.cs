namespace AulaMaui.View;

public partial class Menu : ContentPage
{
	public Menu()
	{
		InitializeComponent();
	}

    private void btn_Cadastrar(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Cadastrar());
    }

    private void btn_Listar(object sender, EventArgs e)
    {

    }
}