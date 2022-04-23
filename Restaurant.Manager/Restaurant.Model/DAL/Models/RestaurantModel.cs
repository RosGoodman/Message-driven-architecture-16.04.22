
using System.ComponentModel.DataAnnotations;

namespace Restaurant.Client.Model.Models;

/// <summary> Модель ресторана. </summary>
public class RestaurantModel
{
    /// <summary> Ключ ресторана в БД. </summary>
    [Key]
    public int Id { get; set; }

    /// <summary> Наименование ресторана. </summary>
    [Required]
    public string Name { get; set; }

    /// <summary> Список столов в ресторане. </summary>
    public List<TableModel> Tables { get; set; }
}
