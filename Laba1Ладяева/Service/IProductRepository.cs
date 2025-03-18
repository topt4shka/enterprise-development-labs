
using Laba1Ладяева.model;
using Laba1Ладяева.Service;

namespace StoreNetwork.Service;

    /// <summary>
    /// Наследник обобщенного интерфейса для работы с магазинами и товарами
    /// </summary>
    public interface IProductRepository : IRepository<Product, int>
{
    /// <summary>
    /// Метод для вывода всех товаров в заданном магазине
    /// </summary>
    /// <param name="storeName">Название магазина</param>
    /// <returns>Список товаров в магазине</returns>
    Task<IList<Product>> GetProductsInStore(string storeName);

    /// <summary>
    /// Метод для вывода списка магазинов, в которых есть заданный товар
    /// </summary>
    /// <param name="productBarcode">Штрих-код товара</param>
    /// <returns>Список названий магазинов</returns>
    Task<IList<int>> GetStoresWithProduct(string productBarcode);

    /// <summary>
    /// Метод для вывода средней стоимости товаров каждой товарной группы для каждого магазина
    /// </summary>
    /// <returns>Список кортежей с названием магазина, кодом группы и средней ценой</returns>
    Task<IList<Tuple<string, int, decimal>>> GetAveragePriceByGroup();

    /// <summary>
    /// Метод для вывода топ 5 покупок по общей сумме продажи
    /// </summary>
    /// <returns>Список кортежей с ФИО покупателя и суммой покупки</returns>
    Task<IList<Tuple<int, decimal>>> GetTop5Sales();

    /// <summary>
    /// Метод для вывода всех товаров, превышающих предельную дату хранения, с указанием магазина
    /// </summary>
    /// <returns>Список кортежей с названием магазина, наименованием товара и датой истечения</returns>
    Task<IList<Tuple<string, int, DateTime>>> GetExpiredProducts();

    /// <summary>
    /// Метод для вывода списка магазинов, в которых за месяц было продано товаров на сумму, превышающую заданную
    /// </summary>
    /// <param name="threshold">Пороговая сумма</param>
    /// <returns>Список названий магазинов</returns>
    Task<IList<int>> GetStoresWithSalesAbove(decimal threshold);
}

    
    

