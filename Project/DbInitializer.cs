using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project.Common.Entities;
using Project.MySQL.Data;
using Project.SQLServer.Data;

namespace Project.Web
{
    //class init data
    public static class DbInitializer
    {
        internal static void Initialize(ApplicationDbContextSQL context) //(rename ApplicationDbContext for MySQL)
        {
            //context.Database.EnsureCreated();

            ////look for any products
            //if (!context.Products.Any())
            //{
            //    return; //db has been seeded
            //}

            var products = new Product[]
            {
                new Product
                {
                    Name="Macbook Pro 2016",
                    Amount= 2,
                    Description="LCD screen 15 inches, 2.3GHz dual-core Intel Core i5, Turbo Boost up to 3.6GHz, with 4MB shared L3 cache",
                    Price= 1500,
                    ImageUrl="./img/product01.png",
                    ProductType= Common.Enum.ProductType.Laptop,
                    Trend= Common.Enum.Trend.NewProduct,
                    CreatedAt= DateTime.UtcNow,
                },
                 new Product
                {
                    Name="Headphone",
                    Amount= 4,
                    Description="The top-rated QC35 adds a direct connection to Google Assistant",
                    Price= 300,
                    ImageUrl="./img/product02.png",
                    ProductType= Common.Enum.ProductType.Heaphone,
                    Trend= Common.Enum.Trend.NewProduct,
                    CreatedAt= DateTime.UtcNow,
                },
                   new Product
                {
                    Name="Macbook Pro 2017",
                    Amount= 1,
                    Description="LCD screen 15 inches, 2.5GHz dual-core Intel Core i7, Turbo Boost up to 3.6GHz, with 6MB shared L3 cache",
                    Price= 2500,
                    ImageUrl="./img/product03.png",
                    ProductType= Common.Enum.ProductType.Laptop,
                    Trend= Common.Enum.Trend.NewProduct,
                    CreatedAt= DateTime.UtcNow,
                },
                   new Product
                {
                    Name="SONY Xperia Z4 Tablet",
                    Amount= 3,
                    Description="10.1 inches,Qualcomm Snapdragon 810, Quad-core 1.5 GHz Cortex-A53 & Quad-core 2.0 GHz Cortex-A57",
                    Price= 2500,
                    ImageUrl="./img/product04.png",
                    ProductType= Common.Enum.ProductType.Tablet,
                    Trend= Common.Enum.Trend.NewProduct,
                    CreatedAt= DateTime.UtcNow,
                },
                   new Product
                {
                    Name="SONY CH400 Wireless Headphones",
                    Amount= 1,
                    Description="Near Field Communication (NFC) technology, Keep music going with up to 20 h of long-lasting battery.3",
                    Price= 2500,
                    ImageUrl="./img/product05.png",
                    ProductType= Common.Enum.ProductType.Heaphone,
                    Trend= Common.Enum.Trend.NewProduct,
                    CreatedAt= DateTime.UtcNow,
                },

            };

            //save to db
            context.AddRange(products);
            context.SaveChanges();

            //add hot product 
            var hotproducts = new Product[]
            {
                 new Product
                {
                    Name="MSI GP73 8RE-073VN",
                    Amount= 2,
                    Description="LCD screen 17.3 inches, 2.3GHz quad-core Intel Core i7, Ram 8GB, 125GB SSD",
                    Price= 1500,
                    ImageUrl="./img/product06.png",
                    ProductType= Common.Enum.ProductType.Laptop,
                    Trend= Common.Enum.Trend.HotProduct,
                    CreatedAt= DateTime.UtcNow,
                },
                  new Product
                {
                    Name="SamSung Galaxy S6 Edge",
                    Amount= 5,
                    Description="Super amoled, quad HD 2k",
                    Price= 500,
                    ImageUrl="./img/product07.png",
                    ProductType= Common.Enum.ProductType.Phone,
                    Trend= Common.Enum.Trend.HotProduct,
                    CreatedAt= DateTime.UtcNow,
                },
                  new Product
                {
                    Name="ASUS UX370UA-C4217TS",
                    Amount= 2,
                    Description="Intel® Core™ i5-6550U 1.8GHz",
                    Price= 700,
                    ImageUrl="./img/product08.png",
                    ProductType= Common.Enum.ProductType.Laptop,
                    Trend= Common.Enum.Trend.HotProduct,
                    CreatedAt= DateTime.UtcNow,
                },
                    new Product
                {
                    Name="Rekcam Digital Camera",
                    Amount= 2,
                    Description="Capture with 23MP",
                    Price= 700,
                    ImageUrl="./img/product09.png",
                    ProductType= Common.Enum.ProductType.Camera,
                    Trend= Common.Enum.Trend.HotProduct,
                    CreatedAt= DateTime.UtcNow,
                },

            };

            //save to db
            context.AddRange(hotproducts);
            context.SaveChanges();

            //add normal product

            //add accessory (phụ kiện)

        }
    }
}
