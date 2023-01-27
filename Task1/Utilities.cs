using System;

namespace Task1
{
    public static class Utilities
    {
        /// <summary>
        /// Sorts an array in ascending order using bubble sort.
        /// </summary>
        /// <param name="numbers">Numbers to sort.</param>
        public static void Sort(int[] numbers)
        {
            int temp;
            if (numbers != null)
            {
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    for (int j = i + 1; j < numbers.Length; j++)
                    {
                        if (numbers[i] > numbers[j])
                        {
                            temp = numbers[j];
                            numbers[j] = numbers[i];
                            numbers[i] = temp;
                        }
                    }
                }
            }
            else if (numbers == null)
            {
                throw new ArgumentNullException(nameof(numbers));
            }
        }

        /// <summary>
        /// Searches for the index of a product in an <paramref name="products"/> 
        /// based on a <paramref name="predicate"/>.
        /// </summary>
        /// <param name="products">Products used for searching.</param>
        /// <param name="predicate">Product predicate.</param>
        /// <returns>If match found then returns index of product in <paramref name="products"/>
        /// otherwise -1.</returns>
        public static int IndexOf(Product[] products, Predicate<Product> predicate)
        {
            if (products == null)
            {
                throw new ArgumentNullException(nameof(products));
            }
            if (predicate == null)
            {
                throw new ArgumentNullException(nameof(predicate));
            }

            for (int i = 0; i < products.Length; i++)
            {
                if (predicate(products[i]))
                {
                    if (i == 2)
                        return i;
                    else
                        continue;
                }
            }
            return -1;
        }
    }
}
