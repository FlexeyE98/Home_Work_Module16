using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorPracticies;
using NUnit;
using NUnit.Framework;

namespace CalculatorTests
{
    [TestFixture]
    public class CalculationTests
    {
        [Test]
        public void AdditionalMustReturnCorrectValue()
        { 
            var calc = new Calculator();
            Assert.That(10 == calc.Additional(5, 5));
        
        }

        [Test]
        public void SubtractionMustReturnCorrectValue()
        {
            var calc = new Calculator();
            Assert.That(5 == calc.Subtraction(10, 5));
        
        }

        [Test]
        public void MultiplicationMustReturnCorrectValue() 
        {
            var calc = new Calculator();
            Assert.That(10 == calc.Miltiplication(5, 2));
        
        }

        [Test]
        public void DivisionMustReturnCorrectValue() 
        {
            var calc = new Calculator();
            Assert.That(10 == calc.Division(100, 10));
        
        }

        [Test]
        public void DivisionMustThrowEceptionIfDivededZero()
        {
            var calc = new Calculator();
            Assert.Throws <DivideByZeroException> (() => calc.Division(100, 0));
        
        }

    }
}
