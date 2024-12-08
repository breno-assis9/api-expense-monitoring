using expense.Application.DTOs.Request;
using expense.Application.DTOs.Response;

namespace expense.Application.Interfaces
{
    public interface IExpenseService
    {
        Task Add(AddExpenseRequest expense);
        Task Update(UpdateExpenseRequest expense);
        Task Delete(Guid id);
        Task<IEnumerable<ExpenseResponse>> GetAll();
        Task<ExpenseResponse> GetById(Guid id);
    }
}
