using Microsoft.AspNetCore.Mvc;
using Restaurant.Client.Model.DAL.Repositoryes;
using Restaurant.DTOModels.DtoModels;
using Restaurant.Manager.Mappers;

namespace Restaurant.Manager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantController : Controller
    {
        private readonly IRestaurantRepository _repository;
        private readonly ILogger _logger;
        private readonly IRestaurantMapper _restMapper;

        /// <summary> Конструктор класса. </summary>
        /// <param name="repository"> Репозиторий. </param>
        /// <param name="logger"> Логгер. </param>
        public RestaurantController(IRestaurantRepository repository, 
            ILogger<RestaurantController> logger,
            IRestaurantMapper restaurantMapper)
        {
            _restMapper = restaurantMapper;
            _repository = repository;
            _logger = logger;
            _logger.LogDebug(1, "Логгер встроен в RestaurantController");
        }

        /// <summary> Создать ресторан. </summary>
        /// <param name="restaurant"> Экземпляр ресторана. </param>
        /// <returns></returns>
        [HttpPost("CreateRestaurant")]
        public IActionResult Create(RestaurantDTO restaurant)
        {
            _logger.LogInformation(1, "Выполнение запроса на создание экземпляра RestaurantModel в БД.");

            var model = _restMapper.MappDtoToModel(restaurant);
            _repository.Add(model);
            return Ok();
        }

        /// <summary> Удалить ресторан по ID. </summary>
        /// <param name="id"> ID ресторана. </param>
        /// <returns></returns>
        [HttpPost("DeleteRestaurant")]
        public IActionResult Delete(int id)
        {
            _logger.LogInformation(1, "Выполнение запроса на удаление экземпляра RestaurantModel из БД.");
            _repository.Delete(id);
            return Ok();
        }

        /// <summary> Получить ресторан по ID. </summary>
        /// <param name="id"> ID ресторана. </param>
        /// <returns> Экземпляр ресторана. </returns>
        [HttpGet("GetRestaurant")]
        public IActionResult Get(int id)
        {
            _logger.LogInformation(1, "Выполнение запроса на получение экземпляра RestaurantModel из БД.");
            var restaurant = _repository.GetById(id);
            if (restaurant is null) return NotFound();
            var restDto = _restMapper.MappModelToDto(restaurant);

            return Ok(restDto);
        }

        /// <summary> Обновить данные ресторана. </summary>
        /// <param name="table"> Экземпляр с новыми данными. </param>
        /// <returns></returns>
        [HttpPatch("UpdateRestaurant")]
        public IActionResult Update(RestaurantDTO restaurant)
        {
            _logger.LogInformation(1, "Выполнение запроса на асинхронное обновление экземпляра RestaurantModel в БД.");

            if (restaurant is null) Ok();
            var model = _restMapper.MappDtoToModel(restaurant!);
            _repository.Update(model);

            return Ok();
        }
    }
}
