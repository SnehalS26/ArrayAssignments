using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Create matrix of 3* 3 & calculate addition & display the details
namespace ArrayAssignment
{
    public class Matrix_Add
    {
        static void Main(string[] args)
        {
            int[,] num = new int[3, 3];
            Console.WriteLine("______First Matrix_____");
            for (int i = 0; i < num.GetLength(0); i++) // GetLength(0) -> 0 row size
            {
                for (int j = 0; j < num.GetLength(1); j++) // 1 --> col size
                {
                    Console.WriteLine($"Enter value for num[{i},{j}]");
                    num[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("------Display First Matrix-------");
            for (int i = 0; i < num.GetLength(0); i++)
            {
                for (int j = 0; j < num.GetLength(1); j++)
                {
                    Console.Write(num[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("____Second Matrix______");
            for (int i = 0; i < num.GetLength(0); i++) // GetLength(0) -> 0 row size
            {
                for (int j = 0; j < num.GetLength(1); j++) // 1 --> col size
                {
                    Console.WriteLine($"Enter value for num[{i},{j}]");
                    num[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("------Display Second Matrix-------");
            for (int i = 0; i < num.GetLength(0); i++)
            {
                for (int j = 0; j < num.GetLength(1); j++)
                {
                    Console.Write(num[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("____Addition two Matrix____");
            for (int i = 0; i < num.GetLength(0); i++)
            {
                for (int j = 0; j < num.GetLength(1); j++)
                {
                    Console.Write(num[i, j] + num[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
