using StockSystem.Domian.Entities;

namespace StockSystem.Domian.Interfaces.Repositories
{
    public interface IProductTypeRepository
    {
        Task<IEnumerable<ProductType>> GetAll();
    }
}
