namespace Csharp_Complete_Learning.Dya_01
{
    // datatypes

    public class DatatypeExample
    {
        string name = "janu"; //fields
        int age = 12;
        char Char = 'A';
        bool isprint = true;
        double marks = 89.50;

        public void Display()
        {
            string name1 = "sourabh";   //local variables
            float height = 5.6f;

            Console.WriteLine(name1);
            Console.WriteLine(height);
            Console.WriteLine(Char);
            Console.WriteLine(isprint);
            Console.WriteLine(marks);



        }
    }

    class Student
    {
        public string studentName;
        public double marks;
        public string subject;
        public string stanaderd;


        public void StudentDetails()
        {
            Console.WriteLine(studentName);
            Console.WriteLine(marks);
            Console.WriteLine(subject);
            Console.WriteLine(stanaderd);

        }
    }
    class Employee
    {
        int empId = 101;
        string empName = "soumya";
        double salary = 20000;
        string department = "HR";


        public void DisplayEmpDetails()

        {
            string address = "bangalore";   //local  variable


            Console.WriteLine("empid:" + empId);
            Console.WriteLine("empNmae:" + empName);
            Console.WriteLine("salary:" + salary);
            Console.WriteLine("emp department:" + department);
            Console.WriteLine(address);
        }
    }

    class Person
    {
        public string city;
            public string country;

        public void DisplayDetails()
        {
            int age = 22;
            string personName = "sunil";
            Console.WriteLine("age is" + age);
            Console.WriteLine("name is:" + personName);

            Console.WriteLine("city name:"+city);
            Console.WriteLine("country name:"+country);





        }
    }
}