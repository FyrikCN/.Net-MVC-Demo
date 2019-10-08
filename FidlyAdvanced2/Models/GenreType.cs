using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FidlyAdvanced2.Models
{
    public class GenreType
    {
        public byte Id { get; set; }
        
        [Display(Name = "Genre")]
        public string Name { get; set; }
    }
}