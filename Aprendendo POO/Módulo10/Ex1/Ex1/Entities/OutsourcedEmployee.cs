using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1.Entities
{
    internal sealed class OutsourcedEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutsourcedEmployee() { }
        public OutsourcedEmployee(double additionalCharge, string name, int hours, double valuePerHour)
            : base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        public override double Payment()
        {
            return base.Payment() + (AdditionalCharge * 1.1);
        }

        //public override string ToString()
        //{
        //    return $"{Name} - $ {Payment().ToString("N2", CultureInfo.InvariantCulture)}";
        //}
    }
}
