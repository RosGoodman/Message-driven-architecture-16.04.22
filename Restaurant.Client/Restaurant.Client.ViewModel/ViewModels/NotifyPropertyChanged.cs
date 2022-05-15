
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Restaurant.Client.ViewModel.ViewModels;

public class NotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;

    public void OnPropertyChanged([CallerMemberName] string prop = "")
    {
        if (PropertyChanged != null)
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
    }
}