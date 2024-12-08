using expense.Domain.Entities;
using expense.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace expense.Infrastructure.Data.Repositories;

public class ExpenseRepository : IExpenseRepository
{
    private readonly ApplicationDbContext _context;

    public ExpenseRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task Add(ExpenseEntity expense)
    {
        await _context.Set<ExpenseEntity>().AddAsync(expense);
        await _context.SaveChangesAsync();
    }

    public async Task Delete(ExpenseEntity expense)
    {
         _context.Set<ExpenseEntity>().Remove(expense);
        await _context.SaveChangesAsync();
    }

    public async Task<IEnumerable<ExpenseEntity>> GetAll()
    {
        return await _context.Set<ExpenseEntity>().ToListAsync();
    }

    public async Task<ExpenseEntity> GetById(Guid id)
    {
        return await _context.Set<ExpenseEntity>().FindAsync(id);
    }

    public async Task Update(ExpenseEntity expense)
    {
        _context.Set<ExpenseEntity>().Update(expense);
        await _context.SaveChangesAsync();
    }
}
