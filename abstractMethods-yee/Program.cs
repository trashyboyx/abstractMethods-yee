using abstractMethods_yee.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace abstractMethods_yee
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();

            Console.Write("Enter the number of tax payers: ");
            int taxPayers = int.Parse(Console.ReadLine());
            for (int i = 1; i <= taxPayers; i++)
            {
                Console.WriteLine($"Tax payer #{i} data: ");
                Console.Write("Individual or company (i/c)? ");
                char typePerson = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                if (typePerson == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double gastoSaude = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    persons.Add(new IndividualPerson(name, anualIncome, gastoSaude));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int numberEmployees = int.Parse(Console.ReadLine());
                    persons.Add(new JuridicalPerson(name, anualIncome, numberEmployees));
                }
            }
            double total = 0.0;

            Console.WriteLine("TAXES PAID:");
            persons.ForEach(person =>
            {
                double imposto = person.ImpostoAnual();
                Console.WriteLine(person.Nome + ": $ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
                total += imposto;
            });

            Console.WriteLine("TOTAL TAXES: $ " + total);

        }
    }
}
