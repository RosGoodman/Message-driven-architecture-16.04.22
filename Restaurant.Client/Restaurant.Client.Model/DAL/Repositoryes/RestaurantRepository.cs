
using Restaurant.Client.Model.Models;
using System.Diagnostics;

namespace Restaurant.Client.Model.DAL.Repositoryes;

/// <summary> Интерфейс для репозитория модели ресторана. </summary>\
public interface IRestaurantRepository : IRepository<RestaurantModel> { }

/// <summary> Репозиторий ресторана. </summary>
public class RestaurantRepository : IRestaurantRepository
{
    ///<inheritdoc/>
    public void Add(RestaurantModel entity)
    {
        try
        {

        }
        catch (Exception ex) { Debug.Print($"Ошибка при попытке   {ex.Message}"); }
    }

    ///<inheritdoc/>
    public void Delete(int id)
    {
        try
        {

        }
        catch (Exception ex) { Debug.Print($"Ошибка при попытке   {ex.Message}"); }
    }

    ///<inheritdoc/>
    public RestaurantModel GetById(int id)
    {
        try
        {

        }
        catch (Exception ex) { Debug.Print($"Ошибка при попытке   {ex.Message}"); }
        return null!;
    }

    ///<inheritdoc/>
    public void Update(RestaurantModel entity)
    {
        try
        {

        }
        catch (Exception ex) { Debug.Print($"Ошибка при попытке   {ex.Message}"); }
    }
}
