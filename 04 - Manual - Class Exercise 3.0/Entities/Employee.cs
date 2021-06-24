using System;
using System.Collections.Generic;
using System.Text;
namespace Entities {
    class Employee {
        public string Name { get; set; }
        public double Income { get; set; }
        public double Tax { get; set; }

        public Employee() { }
        public Employee(string name, double income, double tax) {
            Name = name;
            Income = income;
            Tax = tax;
        }

        public double NetSalary() {
            return Income - Tax;
        }
        public void IncreaseSalay(double percentage) {
            Income = (Income) * ((100 + percentage) / 100);                        
        }

        public override string ToString() {
            return Name + ", $" + (Income - Tax);

        }
    }
}
