using ShopHaXinh.Data.Entities;
using ShopHaXinh.Data.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopHaXinh.Data.Extentions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        { 
            modelBuilder.Entity<Language>().HasData(
                new Language() { Id = "vi", Name = "Tiếng Việt", IsDefault = true },
                new Language() { Id = "en", Name = "English", IsDefault = false }
                );
            #region Seed Category
            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = 1,
                    Name = "iPhone"
                },

                new Category()
                {
                    Id = 2,
                    Name = "Samsung"
                },

                new Category()
                {
                    Id = 3,
                    Name = "Oppo"
                },

                new Category()
                {
                    Id = 4,
                    Name = "Vivo"
                },

                new Category()
                {
                    Id = 5,
                    Name = "Xiaomi"
                },

                new Category()
                {
                    Id = 6,
                    Name = "Nokia"
                }
              );
            #endregion

            #region Seed Product
            modelBuilder.Entity<Product>().HasData(
                 new Product()
                 {
                     Id = 1,
                     Name = "Esprit Ruffle Shirt",
                     CategoryId = 1,
                     Price = 16000,
                     Stock = 5,
                     Tag = "Fashion",
                     DateCreated = DateTime.Now,
                     Description = "Nulla eget sem vitae eros pharetra viverra. Nam vitae luctus ligula. Mauris consequat ornare feugiat.",
                     Details = ""
                 },

                new Product()
                {
                    Id = 2,
                    Name = "Lightweight Jacket",
                    CategoryId = 2,
                    Price = 20990000,
                    Stock = 5,
                    Tag = "Fashion",
                    DateCreated = DateTime.Now,
                    Description = "Nulla eget sem vitae eros pharetra viverra. Nam vitae luctus ligula. Mauris consequat ornare feugiat.",
                    Details = ""
                },

                new Product()
                {
                    Id = 3,
                    Name = "Only Check Trouser",
                    CategoryId = 3,
                    Price = 8290000,
                    Stock = 5,
                    Tag = "Fashion",
                    DateCreated = DateTime.Now,
                    Description = "Hình ảnh là do shop chụp 100%",
                    Details = ""
                },

                new Product()
                {
                    Id = 4,
                    Name = "Classic Trench Coat",
                    CategoryId = 4,
                    Price = 9990000,
                    Stock = 5,
                    Tag = "Fashion",
                    DateCreated = DateTime.Now,
                    Description = "- Hình ảnh là do shop chụp 100%",
                    Details = ""
                },

                new Product()
                {
                    Id = 5,
                    Name = "Front Pocket Jumper",
                    CategoryId = 5,
                    Price = 5090000,
                    Stock = 5,
                    Tag = "Fashion",
                    DateCreated = DateTime.Now,
                    Description = "- Hình ảnh là do shop chụp 100%",
                    Details = ""
                },

                new Product()
                {
                    Id = 6,
                    Name = "Vintage Inspired Classic",
                    CategoryId = 6,
                    Price = 3290000,
                    Stock = 5,
                    Tag = "Fashion",
                    DateCreated = DateTime.Now,
                    Description = "- Hình ảnh là do shop chụp 100%",
                    Details = ""
                }
             );
            #endregion

            // tạo data cho user mặc định
            // any guid
            var roleId = new Guid("8D04DCE2-969A-435D-BBA4-DF3F325983DC");
            var adminId = new Guid("69BD714F-9576-45BA-B5B7-F00649BE00DE");

            modelBuilder.Entity<AppRole>().HasData(
            new AppRole
            {
                Id = roleId,
                Name = "admin",
                NormalizedName = "admin",
                Description = "Administrator role"
            }
            );
            var hasher = new PasswordHasher<AppUser>();
            modelBuilder.Entity<AppUser>().HasData(new AppUser
            {
                Id = adminId,
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "huybka1996@gmail.com",
                PhoneNumber = "0384387170",
                Address = "Văn Khê,Mê Linh, Hà Nội",
                NormalizedEmail = "HUYBKA1996@GMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Huy@123"),
                SecurityStamp = string.Empty,
                Name = "Huy Nguyễn",
            }); 
            // gán role admin và admin user
            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = roleId,
                UserId = adminId
            });
        }
    }
}
