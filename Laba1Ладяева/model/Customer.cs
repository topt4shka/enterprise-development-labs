using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1Ладяева.model;

/// <summary>
/// Покупатель
/// </summary>
class Customer
{
    // <summary>
    /// Номер карты покупателя
    /// </summary>
    [Key]
    public required string CardNumber { get; set; }

    /// <summary>
    /// ФИО покупателя
    /// </summary>
    public string? FullName { get; set; }
}
