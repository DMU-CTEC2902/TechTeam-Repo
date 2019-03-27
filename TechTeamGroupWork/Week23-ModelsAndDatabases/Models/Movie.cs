using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FilmReview.Models
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }
        public int DirectorId { get; set; }
        public string MovieTitle { get; set; }
        public string Description { get; set; }
        public int MovieYear { get; set; }
        public string MovieImage { get; set; }

        public virtual Genre Genra { get; set; }
        public virtual Director Director { get; set; }
 
        public virtual ICollection<Actor> Actors { get; set; }
        public virtual ICollection<Review> Reviews {get; set;}
    }
}