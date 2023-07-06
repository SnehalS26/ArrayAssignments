using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//WAP to create an array of 5 integers. Initialize 5 values. Display using foreach loop.
namespace ArrayAssignment
{
    public class ArrayDisplay
    {
        static void Main(string[] args)
        {
            int[] numb = new int[5] { 11, 12, 13, 14, 15 };
            foreach (var item in numb)
            {
                Console.WriteLine(item);
            }
        }
    }
}
