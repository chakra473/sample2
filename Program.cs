using System;

namespace factorial_and_power
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Class1 c = new Class1();
            //Console.WriteLine("enter a number to find factorial and 2 power");
            //int num=Convert.ToInt32(Console.ReadLine());
            //int hold=c.fact(num);
            //Console.WriteLine("the factorial of {0} is {1}",num,hold);

            //c.fact1(num);
            //Class1.pow(num);
            //pow(num);
           string input= user();
            Console.WriteLine(input);
            user();

           
            
           

        }
        public static string user()
        {
            Console.WriteLine("enter the username");
            string input = Console.ReadLine();
            if(input.Length<3)
            {
                Console.WriteLine("username is invalid");
            }
            else
            {
                Console.WriteLine("Hello {0} how are you", input);
            }
            return input;
        }
       public static void pow(int num)
        {
            int a = 1
                ;
            for(int i=1; i<=num; i++)
            {
                a = a * 2;
            }
           
            Console.WriteLine("2 power of {0} is {1}",num,a);
        }

    }
}
