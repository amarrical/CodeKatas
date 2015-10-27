//-----------------------------------------------------------------------
// <copyright file="OutputGeneratorTests.cs" company="ImprovingEnterprises">
//     Copyright (c) ImprovingEnterprises. All rights reserved.
// </copyright>
// <author>Anthony Marrical</author>
//-----------------------------------------------------------------------
namespace FizzBuzz.Test
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;

    using NUnit.Framework;

    [SuppressMessage("Microsoft.StyleCop.CSharp.DocumentationRules",
        "SA1600:ElementsMustBeDocumented",
        Justification = "Tests are self documenting")]
    [TestFixture]
    public class OutputGeneratorTests
    {
        #region [ Fields ]

        private Translator translator;

        private OutputGenerator target; 

        #endregion

        #region [ Setup/Teardown ]

        [SetUp]
        public void SetUp()
        {
            this.translator = new Translator();
            this.target = new OutputGenerator(this.translator);
        }

        #endregion

        #region [ Tests ]

        [Test]
        [ExpectedException(typeof(ArgumentException), ExpectedMessage = "Translator cannot be null\r\nParameter name: translator")]
        public void ConstructorThrowsExceptionIfTranslatorIsNull()
        {
            // Assemble

            // Act
            this.target = new OutputGenerator(null);

            // Assert
        }

        [Test]
        [ExpectedException(typeof(ArgumentException), ExpectedMessage = "End must be greater than start\r\nParameter name: end")]
        public void GeneratorThrowsExcpetionWhenEndIsLessThanStart()
        {
            // Assemble
            const int start = 100;
            const int end = 10;
            Assert.IsTrue(start > end);

            // Act
            var result = this.target.Generate(start, end);

            // Assert
        }

        [Test]
        public void GeneratorCanAcceptARangeForGeneration()
        {
            // Arrange
            // Act
            var result = this.target.Generate(1, 100);

            // Assert
            Assert.AreEqual(100, result.Count);
        }

        [Test]
        public void GeneratorWillUseOutputFromTranslator()
        {
            // Arrange
            const string expectedReplacement = "Foo";
            var translation = new Translation(3, expectedReplacement);
            this.translator.AddTranslation(translation);

            // Act
            var result = this.target.Generate(3, 3);

            // Assert
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual(expectedReplacement, result.First());
        }

        #endregion
    }
}
