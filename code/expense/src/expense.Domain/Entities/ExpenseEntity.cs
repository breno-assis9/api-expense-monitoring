using expense.Domain.DomainObjects.Entities;
using expense.Domain.DomainObjects.Enums;

namespace expense.Domain.Entities;

public class ExpenseEntity : EntityBase
{
    #region Constructors

    public ExpenseEntity(ExpenseTypeEnum expenseType,
                         PaymentTypeEnum paymentType,
                         CardTypeEnum? cardType,
                         string description,
                         decimal value,
                         DateTime dueDate)
    {
        ExpenseType = expenseType;
        PaymentType = paymentType;
        CardType = cardType;
        Description = description;
        Value = value;
        DueDate = dueDate;
        DataRegister = DateTime.Now;
        DataUpdate = DateTime.Now;
    }

    public ExpenseEntity(Guid id, 
                         ExpenseTypeEnum expenseType,
                         PaymentTypeEnum paymentType,
                         CardTypeEnum? cardType,
                         string description,
                         decimal value,
                         DateTime dueDate)
    {
        Id = id;
        ExpenseType = expenseType;
        PaymentType = paymentType;
        CardType = cardType;
        Description = description;
        Value = value;
        DueDate = dueDate;
        DataUpdate = DateTime.Now;
    }

    #endregion

    #region Properties

    public ExpenseTypeEnum ExpenseType { get; private set; }
    public PaymentTypeEnum PaymentType { get; private set; }
    public CardTypeEnum? CardType { get; private set; }
    public string Description { get; private set; } = string.Empty;
    public decimal Value { get; private set; } = decimal.Zero;
    public DateTime DataRegister { get; set; }
    public DateTime DataUpdate { get; set; }
    public DateTime DueDate { get; private set; }

    #endregion

    #region Methods
    public void AddExpense(ExpenseEntity expense)
    {
        ExpenseType = expense.ExpenseType;
        PaymentType = expense.PaymentType;

        if (expense.PaymentType == PaymentTypeEnum.Card)
        {
            CardType = expense.CardType;
        }

        Description = expense.Description;
        Value = expense.Value;
        DataRegister = expense.DataRegister;
        DataUpdate = expense.DataUpdate;
        DueDate = expense.DueDate;
    }

    public void UpdateExpense(ExpenseEntity expense)
    {
        Id = expense.Id;
        ExpenseType = expense.ExpenseType;
        PaymentType = expense.PaymentType;

        if (expense.PaymentType == PaymentTypeEnum.Card)
        {
            CardType = expense.CardType;
        }

        Description = expense.Description;
        Value = expense.Value;
        DataRegister = expense.DataRegister;
        DataUpdate = expense.DataUpdate;
        DueDate = expense.DueDate;
    }

    #endregion
}
