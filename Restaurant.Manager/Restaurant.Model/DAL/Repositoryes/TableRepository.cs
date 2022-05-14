
using Microsoft.EntityFrameworkCore;
using Restaurant.Client.Model.DAL.DataContext;
using Restaurant.Client.Model.Models;
using System.Diagnostics;

namespace Restaurant.Client.Model.DAL.Repositoryes;

/// <summary> Интерфейс репозитория для моделей столов. </summary>
public interface ITableRepository : IRepository<TableModel> { }

/// <summary> Репозиторий для моделей столов. </summary>
public class TableRepository : ITableRepository
{
    private IContextDb _contextDb;

    /// <summary> Конструктор. </summary>
    /// <param name="context"> Конткст БД. </param>
    public TableRepository(IContextDb context)
    {
        _contextDb = context;
    }

    ///<inheritdoc/>
    public void Add(TableModel entity)
    {
        try
        {
            var tableDb = _contextDb.Tables.Where(t => t.RestaurantId == entity.RestaurantId).FirstOrDefault();
            if (tableDb is not null) return;
            
            _contextDb.Tables.Add(entity);
            _contextDb.ContextSaveChanges();
        }
        catch (Exception ex) { Debug.Print($"Ошибка при попытке   {ex.Message}"); }
    }

    ///<inheritdoc/>
    public void Delete(int id)
    {
        try
        {
            var tableDb = _contextDb.Tables.Where(t => t.Id == id).FirstOrDefault();
            if (tableDb is null) return;

            _contextDb.Tables.Remove(tableDb);
            _contextDb.ContextSaveChanges();
        }
        catch (Exception ex) { Debug.Print($"Ошибка при попытке   {ex.Message}"); }
    }

    ///<inheritdoc/>
    public TableModel? GetById(int id)
    {
        try
        {
            return _contextDb.Tables.Where(t => t.Id == id).FirstOrDefault();
        }
        catch (Exception ex) { Debug.Print($"Ошибка при попытке   {ex.Message}"); }
        return null!;
    }

    ///<inheritdoc/>
    public void Update(TableModel entity)
    {
        try
        {
            var tableDb = _contextDb.Tables.Where(t => t.Id == entity.Id).FirstOrDefault();
            if (tableDb is null) return;

            tableDb.NumbOfTable = entity.NumbOfTable;
            tableDb.NumberOfSeats = entity.NumberOfSeats;
            tableDb.Restaurant = entity.Restaurant;
            tableDb.RestaurantId = entity.RestaurantId;

            _contextDb.Tables.Update(tableDb);
            _contextDb.ContextSaveChanges();
        }
        catch (Exception ex) { Debug.Print($"Ошибка при попытке   {ex.Message}"); }
    }
}
