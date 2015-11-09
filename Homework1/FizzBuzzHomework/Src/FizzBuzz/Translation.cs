//-----------------------------------------------------------------------
// <copyright file="Translation.cs" company="ImprovingEnterprises">
//     Copyright (c) ImprovingEnterprises. All rights reserved.
// </copyright>
// <author>Anthony Marrical</author>
//-----------------------------------------------------------------------
namespace FizzBuzz
{
    using System;

    /// <summary>
    /// Contains a translation for the translator.
    /// </summary>
    public class Translation
    {
        #region [ Constructors ]

        /// <summary>
        /// Initializes a new instance of the <see cref="Translation"/> class.
        /// </summary>
        /// <param name="divisor">Divisor to determine numbers to replace.</param>
        /// <param name="replacement">Replacement for numbers divisible by divisor.</param>
        public Translation(int divisor, string replacement)
        {
            if (divisor < 1)
                throw new ArgumentException("Divisor cannot be less than 1", nameof(divisor));

            if (string.IsNullOrEmpty(replacement))
                throw new ArgumentException("Replacement cannot be null or empty", nameof(replacement));

            this.Divisor = divisor;
            this.Replacement = replacement;
        } 

        #endregion

        #region [ Properties ]

        /// <summary>
        /// Gets the divisor showing which numbers should be replaced.
        /// </summary>
        public int Divisor { get; private set; }

        /// <summary>
        /// Gets the repacement for numbers divisible by divisor.
        /// </summary>
        public string Replacement { get; private set; }

        #endregion

        #region [ Methods ]

        /// <summary>
        /// Determines if this translation should affect the number in question.
        /// </summary>
        /// <param name="number">The number to be tested.</param>
        /// <returns>A value indicating whither the number should be replaced.</returns>
        public bool CanHandle(int number)
        {
            return (number % this.Divisor == 0);
        } 

        #endregion
    }
}