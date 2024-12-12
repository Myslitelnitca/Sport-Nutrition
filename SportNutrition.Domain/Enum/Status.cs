using System.ComponentModel;

namespace SportNutrition.Domain.Enum;

public enum Status
{
    [Description("Не рассмотрено")]
    NotConsidered = 0,
    
    [Description("Одобрено")]
    Approved,
    
    [Description("Отказано")]
    Denided,
}