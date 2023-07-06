using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// WAP to print all unique elements in the array.
namespace ArrayAssignment
{
    public class Unique_Element_Array
    {
        static void Main(string[] args)
        {
            int[] array = new int[10] { 1, 2, 3, 4, 5, 6, 1, 2, 3, 4 };


            for (int i = 0; i < array.Length; i++)
            {
                int a = 0;
                for (int j = 0; j < i; j++)
                {
                    if (array[i] == array[j])
                    {
                        a = 1;
                        break;
                    }
                }
                if (a == 0)
                {
                    Console.WriteLine(array[i]);
                }
            }

        }  
    }
}
