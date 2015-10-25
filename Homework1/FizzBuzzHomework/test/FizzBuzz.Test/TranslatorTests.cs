namespace FizzBuzz.Test
{
    using System;
    using System.Diagnostics.CodeAnalysis;

    using NUnit.Framework;

    [SuppressMessage("Microsoft.StyleCop.CSharp.DocumentationRules",
        "SA1600:ElementsMustBeDocumented",
        Justification = "Tests are self documenting")]
    [TestFixture]
    public class TranslatorTests
    {
        #region [ Fields ]

        private Translator target;

        #endregion

        #region [ Setup/Teardown ]

        [SetUp]
        public void SetUp()
        {
            this.target = new Translator();
        }

        #endregion

        #region [ Tests ]

        [TestCase(1, "1")]
        [TestCase(2, "2")]
        [TestCase(3, "3")]
        [TestCase(5, "5")]
        [TestCase(10, "10")]
        [TestCase(456, "456")]
        public void UninitalizedTranslatorWillReturnNumberStrings(int number, string expected)
        {
            // Arrange
            // Act
            var result = this.target.Translate(number);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void TranslatorWillReplaceNumberIfItHasSuitableReplacement()
        {
            // Arrange
            const string replacementString = "Replacement";
            const int divisor = 3;
            var replacment = new Translation(divisor, replacementString);
            const int number = 6;
            Assert.IsTrue(replacment.CanHandle(number));

            // Act
            this.target.AddTranslation(replacment);
            var result = this.target.Translate(number);

            // Assert
            Assert.AreEqual(replacementString, result);
        }

        [Test]
        public void TranslatorWillReturnNumberAsStringIfNoSuitableReplacement()
        {
            // Assemble
            const int divisor = 3;
            const int number = 7;
            var replacment = new Translation(divisor, "Replacement");
            Assert.IsFalse(replacment.CanHandle(number));

            // Act
            var result = this.target.Translate(number);

            // Assert
            Assert.AreEqual("7", result);
        }
        
        [Test]
        public void TranslatorWillReplaceWithBothValuesInOrderOfDivisorIfNumberCanBeHandledByMultipleRepacements()
        {
            const string replacementString1 = "Fizz";
            const int divisor1 = 3;
            var replacment1 = new Translation(divisor1, replacementString1);

            const string replacementString2 = "Buzz";
            const int divisor2 = 5;
            var replacment2 = new Translation(divisor2, replacementString2);

            const int number = 15;
            Assert.IsTrue(replacment1.CanHandle(number));
            Assert.IsTrue(replacment2.CanHandle(number));
            Assert.IsTrue(divisor1 < divisor2);
            const string expectedResult = replacementString1 + replacementString2;

            // Act
            this.target.AddTranslation(replacment1);
            this.target.AddTranslation(replacment2);
            var result = this.target.Translate(number);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void TranslatorCannotAddASecondReplacementThatConstainsADivisorWhichAlreadyExists()
        {
            // Arrange
            const int divisor = 3;
            var replacment1 = new Translation(divisor, "Fizz");
            var replacment2 = new Translation(divisor, "Buzz");

            // Act
            this.target.AddTranslation(replacment1);

            // Assert
            Assert.Throws<ArgumentException>(() => this.target.AddTranslation(replacment2), "Cannot add translation with same divisor\r\nParameter name: translation");
        }
        
        [Test]
        public void TranslationsInTranslatorCanBeCleared()
        {
            // Assemble
            const int divisor = 3;
            var replacment1 = new Translation(divisor, "Fizz");
            var replacment2 = new Translation(divisor, "Buzz");

            // Act
            this.target.AddTranslation(replacment1);
            this.target.ClearTranslations();
            this.target.AddTranslation(replacment2);

            // Assert
        }

        #endregion
    }
}