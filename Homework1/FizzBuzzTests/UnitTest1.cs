using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzz;
using System.IO;

namespace FizzBuzzTests
{
    [TestClass]
    public class UnitTest1
    {

        [TestInitialize]
        public void InitializeTest()
        {
            StreamWriter standardOut =
                new StreamWriter(Console.OpenStandardOutput());
            standardOut.AutoFlush = true;
            Console.SetOut(standardOut);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void MaxLesserThanOneShouldThrowException()
        {
            Printer p = new Printer(5, 4);
            p.run();
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ZeroDivisorShouldThrowException()
        {
            Printer p = new Printer(1, 2);
            p.addMutator(0, "Test");
            p.run();
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void NegativeDivisorShouldThrowException()
        {
            Printer p = new Printer(1, 2);
            p.addMutator(-1, "Test");
            p.run();
        }

        [TestMethod]
        public void EqualMinAndMaxShouldShouldPrintOneNumber()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                Printer p = new Printer(1, 1);
                p.run();
                Assert.AreEqual("1 ", sw.ToString());
            }
        }

        [TestMethod]
        public void EqualMinAndMaxAndDivisorShouldShouldPrintText()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                Printer p = new Printer(3, 3);
                p.addMutator(3, "Fizz");
                p.run();
                Assert.AreEqual("Fizz ", sw.ToString());
            }
        }

        [TestMethod]
        public void EqualMinAndMaxAndDivisorNotInRangeShouldShouldPrintNumber()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                Printer p = new Printer(3, 3);
                p.addMutator(5, "Buzz");
                p.run();
                Assert.AreEqual("3 ", sw.ToString());
            }
        }

        [TestMethod]
        public void NegativeMinAndMaxShouldPrintNumber()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                Printer p = new Printer(-3, -1);
                p.run();
                Assert.AreEqual("-3 -2 -1 ", sw.ToString());
            }
        }

        [TestMethod]
        public void NegativeAndPostiveMinAndMaxShouldPrintNumber()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                Printer p = new Printer(-3, 1);
                p.run();
                Assert.AreEqual("-3 -2 -1 0 1 ", sw.ToString());
            }

        }

        [TestMethod]
        public void DivisorOfOneShouldPrintText()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                Printer p = new Printer(1, 3);
                p.addMutator(1, "Foo");
                p.run();
                Assert.AreEqual("Foo Foo Foo ", sw.ToString());
            }
        }

        [TestMethod]
        public void NormalFizzBuzz()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                Printer p = new Printer(1, 15);
                p.addMutator(3, "Fizz");
                p.addMutator(5, "Buzz");
                p.run();
                Assert.AreEqual("1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 FizzBuzz ", sw.ToString());
            }
        }
    }
}
