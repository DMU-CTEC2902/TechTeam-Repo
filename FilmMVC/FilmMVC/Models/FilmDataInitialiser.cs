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
            dir1.Photo = "https://m.media-amazon.com/images/M/MV5BMTc2NzcyMDU5NV5BMl5BanBnXkFtZTcwODc1OTM0NA@@._V1_SY1000_CR0,0,717,1000_AL_.jpg";
            context.Directors.Add(dir1);
            //director 2
            Director dir2 = new Director();
            dir2.DirectorId = 2;
            dir2.Name = "George Lucas";
            dir2.DateOfBirth = Convert.ToDateTime("14/05/1944");
            dir1.Photo = "https://m.media-amazon.com/images/M/MV5BMTA0Mjc0NzExNzBeQTJeQWpwZ15BbWU3MDEzMzQ3MDI@._V1_.jpg";
            context.Directors.Add(dir2);
            //director 3
            Director dir3 = new Director();
            dir3.DirectorId = 3;
            dir3.Name = "Ryan Coogler";
            dir3.DateOfBirth = Convert.ToDateTime("23/05/1986");
            dir1.Photo = "https://m.media-amazon.com/images/M/MV5BMjI2MTYyNzU1MV5BMl5BanBnXkFtZTgwNTE4NzI5NzE@._V1_.jpg";
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
            //film4
            Film fil4 = new Film();
            fil4.FilmId = 4;
            fil4.DirectorId = 1;
            fil4.Title = "Transformers Revenge of the Fallen";
            fil4.Description = "Transformers 2.";
            fil4.Year = 2009;
            fil4.Image = "https://m.media-amazon.com/images/M/MV5BNjk4OTczOTk0NF5BMl5BanBnXkFtZTcwNjQ0NzMzMw@@._V1_SY1000_CR0,0,674,1000_AL_.jpg";
            fil4.Director = dir1;
            context.Films.Add(fil4);
            //film5
            Film fil5 = new Film();
            fil5.FilmId = 5;
            fil5.DirectorId = 1;
            fil5.Title = "Transformers Dark of the Moon";
            fil5.Description = "Transformers 3.";
            fil5.Year = 2011;
            fil5.Image = "https://m.media-amazon.com/images/M/MV5BMTkwOTY0MTc1NV5BMl5BanBnXkFtZTcwMDQwNjA2NQ@@._V1_SY1000_CR0,0,668,1000_AL_.jpg";
            fil5.Director = dir1;
            context.Films.Add(fil5);
            //film6
            Film fil6 = new Film();
            fil6.FilmId = 6;
            fil6.DirectorId = 3;
            fil6.Title = "Creed";
            fil6.Description = "Son of Adonis Creed seeks out Rocky Balboa to become his trainer.";
            fil6.Year = 2015;
            fil6.Image = "https://m.media-amazon.com/images/M/MV5BODg5NDM1MDI4NF5BMl5BanBnXkFtZTgwMzg0MzQxNzE@._V1_SY1000_CR0,0,674,1000_AL_.jpg";
            fil6.Director = dir3;
            context.Films.Add(fil6);
            //film7
            Film fil7 = new Film();
            fil7.FilmId = 7;
            fil7.DirectorId = 2;
            fil7.Title = "Star Wars: Episode I - The Phantom Menace";
            fil7.Description = "Two Jedi come across a young boy that could be the chosen one.";
            fil7.Year = 1999;
            fil7.Image = "https://m.media-amazon.com/images/M/MV5BYTRhNjcwNWQtMGJmMi00NmQyLWE2YzItODVmMTdjNWI0ZDA2XkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_SY999_SX666_AL_.jpg";
            fil7.Director = dir2;
            context.Films.Add(fil7);
            //film8
            Film fil8 = new Film();
            fil8.FilmId = 8;
            fil8.DirectorId = 2;
            fil8.Title = "Star Wars: Episode III - Revenge of the Sith";
            fil8.Description = "Anakin grows closer to Palpatine.";
            fil8.Year = 2005;
            fil8.Image = "https://m.media-amazon.com/images/M/MV5BNTc4MTc3NTQ5OF5BMl5BanBnXkFtZTcwOTg0NjI4NA@@._V1_SY1000_SX750_AL_.jpg";
            fil8.Director = dir2;
            context.Films.Add(fil8);

            base.Seed(context);

        }
    }
}