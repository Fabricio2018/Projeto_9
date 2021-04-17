using System;
using System.Collections.Generic;
using System.Globalization;
using Exerc_Abstrato2.Entities;

namespace Exerc_Abstrato2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> list = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i <=n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data: ");
                Console.Write("Individual or company (i/c)? ");
                char comp = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual Income: ");
                double anualInCome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (comp == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Individual(name, anualInCome, healthExpenditures));
                }

                else
                {
                    Console.Write("Number of employee: ");
                    int numberOfEmployee = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, anualInCome, numberOfEmployee));
                }
            }
            double sum = 0.0;
            Console.WriteLine();
            Console.WriteLine("Taxes Paid: ");
            foreach (TaxPayer taxPayer in list)
            {
                double tax = taxPayer.Tax();
                Console.WriteLine(taxPayer.Name + ": $" + tax.ToString("F2", CultureInfo.InvariantCulture));
                sum += tax;
            }

            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: $ " + sum.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
