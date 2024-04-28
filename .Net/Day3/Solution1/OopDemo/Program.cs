using MyEntities;
namespace OopDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Person p = new Person();
            //Default Constructor
            Student student = new Student();
            Console.WriteLine(student);

            //Parametrised
            Student st = new Student(1, "Miss", "Radha", "xyz", "xyz@gmail.com", "0987654");
            Console.WriteLine(st);

            
            Student st1 = new Student (st);
            st.LastName = "Pqr";
            Console.WriteLine("Printing st: "+st);
            Console.WriteLine("Printing st1: " + st1);
          

            //Emp Demo with object initialiser
            Emp e = new Emp();
            Emp e1 = new Emp { Id = 1 ,Name="Emp1"};
            Emp e2 = new Emp { Name = "Emp2", Salary = 5000.90f };

            Console.WriteLine(e);
            Console.WriteLine(e1);
            Console.WriteLine(e2);
            Console.WriteLine("----------------------------");
            Emp[] emparr = { 
                new Emp{ Id = 1 ,Name="xyz",Salary=6000f},
                new Emp{ Id = 2 ,Name="pqr"},
                new Emp{ Id = 3 ,Address="FC Road"}
            };

            foreach (var item in emparr)
            {
                Console.WriteLine(item);
            }
              */

            Calculator calculator = new Calculator();
            calculator.Add(12, 4);//optional param
            calculator.Add(12, 4,6); 
            calculator.Display(3, "xyz");//positional
            calculator.Display(nm: "pqr", id: 10);//Named
            calculator.Add(10, c: 100, b: 20);//positional+named
            Console.WriteLine(calculator.Sum()); ;//0
            Console.WriteLine(calculator.Sum(1,2,3,4,5,6,7));
            Console.WriteLine(calculator.Sum(10, 20));
            //overloaded
            calculator.Add(10, 3.5f, 5.6f);
        }
    }
}
