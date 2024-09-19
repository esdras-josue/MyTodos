using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace MyTodos.ViewModel
{
    public partial class MainViewModel : ObservableObject
    {
        public MainViewModel() 
        {
            Items = new ObservableCollection<string>();
        }

        [ObservableProperty]
        ObservableCollection<string> items;

        [ObservableProperty]
        string text;

        [RelayCommand]
        void Add()
        {
            if (string.IsNullOrWhiteSpace(text))
                return;

            Items.Add(text);
            // agregar una tarea
            Text = string.Empty;
        }

        [RelayCommand]
        void Delete(string s)
        {
            // eliminar una tarea
            if (Items.Contains(s))
            {
                Items.Remove(s);
            }
                    
        }
    }
}
