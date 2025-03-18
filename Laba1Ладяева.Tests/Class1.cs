using System.Xml.Linq;
using Laba1Ладяева.Service.InMemory;

namespace Laba1Ладяева.Tests;
/// <summary>
/// Класс с юнит-тестами репозитория продаж
/// </summary>
public class SaleRepositoryTests
{
    /// <summary>
    /// Параметризованный тест метода, возвращающего продажи по идентификатору товара
    /// </summary>
    /// <param name="productId"></param>
    /// <param name="expectedCount"></param>
    [Theory]
    [InlineData(1, 2)] // Пример: товар с ID 1 имеет 2 продажи
    [InlineData(2, 1)] // Пример: товар с ID 2 имеет 1 продажу
    [InlineData(3, 0)] // Пример: товар с ID 3 не имеет продаж
    public async Task GetSalesByProductId_Success(int productId, int expectedCount)
    {
        var repo = new SaleInMemoryRepository();
        var sales = await repo.GetSalesByProductId(productId);
        Assert.Equal(expectedCount, sales.Count);
    }

    /// <summary>
    /// Непараметрический тест метода, выводящего топ 5 товаров по количеству продаж
    /// </summary>
    [Fact]
    public async Task GetTop5ProductsBySalesCount_Success()
    {
        var repo = new SaleInMemoryRepository();
        var topProducts = await repo.GetTop5ProductsBySalesCount();
        Assert.Equal(5, topProducts.Count); // Предполагается, что в тестовых данных есть 5 товаров
    }
}

