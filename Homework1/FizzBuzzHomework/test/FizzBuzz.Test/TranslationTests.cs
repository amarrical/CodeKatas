//-----------------------------------------------------------------------
// <copyright file="TranslationTests.cs" company="ImprovingEnterprises">
//     Copyright (c) ImprovingEnterprises. All rights reserved.
// </copyright>
// <author>Anthony Marrical</author>
//-----------------------------------------------------------------------
namespace FizzBuzz.Test
{
    using System;
    using System.Diagnostics.CodeAnalysis;

    using FizzBuzz;

    using NUnit.Framework;

    [SuppressMessage("Microsoft.StyleCop.CSharp.DocumentationRules",
        "SA1600:ElementsMustBeDocumented",
        Justification = "Tests are self documenting")]
    [TestFixture]
    public class TranslationTests
    {
        #region [ Fields ]

        private Translation target;

        #endregion

        #region [ Setup/Teardown ]

        [SetUp]
        public void SetUp()
        {
        }

        #endregion

        #region [ Tests ]

        #region [ Constructor ]

        [Test]
        [ExpectedException(typeof(ArgumentException), ExpectedMessage = "Replacement cannot be null or empty\r\nParameter name: replacement")]
        public void ConstructorThrowsExceptionIfReplacementStringIsNull()
        {
            // Assemble
            const int divisor = 2;
            const string replacement = null;

            // Act
            this.target = new Translation(divisor, replacement);

            // Assert
        }


        [Test]
        [ExpectedException(typeof(ArgumentException), ExpectedMessage = "Replacement cannot be null or empty\r\nParameter name: replacement")]
        public void ConstructorThrowsExceptionIfReplacementStringIsEmpty()
        {
            // Assemble
            const int divisor = 2;
            var replacement = string.Empty;

            // Act
            this.target = new Translation(divisor, replacement);

            // Assert
        }


        [Test]
        [ExpectedException(typeof(ArgumentException), ExpectedMessage = "Divisor cannot be less than 1\r\nParameter name: divisor")]
        public void ConstructorThrowsExceptionIfDivisorIsZero()
        {
            // Assemble
            const int divisor = 0;
            const string replacement = "Foo";

            // Act
            this.target = new Translation(divisor, replacement);

            // Assert
        }

        [TestCase(-1)]
        [TestCase(-45)]
        [TestCase(-325)]
        [TestCase(-2342)]
        [TestCase(-456312)]
        [TestCase(-9564)]
        [TestCase(-2)]
        [TestCase(Int16.MinValue)]
        [TestCase(Int16.MinValue + 1)]
        [ExpectedException(typeof(ArgumentException), ExpectedMessage = "Divisor cannot be less than 1\r\nParameter name: divisor")]
        public void ConstructorThrowsExceptionIfDivisorIsLessThanZero(int divisor)
        {
            // Assemble
            const string replacement = "Foo";

            // Act
            this.target = new Translation(divisor, replacement);

            // Assert
        }

        #endregion

        #region [ CanHandle ]

        [Test]
        public void CanHandleReturnsFalseIfNumberIsNotDivisibleByDivisor()
        {
            // Assemble
            const int divisor = 3;
            const int number = 4;
            Assert.IsFalse(number % divisor == 0);
            this.target = new Translation(divisor, "Fizz");

            // Act
            var result = this.target.CanHandle(number);

            // Assert
            Assert.IsFalse(result);
        }


        [Test]
        public void CanHandleReturnsTrueIfNumberIsEqualToDivsor()
        {
            // Assemble
            const int divisor = 3;
            const string replacement = "Foo";
            this.target = new Translation(divisor, replacement);

            // Act
            var result = this.target.CanHandle(divisor);

            // Assert
            Assert.IsTrue(result);
        }

        [TestCase(2)]
        [TestCase(4)]
        [TestCase(5)]
        [TestCase(7)]
        [TestCase(13)]
        [TestCase(45)]
        public void CanHandleReturnsTrueIfNumberIsAMultipleOfDivisor(int multiplier)
        {
            // Assemble
            const int divisor = 3;
            const string replacement = "Foo";
            this.target = new Translation(divisor, replacement);

            // Act
            var result = this.target.CanHandle(divisor * multiplier);

            // Assert
            Assert.IsTrue(result);
        }

        #endregion

        #endregion
    }
}
