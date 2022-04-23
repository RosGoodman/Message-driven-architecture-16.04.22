using Restaurant.Client.Model.DAL.DataContext;
using Restaurant.Client.Model.DAL.Repositoryes;
using Restaurant.Manager.Mappers;
using Table.Manager.Mappers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var services = builder.Services;

services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
services.AddEndpointsApiExplorer();

services.AddSwaggerGen(c =>
{
    var filePath = Path.Combine(AppContext.BaseDirectory, "SimpleSwagger.xml");
    c.IncludeXmlComments(filePath, includeControllerXmlComments: true);
});

services.AddSingleton(typeof(IContextDb), typeof(ContextDb));
//репозитории
services.AddSingleton(typeof(IRestaurantRepository), typeof(RestaurantRepository));
services.AddSingleton(typeof(ITableRepository), typeof(TableRepository));

//мапперы
services.AddSingleton(typeof(IRestaurantMapper), typeof(RestaurantMapper));
services.AddSingleton(typeof(ITableModelMapper), typeof(TableMapper));



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
