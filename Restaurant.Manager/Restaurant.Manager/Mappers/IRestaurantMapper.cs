using Restaurant.Client.Model.Models;
using Restaurant.DTOModels.DtoModels;

namespace Restaurant.Manager.Mappers
{
    public interface IRestaurantMapper
    {
        RestaurantModel MappDtoToModel(RestaurantDTO dto);
        RestaurantDTO MappModelToDto(RestaurantModel model);
    }
}