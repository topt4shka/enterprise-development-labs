using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1Ладяева.model;

/// <summary>
/// Товар
/// </summary>
internal class Product
{
    /// <summary>
    /// Штрих-код товара
    /// </summary>
    [Key]
    public required string Barcode { get; set; }

    /// <summary>
    /// Код товарной группы
    /// </summary>
    public string? GroupCode { get; set; }

    /// <summary>
    /// Наименование товара
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Вес упаковки
    /// </summary>
    public double Weight { get; set; }

    /// <summary>
    /// Тип товара (штучный или развесной)
    /// </summary>
    public string Type { get; set; } // "штучный" или "развесной"

    /// <summary>
    /// Цена товара
    /// </summary>
    public decimal Price { get; set; }

    /// <summary>
    /// Предельная дата хранения
    /// </summary>
    public DateTime ExpirationDate { get; set; }
}
