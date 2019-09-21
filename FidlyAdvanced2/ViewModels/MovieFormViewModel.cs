using FidlyAdvanced2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FidlyAdvanced2.ViewModels
{
    public class MovieFormViewModel
    {
        public IEnumerable<GenreType> GenreTypes { get; set; }
        public Movie Movie { get; set; }
        public String Title {
            get
            {
                if (Movie != null)
                    return "Edit Movie";
                return "New Movie";
            }
        }
    }
}