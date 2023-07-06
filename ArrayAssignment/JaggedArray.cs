using ArrayAssignment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//WAP to create jagged array,initialized data & display the details
namespace ArrayAssignment
{
    public class JaggedArray
    {
        static void Main(string[] args)
        {
            int[][] jaggedArray = new int[5][];
            jaggedArray[0] = new int[] { 1, 2, 3, 4 };
            jaggedArray[1] = new int[] { 11, 22, 33, 44, 55 };
            jaggedArray[2] = new int[] { 111, 222, 333 };
            jaggedArray[3] = new int[] { 1111 };
            jaggedArray[4] = new int[] { 010, 020 };

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].GetLength(0); j++)
                {
                    Console.Write(jaggedArray[i][j] + " ");
                }
                Console.WriteLine();
            }
        
        }
    }
}
