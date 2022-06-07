/* using System;
using System.Collections.Generic;

namespace NetDiretoAoPonto.ArraysListasLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Array 
            var numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var numbersCopy = new int[10];


            // 0-based ( o i de indice )

            for (var i = 0; i < numbers.Length; i++)
            {
                numbersCopy[i] = numbers[i];
            }

            var numbersString = "1 2 3 4 5 6 7 8 9 10";
            var numbersArray = numbersString.Split(' ');
            var numbersConvertedFromString = Array.ConvertAll(numbersArray, Convert.ToInt32);


            #endregion Array

            #region Listas
            var list = new List<int> { 0, 1, 2, 3, 4 };
            var listFromArray = new List<int>(numbers);

            list.Add(5);
            list.AddRange(new List<int> { 6, 7 });
            list.AddRange(new int[] { 8, 9 });

            var count = list.Count;
            var contains14 = list.Contains(14);
            var contais2 = list.Contains(2);

            Console.WriteLine("Lista reversa: ");
            list.Reverse();
            list.ForEach(l => Console.WriteLine(1));

            Console.WriteLine("Lista ordenada: ");
            list.Sort();
            list.ForEach(l => Console.WriteLine(1));

            list.Remove(4);
            list.RemoveAll(l => l > 5 );

            list.Clear();



            #endregion Listas

            Console.ReadKey();
        }
    }
} */ 