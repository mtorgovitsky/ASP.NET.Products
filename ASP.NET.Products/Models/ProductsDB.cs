using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.NET.Products.Models
{
    public class ProductsDB
    {
        public List<Product> Products { get; set; }

        public ProductsDB()
        {
            Products = new List<Product>
            {
                new Product { PictureID = 1, ImagePath = @"C:\Users\Default\Desktop\05.02.2017\ASP.NET.Products\ASP.NET.Products\images\1.jpg", Discription = "Discription1"},
                new Product { PictureID = 2, ImagePath = @"C:\Users\Default\Desktop\05.02.2017\ASP.NET.Products\ASP.NET.Products\images\2.jpg", Discription = "Discription2"},
                new Product { PictureID = 3, ImagePath = @"C:\Users\Default\Desktop\05.02.2017\ASP.NET.Products\ASP.NET.Products\images\3.jpg", Discription = "Discription3"},
                new Product { PictureID = 4, ImagePath = @"C:\Users\Default\Desktop\05.02.2017\ASP.NET.Products\ASP.NET.Products\images\4.jpg", Discription = "Discription4"},
                new Product { PictureID = 5, ImagePath = @"C:\Users\Default\Desktop\05.02.2017\ASP.NET.Products\ASP.NET.Products\images\5.jpg", Discription = "Discription4"}

            };
        }
    }
}