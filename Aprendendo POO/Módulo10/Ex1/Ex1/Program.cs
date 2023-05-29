using Ex1.Entities;
using System;
using System.Runtime.CompilerServices;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of employees: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Line();

            Employee emp = new Employee();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Employee #{i + 1} data");
                Console.Write("Outsourced (y/n)?: ");
                char c = Convert.ToChar(Console.ReadLine());
                Console.Write("Name: ");
                string? name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = Convert.ToInt32(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = Convert.ToDouble(Console.ReadLine());

                if (c == 'y')
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = Convert.ToDouble(Console.ReadLine());

                    emp.AddItem(new OutsourcedEmployee(additionalCharge, name, hours, valuePerHour));
                }
                else
                { 
                    emp.AddItem(new Employee(name, hours, valuePerHour));
                }
                Line();
            }
            Console.WriteLine("PAYMENTS:");
            Console.WriteLine(emp);
        }

        public static void Line()
        {
            Console.WriteLine("\n-----------------------------------------\n");
        }
    }
}