using System;
namespace Csharp_Complete_Learning
{
    class ReadlineMethod
    {
        public static void Run1()
        {
            Console.WriteLine("enter the name");
            string name = Console.ReadLine();
            Console.WriteLine("my name is:" + name);
            

            Console.WriteLine("enter your age");
            string input = Console.ReadLine();

            int getAge = Convert.ToInt32(input);
            Console.WriteLine("age is:" + getAge);

            Console.WriteLine("enter your name");
            string result = Console.ReadLine();
            Console.WriteLine("name is:" + result);

            Console.WriteLine("enter the First number");
            int result1 = Convert.ToInt32(Console.ReadLine());
           

            Console.WriteLine("enter the second number");
            int result2= Convert.ToInt32(Console.ReadLine());


            int Sum = result1 + result2;
            Console.WriteLine("tota is:" + Sum);













        }

    }
    
}

