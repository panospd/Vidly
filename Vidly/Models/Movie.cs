﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name="Title")]
        public string Name { get; set; }

        
        public Genre Genre { get; set; }
        [Display(Name="Genre")]
        [Required]
        public int GenreId { get; set; }

        [Display(Name="Release Date")]
        public DateTime RealeaseDate { get; set; }

        public DateTime DateAdded { get; set; }

        [Display(Name="Number in Stock")]
        [Range(1,20)]
        public byte NumberInSock { get; set; }

        public byte NumberAvailable { get; set; }
    }
}