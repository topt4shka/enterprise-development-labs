using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1Ладяева.model;

/// <summary>
/// Сеть магазинов
/// </summary>
class StoreNetwork
{
    /// <summary>
    /// Список магазинов
    /// </summary>
    public List<Store> Stores { get; set; } = new List<Store>();

    /// <summary>
    /// Список продаж
    /// </summary>
    public List<Sale> Sales { get; set; } = new List<Sale>();

    
