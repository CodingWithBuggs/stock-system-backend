using Microsoft.EntityFrameworkCore;
using StockSystem.Domian.Entities;
using StockSystem.Domian.Interfaces.Repositories;
using SystemStock.Infrastructure.EFCore.Context;

namespace SystemStock.Infrastructure.Repositories
{
    public class ProductTypeRepository: IProductTypeRepository
    {
        private readonly StockSystemContext _context;

        public ProductTypeRepository(StockSystemContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ProductType>> GetAll()
        {
            var data = await _context.ProductTypes.ToListAsync();
            return data;
        }

    }
}
