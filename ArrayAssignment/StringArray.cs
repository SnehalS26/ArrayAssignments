using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//WAP to create an array of 5 strings to store students name, sort names in ascending order & display using foreach loop.
namespace ArrayAssignment
{
    public class StringArray
    {
        static void Main(string[] args)
        {
            string[] name = new string[5] { "Snehal", "Raj", "Viraj", "Nikita", "Pooja" };
            foreach (var item in name)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("___After Ascending___");
            Array.Sort(name);
            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine("name[{0}]:{1}", i, name[i]);
            }
        }
    }
}
