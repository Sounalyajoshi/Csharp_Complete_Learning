using Csharp_Complete_Learning.Dya_01;

namespace Csharp_Complete_Learning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Datatype practice
            DatatypeExample de = new DatatypeExample();
            de.Display();

            Console.WriteLine("----------------------------");
            Student s = new Student();
            s.studentName = "janu";
            s.marks = 98;
            s.subject = "science";
            s.stanaderd = "5th";

            s.StudentDetails();
            Console.WriteLine("----------------------------");
            Employee emp = new Employee();
            emp.DisplayEmpDetails();

            Console.WriteLine("----------------------------");
            Person p = new Person();
            p.city = "bangalore";
            p.country = "india";
            p.DisplayDetails();

            Console.WriteLine("----------------------------");

            //Variable practice

            Students s12 = new Students();
            s12.display();
            Console.WriteLine("----------------------------");
            Employee1 e1 = new Employee1();

            e1.EmpDisplay();
            Console.WriteLine("----------------------------");
            Product p1 = new Product();
            p1.productName = "janu";
            Console.WriteLine(p1.productName);
            p1.DisplayProduct();
            Console.WriteLine("----------------------------");

            StudentMarks sm = new StudentMarks();
            sm.marks = 75;
            sm.marks = 90;
            Console.WriteLine("student final marks is:" + sm.marks);

            Console.WriteLine("-----------var practice-----------------");


            Var_Keyword v = new Var_Keyword();

            v.VarExample();
            v.Display1();
            v.Display2();

            Console.WriteLine("---------dynamic practice-------------------");

            Dynamic d = new Dynamic();
            d.studentName = "kiran";
            d.age = 25;
            d.Dinamicdisplay();

            Console.WriteLine("---------dynamic practice-------------------");

            Shop shop = new Shop();

            shop.shopName = "kirani store";
            shop.address = "bangalore";
            shop.displayShop();





        }
    }
    
}

