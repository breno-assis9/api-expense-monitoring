using System.ComponentModel.DataAnnotations;

namespace expense.Domain.DomainObjects.Enums;

public enum CardTypeEnum
{
    [Display(Name = "Cartão Crédito")]
    Credito = 0,
    
    [Display(Name = "Cartão Débito")]
    Debit = 1,

    [Display(Name = "Cartão Alimentação")]
    Food = 2,

    [Display(Name = "Cartão Refeição")]
    Meal = 3,
}
