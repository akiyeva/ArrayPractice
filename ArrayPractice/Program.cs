using System;

namespace ArrayPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int lastIdx = numbers.Length - 1;

            for (int i = lastIdx; i >= 0; i--)
            {
                Console.WriteLine(numbers[i]);
            }
            #endregion
        }
    }
}
