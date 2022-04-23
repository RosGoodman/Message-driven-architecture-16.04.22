using AutoMapper;
using Restaurant.Client.Model.Models;
using Restaurant.DTOModels.DtoModels;
using Table.Manager.Mappers;

namespace Restaurant.Manager.Mappers;

/// <summary> Маппер для моделей ресторана. </summary>
public class RestaurantMapper : IRestaurantMapper
{
    private readonly ITableModelMapper _tableMapper;

    /// <summary> ctor. </summary>
    /// <param name="tableMapper"> Маппер для столов. </param>
    public RestaurantMapper(ITableModelMapper tableMapper)
    {
        _tableMapper = tableMapper;
    }

    /// <summary> Преобразовать DTO в модель ресторана. </summary>
    /// <param name="dto"> Источник. </param>
    /// <returns> Модель ресторана. </returns>
    public RestaurantModel MappDtoToModel(RestaurantDTO dto)
    {
        var config = new MapperConfiguration(cfg => cfg.CreateMap<RestaurantDTO, RestaurantModel>());
        var mapper = new Mapper(config);
        var model = mapper.Map<RestaurantModel>(dto);

        if(dto.Tables is null) return model;
        model.Tables = _tableMapper.MappDtoToModel(dto.Tables);

        return model;
    }

    /// <summary> Преобразовать модель ресторана в DTO. </summary>
    /// <param name="model"> Источник. </param>
    /// <returns> DTO. </returns>
    public RestaurantDTO MappModelToDto(RestaurantModel model)
    {
        var config = new MapperConfiguration(cfg => cfg.CreateMap<RestaurantModel, RestaurantDTO>());
        var mapper = new Mapper(config);
        var dto = mapper.Map<RestaurantDTO>(model);

        if(model is null) return dto;
        dto.Tables = _tableMapper.MappDtoToModel(model.Tables);

        return dto;
    }
}
