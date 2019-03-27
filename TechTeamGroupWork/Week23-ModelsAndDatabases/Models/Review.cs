using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FilmReview.Models
{
    public class Review
    {
        [Key]
        public int ReviewId {get; set;}

        public string Description { get; set; }
        public DateTime ReviewTime { get; set; }
        public string ReviewUser { get; set; }
        public int MovieId { get; set; }

        //public virtual ICollection<Comment> Comments { get; set; }
    }
}