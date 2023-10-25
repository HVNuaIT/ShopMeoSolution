

using Microsoft.AspNetCore.Http;
using ShopMeoSolution.Application.Catalog.Common;
using ShopMeoSolution.Application.Catalog.Product.IService;
using ShopMeoSolution.Domain.EF;
using ShopMeoSolution.Domain.Entity;
using ShopMeoSolution.ViewModel.Catalog.SanPham;
using ShopMeoSolution.ViewModel.Catalog.SanPham.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ShopMeoSolution.Application.Catalog.SanPham.Request
{
    public class SanPhamRequest : IAdminSanPhamService
    {
        public readonly ShopMeoDbContext db;
          public readonly IHinhAnhSevice hinhAnhSevice;
        private const string USER_CONTENT_FOLDER_NAME = "user-content";
        public SanPhamRequest(ShopMeoDbContext _db,IHinhAnhSevice _hinhAnhSevice)
        {
            db = _db;
            hinhAnhSevice = _hinhAnhSevice;
        }

        public async Task<string> CreateProduct(CreateProduct request)
        {
            var sp = new Domain.Entity.SanPham()
            {
                TenSanPham = request.TenSanPham,
                Gia = request.Gia,
                SoLuong=request.SoLuong,
                TrangThai = request.TrangThai,
                IdDanhMuc = request.IdDanhMuc,
                MoTa = request.MoTa,

            };
            if (request.HinhAnh != null)
            {
                sp.HinhAnhSanPhams = new List<HinhAnhSanPham>()
                {
                    new HinhAnhSanPham
                    {
                        NgayTao = DateTime.Now,
                        KichThuc = request.HinhAnh.Length,
                        DuongDanImg =await this.SaveImg(request.HinhAnh),

                    }

                };
            }
            db.SanPhams.Add(sp);
            await db.SaveChangesAsync();
            
             return "Thanh Cong" ;
        }

        public async Task<string> Delete(int request)
        {
            throw new NotImplementedException();
        }

        public async Task<string> EditProduct(EditProduct request)
        {
            throw new NotImplementedException();
        }

        public List<DanhMuc> GetMuc()
        {
            return db.DanhMucs.ToList();
        }

        public  List<Domain.Entity.SanPham> GetProducts()
        {
                        
            return db.SanPhams.ToList() ;
        }
        public async Task<string> SaveImg(IFormFile Img)
        {
            var originalfileName = ContentDispositionHeaderValue.Parse(Img.ContentDisposition).FileName.Trim('"');
            var fileName = $"{Guid.NewGuid()}{Path.GetExtension(originalfileName)}";
            await hinhAnhSevice.SaveFile(Img.OpenReadStream(), fileName);
               return "/" + USER_CONTENT_FOLDER_NAME + "/" + fileName; ;
        }
      

    }
}
