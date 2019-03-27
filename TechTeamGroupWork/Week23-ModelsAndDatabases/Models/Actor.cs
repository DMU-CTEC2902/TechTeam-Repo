using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FilmReview.Models
{
    public class Actor
    {
        [Key]
        public int ActorId { get; set; }

        public string ActorName { get; set; }
        public string ActorImage { get; set; }
        public string ActorDOB { get; set; }
        public string ActorGender { get; set; }
        

        public virtual ICollection<Movie> Movies { get; set; }
    }
}