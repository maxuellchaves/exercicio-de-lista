using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace List_exerc_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());

            List<Employees> employee = new List<Employees>();
            Console.WriteLine();
            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Emplyoee #{i}: ");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();
                employee.Add(new Employees(id, name, salary));
                    
            }

            Console.Write("Enter the employee id that will have salary increase : ");
            int id2 = int.Parse(Console.ReadLine());
           

            Employees finds = employee.Find(x => x.Id == id2);

            if (finds!=null)
            {
                Console.Write("Enter the percentage: ");
                double pecentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                finds.IcreaseSalary(pecentage);
            }
            else
            {
                Console.WriteLine("This id does not exist !");
            }
            Console.WriteLine();
            Console.WriteLine("Updated list of employess: ");


            foreach(Employees obj in employee)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
        }
    }
}
