using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project.Common.Entities;
using Project.MySQL.Data;
using Project.SQLServer.Data;
//using Project.SQLServer.Data;

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
                    ImageUrl="/img/product01.png",
                    ProductType= Common.Enum.ProductType.Laptop,
                    Trend= Common.Enum.Trend.NewProduct,
                    CreatedAt= DateTime.UtcNow,
                    Rating=1,
                },
                 new Product
                {
                    Name="Headphone",
                    Amount= 4,
                    Description="The top-rated QC35 adds a direct connection to Google Assistant",
                    Price= 300,
                    ImageUrl="/img/product02.png",
                    ProductType= Common.Enum.ProductType.Heaphone,
                    Trend= Common.Enum.Trend.NewProduct,
                    CreatedAt= DateTime.UtcNow,
                    Rating=4,
                },
                   new Product
                {
                    Name="Macbook Pro 2017",
                    Amount= 1,
                    Description="LCD screen 15 inches, 2.5GHz dual-core Intel Core i7, Turbo Boost up to 3.6GHz, with 6MB shared L3 cache",
                    Price= 2500,
                    ImageUrl="/img/product03.png",
                    ProductType= Common.Enum.ProductType.Laptop,
                    Trend= Common.Enum.Trend.NewProduct,
                    CreatedAt= DateTime.UtcNow,
                    Rating=3,
                },
                   new Product
                {
                    Name="SONY Xperia Z4 Tablet",
                    Amount= 3,
                    Description="10.1 inches,Qualcomm Snapdragon 810, Quad-core 1.5 GHz Cortex-A53 & Quad-core 2.0 GHz Cortex-A57",
                    Price= 2500,
                    ImageUrl="/img/product04.png",
                    ProductType= Common.Enum.ProductType.Tablet,
                    Trend= Common.Enum.Trend.NewProduct,
                    CreatedAt= DateTime.UtcNow,
                    Rating=3,
                },
                   new Product
                {
                    Name="SONY CH400 Wireless Headphones",
                    Amount= 1,
                    Description="Near Field Communication (NFC) technology, Keep music going with up to 20 h of long-lasting battery.3",
                    Price= 2500,
                    ImageUrl="/img/product05.png",
                    ProductType= Common.Enum.ProductType.Heaphone,
                    Trend= Common.Enum.Trend.NewProduct,
                    CreatedAt= DateTime.UtcNow,
                    Rating=4,
                },

                    new Product
                {
                    Name="IPHONE X 64GB",
                    Amount= 100,
                    Description="Thông số kỹ thuật Màn hình:OLED, 5.8, Super Retina Hệ điều hành:iOS 11 Camera sau: camera 12 MP Camera trước:7 MP CPU:Apple A11 Bionic 6 nhân RAM:3 GB  Bộ nhớ trong:256 GB Thẻ SIM: 1 Nano SIM, Hỗ trợ 4G Dung lượng pin: 2716 mAh, có sạc nhanh",
                    Price= 290000000,
                    ImageUrl="/img/iphone-x.png",
                    ProductType= Common.Enum.ProductType.Phone,
                    Trend= Common.Enum.Trend.NewProduct,
                    CreatedAt= DateTime.UtcNow,
                    Rating=2,
                },
                    new Product
                {
                    Name="Samsung S8",
                    Amount= 300,
                    Description="Thông số kỹ thuật Màn hình:Super AMOLED, 5.8, Quad HD+(2K +) Hệ điều hành:Android 7.0(Nougat)Camera sau12 MPCamera trước:8 MPCPU:Exynos 8895 8 nhân 64 - bitRAM:4 GBBộ nhớ trong:64 GBThẻ nhớ:MicroSD, hỗ trợ tối đa 256 GB Thẻ SIM:2 SIM Nano(SIM 2 chung khe thẻ nhớ), Hỗ trợ 4G HOT Mua sim Mobi Big 60(3GB data / tháng).Giá từ 80.000đ Dung lượng pin:3000 mAh, có sạc nhanh",
                    Price= 15000000,
                    ImageUrl="/img/samsung-s8.png",
                    ProductType= Common.Enum.ProductType.Phone,
                    Trend= Common.Enum.Trend.NewProduct,
                    CreatedAt= DateTime.UtcNow,
                    Rating=3,
                },
                    new Product
                {
                    Name="Samsung A8",
                    Amount= 500,
                    Description="Thông số kỹ thuật Màn hình:Super AMOLED, 6, Full HD+ Hệ điều hành:Android 7.1(Nougat) Camera sau:16 MP Camera trước:16 MP và 8 MP CPU: Exynos 7885 8 nhân 64 - bit RAM: 6 GB Bộ nhớ trong: 64 GB Thẻ nhớ:MicroSD, hỗ trợ tối đa 256 GB Thẻ SIM: 2 Nano SIM, Hỗ trợ 4G HOT Mua sim Mobi Big 60(3GB data / tháng).Giá từ 80.000đDung lượng pin: 3500 mAh, có sạc nhanh ",
                    Price= 13000000,
                    ImageUrl="/img/samsung-a8.png",
                    ProductType= Common.Enum.ProductType.Phone,
                    Trend= Common.Enum.Trend.NewProduct,
                    CreatedAt= DateTime.UtcNow,
                    Rating=4,
                },
                    new Product
                {
                    Name="Iphone 6SPLUS",
                    Amount= 400,
                    Description="Thông số kỹ thuật Màn hình: LED-backlit IPS LCD, 5.5, Retina HD Hệ điều hành:iOS 11 Camera sau:12 MP Camera trước:5 MP CPU:Apple A9 2 nhân 64-bit RAM:2 GB Bộ nhớ trong:32 GB Thẻ SIM:1 Nano SIM, Hỗ trợ 4G HOT Mua sim Mobi Big 60 (3GB data/ tháng). Giá từ 80.000đ Dung lượng pin:2750 mAh",
                    Price= 12000000,
                    ImageUrl="/img/iphone-6s-plus.png",
                    ProductType= Common.Enum.ProductType.Phone,
                    Trend= Common.Enum.Trend.NewProduct,
                    CreatedAt= DateTime.UtcNow,
                    Rating=5,
                },
                    new Product
                {
                    Name="Sony Xperia",
                    Amount= 250,
                    Description="Thông số kỹ thuật Màn hình:IPS HDR LCD, 5.2, Full HD Hệ điều hành:Android 8.0 (Oreo) Camera sau:19 MP Camera trước:13 MP CPU:Qualcomm Snapdragon 835 8 nhân 64-bitRAM:4 GB Bộ nhớ trong:64 GB Thẻ nhớ:MicroSD, hỗ trợ tối đa 256 GB Thẻ SIM:2 Nano SIM, Hỗ trợ 4G Dung lượng pin:2700 mAh, có sạc nhanh",
                    Price= 11000000,
                    ImageUrl="/img/sony-xperia-xz1.png",
                    ProductType= Common.Enum.ProductType.Phone,
                    Trend= Common.Enum.Trend.NewProduct,
                    CreatedAt= DateTime.UtcNow,
                    Rating=3,
                },
                    new Product
                {
                    Name="Huawei P20 Pro",
                    Amount= 50,
                    Description="Thông số kỹ thuật Màn hình:IPS LCD, 5.84, Full HD+ Hệ điều hành:Android 8.0 (Oreo) Camera sau:16 MP và 2 MP (2 camera) Camera trước:16 MP CPU:HiSilicon Kirin 659 8 nhân RAM:4 GB Bộ nhớ trong:64 GB Thẻ nhớ:MicroSD, hỗ trợ tối đa 256 GB Thẻ SIM:2 Nano SIM, Hỗ trợ 4G HOT Mua sim Mobi Big 60 (3GB data/ tháng). Giá từ 80.000đ Dung lượng pin:3000 mAh, có sạc nhanh",
                    Price= 7000000,
                    ImageUrl="/img/huawei-p20-pro.png",
                    ProductType= Common.Enum.ProductType.Phone,
                    Trend= Common.Enum.Trend.NewProduct,
                    CreatedAt= DateTime.UtcNow,
                    Rating=4,
                },
                    new Product
                {
                    Name="Oppo F7",
                    Amount= 50,
                    Description="Màn hình:LTPS LCD, 6.23, Full HD+ Hệ điều hành:ColorOS 5.0 (Android 8.1) Camera sau:16 MP Camera trước:25 MP CPU:MediaTek Helio P60 8 nhân 64-bit RAM:6 GB Bộ nhớ trong:128 GB Thẻ nhớ:MicroSD, hỗ trợ tối đa 256 GB Thẻ SIM:2 Nano SIM, Hỗ trợ 4G HOT Mua sim Mobi Big 60 (3GB data/ tháng). Giá từ 80.000đ Dung lượng pin:3400 mAh",
                    Price= 10000000,
                    ImageUrl="/img/oppo-f7.png",
                    ProductType= Common.Enum.ProductType.Phone,
                    Trend= Common.Enum.Trend.NewProduct,
                    CreatedAt= DateTime.UtcNow,
                    Rating=3,
                },
                    new Product
                {
                    Name="Vivo V9",
                    Amount= 50,
                    Description="Thông số kỹ thuật Màn hình:IPS LCD, 6.3, Full HD+ Hệ điều hành:Android 8.1 (Oreo) Camera sau:16 MP và 5 MP (2 camera) Camera trước:24 MP CPU:Snapdragon 626 8 nhân 64-bit RAM:4 GB Bộ nhớ trong:64 GB Thẻ nhớ:MicroSD, hỗ trợ tối đa 256 GB Thẻ SIM:2 Nano SIM, Hỗ trợ 4G Dung lượng pin:3260 mAh",
                    Price= 8000000,
                    ImageUrl="/img/vivo-v9.png",
                    ProductType= Common.Enum.ProductType.Phone,
                    Trend= Common.Enum.Trend.NewProduct,
                    CreatedAt= DateTime.UtcNow,
                    Rating=3,
                },
                    new Product
                {
                    Name="Nokia 7",
                    Amount= 30,
                    Description="Thông số kỹ thuật Màn hình:IPS LCD, 6, Full HD+ Hệ điều hành:Android 8.0 (Oreo) Camera sau:12 MP và 13 MP (2 camera) Camera trước:16 MP CPU:Qualcomm Snapdragon 660 8 nhân RAM:4 GB Bộ nhớ trong:64 GB Thẻ nhớ:MicroSD, hỗ trợ tối đa 256 GB Thẻ SIM:2 SIM Nano (SIM 2 chung khe thẻ nhớ), Hỗ trợ 4G Dung lượng pin:3800 mAh",
                    Price= 9000000,
                    ImageUrl="/img/nokia-7.png",
                    ProductType= Common.Enum.ProductType.Phone,
                    Trend= Common.Enum.Trend.NewProduct,
                    CreatedAt= DateTime.UtcNow,
                    Rating=3,
                },
                    new Product
                {
                    Name="HTC U",
                    Amount= 30,
                    Description="Thông số kỹ thuật Màn hình:LTPS LCD, 6.0, Full HD+ Hệ điều hành:ColorOS 5.0 (Android 8.1 )Camera sau:13 MP Camera trước:8 MP CPU:MediaTek Helio P60 8 nhân 64-bit RAM:4 GB Bộ nhớ trong:64 GB Thẻ nhớ:MicroSD, hỗ trợ tối đa 256 GB Thẻ SIM:2 Nano SIM, Hỗ trợ 4G HOT Mua sim Mobi Big 60 (3GB data/ tháng). Giá từ 80.000đ Dung lượng pin:3410 mAh",
                    Price= 3000000,
                    ImageUrl="/img/htc-u.png",
                    ProductType= Common.Enum.ProductType.Phone,
                    Trend= Common.Enum.Trend.NewProduct,
                    CreatedAt= DateTime.UtcNow,
                    Rating=4,
                },
                    new Product
                {
                    Name="Laptop DELL",
                    Amount= 30,
                    Description="Mô tả CPU: Intel Core i7-8550U (1.80 Ghz up to 4.0 Ghz, 8M Cache) RAM: 8GB DDR4 2400 MHz (2 slots) VGA: AMD 530 4GB + Intel UHD Graphics 620 Ổ cứng: HDD 2TB 5400rpm Hỗ trợ khe cắm M.2: M.2 SATA/NVMe Màn hình: 15.6 (1920 x 1080), Webcam Cổng giao tiếp: HDMI, USB Type-C/DP, 2x USB 3.0, USB 2.0 Wifi AC, LAN 100Mbit, Bluetooth 4.1DVD-RW, Card reader, Led Keyboard Khối lượng: 2.12 Kg, pin 3 cell Hệ điều hành: Win 10 Home",
                    Price= 39000000,
                    ImageUrl="/img/dell_xps13_silver.jpg",
                    ProductType= Common.Enum.ProductType.Laptop,
                    Trend= Common.Enum.Trend.NewProduct,
                    CreatedAt= DateTime.UtcNow,
                    Rating=3,
                },
                    new Product
                {
                    Name="Laptop Lenovo",
                    Amount= 30,
                    Description="Mô tả CPU: Intel Core i7-8550U (1.80 Ghz up to 4.0 Ghz, 8M Cache) RAM: 8GB DDR4 2400 MHz (2 slots) VGA: AMD 530 4GB + Intel UHD Graphics 620 Ổ cứng: HDD 2TB 5400rpm Hỗ trợ khe cắm M.2: M.2 SATA/NVMe Màn hình: 15.6 (1920 x 1080), Webcam Cổng giao tiếp: HDMI, USB Type-C/DP, 2x USB 3.0, USB 2.0 Wifi AC, LAN 100Mbit, Bluetooth 4.1DVD-RW, Card reader, Led Keyboard Khối lượng: 2.12 Kg, pin 3 cell Hệ điều hành: Win 10 Home",
                    Price= 15000000,
                    ImageUrl="/img/laptop_lenovo_ideapad.jpg",
                    ProductType= Common.Enum.ProductType.Laptop,
                    Trend= Common.Enum.Trend.NewProduct,
                    CreatedAt= DateTime.UtcNow,
                    Rating=2,
                },
                    new Product
                {
                    Name="Laptop Acer",
                    Amount= 30,
                    Description="Mô tả CPU: Intel Core i7-8550U (1.80 Ghz up to 4.0 Ghz, 8M Cache) RAM: 8GB DDR4 2400 MHz (2 slots)VGA: AMD 530 4GB + Intel UHD Graphics 620 Ổ cứng: HDD 2TB 5400rpm  Hỗ trợ khe cắm M.2: M.2 SATA/NVMe Màn hình: 15.6 (1920 x 1080), Webcam Cổng giao tiếp: HDMI, USB Type-C/DP, 2x USB 3.0, USB 2.0Wifi AC, LAN 100Mbit, Bluetooth 4.1DVD-RW, Card reader, Led Keyboard Khối lượng: 2.12 Kg, pin 3 cell Hệ điều hành: Win 10 Home",
                    Price= 23000000,
                    ImageUrl="/img/laptop_acer_nitro.jpg",
                    ProductType= Common.Enum.ProductType.Laptop,
                    Trend= Common.Enum.Trend.NewProduct,
                    CreatedAt= DateTime.UtcNow,
                    Rating=3,
                },
                    new Product
                {
                    Name="Loa Bluetooth",
                    Amount= 30,
                    Description="Công suất loa lớn cho âm thanh phát ra to, rõ và trầm ấm. Các nút ấn dạng cảm ứng khá nhạy với cú chạm nhẹ. Cách tăng giảm âm lượng độc đáo, tạo sự thích thú. Tự động ngủ sau 15 phút không kết nối hoặc phát nhạc. Có thể nhận và nghe gọi cuộc gọi trực tiếp trên loa. Công nghệ bluetooth 4.0 giúp kết nối tới hơn 10 m.Pin 2.200 mAh, chơi nhạc 12 giờ với âm lượng 75%. Chú ý: Dùng Adapter 5V-1A/2A để sạc cho thiết bị, Adapter trên 5V có thể gây ra hư hỏng cho thiết bị.",
                    Price= 220000,
                    ImageUrl="/img/loa-bluetooth-cloud-fox.png",
                    ProductType= Common.Enum.ProductType.Accessory,
                    Trend= Common.Enum.Trend.NewProduct,
                    CreatedAt= DateTime.UtcNow,
                    Rating=4,
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
                    ImageUrl="/img/product06.png",
                    ProductType= Common.Enum.ProductType.Laptop,
                    Trend= Common.Enum.Trend.HotProduct,
                    CreatedAt= DateTime.UtcNow,
                    Rating=3,
                },
                  new Product
                {
                    Name="SamSung Galaxy S6 Edge",
                    Amount= 5,
                    Description="Super amoled, quad HD 2k",
                    Price= 500,
                    ImageUrl="/img/product07.png",
                    ProductType= Common.Enum.ProductType.Phone,
                    Trend= Common.Enum.Trend.HotProduct,
                    CreatedAt= DateTime.UtcNow,
                    Rating=5,
                },
                  new Product
                {
                    Name="ASUS UX370UA-C4217TS",
                    Amount= 2,
                    Description="Intel® Core™ i5-6550U 1.8GHz",
                    Price= 700,
                    ImageUrl="/img/product08.png",
                    ProductType= Common.Enum.ProductType.Laptop,
                    Trend= Common.Enum.Trend.HotProduct,
                    CreatedAt= DateTime.UtcNow,
                    Rating=3,
                },
                    new Product
                {
                    Name="Rekcam Digital Camera",
                    Amount= 2,
                    Description="Capture with 23MP",
                    Price= 700,
                    ImageUrl="/img/product09.png",
                    ProductType= Common.Enum.ProductType.Camera,
                    Trend= Common.Enum.Trend.HotProduct,
                    CreatedAt= DateTime.UtcNow,
                    Rating=1,
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
