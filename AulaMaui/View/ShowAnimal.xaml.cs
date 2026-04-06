using AulaMaui.Model;

namespace AulaMaui.View;

public partial class ShowAnimal : ContentPage
{
	public ShowAnimal(Animal a)
	{
		InitializeComponent();
		ets_nome.Text = a.Nome;
		ets_especie.Text = a.Especie;
		ets_doenca.Text = a.Doenca;
		ets_imagem.Source = a.Imagem;
		
    }
}