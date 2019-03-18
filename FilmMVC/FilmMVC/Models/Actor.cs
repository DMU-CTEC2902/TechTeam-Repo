using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FilmMVC.Models
{
    public class Actor
    {
        public virtual int ActorId { get; set; }
        public virtual string Name { get; set; }
        public virtual string DateOfBirth { get; set; }

    }
}