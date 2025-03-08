using AulaRestricoesGenerics.Entities;
using AulaRestricoesGenerics.Services;
using System.Globalization;

namespace AulaRestricoesGenerics
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.WriteLine("Enter N:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] vect = Console.ReadLine().Split(',');
                string name = vect[0];
                double price = double.Parse(vect[1], CultureInfo.InvariantCulture);
                int x = int.Parse(Console.ReadLine());
                list.Add(new Product(name,price));
            }

            CalculationService calculationService = new CalculationService();

            Product max = calculationService.Max(list);
            Console.WriteLine("Max: ");
            Console.WriteLine(max);
        }
    }
}