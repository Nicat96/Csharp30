using TASK_3;

namespace P235
{
    class Program 
    {
        static void Main(string[] args) 
        {
            Product bakeryProduct = new Product(ProductType.Bakery, 10.0m);
            Console.WriteLine("Bakery Product Code: " + bakeryProduct.Code);
            Console.WriteLine("Bakery Product Discounted Price: " + bakeryProduct.DiscountedPrice);

            Product drinkProduct = new Product(ProductType.Drink, 5.0m);
            Console.WriteLine("Drink Product Code: " + drinkProduct.Code);
            Console.WriteLine("Drink Product Discounted Price: " + drinkProduct.DiscountedPrice);

            Console.WriteLine("Total Product Count: " + drinkProduct.TotalCount);
        }




    }
    
    
}









