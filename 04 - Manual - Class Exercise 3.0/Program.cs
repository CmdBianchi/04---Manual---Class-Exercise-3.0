using System;
using Entities;
namespace _04___Manual___Class_Exercise_3._0 {
    class Program {
        static void Main(string[] args) {
            Employee employee = new Employee();
            Console.Write("Nome do funcionário: "); employee.Name = Console.ReadLine();
            Console.Write("Salário bruto: "); employee.Income = double.Parse(Console.ReadLine());
            Console.Write("Imposto: "); employee.Tax = double.Parse(Console.ReadLine());
            Console.WriteLine(employee.NetSalary());
            Console.WriteLine("Digite a porcentagem para aumentar o salário: "); double percentage = double.Parse(Console.ReadLine());
            employee.IncreaseSalay(percentage);
            Console.WriteLine("");
            Console.WriteLine(employee);
        }
    }
}
