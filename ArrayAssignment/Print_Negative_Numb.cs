using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//WAP to print all negative elements in an array and also count total number of negative elements in an array.
namespace ArrayAssignment
{
    public class Print_Negative_Numb
    {
        static void Main(string[] args)
        {
            int[] array = new int[8];
            Console.WriteLine("Enter Array Elements");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    count++;
                    Console.Write(" " + array[i] + " ");
                }
            }
            Console.WriteLine($"\nCount of Negative Numbers is = {count}");
        }
    }
}
