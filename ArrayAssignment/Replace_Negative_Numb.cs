using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//WAP to replace all negative value with its immediate left elements square.
//Means arr[] = [12, 3,-19, 29, 5, -61, 44, 7, -9] Output array will be [12, 3, 9, 29, 5, 25, 44, 7, 49].
namespace ArrayAssignment
{
    public class Replace_Negative_Numb
    {
        static void Main(string[] args)
        {
            int[] num = new int[] { 12, 3, -19, 29, 5, -61, 44, 7, -9 };
            int i;
            for( i =0; i < num.Length; i++)
            {
                if(num[i] < 0)
                {
                    int j = i - 1;
                    num[i] = num[j] * num[j];
                }
                Console.WriteLine(num[i]);
            }
            
        }
    }
}
