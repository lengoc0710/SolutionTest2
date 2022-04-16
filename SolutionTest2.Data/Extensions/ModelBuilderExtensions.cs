using Microsoft.EntityFrameworkCore;
using SolutionTest2.Data.Entities;
using SolutionTest2.Data.EnumTest;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolutionTest2.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppConfig>().HasData(
                new AppConfig() { Key = "HomeTitle", Value = "This is homepage of SolutionTest" },
             new AppConfig() { Key = "HomeKeyword", Value = "This is  keyword of SolutionTest" },
            new AppConfig() { Key = "HomeDescription", Value = "This is description of SolutionTest" });
            modelBuilder.Entity<Language>().HasData(
            new Language() { Id = "vi", Name = "Tiếng Việt", IsDefault = true },
            new Language() { Id = "en", Name = "English", IsDefault = false }
            );


            modelBuilder.Entity<CategoryTranslation>().HasData(
                new CategoryTranslation() { Id = 1, CategoryId = 1, Name = "Áo nam", LanguageId = "vi", SeoAlias = "ao-nam", SeoDescription = "Sản phẩm áo thời trang nam", SeoTitle = "Sản phẩm áo thời trang nam" },
                new CategoryTranslation() { Id = 2, CategoryId = 1, Name = "Men Shirt", LanguageId = "en", SeoAlias = "men-shirt", SeoDescription = "The shirt products for men", SeoTitle = "The shirt products for men" },
                new CategoryTranslation() { Id = 3, CategoryId = 2, Name = "Áo nữ", LanguageId = "vi", SeoAlias = "ao-nu", SeoDescription = "Sản phẩm áo thời trang nữ", SeoTitle = "Sản phẩm áo thời trang women" },
                new CategoryTranslation() { Id = 4, CategoryId = 2, Name = "Women Shirt", LanguageId = "en", SeoAlias = "women-shirt", SeoDescription = "The shirt products for women", SeoTitle = "The shirt products for women" }
                  );




            modelBuilder.Entity<CategoryTest>().HasData(
              new CategoryTest()
              {
                  ID = 1,
                  OnHome = true,
                  ParentID = null,
                  SortOrder = 1,
                  Status = Status.Active,
                  //CategoryTranslations = new List<CategoryTranslation>() {
                  //new CategoryTranslation() { Id = 1, CategoryId = 1, Name = "Áo nam", LanguageId = "vi", SeoAlias = "ao-nam", SeoDescription = "Sản phẩm áo thời trang nam", SeoTitle = "Sản phẩm áo thời trang nam" },
                  //new CategoryTranslation() { Id = 2, CategoryId = 1, Name = "Men Shirt", LanguageId = "en", SeoAlias = "men-shirt", SeoDescription = "The shirt products for men", SeoTitle = "The shirt products for men" },
              //}

              },
               new CategoryTest()
               {
                   ID = 2,
                   OnHome = true,
                   ParentID = null,
                   SortOrder = 2,
                   Status = Status.Active,
                 //  CategoryTranslations = new List<CategoryTranslation>()
                   
                       //    new CategoryTranslation() { Id = 3, CategoryId = 2, Name = "Áo nữ", LanguageId = "vi", SeoAlias = "ao-nu", SeoDescription = "Sản phẩm áo thời trang nữ", SeoTitle = "Sản phẩm áo thời trang women" },
                       //    new CategoryTranslation() { Id = 4, CategoryId = 2, Name = "Women Shirt", LanguageId = "en", SeoAlias = "women-shirt", SeoDescription = "The shirt products for women", SeoTitle = "The shirt products for women" }
                       //}
                       //}
                   
               }
               );
            modelBuilder.Entity<ProductTest>().HasData(
          new ProductTest()
          {
              ID = 1,
              DateCreated = DateTime.Now,
              FirstPrice = 100000,
              Price = 200000,
              Stock = 0,
              ViewCount = 0,
          });
            modelBuilder.Entity<ProductTranslation>().HasData(
                 new ProductTranslation()
                 {
                     Id = 1,
                     ProductId = 1,
                     Name = "Áo sơ mi nam trắng hiện đại",
                     LanguageId = "vi",
                     SeoAlias = "ao-so-mi-nam-trang-hien-dai ",
                     SeoDescription = "Áo sơ mi nam trắng hiện đại ",
                     SeoTitle = "Áo sơ mi nam trắng hiện đại ",
                     Details = "Áo sơ mi nam trắng hiện đại",
                     Description = "Áo sơ mi nam trắng hiện đại "
                 },
                      new ProductTranslation()
                      {
                          Id = 2,
                          ProductId = 1,
                          Name = "Modern men T-Shirt",
                          LanguageId = "en",
                          SeoAlias = "modern-men-t-shirt",
                          SeoDescription = "Modern  Men T-Shirt",
                          SeoTitle = "Modern Men T-Shirt",
                          Details = "Modern Men T-Shirt",
                          Description = "Modern Men T-Shirt"
                      });
          

            modelBuilder.Entity<ProductInCategory>().HasData(
                    new ProductInCategory() { ProductId = 1, CategoryId = 1 }
                    );


        }

    }
}
