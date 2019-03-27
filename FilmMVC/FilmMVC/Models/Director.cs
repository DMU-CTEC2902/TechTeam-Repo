using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FilmMVC.Models
{
    public class Director
    {
        public virtual int DirectorId { get; set; }
        public virtual string Name { get; set; }

        public DateTime DateOfBirth { get; set; }

        public virtual string Photo { get; set; }
        public virtual List<Film> Films { get; set; }
    }
}