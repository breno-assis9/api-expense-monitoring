using expense.Domain.Entities;

namespace expense.Domain.Interfaces;

public interface IExpenseRepository
{
    Task Add(ExpenseEntity expense);
    Task Update(ExpenseEntity expense);
    Task Delete(ExpenseEntity expense);
    Task<IEnumerable<ExpenseEntity>> GetAll();
    Task<ExpenseEntity> GetById(Guid id);
}
