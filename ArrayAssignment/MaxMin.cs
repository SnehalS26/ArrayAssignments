using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAssignment
{
    internal class MaxMin
    {
        static void Main(string[] args)
        {
            int max, min;
            //                     0   1
            int[] arr = new int[] { 56, 34, 89, 12, 45, 99, 78, 11, 55, 10 };

            max = arr[0];// assume  56
            min = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }

            Console.WriteLine($"max = {max} and min ={min}");
        }
        
    }
}
