using expense.Domain.Entities;

namespace expense.Application.Interfaces
{
    public interface IExpenseService
    {
        Task Add(ExpenseEntity expense);
        Task Update(ExpenseEntity expense);
        Task Delete(Guid id);
        Task<IEnumerable<ExpenseEntity>> GetAll();
        Task<ExpenseEntity> GetById(Guid id);
    }
}
