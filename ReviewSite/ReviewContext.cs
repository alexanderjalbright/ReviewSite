using Microsoft.EntityFrameworkCore;
using ReviewSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewSite
{
    public class ReviewContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<UserReview> UserReviews { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=nbnReviewSite;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString)
                          .UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData
                (
                    new Category()
                    {
                        CategoryId = 1,
                        Name = "C#"
                    },
                    new Category()
                    {
                        CategoryId = 2,
                        Name = "Python"
                    }
                );

            modelBuilder.Entity<Review>().HasData
                (
                    new Review()
                    {
                        Title = "Machine Learning",
                        ReviewId = 1,
                        ImageURL = "/Images/machinelearning.jpg",
                        Overview = "Learn to use machine learning to your advantage.",
                        Summary = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.",
                        TagList = new List<string>() { "C#", "Algorithms", "Machine Learning" },
                        CategoryId = 1
                    },
                    new Review()
                    {
                        Title = "Python For Everybody",
                        ReviewId = 2,
                        ImageURL = "/Images/pythonforeveryone.jpg",
                        Overview = "It really is for everybody!",
                        Summary = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.",
                        TagList = new List<string>() { "Python", "Algorithms", "Coding" },
                        CategoryId = 2

                    },
                    new Review()
                    {
                        Title = "WWKD?",
                        ReviewId = 3,
                        ImageURL = "/Images/wwkd.jpg",
                        Overview = "What would Kyle do?",
                        Summary = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.",
                        TagList = new List<string>() { "C#", "ASP.NET", "MVC" },
                        CategoryId = 1
                    }
                );

            modelBuilder.Entity<UserReview>().HasData
                (

                    new UserReview()
                    {
                        UserReviewId = 1,
                        UserName = "MoocJunkie",
                        Comment = "Its free!",
                        Rating = 3.3M,
                        ReviewId = 1


                    },
                    new UserReview()
                    {
                        UserReviewId = 2,
                        UserName = "SwagYoloFleekDabs",
                        Comment = "You get what you pay for and it's free.",
                        Rating = 4.1M,
                        ReviewId = 1
                    },
                    new UserReview() {
                        UserReviewId = 3,
                        UserName = "xXx_DragonSlayer_xXx",
                        Comment = "The instructors are racist.",
                        Rating = 3.9M,
                        ReviewId = 1
                    },
                    new UserReview()
                    {
                        UserReviewId = 4,
                        UserName = "JoeLovesFishing_USA",
                        Comment = "The instructors love you like their own family!",
                        Rating = 4.9M,
                        ReviewId = 2
                    },
                    new UserReview()
                    {
                        UserReviewId = 5,
                        UserName = "elDiablo1992",
                        Comment = "If I could experience Groundhog Day here, I'd still never get enough.",
                        Rating = 5.0M,
                        ReviewId = 2
                    },
                    new UserReview()
                    {
                        UserReviewId = 6,
                        UserName = "W3CanC0d31T",
                        Comment = "This place attracts weirdos.",
                        Rating = 4.1M,
                        ReviewId = 2
                    },
                    new UserReview()
                    {
                        UserReviewId = 7,
                        UserName = "anegronjr",
                        Comment = "Its so close!",
                        Rating = 2.2M,
                        ReviewId = 3
                    },
                    new UserReview()
                    {
                        UserReviewId = 8,
                        UserName = "alexanderjalbright",
                        Comment = "The carpets smell like urine.",
                        Rating = 1.7M,
                        ReviewId = 3
                    },
                    new UserReview()
                    {
                        UserReviewId = 9,
                        UserName = "khanishvili",
                        Comment = "The coffee has a peculiar taste.",
                        Rating = 2.2M,
                        ReviewId = 3
                    },
                    new UserReview()
                    {
                        UserReviewId = 10,
                        UserName = "jen3ten",
                        Comment = "The coffee has a peculiar taste.",
                        Rating = 2.3M,
                        ReviewId = 3
                    },
                    new UserReview()
                    {
                        UserReviewId = 11,
                        UserName = "MaryMcGeary",
                        Comment = "The coffee has a peculiar taste.",
                        Rating = 2.0M,
                        ReviewId = 3
                    },
                    new UserReview()
                    {
                        UserReviewId = 12,
                        UserName = "mroyski",
                        Comment = "The coffee has a peculiar taste.",
                        Rating = 1.5M,
                        ReviewId = 3
                    },
                    new UserReview()
                    {
                        UserReviewId = 13,
                        UserName = "aldenmolina",
                        Comment = "The coffee has a peculiar taste.",
                        Rating = 3.0M,
                        ReviewId = 3
                    },
                    new UserReview()
                    {
                        UserReviewId = 14,
                        UserName = "JoeScheiman",
                        Comment = "The coffee has a peculiar taste.",
                        Rating = 3.0M,
                        ReviewId = 3
                    }
                );

            base.OnModelCreating(modelBuilder);
            
                
        }
    }
}
