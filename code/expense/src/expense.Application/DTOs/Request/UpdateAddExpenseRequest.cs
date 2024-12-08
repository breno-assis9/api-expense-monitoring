using expense.Domain.DomainObjects.Enums;

namespace expense.Application.DTOs.Request
{
    public class UpdateExpenseRequest
    {
        public Guid Id { get; set; }
        public ExpenseTypeEnum ExpenseType { get; set; }
        public PaymentTypeEnum PaymentType { get; set; }
        public CardTypeEnum? CardType { get; set; }
        public string Description { get;  set; }
        public decimal Value { get; set; }
        public DateTime DueDate { get; set; }
    }
}
