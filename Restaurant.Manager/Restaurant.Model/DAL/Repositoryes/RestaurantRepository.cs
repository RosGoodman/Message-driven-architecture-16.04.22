
using Restaurant.Client.Model.DAL.DataContext;
using Restaurant.Client.Model.Models;
using System.Diagnostics;

namespace Restaurant.Client.Model.DAL.Repositoryes;

/// <summary> Интерфейс для репозитория модели ресторана. </summary>\
public interface IRestaurantRepository : IRepository<RestaurantModel> { }

/// <summary> Репозиторий ресторана. </summary>
public class RestaurantRepository : IRestaurantRepository
{
    private IContextDb _context;

    public RestaurantRepository(IContextDb context)
    {
        _context = context;
    }

    ///<inheritdoc/>
    public void Add(RestaurantModel entity)
    {
        try
        {
            var restDb = _context.Restaurants.Where(r => r.Name == entity.Name).FirstOrDefault();
            if (restDb is not null) return;

            _context.Restaurants.Add(entity);
            _context.ContextSaveChanges();
        }
        catch (Exception ex) { Debug.Print($"Ошибка при попытке   {ex.Message}"); }
    }

    ///<inheritdoc/>
    public void Delete(int id)
    {
        try
        {
            var restDb = _context.Restaurants.Where(r => r.Id == id).FirstOrDefault();
            if (restDb is null) return;

            _context.Restaurants.Remove(restDb!);
            _context.ContextSaveChanges();
        }
        catch (Exception ex) { Debug.Print($"Ошибка при попытке   {ex.Message}"); }
    }

    ///<inheritdoc/>
    public RestaurantModel? GetById(int id)
    {
        try
        {
            var restDb = _context.Restaurants.Where(r => r.Id == id).FirstOrDefault();
            return restDb;
        }
        catch (Exception ex) { Debug.Print($"Ошибка при попытке   {ex.Message}"); }
        return null!;
    }

    ///<inheritdoc/>
    public void Update(RestaurantModel entity)
    {
        try
        {
            var restDb = _context.Restaurants.Where(r => r.Id == entity.Id).FirstOrDefault();
            if (restDb is null) return;

            restDb.Name = entity.Name;

            _context.Restaurants.Update(restDb!);
            _context.ContextSaveChanges();
        }
        catch (Exception ex) { Debug.Print($"Ошибка при попытке   {ex.Message}"); }
    }
}
