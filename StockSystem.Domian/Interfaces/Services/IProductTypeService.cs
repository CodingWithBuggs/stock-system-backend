using StockSystem.Domian.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockSystem.Domian.Interfaces.Services
{
    public interface IProductTypeService
    {
        Task<IEnumerable<ProductType>> GetAll();
    }
}
