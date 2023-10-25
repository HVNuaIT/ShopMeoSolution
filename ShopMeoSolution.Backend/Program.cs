using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using ShopMeoSolution.Application.Catalog.Common;
using ShopMeoSolution.Application.Catalog.Product.IService;
using ShopMeoSolution.Application.Catalog.SanPham.Request;
using ShopMeoSolution.Domain.EF;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<IHinhAnhSevice, HinhAnhRequest>();
builder.Services.AddTransient<IAdminSanPhamService, SanPhamRequest>();
builder.Services.AddDbContext<ShopMeoDbContext>(context => context.UseSqlServer(builder.Configuration.GetConnectionString("db")));


var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAuthentication();
app.UseRouting();
app.UseAuthorization();

app.MapControllers();

app.Run();
