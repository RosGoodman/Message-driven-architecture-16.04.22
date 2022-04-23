using AutoMapper;
using Restaurant.Client.Model.Models;
using Restaurant.DTOModels.DtoModels;

namespace Table.Manager.Mappers;

/// <summary> Маппер для моделей стола. </summary>
public class TableMapper : ITableModelMapper
{
    /// <summary> Преобразовать DTO в модель стола. </summary>
    /// <param name="dto"> Источник. </param>
    /// <returns> Модель ресторана. </returns>
    public TableModel MappDtoToModel(TableDTO dto)
    {
        var config = new MapperConfiguration(cfg => cfg.CreateMap<TableDTO, TableModel>());
        var mapper = new Mapper(config);
        var model = mapper.Map<TableModel>(dto);
        return model;
    }

    /// <summary> Преобразовать модель стола в DTO. </summary>
    /// <param name="model"> Источник. </param>
    /// <returns> DTO. </returns>
    public TableDTO MappDtoToModel(TableModel model)
    {
        var config = new MapperConfiguration(cfg => cfg.CreateMap<TableModel, TableDTO>());
        var mapper = new Mapper(config);
        var dto = mapper.Map<TableDTO>(model);
        return dto;
    }

    /// <summary> Преобразовать список DTO в список моделей стола. </summary>
    /// <param name="dto"> Источник. </param>
    /// <returns> Список моделей ресторана. </returns>
    public List<TableModel> MappDtoToModel(List<TableDTO> dto)
    {
        var config = new MapperConfiguration(cfg => cfg.CreateMap<TableDTO, TableModel>());
        var mapper = new Mapper(config);
        var models = mapper.Map<List<TableModel>>(dto);
        return models;
    }

    /// <summary> Преобразовать список моделей стола в список DTO. </summary>
    /// <param name="model"> Источник. </param>
    /// <returns> Список DTO. </returns>
    public List<TableDTO> MappDtoToModel(List<TableModel> model)
    {
        var config = new MapperConfiguration(cfg => cfg.CreateMap<TableModel, TableDTO>());
        var mapper = new Mapper(config);
        var dtos = mapper.Map<List<TableDTO>>(model);
        return dtos;
    }
}
