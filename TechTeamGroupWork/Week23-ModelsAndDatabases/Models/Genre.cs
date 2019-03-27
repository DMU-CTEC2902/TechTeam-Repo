using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FilmReview.Models
{
    public class Genre
    {
        [Key]
        public int GenraId { get; set; }
        
        public string GenraType { get; set; }
    }
}