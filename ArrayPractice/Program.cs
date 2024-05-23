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


            #region Task2
            int[] arr1 = { 1, 2, 3 };
            int[] arr2 = { 1, 2, 4, 5, 3 };
            bool allIncluded = true;

            for (int i = 0; i < arr1.Length; i++)
            {
                bool isFound = false;
                for (int j = 0; j < arr2.Length; j++)
                {
                    if (arr1[i] == arr2[j])
                    {
                        isFound = true;
                        break;
                    }
                }
                if (!isFound)
                {
                    allIncluded = false;
                    break;
                }
            }

            if (allIncluded)
            {
                Console.WriteLine("All numbers from the first array are included in the second array.");
            }
            else
            {
                Console.WriteLine("Not all numbers from the first array are included in the second array.");
            }
            #endregion
        }
    }
}
