using StockSystem.Domian.Entities;
using StockSystem.Domian.Interfaces.Repositories;
using StockSystem.Domian.Interfaces.Services;

namespace StockSystem.Application.Services
{
    public class ProductTypeService : IProductTypeService
    {
        private readonly IProductTypeRepository _repository;

        public ProductTypeService(IProductTypeRepository repository)
        {
            _repository = repository;
        }
        public async Task<IEnumerable<ProductType>> GetAll() {
            return await _repository.GetAll();        
        }
    }
}
