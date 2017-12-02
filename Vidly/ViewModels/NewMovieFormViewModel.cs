using System;
using Vidly.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Vidly.ViewModels
{
    public class NewMovieFormViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }

        public int? Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Display(Name = "Genre")]
        [Required]
        public int? GenreId { get; set; }

        [Display(Name = "Release Date")]

        [Required]
        public DateTime? RealeaseDate { get; set; }

        [Display(Name = "Number in Stock")]
        [Range(1, 20)]
        [Required]
        public byte? NumberInSock { get; set; }

        public string Title
        {
            get
            {
               return (Id != 0)? "Edit Movie" : "New Movie";
            }
        }

        public NewMovieFormViewModel()
        {
            Id = 0;
        }

        public NewMovieFormViewModel(Movie movie)
        {
            Id = movie.Id;
            Name = movie.Name;
            RealeaseDate = movie.RealeaseDate;
            NumberInSock = movie.NumberInSock;
            GenreId = movie.GenreId;
        }
    }
}