using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1Ладяева.model;

/// <summary>
/// Магазин
/// </summary>
public class Store
{
    /// <summary>
    /// Штрих-код товара
    /// </summary>
    [Key]
    public required int Id { get; set; }

    /// <summary>
    /// Название магазина
    /// </summary>
    public required string Name { get; set; }

    /// <summary>
    /// Список товаров в магазине
    /// </summary>
    public virtual List<Product> Products { get; set; } = new List<Product>();
}
