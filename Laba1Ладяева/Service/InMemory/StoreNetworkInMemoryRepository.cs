using Laba1Ладяева.model;
using Laba1Ладяева.Data;
using System.Xml.Linq;

namespace Laba1Ладяева.Service.InMemory;

/// <summary>
/// Имплементация репозитория для связующей сущности товаров и магазинов, которая хранит коллекцию в оперативной памяти 
/// </summary>
public class ProductStoreInMemoryRepository : IRepository<ProductStore, int>
{
    private List<ProductStore> _productStores;

    /// <summary>
    /// Конструктор репозитория
    /// </summary>
    public ProductStoreInMemoryRepository()
    {
        _productStores = DataSeeder.ProductStores;
    }

    /// <inheritdoc/>
    public Task<ProductStore> Add(ProductStore entity)
    {
        try
        {
            _productStores.Add(entity);
        }
        catch
        {
            return null!;
        }
        return Task.FromResult(entity);
    }

    /// <inheritdoc/>
    public async Task<bool> Delete(int key)
    {
        try
        {
            var productStore = await Get(key);
            if (productStore != null)
                _productStores.Remove(productStore);
        }
        catch
        {
            return false;
        }
        return true;
    }

    /// <inheritdoc/>
    public Task<ProductStore?> Get(int key) =>
        Task.FromResult(_productStores.FirstOrDefault(item => item.Id == key));

    /// <inheritdoc/>
    public Task<IList<ProductStore>> GetAll() =>
        Task.FromResult((IList<ProductStore>)_productStores);

    /// <inheritdoc/>
    public async Task<ProductStore> Update(ProductStore entity)
    {
        try
        {
            await Delete(entity.Id);
            await Add(entity);
        }
        catch
        {
            return null!;
        }
        return entity;
    }
}


