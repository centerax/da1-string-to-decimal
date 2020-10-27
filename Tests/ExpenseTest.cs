using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Dominio;

namespace Tests
{
    [TestClass]
    public class ExpenseTest
    {
        [TestMethod]
        public void TestAmount()
        {
            Expense e = new Expense { Amount = "23.99" };

            decimal amount = decimal.Parse(e.Amount);

            Assert.AreEqual(23.99M, amount);
        }

        [TestMethod]
        [ExpectedException(typeof(System.FormatException))]
        public void TestAmountFails()
        {
            Expense e = new Expense { Amount = "23.99sss" };

            decimal amount = decimal.Parse(e.Amount);

            Assert.AreEqual(23.99M, amount);
        }

        [TestMethod]
        public void TestAmountTry()
        {
            Expense e = new Expense { Amount = "23.99sss" };

            decimal monto;
            bool canConvert = decimal.TryParse(e.Amount, out monto);
            //La variable canConver toma el valor FALSE cuando no puede convertir el string a decimal.

            Assert.AreEqual(0M, monto);
        }
    }
}
