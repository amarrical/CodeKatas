namespace FizzBuzz
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// Translates a number based on contained translations.
    /// </summary>
    public class Translator
    {
        #region [ Fields ]

        /// <summary>
        /// The list of translations this translator will make.
        /// </summary>
        private readonly List<Translation> translations; 

        #endregion

        #region [ Constructors ]

        /// <summary>
        /// Initializes a new instance of the <see cref="Translator"/> class.
        /// </summary>
        public Translator()
        {
            this.translations = new List<Translation>();
        }

        #endregion

        #region [ Methods ]

        /// <summary>
        /// Adds a translation to the list of translations this translator will make.
        /// </summary>
        /// <param name="translation">Translation being added.</param>
        public void AddTranslation(Translation translation)
        {
            if (this.translations.Any(r => r.Divisor == translation.Divisor))
                throw new ArgumentException("Cannot add translation with same divisor", nameof(translation));

            this.translations.Add(translation);
        }

        /// <summary>
        /// Clears all translations from the translator.
        /// </summary>
        public void ClearTranslations()
        {
            this.translations.Clear();
        }

        /// <summary>
        /// Translates a number based on the translations this translator contains.
        /// </summary>
        /// <param name="number">Number to be translated.</param>
        /// <returns>A string representation of the number, or its replacement(s).</returns>
        public string Translate(int number)
        {
            var stringbuilder = new StringBuilder();
            this.translations.Where(t => t.CanHandle(number)).OrderBy(t => t.Divisor).ToList().ForEach(t => stringbuilder.Append(t.Replacement));
            if (stringbuilder.Length == 0)
                stringbuilder.Append(number.ToString(CultureInfo.InvariantCulture));

            return stringbuilder.ToString();
        }

        #endregion
    }
}