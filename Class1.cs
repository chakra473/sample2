using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorial_and_power
{
    internal class Class1
    {
        public int fact(int num)
        {
            int fact = 1;
            for(int i = 1; i <=num; i++)
            {
            fact=fact*i;
               
            }
            
            return fact;
        }
        public void fact1(int num)
        {
            int fact1=1,j=1;
            while(j<= num)
            {
                fact1 = fact1 * j;
                j++;    
            }
            Console.WriteLine("the factorial of " + num + " is " + fact1);
        }
        public static void pow(int num)
        {
           
            double pow = Math.Pow(2, num);
            Console.WriteLine("2 power of " + num +" is "+ pow);
        }
    }
}
