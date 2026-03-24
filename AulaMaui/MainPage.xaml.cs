using AulaMaui.Model;
using AulaMaui.View;

namespace AulaMaui
{
    public partial class MainPage : ContentPage
    {
        Animal animal = new Animal();
       
        public MainPage()
        {
            InitializeComponent();
        }

        private async void novoAnimal(object sender, EventArgs e)
        {
            animal.Nome = et_nome.Text;
            animal.Especie = et_especie.Text;   
            animal.Doenca = et_doenca.Text;
            animal.Imagem = et_imagem.Text;
            await Navigation.PushAsync(new MostraAnimal(animal));



        }
    }
}
