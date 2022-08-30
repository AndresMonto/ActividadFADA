using System;
using System.Collections.Generic;

namespace BinarySearch
{
    public class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in SortArray(new(){ 3, 4, 5, 7, 1, 10, 2, 15, 8 }))
            {
                Console.Write(item + " - ");
            }
            
        }

        public static List<int> SortArray(List<int> arr)  {

            int count = 0;

            for (int i = arr.Count-1; i > 0 && (count != arr.Count); i--)
            {
                int current = arr[i];
                int previous = arr[i - 1];

                if (current > previous)
                {
                    int val = previous;
                    arr[i - 1] = current;
                    arr[i] = val;
                }

                if (i == 1)
                {
                    count++;
                    i = arr.Count;
                }               

            }

            return arr;

        }

    }
}
