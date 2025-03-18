using Laba1Ладяева.model;
using System.Xml.Linq;
using Laba1Ладяева.Data;

namespace Laba1Ладяева.Service.InMemory
{
    /// <summary>
    /// Имплементация репозитория для магазинов, которая хранит коллекцию в оперативной памяти 
    /// </summary>
    public class StoreInMemoryRepository : IStoreRepository
    {
        private List<Store> _stores;

        /// <summary>
        /// Конструктор репозитория
        /// </summary>
        public StoreInMemoryRepository()
        {
            _stores = DataSeeder.Stores; // Предполагается, что DataSeeder содержит данные о магазинах
        }

        /// <inheritdoc/>
        public Task<Store> Add(Store entity)
        {
            _stores.Add(entity);
            return Task.FromResult(entity);
        }

        /// <inheritdoc/>
        public async Task<bool> Delete(string key)
        {
            var store = await Get(key);
            if (store != null)
            {
                _stores.Remove(store);
                return true;
            }
            return false;
        }

        /// <inheritdoc/>
        public Task<Store?> Get(string key) =>
            Task.FromResult(_stores.FirstOrDefault(item => item.Name == key));

        /// <inheritdoc/>
        public Task<IList<Store>> GetAll() =>
            Task.FromResult((IList<Store>)_stores);

        /// <inheritdoc/>
        public async Task<Store> Update(Store entity)
        {
            await Delete(entity.Name);
            await Add(entity);
            return entity;
        }
    }



}
