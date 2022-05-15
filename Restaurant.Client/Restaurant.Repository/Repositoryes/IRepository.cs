
using System.Collections.ObjectModel;

namespace Restaurant.Repository.Repositoryes;

public interface IRepository<T> where T : class
{
    T Create(T entity);
    ObservableCollection<T> GetAll();
    void Delete(int id);
    void Update(T entity);
}