using DataAnnotationsExtensions;
using ExpressiveAnnotations.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DieCup.Models
{
    public class DieCupModel
    {
        [Required]
        [Integer]
        public int Count { get; set; }

        [Required]
        [Integer]
        public int Minimum { get; set; }

        [Required]
        [Integer]
        [AssertThat("Maximum > Minimum",
            ErrorMessage = "Must be greater than the Minimum")]
        public int Maximum { get; set; }

        [Integer]
        [AssertThat("LoadedChance >= Minimum && LoadedChance <= Maximum",
            ErrorMessage = "Must be between or equal to the Minimum and Maximum.")]
        [Display(Name = "Loaded Value")]
        public int? LoadedValue { get; set; }

        [Range(0, 1)]
        [Display(Name = "Loaded Chance")]
        public double LoadedChance { get; set; }

        public DieCupModel()
        {
            Count = 1;
            Minimum = 1;
            Maximum = 6;
            LoadedChance = 0.5;
        }
    }
}