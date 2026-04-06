using AulaMaui.Model;
using AulaMaui.View;
using System.Collections.ObjectModel;

namespace AulaMaui
{
    public partial class MainPage : ContentPage
    {
        
       
        public MainPage()
        {
            InitializeComponent();
        }

        private async void novoAnimal(object sender, EventArgs e)
        {
            Animal animal = new Animal();
            animal.Nome = et_nome.Text;
            animal.Especie = et_especie.Text;   
            animal.Doenca = et_doenca.Text;
            animal.Imagem = et_imagem.Text;
            await DisplayAlert("Sucesso", "Animal cadastrado com sucesso!", "OK");
            await Navigation.PushAsync(new ListaAnimal(animal));

        }
    }
}
