namespace Csharp_Complete_Learning.Dya_01
{
    class Students
    {
        public void display()
        {
            int age = 21;
            age = 25;
            Console.WriteLine(age);
        }
    }
    class Employee1
    {
        public void EmpDisplay()
        {
            string employeeName = "rahul";
            employeeName = "kiran";
            Console.WriteLine("employee namee is:" + employeeName);
        }
    }
    class Product
    {
        public string productName = "sonu";
        public void DisplayProduct()
        {
            double productPrice = 150.50;
            productPrice = 250.75;
            Console.WriteLine(productPrice);
        }
    }

    class StudentMarks
    {
        public int marks = 60;

    }
    class Var_Keyword
    {
        // var is implicitily local variable
        //u must assign value at declaration time

        public void VarExample()
        {
            var age = 22;
            age = 40;
            Console.WriteLine("age is:" + age);

        }

        public void Display1()
        {
            var isPassed = true;
            isPassed = false;
            Console.WriteLine(isPassed);
        }

        public void Display2()
        {
            var price = 250;
            price = 400;
            Console.WriteLine(price);
        }


    }
    class Dynamic
    {
        public dynamic studentName = "rahul";
        public dynamic age = 22;

        public void Dinamicdisplay()
        {
            dynamic salary = 25000;
            salary = "twenty five thousands rupees";
            Console.WriteLine(salary);
            Console.WriteLine("student name is:" + studentName);
            Console.WriteLine("student age is:" + age);
        }
    }

    class Shop
    {
        public string shopName;

        public string address;

        public void displayShop()
        {
            string productName = "chocolate";
            int productPrice = 10;
            Console.WriteLine("product name is:" + productName);
            Console.WriteLine("product price :" + productPrice);
            Console.WriteLine("shop name:" +shopName);
            Console.WriteLine("shop address :" + address);

        }

    }

}