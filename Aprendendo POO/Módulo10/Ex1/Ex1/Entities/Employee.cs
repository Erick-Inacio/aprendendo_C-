using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace Ex1.Entities
{
    internal class Employee
    {
        public string? Name { get; set; }
        public int Hours { get; set; }
        public double ValuePerHour { get; set; }
        public List<Employee> List { get; set; } = new List<Employee>();

        public Employee() { }
        public Employee(string name, int hours, double valuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }

        public virtual double Payment()
        {
            return Hours * ValuePerHour;
        }
        public void AddItem(Employee item)
        {
            List.Add(item);
        }
        public void RemoveItem(Employee item)
        {
            List.Remove(item);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Employee emp in List)
            {
                sb.Append($"{emp.Name} - $ {emp.Payment().ToString("N2", CultureInfo.InvariantCulture)}\n");
            }

            return sb.ToString();
        }


    }
}
