//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="ImprovingEnterprises">
//     Copyright (c) ImprovingEnterprises. All rights reserved.
// </copyright>
// <author>Anthony Marrical</author>
//-----------------------------------------------------------------------
namespace FizzBuzz.UI
{
    using System;
    using System.Linq;

    /// <summary>
    /// The main program that generates results
    /// </summary>
    class Program
    {
        /// <summary>
        /// Main program that runs on startup
        /// </summary>
        /// <param name="args">Not used, ignore these.</param>
        static void Main(string[] args)
        {
            var translator = new Translator();
            translator.AddTranslation(new Translation(3, "Fizz"));
            translator.AddTranslation(new Translation(5, "Buzz"));
            translator.AddTranslation(new Translation(7, "Foo"));
            translator.AddTranslation(new Translation(11, "Bar"));

            var generator = new OutputGenerator(translator);
            var output = generator.Generate(1, 300);
            output.ForEach(Console.WriteLine);
        }
    }
}
