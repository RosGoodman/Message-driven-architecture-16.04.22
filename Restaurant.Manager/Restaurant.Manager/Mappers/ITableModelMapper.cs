using Restaurant.Client.Model.Models;
using Restaurant.DTOModels.DtoModels;

namespace Table.Manager.Mappers
{
    public interface ITableModelMapper
    {
        TableModel MappDtoToModel(TableDTO dto);
        TableDTO MappDtoToModel(TableModel model);
        public List<TableModel> MappDtoToModel(List<TableDTO> dto);
        public List<TableDTO> MappDtoToModel(List<TableModel> model);
    }
}