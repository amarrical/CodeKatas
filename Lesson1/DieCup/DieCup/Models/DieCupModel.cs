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
        public int count { get; set; }

        [Required]
        public int min { get; set; }

        [Required]
        public int max { get; set; }

        public int? loadedVal { get; set; }

        [Range(0, 1)]
        public double loadedChance { get; set; }

        public DieCupModel()
        {
            count = 1;
            min = 1;
            max = 6;
            loadedChance = 0.5;
        }
    }
}