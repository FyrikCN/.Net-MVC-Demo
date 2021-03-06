﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FidlyAdvanced2.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Released Date")]
        public DateTime ReleaseDate { get; set; }

        public DateTime AddedDate { get; set; }

        [Required]
        [Display(Name = "Numebr in Stock")]
        [Range(1, 20)]
        public int NumberInStock { get; set; }

        public GenreType GenreType { get; set; }

        [Display(Name = "Genre")]
        public byte? GenreTypeId { get; set; }
    }
}