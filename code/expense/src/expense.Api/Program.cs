using expense.Api.Extensions;
using expense.Application.Mapping;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAutoMapper(typeof(MappingProfile));

builder.Services.AddApplicationServices(builder.Configuration);

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

builder.Services.AddControllers();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger(); // Gera a documentação Swagger
    app.UseSwaggerUI(); // Interface interativa para visualizar a documentação
}

app.MapControllers();

app.Run();
