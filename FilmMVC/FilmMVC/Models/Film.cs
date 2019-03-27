using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FilmMVC.Models
{
    public class Film
    {
        public virtual int FilmId { get; set; }
        public virtual int DirectorId { get; set; }
        public virtual string Title { get; set; }
        public virtual string Description { get; set; }
        public virtual int Year { get; set; }

        public virtual string Image { get; set; }
        public virtual Director Director { get; set; }

    }
}