using Domain.Entity;
using ShopMeoSolution.ViewModel.Catalog.SanPham.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopMeoSolution.Application.Catalog.Product.IService
{
    public interface IAdminSanPhamService
    {
        Task<string> CreateProduct(CreateProduct request);
        Task<string> EditProduct(EditProduct request);
        Task<string> Delete(int request);
        List<Domain.Entity.SanPham> GetProducts();
        List<Domain.Entity.DanhMuc> GetMuc();
    }
}
