using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Move zeros to beginning or end of array. 
e.g. if given array is { 2 , 10 , 0 ,5 ,3, 0, 4 ,1} then output array should be 
a. { 0,0,2,10,5,3,4,1} 
b. {2,10,5,3,4,1,0,0}
 */
namespace ArrayAssignment
{
    public class Move_zeros
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------Move Zero Begining----------------------------------");
            int[] array = new int[] { 3, 0, 0, 1, 2, 0, 4, 0 };
            int j = array.Length - 1;
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i] != 0)
                {
                    array[j] = array[i];
                    j--;
                }
            }
            for (int i = j; i >= 0; i--)
            {
                array[j] = 0;
                j--;
            }

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

            /*
            Console.WriteLine("------------------Move Zero End-----------------------------");
            int[] array = new int[] { 3, 0, 0, 1, 2, 0, 4, 0 };
            for (int i = 0; i < array.Length; i++)
            {
                //skip non-zero elements  
                if (array[i] != 0)
                    continue;
                //look for the nearest non-zero  
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] == 0)
                        continue;
                    //swap it with our zero  
                    array[i] = array[j];
                    array[j] = 0;
                    break;
                }
            }
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }*/

            /*-------------------------------------------------------------------------------
            int[] num = new int[] { 2, 10, 0, 5, 3, 0, 4, 1 };

            for (int i = 0; i < num.Length; i++)
            {
                for (int j = i+1; j < num.Length-1; j++)
                {
                    int temp;
                    if (num[j] == 0)
                     
                    {
                        temp = num[i];
                        num[i] = num[j];
                        num[j] = temp;
                    }         
                }
            }
            foreach (int i in num)
            {
                Console.Write(i);
            }*/
        }
    }
}
