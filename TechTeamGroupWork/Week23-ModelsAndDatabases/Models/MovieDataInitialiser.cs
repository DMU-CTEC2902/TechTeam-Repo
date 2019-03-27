using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace FilmReview.Models
{

#if true
    public class MovieDataInitialiser : DropCreateDatabaseAlways<DataContext>
    {


        protected override void Seed(DataContext context)
        {
            // Users
			//create user object
            User user1 = new User();
			//create user properties and assign some data
            user1.UserId = 1;
            user1.Email = "khalid@gmail.com";
            user1.UserName = "Khalid Moallim";
            user1.Status = "admin";
            user1.Password = "123456";
			// add user1 to the data context users
            context.Users.Add(user1);

            // Users
            //create user object
            User user2 = new User();
            //create user properties and assign some data
            user2.UserId = 2;
            user2.Email = "mohamed.mudrik@ymail.com";
            user2.UserName = "MudrikMohamed";
            user2.Status = "admin";
            user2.Password = "muhtar2006";
            // add user1 to the data context users
            context.Users.Add(user1);

            // Genras
            //create genra1 object
            Genre genra1 = new Genre();
			//create properties and assign some data
            genra1.GenraId = 1;
            genra1.GenraType = "Action";
			// add to the data context 
            context.Genras.Add(genra1);
          
          

            // Directors
			//create director1 object
            Director director1 = new Director();
			//create properties and assign some data
            director1.DirectorId = 1;
            director1.DirectorName = "Khalid Moallim";
            director1.DirectorDOB = "05/01/1995";
            director1.DirectorImage = "default.jpg";
            director1.Movies = new List<Movie>();
			// add to the data context
            context.Directors.Add(director1);


            // Movie 1
            Movie movie1 = new Movie();
            movie1.MovieId = 1;
            movie1.MovieTitle = "Black Hawk Down";
            movie1.MovieYear = 2001;
            movie1.MovieImage = "1.jpg";
            movie1.Genra = genra1;
            movie1.DirectorId = 2;
            movie1.Director = director1;
            director1.Movies.Add(movie1);
            movie1.Description = "Action movie based on real event";
            movie1.Actors = new List<Actor>();
            movie1.Reviews = new List<Review>();

            // Movie Actors
            var actorsMovie1 = new List<Actor>
            {
                new Actor {  ActorId = 1, ActorName = "Ali Moallim", ActorImage="default.jpg", ActorGender = "Male", ActorDOB = "10/10/1990", Movies = new List<Movie>()},
                new Actor {  ActorId = 2, ActorName = "Ise Moallim", ActorImage="default.jpg",  ActorGender = "Male", ActorDOB = "02/07/1980", Movies = new List<Movie>()},
                new Actor {  ActorId = 3, ActorName = "Yasmin Geele", ActorImage="default.jpg", ActorGender = "Female", ActorDOB = "05/08/1999", Movies = new List<Movie>()}
            };

            actorsMovie1.ForEach(actor => {
                context.Actors.Add(actor);
                movie1.Actors.Add(actor);
                actor.Movies.Add(movie1);
                });

            // Movie Reviews
            var reviewsMovie1 = new List<Review>
            {
                new Review { ReviewId = 1, ReviewTime = DateTime.Now, ReviewUser = user1.UserName, MovieId = movie1.MovieId, Description = "This movie is very cool" },
                new Review { ReviewId = 2, ReviewTime = DateTime.Now, ReviewUser = user2.UserName, MovieId = movie1.MovieId, Description = "I like this movie, it is very fantastic" },
            };

            reviewsMovie1.ForEach(review => {
                // add to the database
                context.Reviews.Add(review);
                // add to the list of movie reviews
                movie1.Reviews.Add(review);
            });


            context.Movies.Add(movie1);

            base.Seed(context);
        }

    }
#endif
}
