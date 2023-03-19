
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Console;


namespace Delegate
{
    public delegate void DelegateInt(ref int[] arr);
    internal class Program
    {
        public static void EvenNumbers(ref int[] arr)
        {
            int size = 0;
            int[] new_arr = new int[arr.Length];
            int j = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    new_arr[j] = arr[i];
                    j++;
                    ++size;
                }
            }
            Array.Resize(ref new_arr, size);
            arr = new_arr;
            WriteLine("Even numbers:");
            for (int i = 0; i < new_arr.Length; i++)
            {
                Write(arr[i] + " ");
            }
            WriteLine();
            WriteLine("**************************************");
        }
        public static void Reverse(ref int[] arr)
        {
            WriteLine("Reversed numbers:");
            Array.Reverse(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Write(arr[i] + " ");
            }
            WriteLine("\n**************************************");

        }
        public static void Sorting(ref int[] arr)
        {
            WriteLine("Sorted numbers:");

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int k = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = k;
                    }
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Write(arr[i] + " ");
            }
            WriteLine();
            WriteLine("**************************************");

        }

        static void Main(string[] args)
        {
            int[] arr = { 2, 78, 99, 18, 117, 93, 19, 102, 81, 113, 125, 61, 10 };
            WriteLine("Set of numbers:");
            foreach (var item in arr)
            {
                Write(item + " ");
            }
            WriteLine();
            WriteLine("**************************************");
            DelegateInt d1 = null;
            DelegateInt d2 = new DelegateInt(ref EvenNumbers);
            DelegateInt d3 = new DelegateInt(ref Reverse);
            DelegateInt d4 = new DelegateInt(ref Sorting);
            d1 = d2 + d3 + d4;
            d1(ref arr);


        }
    }
}
