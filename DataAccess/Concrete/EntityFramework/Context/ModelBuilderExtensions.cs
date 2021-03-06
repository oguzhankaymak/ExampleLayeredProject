﻿using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework.Context
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    CategoryName = "Elektronik"

                },
                new Category
                {
                    Id = 2,
                    CategoryName = "Süt Ürünleri"

                },
                new Category
                {
                    Id = 3,
                    CategoryName = "İçecekler"

                },
                new Category
                {
                    Id = 4,
                    CategoryName = "Unlu Mamüller"

                });

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    ProductName = "Dell Bilgisayar",
                    UnitPrice = 4500,
                    UnitsInStock = 100,
                    QuantityPerUnit = "PC",
                    CategoryId = 1

                },
                new Product
                {
                    Id = 2,
                    ProductName = "Casper Bilgisayar",
                    UnitPrice = 2000,
                    UnitsInStock = 100,
                    QuantityPerUnit = "PC",
                    CategoryId = 1

                },
                new Product
               {
                   Id = 3,
                   ProductName = "Huaweı Akıllı Telefon",
                   UnitPrice = 2200,
                   UnitsInStock = 100,
                   QuantityPerUnit = "Telefon",
                   CategoryId = 1

               },
                new Product
                {
                    Id = 4,
                    ProductName = "Sütaş Yoğurt",
                    UnitPrice = 10,
                    UnitsInStock = 10000,
                    QuantityPerUnit = "1000ml yoğurt",
                    CategoryId = 2

                },
                new Product
               {
                   Id = 5,
                   ProductName = "Fanta",
                   UnitPrice = 5,
                   UnitsInStock = 10000,
                   QuantityPerUnit = "2,5 lt kola",
                   CategoryId = 3

               },
                new Product
              {
                  Id = 6,
                  ProductName = "Coca Cola",
                  UnitPrice = 5,
                  UnitsInStock = 10000,
                  QuantityPerUnit = "2,5 lt kola",
                  CategoryId = 3

              },
                new Product
              {
                  Id = 7,
                  ProductName = "Poğaça",
                  UnitPrice = 2,
                  UnitsInStock = 10000,
                  QuantityPerUnit = "1 adet poğaça",
                  CategoryId = 4

              },
                new Product
                {
                    Id = 8,
                    ProductName = "Simit",
                    UnitPrice = 2,
                    UnitsInStock = 10000,
                    QuantityPerUnit = "1 adet simit",
                    CategoryId = 4

                },
                new Product
                {
                    Id = 9,
                    ProductName = "Kıymalı Pide",
                    UnitPrice = 12,
                    UnitsInStock = 10000,
                    QuantityPerUnit = "1 adet kıymalı pide",
                    CategoryId = 4

                },
                new Product
                {
                    Id = 10,
                    ProductName = "Kurabiye",
                    UnitPrice = 18,
                    UnitsInStock = 10000,
                    QuantityPerUnit = "1 kg kurabiye",
                    CategoryId = 4

                });

            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    Username = "oguzhankaymak",
                    Password = "123"

                });
        }
    }
}
