
using Restaurant.Client.Model.Models;

namespace Restaurant.Client.Model.DAL.Repositoryes;

/// <summary> Интерфейс для репозитория модели ресторана. </summary>\
public interface IRestaurantRepository : IRepository<RestaurantModel> { }


///<inheritdoc cref="IRestaurantRepository"/>
public class RestaurantRepository : IRestaurantRepository
{
    public void Add(RestaurantModel entity)
    {
        throw new NotImplementedException();
    }

    public void Delete(int id)
    {
        throw new NotImplementedException();
    }

    public RestaurantModel GetById(int id)
    {
        throw new NotImplementedException();
    }

    public void Update(RestaurantModel entity)
    {
        throw new NotImplementedException();
    }
}
