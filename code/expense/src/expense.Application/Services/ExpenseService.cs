using AutoMapper;
using expense.Application.DTOs.Request;
using expense.Application.DTOs.Response;
using expense.Application.Interfaces;
using expense.Domain.Entities;
using expense.Domain.Interfaces;

namespace expense.Application.Services;

public class ExpenseService : IExpenseService
{
    private readonly IExpenseRepository _expenseRepository;
    private readonly IMapper _mapper;
    public ExpenseService(IExpenseRepository expenseRepository, IMapper mapper)
    {
        _expenseRepository = expenseRepository;
        _mapper = mapper;
    }

    public async Task Add(AddExpenseRequest expense)
    {
        await _expenseRepository.Add(_mapper.Map<ExpenseEntity>(expense));
    }

    public async Task Delete(Guid id)
    {
        var expense = await _expenseRepository.GetById(id);
        await _expenseRepository.Delete(expense);
    }

    public async Task<IEnumerable<ExpenseResponse>> GetAll()
    {
        return _mapper.Map<IEnumerable<ExpenseResponse>>(await _expenseRepository.GetAll());
    }

    public async Task<ExpenseResponse> GetById(Guid id)
    {
        return _mapper.Map<ExpenseResponse>(await _expenseRepository.GetById(id));
    }

    public async Task Update(UpdateExpenseRequest expense)
    {
        await _expenseRepository.Update(_mapper.Map<ExpenseEntity>(expense));
    }
}
