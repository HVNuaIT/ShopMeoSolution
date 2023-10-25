using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopMeoSolution.Application.Catalog.Product.IService;
using ShopMeoSolution.ViewModel.Catalog.SanPham.Admin;

namespace ShopMeoSolution.Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SanPhamController : ControllerBase
    {
        public readonly IAdminSanPhamService adminSanPhamService;
      
        public SanPhamController(IAdminSanPhamService adminSanPhamService)
        {
            this.adminSanPhamService = adminSanPhamService;
        }
        [HttpPost]
        public async Task<ActionResult> Create([FromForm]CreateProduct sp)
        {
            var product = await adminSanPhamService.CreateProduct(sp);
            return Ok(product);
        }
    }
}
