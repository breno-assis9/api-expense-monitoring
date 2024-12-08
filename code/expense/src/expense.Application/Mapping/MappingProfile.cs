using AutoMapper;
using expense.Application.DTOs.Request;
using expense.Application.DTOs.Response;
using expense.Domain.Entities;

namespace expense.Application.Mapping;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        // Responses
        CreateMap<ExpenseResponse, ExpenseEntity>().ReverseMap();

        // Requests
        CreateMap<AddExpenseRequest, ExpenseEntity>().ReverseMap();
        CreateMap<UpdateExpenseRequest, ExpenseEntity>().ReverseMap();
    }
}
