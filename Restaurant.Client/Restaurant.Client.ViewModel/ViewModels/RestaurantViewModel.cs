
using Restaurant.DTOModels.DtoModels;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace Restaurant.Client.ViewModel.ViewModels;

public class RestaurantViewModel : NotifyPropertyChanged, INotifyPropertyChanged
{
    private ObservableCollection<RestaurantDTO> _restauransCollection;



    public ObservableCollection<RestaurantDTO> RestauransCollection
    {
        get => _restauransCollection;
        set
        {
            _restauransCollection = value;
            OnPropertyChanged("RestauransCollection");
        }
    }


    public RestaurantViewModel()
    {

    }


    private void LoadRestaurantColl()
    {

    }
}