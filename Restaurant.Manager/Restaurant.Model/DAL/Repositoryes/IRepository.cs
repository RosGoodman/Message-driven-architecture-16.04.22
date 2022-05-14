
namespace Restaurant.Client.Model.DAL.Repositoryes;

/// <summary> Иснетерфейс репозиториев. </summary>
/// <remarks>remarks</remarks>
public interface IRepository<T> where T : class
{
    /// <summary> Добавить сущность dв БД. </summary>
    /// <param name="entity"> Добавляемый экземпляр. </param>
    public void Add(T entity);

    /// <summary> Удалить сущность из БД. </summary>
    /// <param name="id"> Id удаляемого экземпляра. </param>
    public void Delete(int id);

    /// <summary> Получить эеземпляр по Id. </summary>
    /// <param name="id"> Id искомого экземпляра. </param>
    /// <returns> Найденный экземпляр или null. </returns>
    public T? GetById(int id);

    /// <summary> Обновить эеземпляр в БД. </summary>
    /// <param name="entity"> Экземпляр с новыи параметрами.. </param>
    public void Update(T entity);
}
