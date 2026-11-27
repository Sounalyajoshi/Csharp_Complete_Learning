using System;
 namespace Csharp_Complete_Learning
{  
    class Conversion
    {
        public static void Test()
        {
            int number = 100;
            double result = number;
            Console.WriteLine(result);

            int number1 = 200;
            float Float = number1;
            Console.WriteLine(Float);


            float num = 1000.90f;
            double n = num;
            Console.WriteLine(n);


            long callno = 123456789l;
            int number3 = (int)callno;
            Console.WriteLine(number3);

            double value = 125.89;
            int values = (int)value;
            Console.WriteLine(values);

            string nums = "12234";
            int getvalue=Convert.ToInt32(nums);
            Console.WriteLine(getvalue);

            string numbervalue = "123445566";
            int d = Convert.ToInt32(numbervalue);
            Console.WriteLine(d);


            int age = 50;
            string check = age.ToString();
            Console.WriteLine(check);


            // string to double

            string value1 = "250.50";
            double results = Convert.ToDouble(value1);
            Console.WriteLine(results);

            // string to float
            string value2 = "99.50";
            float result1 = Convert.ToSingle(value2);

            Console.WriteLine(result1);

       






        }
    }

}

