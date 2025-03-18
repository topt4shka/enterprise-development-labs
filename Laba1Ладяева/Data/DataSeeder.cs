using Laba1Ладяева.model;


namespace Laba1Ладяева.Data;
/// <summary>
/// Класс для заполнения коллекций данными
/// </summary>
public static class DataSeeder
{
    /// <summary>
    /// Коллекция товаров, использующаяся для первичного наполнения базы данных (и инмемори репозиториев)
    /// </summary>
    public static readonly List<Product> Products =
        new()
        {
            new()
            {
                Barcode = "1234567890123",
                Name = "Яблоко",
                Weight = 0.2,
                Type = "развесной",
                Price = 100.00m,
                ExpirationDate = new DateTime(2024, 12, 31)
            },
            new()
            {
                Barcode = "2345678901234",
                Name = "Банан",
                Weight = 0.15,
                Type = "развесной",
                Price = 80.00m,
                ExpirationDate = new DateTime(2024, 11, 30)
            },
            new()
            {
                Barcode = "3456789012345",
                Name = "Шоколадный батончик",
                Weight = 0.1,
                Type = "штучный",
                Price = 50.00m,
                ExpirationDate = new DateTime(2025, 01, 15)
            },
            new()
            {
                Barcode = "4567890123456",
                Name = "Кока-Кола",
                Weight = 1.0,
                Type = "штучный",
                Price = 60.00m,
                ExpirationDate = new DateTime(2025, 06, 30)
            },
        };

    /// <summary>
    /// Коллекция магазинов, использующаяся для первичного наполнения базы данных (и инмемори репозиториев)
    /// </summary>
    public static readonly List<Store> Stores =
        new()
        {
            new()
            {
                Id = 1,
                Name = "Магазин 1"
            },
            new()
            {
                Id = 2,
                Name = "Магазин 2"
            },
            new()
            {
                Id = 3,
                Name = "Магазин 3"
            },
        };

    /// <summary>
    /// Коллекция покупателей, использующаяся для первичного наполнения базы данных (и инмемори репозиториев)
    /// </summary>
    public static readonly List<Customer> Customers =
        new()
        {
            new()
            {
                CardNumber = "1001",
                FullName = "Иванов Иван Иванович"
            },
            new()
            {
                CardNumber = "1002",
                FullName = "Петров Петр Петрович"
            },
            new()
            {
                CardNumber = "1003",
                FullName = "Сидоров Сидор Сидорович"
            },
        };

    /// <summary>
    /// Коллекция продаж, использующаяся для первичного наполнения базы данных (и инмемори репозиториев)
    /// </summary>
    public static readonly List<Sale> Sales =
        new()
        {
            new()
            {
                Id = 1,
                Product = Products[0], // Яблоко
                Customer = Customers[0], // Иванов Иван Иванович
                SaleDate = DateTime.Now,
                Quantity = 3
            },
            new()
            {
                Id = 2,
                Product = Products[1], // Банан
                Customer = Customers[1], // Петров Петр Петрович
                SaleDate = DateTime.Now,
                Quantity = 5
            },
            new()
            {
                Id = 3,
                Product = Products[2], // Шоколадный батончик
                Customer = Customers[2], // Сидоров Сидор Сидорович
                SaleDate = DateTime.Now,
                Quantity = 2
            },
        };
}


