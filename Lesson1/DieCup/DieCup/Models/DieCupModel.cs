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
        [AssertThat("Maximum > minimum")]
        public int Maximum { get; set; }

        [Integer]
        [AssertThat("LoadedChance >= Minimum && LoadedChance <= Maximum")]
        public int? LoadedValue { get; set; }

        [Range(0, 1)]
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