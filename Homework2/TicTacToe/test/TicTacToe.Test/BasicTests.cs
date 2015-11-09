//-----------------------------------------------------------------------
// <copyright file="BasicTests.cs" company="ImprovingEnterprises">
//     Copyright (c) ImprovingEnterprises. All rights reserved.
// </copyright>
// <author>Anthony Marrical</author>
//-----------------------------------------------------------------------

using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;
using NUnit.Framework;

namespace TicTacToe.Test
{
    // Sourced from https://github.com/crisi/tdd-test/blob/master/tic-tac-toe/src/test/ch/crisi/tdd/tictactoe/TicTacToeTest.java

    [SuppressMessage("Microsoft.StyleCop.CSharp.DocumentationRules",
        "SA1600:ElementsMustBeDocumented",
        Justification = "Tests are self documenting")]
    [TestFixture]
    public class BasicTests
    {
        private TicTacToe target;

        [SetUp]
        public void SetUp()
        {
            this.target = new TicTacToe();
        }


        [Test]
        public void CanSetCircle()
        {
            // Assemble
            // Act
            target.SetCircle(1, 1);

            // Assert
            Assert.IsTrue(target.IsCircle(1,1));
        }


        [Test]
        public void CanSetCircleOnBlankSpace()
        {
            // Assemble
            // Act
            var circlePlaced = target.SetCircle(1, 1);

            // Assert
            Assert.True(circlePlaced);
        }


        [Test]
        public void CannotSetCircleOnCircle()
        {
            // Assemble
            target.SetCircle(1, 1);
            
            // Act
            var circlePlaced = target.SetCircle(1, 1);

            // Assert
            Assert.False(circlePlaced);
        }


        [Test]
        public void CanSetCross()
        {
            // Assemble
            // Act
            target.SetCross(1, 1);

            // Assert
            Assert.True(target.IsCross(1, 1));
        }


        [Test]
        public void CanSetCrossOnBlank()
        {
            // Assemble
            // Act
            var crossPlaced = target.SetCross(1, 1);

            // Assert
            Assert.True(crossPlaced);
        }


        [Test]
        public void CannotSetCrossOnCross()
        {
            // Assemble
            target.SetCross(1, 1);

            // Act
            var crossPlaced = target.SetCross(1, 1);

            // Assert
            Assert.False(crossPlaced);
        }
    }
}