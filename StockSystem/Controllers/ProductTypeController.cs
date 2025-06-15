using Microsoft.AspNetCore.Mvc;
using StockSystem.Domian.Interfaces.Services;

namespace StockSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductTypeController : ControllerBase
    {
        private readonly IProductTypeService _service;

        public ProductTypeController(IProductTypeService service)
        {

            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var data = await _service.GetAll();
            return Ok(data);
        }
    }
}
