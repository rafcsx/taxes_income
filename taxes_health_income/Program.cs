using System;
using System.Collections.Generic;
using taxes_health_income.Entities;
using System.Globalization;

namespace taxes_health_income
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> tax_list = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int pay_rep = int.Parse(Console.ReadLine());

            for (int i = 1; i <= pay_rep; i++)
            {
                Console.WriteLine($"Tax payer {i} data:");

                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name_input = Console.ReadLine();

                Console.Write("Anual income: ");
                double anual_input = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'i' || ch == 'I')
                {
                    Console.Write("Health expenditures: ");
                    double health_input = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    tax_list.Add(new Individual(name_input, anual_input, health_input));
                }

                else
                {
                    Console.Write("Number of employees: ");
                    {
                        int emp_input = int.Parse(Console.ReadLine());

                        tax_list.Add(new Company(name_input, anual_input, emp_input));
                    }
                }
            }
            Console.WriteLine();

            Console.WriteLine("TAXES PAID: ");
            double sum = 0.0;
            foreach (TaxPayer payer in tax_list)
            {
                Console.WriteLine($"{payer.Name}: $ {payer.Tax().ToString("F2", CultureInfo.InvariantCulture)}");
                sum += payer.Tax();
            }
            Console.WriteLine();

            Console.WriteLine($"TOTAL TAXES: $ {sum.ToString("F2", CultureInfo.InvariantCulture)}");
        }

    }
}