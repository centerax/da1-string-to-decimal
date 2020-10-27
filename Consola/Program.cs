using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            var gastos = new List<Expense>();

            gastos.Add(new Expense {Amount = "12.00"});
            gastos.Add(new Expense { Amount = "25.50" });
            gastos.Add(new Expense { Amount = "100" });

            gastos.ForEach(Console.WriteLine);

            Console.ReadKey();
        }
    }
}
