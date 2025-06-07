using StockSystem.Domian.Entities;
using StockSystem.Domian.Interfaces.Repositories;
using StockSystem.Domian.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
