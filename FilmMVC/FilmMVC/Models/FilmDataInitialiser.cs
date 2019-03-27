using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace FilmMVC.Models
{
    public class FilmDataInitialiser: DropCreateDatabaseAlways<FilmContext>
    {
        protected override void Seed(FilmContext context)
        {
            //Directors

            //director 1
            Director dir1 = new Director();
            dir1.DirectorId = 1;
            dir1.Name = "Michael Bay";
            dir1.DateOfBirth = Convert.ToDateTime("17/02/1965");
            context.Directors.Add(dir1);
            //director 2
            Director dir2 = new Director();
            dir2.DirectorId = 2;
            dir2.Name = "George Lucas";
            dir2.DateOfBirth = Convert.ToDateTime("14/05/1944");
            context.Directors.Add(dir2);
            //director 3
            Director dir3 = new Director();
            dir3.DirectorId = 3;
            dir3.Name = "Ryan Coogler";
            dir3.DateOfBirth = Convert.ToDateTime("23/05/1986");
            context.Directors.Add(dir3);

            //Films

            //film1
            Film fil1 = new Film();
            fil1.FilmId = 1;
            fil1.DirectorId = 1;
            fil1.Title = "Transformers";
            fil1.Description = "Autobots with the help of a teenager battle Decepticons for an acient object on Earth.";
            fil1.Year = 2007;
            fil1.Image = "https://m.media-amazon.com/images/M/MV5BNDg1NTU2OWEtM2UzYi00ZWRmLWEwMTktZWNjYWQ1NWM1OThjXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_SY1000_CR0,0,674,1000_AL_.jpg";
            fil1.Director = dir1;
            context.Films.Add(fil1);
            //film2
            Film fil2 = new Film();
            fil2.FilmId = 2;
            fil2.DirectorId = 2;
            fil2.Title = "Star Wars: Episode IV - A New Hope";
            fil2.Description = "Luke Skywalker joins a Jedi, a pilot and a wookie to save the galaxy from the Empire whilst trying to rescue Princess Leia.";
            fil2.Year = 1977;
            fil2.Image = "https://m.media-amazon.com/images/M/MV5BNzVlY2MwMjktM2E4OS00Y2Y3LWE3ZjctYzhkZGM3YzA1ZWM2XkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_SY1000_CR0,0,643,1000_AL_.jpg";
            fil2.Director = dir2;
            context.Films.Add(fil2);
            //film3
            Film fil3 = new Film();
            fil3.FilmId = 3;
            fil3.DirectorId = 3;
            fil3.Title = "Black Panther";
            fil3.Description = "Prince T'Challa must take on the mantle as king of Wakanda and deal with civil unrest along with being Black panther.";
            fil3.Year = 2018;
            fil3.Image = "https://m.media-amazon.com/images/M/MV5BMTg1MTY2MjYzNV5BMl5BanBnXkFtZTgwMTc4NTMwNDI@._V1_SY1000_CR0,0,674,1000_AL_.jpg";
            fil3.Director = dir3;
            context.Films.Add(fil3);

            base.Seed(context);




        }
    }
}