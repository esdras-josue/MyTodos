using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace MyTodos.ViewModel
{
    public partial class MainViewModel : ObservableObject
    {
        // Las propiedades se generan automáticamente a partir de los atributos [ObservableProperty]
        [ObservableProperty]
        ObservableCollection<string> items = new ObservableCollection<string>();

        [ObservableProperty]
        string text;

        // Los comandos se generan automáticamente a partir de los atributos [RelayCommand]
        [RelayCommand]
        void Add()
        {
            if (string.IsNullOrWhiteSpace(Text))
                return;

            Items.Add(Text);
            // Limpiar la entrada de texto
            Text = string.Empty;
        }

        [RelayCommand]
        void Delete(string item)
        {
            if (Items.Contains(item))
            {
                Items.Remove(item);
            }
        }

        [RelayCommand]
        void EditItem(string item)
        {
            // Asignar el ítem al Text para que pueda ser editado
            Text = item;
            // Remover la tarea temporalmente de la lista
            Items.Remove(item);
        }
    }
}