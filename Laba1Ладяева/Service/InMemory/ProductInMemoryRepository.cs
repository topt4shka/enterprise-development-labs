using System.Linq;
using Laba1Ладяева.model;
using Laba1Ладяева.Data;
using StoreNetwork.Service;


namespace Laba1Ладяева.Service.InMemory;
/// <summary>
/// Имплементация репозитория для товаров, которая хранит коллекцию в оперативной памяти 
/// </summary>
public class ProductInMemoryRepository : IProductRepository
{
    private List<Product> _products;
    private List<Store> _stores;
    private List<Sale> _sales;

    /// <summary>
    /// Конструктор репозитория
    /// </summary>
    public ProductInMemoryRepository()
    {
        _products = DataSeeder.Products;
        _stores = DataSeeder.Stores;
        _sales = DataSeeder.Sales;
    }

    /// <inheritdoc/>
    public Task<Product> Add(Product entity)
    {
        try
        {
            _products.Add(entity);
        }
        catch
        {
            return null!;
        }
        return Task.FromResult(entity);
    }

    /// <inheritdoc/>
    public async Task<bool> Delete(string barcode)
    {
        try
        {
            var product = await Get(barcode);
            if (product != null)
                _products.Remove(product);
        }
        catch
        {
            return false;
        }
        return true;
    }

    /// <inheritdoc/>
    public async Task<Product> Update(Product entity)
    {
        try
        {
            await Delete(entity.Barcode);
            await Add(entity);
        }
        catch
        {
            return null!;
        }
        return entity;
    }

    /// <inheritdoc/>
    public Task<Product?> Get(string barcode) =>
        Task.FromResult(_products.FirstOrDefault(item => item.Barcode == barcode));

    /// <inheritdoc/>
    public Task<IList<Product>> GetAll() =>
        Task.FromResult((IList<Product>)_products);

    /// <inheritdoc/>
    public async Task<IList<Tuple<string, decimal>>> GetTop5ProductsByPrice()
    {
        return await Task.FromResult(_products
            .OrderByDescending(product => product.Price)
            .Take(5)
            .Select(product => new Tuple<string, decimal>(product.ToString(), product.Price))
            .ToList());
    }

    /// <inheritdoc/>
    public async Task<IList<Tuple<string, int>>> GetTop5ProductsBySalesCount()
    {
        var productSalesCount = _sales
            .GroupBy(sale => sale.Product.Barcode)
            .Select(group => new
            {
                Barcode = group.Key,
                Count = group.Sum(sale => sale.Quantity)
            })
            .OrderByDescending(x => x.Count)
            .Take(5)
            .ToList();

        var result = new List<Tuple<string, int>>();
        foreach (var item in productSalesCount)
        {
            var product = await Get(item.Barcode);
            if (product != null)
            {
                result.Add(new Tuple<string, int>(product.ToString(), item.Count));
            }
        }

        return result;
    }
}

