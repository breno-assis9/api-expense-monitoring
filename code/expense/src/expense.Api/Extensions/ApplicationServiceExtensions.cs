using expense.Application.Interfaces;
using expense.Application.Services;
using expense.Domain.Interfaces;
using expense.Infrastructure.Data;
using expense.Infrastructure.Data.Repositories;
using Microsoft.EntityFrameworkCore;

namespace expense.Api.Extensions;

public static class ApplicationServiceExtensions
{
    public static void AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
    {
        // Configura o DbContext
        services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

        // Registra repositórios
        services.AddScoped<IExpenseRepository, ExpenseRepository>();

        // Registra outros serviços da aplicação
        services.AddScoped<IExpenseService, ExpenseService>();
    }
}
