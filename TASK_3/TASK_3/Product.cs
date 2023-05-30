using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_3
{
    internal class Product
    {
        public ProductType ProductType { get; }
        public string Code { get; }
        public string Name { get; }
        public decimal Price { get; }
        public decimal DiscountedPrice { get; }
        public int TotalCount { get; private set; }

        private static int bakeryProductCount = 0;
        private static int productCount = 0;

        public Product(ProductType productType, decimal price)
        {
            ProductType = productType;
            Price = price;

            switch (productType)
            {
                case ProductType.Bakery:
                    bakeryProductCount++;
                    Code = "B" + bakeryProductCount.ToString().PadLeft(3, '0');
                    DiscountedPrice = price * 0.9m; // %10 indirim
                    break;
                default:
                    productCount++;
                    Code = productType.ToString().Substring(0, 1) + productCount.ToString().PadLeft(3, '0');
                    DiscountedPrice = price;
                    break;
            }

            TotalCount = bakeryProductCount + productCount;
        }


    }

    enum ProductType
    {
        Bakery=1000,
        Drink,
        Meat,
        Fish
    }
}
