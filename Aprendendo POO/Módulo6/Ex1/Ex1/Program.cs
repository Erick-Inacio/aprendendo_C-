using System;
using System.Collections.Generic;
using System.Globalization;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            Console.Write("How many employees will be registered?: ");
            int qtdeEmp = int.Parse(Console.ReadLine());

            for (int i = 0; i < qtdeEmp; i++)
            {
                Console.WriteLine($"Employee #{i + 1}: ");

                Console.Write("id: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("name: ");
                string? name = Console.ReadLine();

                Console.Write("salary: ");
                double salary = double.Parse(Console.ReadLine());

                employees.Add(new Employee(id, name, salary));

                Console.WriteLine();

            }

            Console.Write("Enter the employee id that will have salary increase: ");
            int id2 = int.Parse(Console.ReadLine());

            Employee emp = employees.Find(x => x.Id == id2);

            if (emp != null)
            {
                Console.Write("Enter the porcentage: ");
                double porc = double.Parse(Console.ReadLine());
                emp.IncreaseSalary(porc);
            }
            else
            {
                Console.WriteLine("This id doesn't exist!");
                Console.WriteLine();
            }

            Console.WriteLine("Updated list of employees:");
            foreach (Employee obj in employees)
            {
                Console.WriteLine(obj);
            }
        }
    }
}