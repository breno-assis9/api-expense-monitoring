using System.ComponentModel.DataAnnotations;

namespace expense.Domain.DomainObjects.Enums;

public enum PaymentTypeEnum
{
    [Display(Name = "Cartão")]
    Card = 0,

    [Display(Name = "Transferência Pix")]
    Pix = 1,
    
    [Display(Name = "Transferência Ted")]
    Ted = 2,

    [Display(Name = "Transferência Doc")]
    Doc = 3,
    
    [Display(Name = "Boleto")]
    Split = 4
}
