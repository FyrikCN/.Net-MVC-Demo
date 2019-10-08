using FidlyAdvanced2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FidlyAdvanced2.ViewModels
{
    public class MovieFormViewModel
    {
        public IEnumerable<GenreType> GenreTypes { get; set; }

        public int? Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Released Date")]
        public DateTime? ReleaseDate { get; set; }
        
        [Required]
        [Display(Name = "Numebr in Stock")]
        [Range(1, 20)]
        public int? NumberInStock { get; set; }

        [Required]
        [Display(Name = "Genre")]
        public byte? GenreTypeId { get; set; }

        public MovieFormViewModel(Movie movie)
        {
            Id = movie.Id;
            Name = movie.Name;
            ReleaseDate = movie.ReleaseDate;
            NumberInStock = movie.NumberInStock;
            GenreTypeId = movie.GenreTypeId;
        }

        public MovieFormViewModel()
        {
            Id = 0;
        }

        public String Title {
            get
            {
                return (Id == 0) ? "New Movie" : "Edit Movie";
            }
        }
    }
}