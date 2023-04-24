using CommunityToolkit.Mvvm.ComponentModel;

namespace Todo.ViewModels;

public partial class MainViewModel : ObservableObject
{
    [ObservableProperty]
    string inputText;
}
