﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FilmReview.Models
{
    public class Genre
    {
        [Key]
        public int GenreId { get; set; }
        
        public string GenreName { get; set; }
    }
}