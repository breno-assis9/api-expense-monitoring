using expense.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace expense.Domain.Interfaces
{
    public interface IExpenseRepository
    {
        Task Add(ExpenseEntity expense);
        Task Update(ExpenseEntity expense);
        Task Delete(ExpenseEntity expense);
        Task<IEnumerable<ExpenseEntity>> GetAll();
        Task<ExpenseEntity> GetById(Guid id);
    }
}
