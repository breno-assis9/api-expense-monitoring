using expense.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace expense.Api.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static void AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {
            // Configura o DbContext
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            // Registra repositórios

            // Registra outros serviços da aplicação
        }
    }
}
