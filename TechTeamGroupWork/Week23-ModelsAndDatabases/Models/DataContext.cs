using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

using System.Diagnostics;

using FilmReview.Models;

namespace FilmReview.Models
{
    public class DataContext : DbContext
    {

        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx

        public DataContext() : base("name=DataContext")
        {
            //Debug.Write(Database.Connection.ConnectionString);
        }

        public System.Data.Entity.DbSet<Movie> Movies { get; set; }
        public System.Data.Entity.DbSet<Genre> Genras { get; set; }
        public System.Data.Entity.DbSet<Director> Directors { get; set; }
        public System.Data.Entity.DbSet<Actor> Actors { get; set; }
        public System.Data.Entity.DbSet<Review> Reviews { get; set; }

        public System.Data.Entity.DbSet<User> Users { get; set; }

    }
}
