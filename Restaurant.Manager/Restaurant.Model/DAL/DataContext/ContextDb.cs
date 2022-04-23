
using Microsoft.EntityFrameworkCore;
using Restaurant.Client.Model.Models;
using System.Reflection;

namespace Restaurant.Client.Model.DAL.DataContext;

public class ContextDb : DbContext, IContextDb
{
    /// <summary> Рестораны. </summary>
    public DbSet<RestaurantModel> Restaurants { get; set; }

    /// <summary> Столы. </summary>
    public DbSet<TableModel> Tables { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var directory = Directory.GetCurrentDirectory();
        optionsBuilder.UseSqlite("Filename=Database1.db", option =>
        {
            option.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName);
        });
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    => base.OnModelCreating(modelBuilder);


    /// <summary> Сохранить изменения. Метод для использования через контейнер. </summary>
    public void ContextSaveChanges() => SaveChanges();
}
