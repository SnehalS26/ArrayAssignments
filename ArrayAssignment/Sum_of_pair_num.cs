using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Find pair of elements in array whose number is given number.
e.g. Given array is { 4,5,7,1,2,3,0} If number given is 7. Then pairs whose sum is equal to given 
number are – (4,3) (5,2) (7,0)
 */
namespace ArrayAssignment
{
    public class Sum_of_pair_num
    {
        static void Main(string[] args)
        {
            int[] num = new int[] { 4, 5, 7, 1, 2, 3, 0 };
            int sum = 7;

            for (int i=0; i<num.Length; i++)
            {
               for(int j=1; j<num.Length; j++)
                {
                    if (num[i] + num[j] == sum)
                    {
                        Console.WriteLine($"num1 {num[i]} + num2{num[j]} = {sum} ");
                    }
                }
            }
        }
    }
}
