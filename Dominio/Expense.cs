using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Expense
    {
        public string Amount { get; set; }

        public override string ToString()
        {
            return $"Monto: {this.Amount}";
        }
    }
}
