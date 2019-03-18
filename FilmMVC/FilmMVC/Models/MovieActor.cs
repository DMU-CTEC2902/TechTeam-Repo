using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FilmMVC.Models
{
    public class MovieActor
    {
        public virtual int MovieActorId { get; set; }

        public virtual int ActorId { get; set; }
        public virtual int FilmId { get; set; }

    }
}