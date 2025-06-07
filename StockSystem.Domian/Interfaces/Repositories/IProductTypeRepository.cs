using StockSystem.Domian.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockSystem.Domian.Interfaces.Repositories
{
    public interface IProductTypeRepository
    {
        Task<IEnumerable<ProductType>> GetAll();
    }
}
