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
            user1.Email = "ClintonMoraes@gmail.com";
            user1.UserName = "Clinton Moraes";
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
            user2.UserName = "Mudrik Mohamed";
            user2.Status = "admin";
            user2.Password = "muhtar2006";
            // add user1 to the data context users
            context.Users.Add(user2);




            // Directors
            //create director1 object
            Director director1 = new Director();
            //create properties and assign some data
            director1.DirectorId = 1;
            director1.DirectorName = "Mudrik Mohamed";
            director1.DirectorDOB = "02/05/1997";
            director1.DirectorImage = "default.jpg";
            director1.Movies = new List<Movie>();
            // add to the data context
            context.Directors.Add(director1);

            // Directors
            //create director1 object
            Director director2 = new Director();
            //create properties and assign some data
            director2.DirectorId = 2;
            director2.DirectorName = "Dylan Patel";
            director2.DirectorDOB = "05/01/1998";
            director2.DirectorImage = "default.jpg";
            director2.Movies = new List<Movie>();
            // add to the data context
            context.Directors.Add(director2);

            // Directors
            //create director1 object
            Director director3 = new Director();
            //create properties and assign some data
            director3.DirectorId = 3;
            director3.DirectorName = "Ahmed Sheikh";
            director3.DirectorDOB = "17/09/1996";
            director3.DirectorImage = "default.jpg";
            director3.Movies = new List<Movie>();
            // add to the data context
            context.Directors.Add(director3);

            // Directors
            //create director1 object
            Director director4 = new Director();
            //create properties and assign some data
            director4.DirectorId = 4;
            director4.DirectorName = "Clinton Moraes";
            director4.DirectorDOB = "26/03/1997";
            director4.DirectorImage = "default.jpg";
            director4.Movies = new List<Movie>();
            // add to the data context
            context.Directors.Add(director4);

            // Directors
            //create director1 object
            Director director5 = new Director();
            //create properties and assign some data
            director5.DirectorId = 5;
            director5.DirectorName = "Komal Bhatti";
            director5.DirectorDOB = "11/03/2001";
            director5.DirectorImage = "default.jpg";
            director5.Movies = new List<Movie>();
            // add to the data context
            context.Directors.Add(director5);




            // Genras
            //create genra1 object
            Genre genre1 = new Genre();
			//create properties and assign some data
            genre1.GenreId = 1;
            genre1.GenreName = "Action";
			// add to the data context 
            context.Genres.Add(genre1);

            // Genras
            //create genra1 object
            Genre genre2 = new Genre();
            //create properties and assign some data
            genre2.GenreId = 2;
            genre2.GenreName = "Drama";
            // add to the data context 
            context.Genres.Add(genre2);


            // Genras
            //create genra1 object
            Genre genre3 = new Genre();
            //create properties and assign some data
            genre3.GenreId = 3;
            genre3.GenreName = "Comedy";
            // add to the data context 
            context.Genres.Add(genre3);

            // Genras
            //create genra1 object
            Genre genre4 = new Genre();
            //create properties and assign some data
            genre4.GenreId = 4;
            genre4.GenreName = "Horror";
            // add to the data context 
            context.Genres.Add(genre4);


            // Genras
            //create genra1 object
            Genre genre5 = new Genre();
            //create properties and assign some data
            genre5.GenreId = 5;
            genre5.GenreName = "Romance";
            // add to the data context 
            context.Genres.Add(genre5);

            // Genras
            //create genra1 object
            Genre genre6 = new Genre();
            //create properties and assign some data
            genre6.GenreId = 6;
            genre6.GenreName = "Fiction";
            // add to the data context 
            context.Genres.Add(genre6);

            // Genras
            //create genra1 object
            Genre genre7 = new Genre();
            //create properties and assign some data
            genre7.GenreId = 7;
            genre7.GenreName = "Adventure";
            // add to the data context 
            context.Genres.Add(genre7);

            

            // Movie 1
            Movie movie1 = new Movie();
            movie1.MovieId = 1;
            movie1.MovieTitle = "Harold and Kumar 2";
            movie1.MovieYear = 2001;
            movie1.MovieImage = "1.jpg";
            movie1.Genre = genre3;
            movie1.DirectorId = 2;
            movie1.Director = director1;
            director1.Movies.Add(movie1);
            movie1.Description = "Comedy movie based two friends misfortune";
            movie1.Actors = new List<Actor>();
            movie1.Reviews = new List<Review>();


            // Movie 2
            Movie movie2 = new Movie();
            movie2.MovieId = 2;
            movie2.MovieTitle = "Inception";
            movie2.MovieYear = 2010;
            movie2.MovieImage = "1.jpg";
            movie2.Genre = genre1;
            movie2.DirectorId = 2;
            movie2.Director = director2;
            director2.Movies.Add(movie2);
            movie2.Description = "A thief who steals corporate secrets through the use of dream-sharing technology";
            movie2.Actors = new List<Actor>();
            movie2.Reviews = new List<Review>();


            // Movie 3
            Movie movie3 = new Movie();
            movie3.MovieId = 3;
            movie3.MovieTitle = "The Wolf of Wall Street";
            movie3.MovieYear = 2013;
            movie3.MovieImage = "1.jpg";
            movie3.Genre = genre2;
            movie3.DirectorId = 3;
            movie3.Director = director3;
            director3.Movies.Add(movie3);
            movie3.Description = "Based on the true story of Jordan Belfort, from his rise to a wealthy stock-broker living the high life to his fall involving crime";
            movie3.Actors = new List<Actor>();
            movie3.Reviews = new List<Review>();


            // Movie 4
            Movie movie4 = new Movie();
            movie4.MovieId = 4;
            movie4.MovieTitle = "Django Unchained";
            movie4.MovieYear = 2012;
            movie4.MovieImage = "1.jpg";
            movie4.Genre = genre2;
            movie4.DirectorId = 4;
            movie4.Director = director4;
            director4.Movies.Add(movie4);
            movie4.Description = "With the help of a German bounty hunter, a freed slave sets out to rescue his wife from a brutal Mississippi plantation owner";
            movie4.Actors = new List<Actor>();
            movie4.Reviews = new List<Review>();


            // Movie 5
            Movie movie5 = new Movie();
            movie5.MovieId = 5;
            movie5.MovieTitle = "Hacksaw Ridge";
            movie5.MovieYear = 2013;
            movie5.MovieImage = "1.jpg";
            movie5.Genre = genre7;
            movie5.DirectorId = 5;
            movie5.Director = director5;
            director5.Movies.Add(movie5);
            movie5.Description = "World War II American Army Medic Desmond T. Doss, who served during the Battle of Okinawa, refuses to kill people, and becomes the first man in American history to receive the Medal of Honor without firing a shot";
            movie5.Actors = new List<Actor>();
            movie5.Reviews = new List<Review>();

            // Movie 6
            Movie movie6 = new Movie();
            movie6.MovieId = 6;
            movie6.MovieTitle = "Manchester by the Sea";
            movie6.MovieYear = 2013;
            movie6.MovieImage = "1.jpg";
            movie6.Genre = genre5;
            movie6.DirectorId = 1;
            movie6.Director = director1;
            director1.Movies.Add(movie6);
            movie6.Description = "A depressed uncle is asked to take care of his teenage nephew after the boy's father dies";
            movie6.Actors = new List<Actor>();
            movie6.Reviews = new List<Review>();


            // Movie 7
            Movie movie7 = new Movie();
            movie7.MovieId = 6;
            movie7.MovieTitle = "Creed 2";
            movie7.MovieYear = 2013;
            movie7.MovieImage = "1.jpg";
            movie7.Genre = genre5;
            movie7.DirectorId = 2;
            movie7.Director = director2;
            director2.Movies.Add(movie7);
            movie7.Description = "The former World Heavyweight Champion Rocky Balboa serves as a trainer and mentor to Adonis Johnson, the son of his late friend and former rival Apollo Creed";
            movie7.Actors = new List<Actor>();
            movie7.Reviews = new List<Review>();

            // Movie1 Actors
            var actorsMovie1 = new List<Actor>
            {
                new Actor {  ActorId = 1, ActorName = "Irbaaz Rangara", ActorImage="https://images.gulfnews.com/201903/190325%20salman_resources1-large.jpg", ActorGender = "Male", ActorDOB = "16/12/1997", Movies = new List<Movie>()},
                new Actor {  ActorId = 2, ActorName = "Anya Jamaican Girl", ActorImage="default.jpg",  ActorGender = "Female", ActorDOB = "02/07/2004", Movies = new List<Movie>()},
              
            };

            actorsMovie1.ForEach(actor => {
                context.Actors.Add(actor);
                movie1.Actors.Add(actor);
                actor.Movies.Add(movie1);
                });

            // Movi1 Reviews
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




                                                         // Movie2 Actors
            var actorsMovie2 = new List<Actor>
            {
                new Actor {  ActorId = 2, ActorName = " Leonardo DiCaprio", ActorImage="default.jpg", ActorGender = "Male", ActorDOB = "16/12/1980", Movies = new List<Movie>()},
                new Actor {  ActorId = 3, ActorName = " Tom Hardy", ActorImage="default.jpg",  ActorGender = "Male", ActorDOB = "02/07/1984", Movies = new List<Movie>()},

            };

            actorsMovie2.ForEach(actor => {
                context.Actors.Add(actor);
                movie2.Actors.Add(actor);
                actor.Movies.Add(movie2);
            });

            // Movi1 Reviews
            var reviewsMovie2 = new List<Review>
            {
                new Review { ReviewId = 3, ReviewTime = DateTime.Now, ReviewUser = user1.UserName, MovieId = movie1.MovieId, Description = "It wasn't what i was expecting" },
                new Review { ReviewId = 4, ReviewTime = DateTime.Now, ReviewUser = user2.UserName, MovieId = movie1.MovieId, Description = "doesn't meet all the hype behind it" },
            };

            reviewsMovie2.ForEach(review => {
                // add to the database
                context.Reviews.Add(review);
                // add to the list of movie reviews
                movie2.Reviews.Add(review);
            });


            context.Movies.Add(movie1);

            base.Seed(context);
        }

    }
#endif
}
