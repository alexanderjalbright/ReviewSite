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
        public DbSet<Course> Reviews { get; set; }
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
                        Name = "C#",
                        Description = "C# is a Microsoft coding language."
                    },
                    new Category()
                    {
                        CategoryId = 2,
                        Name = "Python",
                        Description = "Python is, well, Python."
                    }
                );

            modelBuilder.Entity<Course>().HasData
                (
                    new Course()
                    {
                        Title = "Machine Learning",
                        CourseId = 1,
                        ImageURL = "/Images/machinelearning.jpg",
                        Overview = "Learn to use machine learning to your advantage.",
                        Summary = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.",
                        StartDate = "August 2nd, 2019",
                        Duration = "16 Weeks",
                        TagList = new List<string>() { "C#", "Algorithms", "Machine Learning" },
                        CategoryId = 1
                    },
                    new Course()
                    {
                        Title = "Python For Everybody",
                        CourseId = 2,
                        ImageURL = "/Images/pythonforeveryone.jpg",
                        Overview = "It really is for everybody!",
                        Summary = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.",
                        StartDate = "August 3rd, 2019",
                        Duration = "12 Weeks",
                        TagList = new List<string>() { "Python", "Algorithms", "Coding" },
                        CategoryId = 2

                    },
                    new Course()
                    {
                        Title = "WWKD?",
                        CourseId = 3,
                        ImageURL = "/Images/wwkd.jpg",
                        Overview = "What would Kyle do?",
                        Summary = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.",
                        StartDate = "August 4th, 2019",
                        Duration = "14 Weeks",
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
                        CourseId = 1


                    },
                    new UserReview()
                    {
                        UserReviewId = 2,
                        UserName = "SwagYoloFleekDabs",
                        Comment = "You get what you pay for and it's free.",
                        Rating = 4.1M,
                        CourseId = 1
                    },
                    new UserReview()
                    {
                        UserReviewId = 3,
                        UserName = "xXx_DragonSlayer_xXx",
                        Comment = "The instructors are racist.",
                        Rating = 3.9M,
                        CourseId = 1
                    },
                    new UserReview()
                    {
                        UserReviewId = 4,
                        UserName = "JoeLovesFishing_USA",
                        Comment = "The instructors love you like their own family!",
                        Rating = 4.9M,
                        CourseId = 2
                    },
                    new UserReview()
                    {
                        UserReviewId = 5,
                        UserName = "elDiablo1992",
                        Comment = "If I could experience Groundhog Day here, I'd still never get enough.",
                        Rating = 5.0M,
                        CourseId = 2
                    },
                    new UserReview()
                    {
                        UserReviewId = 6,
                        UserName = "W3CanC0d31T",
                        Comment = "This place attracts weirdos.",
                        Rating = 4.1M,
                        CourseId = 2
                    },
                    new UserReview()
                    {
                        UserReviewId = 7,
                        UserName = "anegronjr",
                        Comment = "I'd rather pay for college than this.",
                        Rating = 2.2M,
                        CourseId = 3
                    },
                    new UserReview()
                    {
                        UserReviewId = 8,
                        UserName = "alexanderjalbright",
                        Comment = "The carpets smell like urine.",
                        Rating = 1.7M,
                        CourseId = 3
                    },
                    new UserReview()
                    {
                        UserReviewId = 9,
                        UserName = "khanishvili",
                        Comment = "The coffee has a peculiar taste.",
                        Rating = 2.2M,
                        CourseId = 3
                    },
                    new UserReview()
                    {
                        UserReviewId = 10,
                        UserName = "jen3ten",
                        Comment = "PICK UP YOUR STARBUCKS CUPS!",
                        Rating = 2.3M,
                        CourseId = 3
                    },
                    new UserReview()
                    {
                        UserReviewId = 11,
                        UserName = "MaryMcGeary",
                        Comment = "I've learned more from 6th graders.",
                        Rating = 2.0M,
                        CourseId = 3
                    },
                    new UserReview()
                    {
                        UserReviewId = 12,
                        UserName = "mroyski",
                        Comment = "I can't see the board.",
                        Rating = 1.5M,
                        CourseId = 3
                    },
                    new UserReview()
                    {
                        UserReviewId = 13,
                        UserName = "aldenmolina",
                        Comment = "(╯°□°）╯︵ ┻━┻",
                        Rating = 3.0M,
                        CourseId = 3
                    },
                    new UserReview()
                    {
                        UserReviewId = 14,
                        UserName = "JoeScheiman",
                        Comment = "I think we can all agree that what Kyle would do and what Kyle will do are two different things.",
                        Rating = 3.0M,
                        CourseId = 3
                    },
                    new UserReview()
                    {
                        UserReviewId = 15,
                        UserName = "mew101",
                        Comment = "I'm just here for the oatmeal.",
                        Rating = 3.0M,
                        CourseId = 3
                    }
                );

            base.OnModelCreating(modelBuilder);


        }
    }
}
