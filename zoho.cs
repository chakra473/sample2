using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorial_and_power
{
    internal class zoho
    {
        public static int zoho1()
        {
            int count = 67;
            int i, j, k = 10;
            for (i = 1, j = 1; i < k && j < k; ++i)
            {
                if (i % 4 == 0)
                {
                    i = 0;
                    j++;
                }
                count = count - 1;
            }
            Console.WriteLine(count);
            return 0;
        }
        public static int foo(int a,int b)
        {
        while(b<a+a)
            {
                b = b * b;
                b = b + 2;
            }
        return b;
    

        }
        
        public static void foo1(int n,int sum)
        {
            int k = 0, j = 0;
            if (n == 0)
                return;
            k = n % 10;
            j=n/ 10;
            k = sum * k;
            foo1(j, sum);
            sum = sum * k + 1;
            Console.WriteLine(k%10);
        }
    }
}
