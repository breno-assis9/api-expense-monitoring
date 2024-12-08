using expense.Application.DTOs.Request;
using expense.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace expense.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ExpensesController : ControllerBase
{
    private readonly IExpenseService _expenseService;

    public ExpensesController(IExpenseService expenseService)
    {
        _expenseService = expenseService;
    }

    [HttpPost]
    public async Task<IActionResult> Post(AddExpenseRequest expense)
    {
        await _expenseService.Add(expense);
        return Ok();
    }

    [HttpPut]
    public async Task<IActionResult> Put(UpdateExpenseRequest expense)
    {
        await _expenseService.Update(expense);
        return Ok();
    }

    [HttpDelete]
    public async Task<IActionResult> Delete(Guid id)
    {
        await _expenseService.Delete(id);
        return Ok();
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var result = await _expenseService.GetAll();
        return Ok(result);
    }

    [HttpGet("id")]
    public async Task<IActionResult> Get(Guid id)
    {
        var result = await _expenseService.GetById(id);
        return Ok(result);
    }
}
