using expense.Domain.DomainObjects.Enums;

namespace expense.Application.DTOs.Response;

public class ExpenseResponse
{
    public Guid Id { get; set; }
    public ExpenseTypeEnum ExpenseType { get; private set; }
    public PaymentTypeEnum PaymentType { get; private set; }
    public CardTypeEnum? CardType { get; private set; }
    public string Description { get; private set; } = string.Empty;
    public decimal Value { get; private set; } = decimal.Zero;
    public DateTime DueDate { get; private set; }
}
