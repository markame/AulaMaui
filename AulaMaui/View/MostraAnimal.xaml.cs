using AulaMaui.Model;

namespace AulaMaui.View;

public partial class MostraAnimal : ContentPage
{
	public MostraAnimal(Animal animal)
	{
        InitializeComponent();
        lblnome.Text = animal.Nome;
        lblespecie.Text = animal.Especie;
        lbldoenca.Text = animal.Doenca;
        imagem.Source = animal.Imagem;
    }
}