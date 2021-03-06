﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Program
    {
        static Random rand = new Random();
        static void Main(string[] args)
        {
            int[] arr = new int[100];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(0, 1000);
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Sort(arr, 0, arr.Length - 1);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.ReadKey();
        }

        static void Sort(int[] arr, int start, int finish)
        {
            int i = start;
            int j = finish;
            int elem = arr[(start + finish) / 2];
            int temp;
            while (i <= j)
            {
                while (arr[i] < elem)
                {
                    i++;
                }
                while (arr[j] > elem)
                {
                    j--;
                }
                if (i <= j)
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    i++;
                    j--;
                }
            }
            if (i < finish)
            {
                Sort(arr, i, finish);
            }
            if (j > start)
            {
                Sort(arr, start, j);
            }
        }
    }
}
