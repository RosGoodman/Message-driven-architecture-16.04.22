
namespace Restaurant.DTOModels.DtoModels;

/// <summary> Модель ресторана DTO. </summary>
public class TableDTO
{
    /// <summary> Id стола в БД. </summary>
    public int Id { get; set; }

    /// <summary> Номер стола. </summary>
    public int NumbOfTable { get; set; }

    /// <summary> Навигационное св-во. </summary>
    public int RestaurantId { get; set; }

    /// <summary> Кол-во мест за столом. </summary>
    public int NumberOfSeats { get; set; }
}
