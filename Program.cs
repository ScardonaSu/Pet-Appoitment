using Microsoft.EntityFrameworkCore;
using Prueba_Desemp.Data;
using Prueba_Desemp.Services.Owner;
using Prueba_Desemp.Services.Pets;
using Prueba_Desemp.Services.Quotes;
using Prueba_Desemp.Services.Vets;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddScoped<IVetsRespository, VetsRespository>();
builder.Services.AddScoped<IOwnerRepository, OwnerRepository>();
builder.Services.AddScoped<IPetsRespository, PetsRespository>();
builder.Services.AddScoped<IQuotesRespository, QuotesRepository>();

//conexión a la Db
builder.Services.AddDbContext<BaseContext>(options =>
    options.UseMySql(
        builder.Configuration.GetConnectionString("MySqlConnection"),
        Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.20-mysql")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapControllers();
app.Run();

