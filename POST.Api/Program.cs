using POS.Infrastructure.Extensions;

var builder = WebApplication.CreateBuilder(args);

//creamosuna variable para traer el builder 

var Configuration = builder.Configuration;

// Add services to the container.
// queda injectado metodo de servicio de injeccion
builder.Services.AddInjectionInfrastructure(Configuration);


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
