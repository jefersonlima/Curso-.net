using System;
using System.Globalization;
using System.Collections.Generic;

namespace CourseList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employees> listEmplyoees = new List<Employees>();
            Console.Write("How many emplyoees will be registered? ");
            int howManyEmplyoees = int.Parse(Console.ReadLine());

            for(int i = 0; i < howManyEmplyoees; i++)
            {
                Console.WriteLine("Emplyoee #" + (i+1) + ":");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                String name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();

                listEmplyoees.Add(new Employees (id, name, salary));
            }

            Console.Write("Enter the employee id that will have salary increase : ");
            int idAlterar = int.Parse(Console.ReadLine());
            Employees l1 = listEmplyoees.Find(x => x.Id == idAlterar);

            if (l1 != null)
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                l1.increaseSalary(percentage);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("This id does not exist!");
                Console.WriteLine();
            }

            Console.WriteLine("Updated list of employees:");
            foreach (Employees obj in listEmplyoees)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
