using AulaMaui.Model;
using System.Collections.ObjectModel;

namespace AulaMaui.View;

public partial class ListaAnimal : ContentPage
{
    public static ObservableCollection<Animal> animais = new ObservableCollection<Animal>();

    public ListaAnimal(Animal a)
    {
        InitializeComponent();

        collectionAnimal.ItemsSource = animais;
        animais.Add(a);
    }

    private async void collectionAnimal_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        Animal animal = (Animal)e.CurrentSelection.FirstOrDefault();
        await Navigation.PushAsync(new ShowAnimal(animal));
    }
}