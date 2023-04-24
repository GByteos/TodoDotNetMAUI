using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace Todo.ViewModels;

public partial class MainViewModel : ObservableObject
{
    public MainViewModel()
    {
        Items = new();
    }

    [ObservableProperty]
    ObservableCollection<string> items;

    [ObservableProperty]
    string inputText;

    [RelayCommand]
    void Add()
    {
        if (string.IsNullOrWhiteSpace(InputText))
            return;
        // add our item
        Items.Add(InputText);
        InputText = string.Empty;
    }

    [RelayCommand]
    void Delete(string s)
    {
        if (Items.Contains(s))
        {
            Items.Remove(s);
        }
    }
}
