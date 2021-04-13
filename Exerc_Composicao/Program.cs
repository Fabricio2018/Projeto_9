using System;
using Exerc_Composicao.Entities;
using Exerc_Composicao.Entities.Enums;
using System.Globalization;
namespace Exerc_Composicao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter departement's name: ");
            string deptName = Console.ReadLine();
            Console.WriteLine("Enter worker data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level(Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base Salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Departement dept = new Departement(deptName);
            Worker worker = new Worker(name, level, baseSalary, dept);

            Console.WriteLine("How many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} contract data: ");              
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valurPerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration(Hours): ");
                int hours = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(date, valurPerHour, hours);
                worker.AddContracts(contract);
            }
            Console.WriteLine();
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string montAndYear = Console.ReadLine();
            int month = int.Parse(montAndYear.Substring(0, 2));
            int year = int.Parse(montAndYear.Substring(3));
            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Departement: " + worker.departement.Name);
            Console.WriteLine("Income for " + montAndYear + ": " 
                + worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
