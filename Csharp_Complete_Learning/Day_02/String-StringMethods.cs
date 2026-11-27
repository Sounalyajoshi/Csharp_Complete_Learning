using System;
namespace Csharp_Complete_Learning
{
    public class Day2
    {
        public static void Run()
        {
            string name = "janusonu";
            Console.WriteLine(name);
            //string propert=length.
            Console.WriteLine(name.Length);

            // string methods.


            string name1 = "januKulkarni";
            Console.WriteLine(name1.ToUpper());


            string course = "CSHARP";
            Console.WriteLine(course.ToLower());
            string address = "  hello world!  ";
            Console.WriteLine(address.Trim());    // trim
            Console.WriteLine(address.Contains("world"));  //Contains

            string age = "22";
            Console.WriteLine(age.Replace("22", "24")); //replace


            string personname = "ramya joshi";
            Console.WriteLine(personname.Substring(4,3)); // substring   4=starting value , 3= no of values u get 


            string name3 = "sounalya";
            Console.WriteLine(name3.Trim().StartsWith("jounalya"));

            string fruitname = "banana";
            Console.WriteLine(fruitname.Substring(2, 2));

            string progran = "programming";
            Console.WriteLine(progran.Remove(5));

            string file = "photo.jpg";
            Console.WriteLine(file.EndsWith(".jpg"));

            string information = "resume.docx";
            Console.WriteLine(information.EndsWith(".docx"));







        }
    }
}