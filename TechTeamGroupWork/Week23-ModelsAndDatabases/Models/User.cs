using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace FilmReview.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        public string UserName { get; set; }
        
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public string Email { get; set; }
        public string Status { get; set; }

    }
}