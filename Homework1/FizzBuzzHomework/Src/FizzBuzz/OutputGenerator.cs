//-----------------------------------------------------------------------
// <copyright file="OutputGenerator.cs" company="ImprovingEnterprises">
//     Copyright (c) ImprovingEnterprises. All rights reserved.
// </copyright>
// <author>Anthony Marrical</author>
//-----------------------------------------------------------------------
namespace FizzBuzz
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Generates an output for a specified range.
    /// </summary>
    public class OutputGenerator
    {
        #region [ Fields ]

        /// <summary>
        /// The translator which will translate numbers.
        /// </summary>
        private readonly Translator translator;

        #endregion

        #region [ Constructors ]

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputGenerator"/> class. 
        /// </summary>
        /// <param name="translator">The translator this output genrator will use.</param>
        public OutputGenerator(Translator translator)
        {
            if (null == translator)
                throw new ArgumentException("Translator cannot be null", nameof(translator));

            this.translator = translator;
        }

        #endregion

        #region [ Methods ]

        /// <summary>
        /// Generates a list of strings for desired range based on which translators are configured.
        /// </summary>
        /// <param name="start">Beginning of the range</param>
        /// <param name="end">End of the range</param>
        /// <returns>A list of translated strings based on the range</returns>
        public List<string> Generate(int start, int end)
        {
            if (start > end)
                throw new ArgumentException("End must be greater than start", nameof(end));

            return Enumerable.Range(start, (end - start) + 1).Select(n => this.translator.Translate(n)).ToList();
        } 

        #endregion
    }
}