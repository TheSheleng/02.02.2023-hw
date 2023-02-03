using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _02._02._2023_hw
{
    internal class Program
    {
        static void EndErr(int code)
        {
            Console.WriteLine("Error Task " + code);
            Console.ReadKey();
            Environment.Exit(code);
        }

        static void InitArr(int[] arr, int min, int max)
        {
            Random r = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(min, max);
            }
        }
        static void PrintArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] arr = new int[rnd.Next(10,25)];
            InitArr(arr, 0, 10);
            PrintArr(arr);

            #region Task 1
            int a_i = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 1 && arr[i] > arr[a_i]) a_i = i; 
            }
            a_i++;

            const int rep = 3;
            for (int i = 0; i < rep; i++)
            {
                int temp = arr[a_i];
                for (int y = a_i; y < arr.Length - 1; y++) arr[y] = arr[y + 1];
                arr[arr.Length - 1] = temp; 
            }

            PrintArr(arr);
            #endregion

            #region Task 2
            int[] iNull = { -1, -1 };
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0) { iNull[0] = i; break; }
            }
            for (int i = iNull[0] + 1; i < arr.Length; i++)
            {
                if (arr[i] == 0) { iNull[1] = i; break; }
            }

            int res = 0;
            for (int i = iNull[0]; i < iNull[1]; i++) res += arr[i];
            Console.WriteLine($"Result: {res}");

            #endregion

            #region Task 3
            int find_sum = rnd.Next(20, 40);
            Console.WriteLine($"\nFind: {find_sum}");

            for (int i = 0; i < arr.Length; i++)
            {
                int sum = 0;
                for (int y = i; y < arr.Length; y++)
                {
                    if (sum < find_sum) sum += arr[y];
                    else if (sum > find_sum) break;
                    else 
                    {
                        Console.WriteLine($"Answer: {i}:{y}");
                        break;
                    }
                }
            }
            #endregion

            Console.ReadKey();
        }
    }
}
