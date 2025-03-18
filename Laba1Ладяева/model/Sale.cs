using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1Ладяева.model;

/// <summary>
/// Продажа
/// </summary>
class Sale
{
    /// <summary>
    /// Покупатель
    /// </summary>
    public Customer Customer { get; set; }

    /// <summary>
    /// Товар
    /// </summary>
    public Product Product { get; set; }

    /// <summary>
    /// Дата продажи
    /// </summary>
    public DateTime SaleDate { get; set; }

    /// <summary>
    /// Общая сумма продажи
    /// </summary>
    public decimal TotalAmount { get; set; }
}
