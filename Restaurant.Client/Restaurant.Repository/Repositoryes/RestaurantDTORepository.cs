
using Restaurant.DTOModels.DtoModels;
using System.Collections.ObjectModel;

namespace Restaurant.Repository.Repositoryes;


public interface IRestaurantDTORepository : IRepository<RestaurantDTO> { }


public class RestaurantDTORepository : IRestaurantDTORepository
{
    public RestaurantDTO Create(RestaurantDTO entity)
    {
        throw new System.NotImplementedException();
    }

    public void Delete(int id)
    {
        throw new System.NotImplementedException();
    }

    public ObservableCollection<RestaurantDTO> GetAll()
    {
        throw new System.NotImplementedException();
    }

    public void Update(RestaurantDTO entity)
    {
        throw new System.NotImplementedException();
    }
}