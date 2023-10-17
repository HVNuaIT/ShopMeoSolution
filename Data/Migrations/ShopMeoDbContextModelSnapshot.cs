﻿// <auto-generated />
using System;
using Domain.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Domain.Migrations
{
    [DbContext(typeof(ShopMeoDbContext))]
    partial class ShopMeoDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Domain.Entity.DanhMuc", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("TenDanhMuc")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<int>("TrangThai")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(1);

                    b.HasKey("Id");

                    b.ToTable("DanhMuc", (string)null);
                });

            modelBuilder.Entity("Domain.Entity.Quyen", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("TenQuyen")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("10");

                    b.HasKey("Id");

                    b.ToTable("Role", (string)null);
                });

            modelBuilder.Entity("Domain.Entity.SanPham", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<byte[]>("File")
                        .IsUnicode(true)
                        .HasColumnType("varbinary(max)");

                    b.Property<double>("Gia")
                        .HasColumnType("float");

                    b.Property<string>("Hinh")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdDanhMuc")
                        .HasColumnType("int");

                    b.Property<string>("MoTa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.Property<string>("TenSanPham")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("TrangThai")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(1);

                    b.HasKey("Id");

                    b.HasIndex("IdDanhMuc");

                    b.ToTable("SanPham", (string)null);
                });

            modelBuilder.Entity("Domain.Entity.SanPhamDanhMuc", b =>
                {
                    b.Property<int>("IdSanPham")
                        .HasColumnType("int");

                    b.Property<int>("IdDanhMuc")
                        .HasColumnType("int");

                    b.Property<int>("DanhMucId")
                        .HasColumnType("int");

                    b.Property<int>("SanPhamId")
                        .HasColumnType("int");

                    b.HasKey("IdSanPham", "IdDanhMuc");

                    b.HasIndex("DanhMucId");

                    b.HasIndex("SanPhamId");

                    b.ToTable("SanPhamDanhMuc", (string)null);
                });

            modelBuilder.Entity("Domain.Entity.TaiKhoan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("True");

                    b.Property<string>("Email")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)")
                        .HasDefaultValue("150");

                    b.Property<string>("MatKhau")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("150");

                    b.Property<string>("SoDienThoai")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("11");

                    b.Property<string>("TenNguoiDung")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("TrangThai")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(1);

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("TenNguoiDung")
                        .IsUnique();

                    b.ToTable("TaiKhoan", (string)null);
                });

            modelBuilder.Entity("Domain.Entity.UserRoles", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("IdRole")
                        .HasColumnType("int");

                    b.HasKey("UserId", "IdRole");

                    b.HasIndex("IdRole");

                    b.ToTable("UserRoles", (string)null);
                });

            modelBuilder.Entity("Domain.Entity.SanPham", b =>
                {
                    b.HasOne("Domain.Entity.DanhMuc", "DanhMuc")
                        .WithMany("SanPhams")
                        .HasForeignKey("IdDanhMuc")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("DanhMuc");
                });

            modelBuilder.Entity("Domain.Entity.SanPhamDanhMuc", b =>
                {
                    b.HasOne("Domain.Entity.DanhMuc", "DanhMuc")
                        .WithMany()
                        .HasForeignKey("DanhMucId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entity.SanPham", "SanPham")
                        .WithMany()
                        .HasForeignKey("SanPhamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DanhMuc");

                    b.Navigation("SanPham");
                });

            modelBuilder.Entity("Domain.Entity.UserRoles", b =>
                {
                    b.HasOne("Domain.Entity.Quyen", "Quyen")
                        .WithMany("UserRoles")
                        .HasForeignKey("IdRole")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Domain.Entity.TaiKhoan", "TaiKhoan")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Quyen");

                    b.Navigation("TaiKhoan");
                });

            modelBuilder.Entity("Domain.Entity.DanhMuc", b =>
                {
                    b.Navigation("SanPhams");
                });

            modelBuilder.Entity("Domain.Entity.Quyen", b =>
                {
                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("Domain.Entity.TaiKhoan", b =>
                {
                    b.Navigation("UserRoles");
                });
#pragma warning restore 612, 618
        }
    }
}
