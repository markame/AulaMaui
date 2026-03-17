using AulaMaui.Model;

namespace AulaMaui
{
    public partial class MainPage : ContentPage
    {
        Macaco macaco = new Macaco();
       
        public MainPage()
        {
            InitializeComponent();
        }

        private void novoMacaco(object sender, EventArgs e)
        {
            macaco.Nome = et_nome.Text;
            macaco.Especie = et_especie.Text;   
            macaco.Doenca = et_doenca.Text;
            macaco.Imagem = et_imagem.Text;
             DisplayAlert("Macaco criado", $"O macaco {macaco.Nome} da espécie {macaco.Especie} com a doença {macaco.Doenca} e imagem {macaco.Imagem} foi criado com sucesso!", "OK","Cancelar");

        }
    }
}
