using expense.Application.Interfaces;
using expense.Domain.Entities;
using expense.Domain.Interfaces;

namespace expense.Application.Services
{
    public class ExpenseService : IExpenseService
    {
        private readonly IExpenseRepository _expenseRepository;

        public ExpenseService(IExpenseRepository expenseRepository)
        {
            _expenseRepository = expenseRepository;
        }

        public async Task Add(ExpenseEntity expense)
        {
            await _expenseRepository.Add(expense);
        }

        public async Task Delete(Guid id)
        {
            var expense = await _expenseRepository.GetById(id);
            await _expenseRepository.Delete(expense);
        }

        public async Task<IEnumerable<ExpenseEntity>> GetAll()
        {
            return await _expenseRepository.GetAll();
        }

        public async Task<ExpenseEntity> GetById(Guid id)
        {
            return await _expenseRepository.GetById(id);
        }

        public async Task Update(ExpenseEntity expense)
        {
            await _expenseRepository.Update(expense);
        }
    }
}
