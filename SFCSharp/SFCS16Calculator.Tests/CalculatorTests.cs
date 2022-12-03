using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFCS16Calculator.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        Calculator calc = new Calculator();

        [Test]
        public void CalculatorMustRetursAdditional()
        {
            var additional = calc.Additional(3, 3);
            Assert.AreEqual(6, additional);
        }

        [Test]
        public void CalculatorMustReturnSubstraction()
        {
            var substraction = calc.Subtraction(6, 3);
            Assert.AreEqual(3, substraction);
        }

        [Test]
        public void CalculatorMustReturnMultiplication()
        {
            var multiplication = calc.Miltiplication(3, 3);
            Assert.AreEqual(9, multiplication);
        }

        [Test]
        public void CalculatorMustRetunDivision()
        {
            var division = calc.Division(9, 3);
            Assert.AreEqual(3, division);
        }

    }
}
