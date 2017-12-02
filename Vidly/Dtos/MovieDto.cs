﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        public int GenreId { get; set; }

        public GenreDto Genre { get; set; }

        public DateTime RealeaseDate { get; set; }

        public DateTime DateAdded { get; set; }
        
        [Range(1, 20)]
        public byte NumberInSock { get; set; }
    }
}