namespace TASK
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region task1
            int[] numbers = { 37, 25, 75, 43, 87, 91, 53, 62, 15 };
            int max = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            Console.WriteLine("the large number: " + max);
            #endregion
            #region Task2
            var product1 = new { id = 1, name = "product1", price = 10, StockCount = 100 };
            var product2 = new { id = 2, name = "product2", price = 20, StockCount = 200 };
            var product3 = new { id = 3, name = "product3", price = 30, StockCount = 300 };
            var product4 = new { id = 4, name = "product4", price = 40, StockCount = 400 };
            var product5 = new { id = 5, name = "product5", price = 50, StockCount = 500 };

            var products = new[] { product1, product2, product3, product4, product5 };
            int sum = 0;
            int count = 0;
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i].id % 2 == 1)
                {
                    sum += products[i].price;
                    count++;

                }
            }
            int avg = sum / count;
            Console.WriteLine(avg);
            #endregion

        }

    }
}
