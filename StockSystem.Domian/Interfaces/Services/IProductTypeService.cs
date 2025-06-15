using StockSystem.Domian.Entities;

namespace StockSystem.Domian.Interfaces.Services
{
    public interface IProductTypeService
    {
        Task<IEnumerable<ProductType>> GetAll();
    }
}
