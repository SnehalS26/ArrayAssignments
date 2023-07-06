using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//WAP to store rain fall in a week using 1D array , accept & display the rain fall.
namespace ArrayAssignment
{
    internal class RainFall
    {
        static void Main(string[] args)
        {
            string[,] rainfall = new string[7, 2];
            Console.Write("\nPlease enter a day of the week: ");
            rainfall[0, 0] = Console.ReadLine();

            Console.Write("\nHow many inches of rain did you get on {0}: ", rainfall[0, 0]);
            rainfall[0, 1] = Console.ReadLine();

            Console.Write("\n\nPlease enter the next day of the week: ");
            rainfall[1, 0] = Console.ReadLine();

            Console.Write("\nHow many inches of rain did you get on {0}: ", rainfall[1, 0]);
            rainfall[1, 1] = Console.ReadLine();

            Console.Write("\n\nPlease enter the next day of the week: ");
            rainfall[2, 0] = Console.ReadLine();

            Console.Write("\nHow many inches of rain did you get on {0}: ", rainfall[2, 0]);
            rainfall[2, 1] = Console.ReadLine();

            Console.Write("\n\nPlease enter the next day of the week: ");
            rainfall[3, 0] = Console.ReadLine();

            Console.Write("\nHow many inches of rain did you get on {0}: ", rainfall[3, 0]);
            rainfall[3, 1] = Console.ReadLine();

            Console.Write("\n\nPlease enter the next day of the week: ");
            rainfall[4, 0] = Console.ReadLine();

            Console.Write("\nHow many inches of rain did you get on {0}: ", rainfall[4, 0]);
            rainfall[4, 1] = Console.ReadLine();

            Console.Write("\n\nPlease enter the next day of the week: ");
            rainfall[5, 0] = Console.ReadLine();

            Console.Write("\nHow many inches of rain did you get on {0}: ", rainfall[5, 0]);
            rainfall[5, 1] = Console.ReadLine();

            Console.Write("\n\nPlease enter the next day of the week: ");
            rainfall[6, 0] = Console.ReadLine();

            Console.Write("\nHow many inches of rain did you get on {0}: ", rainfall[6, 0]);
            rainfall[6, 1] = Console.ReadLine();

            double myMin2 = Convert.ToDouble(rainfall[0, 1]);
            for (int i = 0; i < rainfall.GetLength(0); i++)
            {
                foreach (double element in rainfall[i, 1])
                {
                    if (element < myMin2)
                    {
                        myMin2 = element;
                    }

                }
                Console.WriteLine("The day with the lowest amount of rainfall received {0}\" of rain.\n", myMin2);
            }
        }
    }
}
