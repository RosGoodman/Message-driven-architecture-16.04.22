
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Restaurant.Client.Model.Models;

/// <summary> Модель стола. </summary>
public class TableModel
{
    /// <summary> Id стола в БД. </summary>
    [Key]
    public int Id { get; set; }

    /// <summary> Номер стола. </summary>
    [Required]
    public int NumbOfTable { get; set; }

    /// <summary> Навигационное св-во. </summary>
    public int RestaurantId { get; set; }

    /// <summary> Ресторан. </summary>
    [Required, ForeignKey("RestaurantId")]
    public RestaurantModel Restaurant { get; set; }

    /// <summary> Кол-во мест за столом. </summary>
    [Required]
    public int NumberOfSeats { get; set; }
}
