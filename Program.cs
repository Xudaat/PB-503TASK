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
        }
    }
}
