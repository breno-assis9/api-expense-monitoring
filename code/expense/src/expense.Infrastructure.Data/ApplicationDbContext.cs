using expense.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace expense.Infrastructure.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
    { }

    public DbSet<ExpenseEntity> expenseEntities { get; set; }
}
