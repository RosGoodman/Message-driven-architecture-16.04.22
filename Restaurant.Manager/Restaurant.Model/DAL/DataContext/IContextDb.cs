using Microsoft.EntityFrameworkCore;
using Restaurant.Client.Model.Models;

namespace Restaurant.Client.Model.DAL.DataContext;

public interface IContextDb
{
    DbSet<RestaurantModel> Restaurants { get; set; }
    DbSet<TableModel> Tables { get; set; }

    void ContextSaveChanges();
}
