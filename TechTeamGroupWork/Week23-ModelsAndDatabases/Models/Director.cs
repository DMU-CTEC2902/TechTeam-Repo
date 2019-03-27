using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FilmReview.Models
{
    public class Director
    {
        [Key]
        public int DirectorId {get; set;}

        public string DirectorName { get; set; }
        public string DirectorDOB { get; set; }
        public string DirectorImage { get; set; }
        
        public virtual ICollection<Movie> Movies {get; set;}
    }
}