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
        public DbSet<Review> Reviews { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=nbnReviewSite;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString)
                          .UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Review>().HasData(
                new Review()
                {
                    Title = "Machine Learning",
                    Id = 1,
                    Category = "Algorithms",
                    ImageURL = "/Images/machinelearning.jpg",
                    Overview = "Learn to use machine learning to your advantage.",
                    Summary = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.",
                    TagList = new List<string>() { "C#", "Algorithms", "Machine Learning" },
                    UserOpinionList = new List<UserReview>()
                    {
                        new UserReview()
                        {
                            UserName = "MoocJunkie",
                            Comment = "Its free!",
                            Rating = 3.3M
                        },
                        new UserReview()
                        {
                            UserName = "SwagYoloFleekDabs",
                            Comment = "You get what you pay for and it's free.",
                            Rating = 4.1M
                        },
                        new UserReview(){
                            UserName = "xXx_DragonSlayer_xXx",
                            Comment = "The instructors are racist.",
                            Rating = 3.9M
                        }

                    }
                },
                new Review()
                {
                    Title = "Python For Everybody",
                    Id = 2,
                    Category = "Python",
                    ImageURL = "/Images/pythonforeveryone.jpg",
                    Overview = "It really is for everybody!",
                    Summary = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.",
                    TagList = new List<string>() { "Python", "Algorithms", "Coding" },
                    UserOpinionList = new List<UserReview>()
                    {
                        new UserReview()
                        {
                            UserName = "JoeLovesFishing_USA",
                            Comment = "The instructors love you like their own family!",
                            Rating = 4.9M
                        },
                        new UserReview()
                        {
                            UserName = "elDiablo1992",
                            Comment = "If I could experience Groundhog Day here, I'd still never get enough.",
                            Rating = 5.0M
                        },
                        new UserReview()
                        {
                            UserName = "W3CanC0d31T",
                            Comment = "This place attracts weirdos.",
                            Rating = 4.1M
                        }
                    }
                },
                new Review()
                {
                    Title = "WWKD?",
                    Id = 3,
                    Category = "What would Kyle do?",
                    ImageURL = "/Images/wwkd.jpg",
                    Overview = "It's definitely not for everybody!",
                    Summary = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.",
                    TagList = new List<string>() { "C#", "ASP.NET", "MVC" },
                    UserOpinionList = new List<UserReview>()
                    {
                        new UserReview()
                        {
                            UserName = "anegronjr",
                            Comment = "Its so close!",
                            Rating = 2.2M
                        },
                        new UserReview()
                        {
                            UserName = "alexanderjalbright",
                            Comment = "The carpets smell like urine.",
                            Rating = 1.7M
                        },
                        new UserReview()
                        {
                            UserName = "khanishvili",
                            Comment = "The coffee has a peculiar taste.",
                            Rating = 2.2M
                        },
                        new UserReview()
                        {
                            UserName = "jen3ten",
                            Comment = "The coffee has a peculiar taste.",
                            Rating = 2.3M
                        },
                        new UserReview()
                        {
                            UserName = "MaryMcGeary",
                            Comment = "The coffee has a peculiar taste.",
                            Rating = 2.0M
                        },
                        new UserReview()
                        {
                            UserName = "mroyski",
                            Comment = "The coffee has a peculiar taste.",
                            Rating = 1.5M
                        },
                        new UserReview()
                        {
                            UserName = "aldenmolina",
                            Comment = "The coffee has a peculiar taste.",
                            Rating = 3.0M
                        },
                        new UserReview()
                        {
                            UserName = "JoeScheiman",
                            Comment = "The coffee has a peculiar taste.",
                            Rating = 3.0M
                        }
                    }
                }
                );
            base.OnModelCreating(modelBuilder);
        }
    }
}
