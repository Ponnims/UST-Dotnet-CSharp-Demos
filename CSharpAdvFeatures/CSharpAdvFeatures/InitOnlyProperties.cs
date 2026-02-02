using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAdvFeatures
{

    class Product
    {   
        public string Name { get; init; }
        public decimal Price { get; init; }

        public Product()
        {
           Name=string.Empty;
           Price=0.0m;
        }

    }
    internal class InitOnlyProperties
    {
        static void Main(string[] args)
        {
            Product product = new Product {Name = "Laptop",Price = 999.99m};

           // product.Name="Desktop"; // This line will cause a compile-time error



        }
    }
}
