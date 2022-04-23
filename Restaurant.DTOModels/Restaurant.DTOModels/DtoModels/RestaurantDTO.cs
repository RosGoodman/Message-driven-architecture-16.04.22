
namespace Restaurant.DTOModels.DtoModels;

/// <summary> Модель ресторана DTO. </summary>
public class RestaurantDTO
{
    /// <summary> Ключ ресторана в БД. </summary>
    public int Id { get; set; }

    /// <summary> Наименование ресторана. </summary>
    public string? Name { get; set; }

    /// <summary> Список столов в ресторане. </summary>
    public List<TableDTO>? Tables { get; set; }
}
