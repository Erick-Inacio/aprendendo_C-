using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Ex1
{
    internal class Employee
    {
        //public int Id { get; set; }
        //public string Name { get; set; }
        //public double Salary { get; private set; }

        //public Employee(int id, string name, double salary)
        //{
        //    Id = id;
        //    Name = name;
        //    Salary = salary;
        //}

        //public void IncreaseSalary(double percentage)
        //{
        //    Salary += Salary * percentage / 100.0;
        //}

        //public override string ToString()
        //{
        //    return Id
        //        + ", "
        //        + Name
        //        + ", "
        //        + Salary.ToString("F2", CultureInfo.InvariantCulture);
        //}

        private int _id;
        private double _salary;

        public string? Name { get; set; }

        public int Id
        {
            get { return _id; }
            set { Id = value; }
        }

        public double Salary
        {
            get { return _salary; }
        }

        public Employee(int Id, string? Name, double Salary)
        {
            this.Id = Id;            //NumberTest(Id);
            this.Name = Name;
            _salary = Salary;
        }

        public void IncreaseSalary(double percentage)
        {
            _salary += (_salary * (percentage/100));
        }

        //private int NumberTest(string Id)
        //{
        //   int aux=0;

        //    do
        //    {
        //        if (int.TryParse(Id, out aux))
        //        {
        //            return aux;
        //        }
        //        else
        //        {
        //            Console.WriteLine("Digite apenas números inteiros: ");
        //        }
        //    } while (true);
        //}

        public override string ToString()
        {
            return ($"Id: {Id}, {Name}, {Salary.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
