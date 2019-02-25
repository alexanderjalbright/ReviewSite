using ReviewSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewSite.Repositories
{
    public class ReviewRepository
    {
        List<Review> reviewList;

        public ReviewRepository()
        {
            reviewList = new List<Review>()
            {
                new Review
                (
                    "Machine Learning",
                    1,
                    "Algorithms",
                    "/Images/machinelearning.jpg",
                    "Learn to use machine learning to your advantage.",
                    "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.",
                    new List<string>() {"C#", "Algorithms", "Machine Learning"},
                    new List<UserReview>()
                    {
                        new UserReview("MoocJunkie", "Its free!", 3.3M),
                        new UserReview("SwagYoloFleekDabs", "You get what you pay for and it's free.", 4.1M),
                        new UserReview("xXx_DragonSlayer_xXx", "The instructors are racist.", 3.9M)

                    }
                ),
                new Review
                (
                    "Python For Everybody", 
                    2, 
                    "Python", 
                    "/Images/pythonforeveryone.jpg", 
                    "It really is for everybody!", 
                    "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.",
                    new List<string>() {"Python", "Algorithms", "Coding"},
                    new List<UserReview>()
                    {
                        new UserReview("JoeLovesFishing_USA", "The instructors love you like their own family!", 4.9M),
                        new UserReview("elDiablo1992", "If I could experience Groundhog Day here, I'd still never get enough.", 5.0M),
                        new UserReview("W3CanC0d31T", "This place attracts weirdos.", 4.1M)
                    }
                ),
                new Review
                (
                    "WWKD?", 
                    3, 
                    "What would Kyle do?", 
                    "/Images/wwkd.jpg", 
                    "It's definitely not for everybody!", 
                    "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.",
                    new List<string>() {"C#", "ASP.NET", "MVC"},
                    new List<UserReview>()
                    {
                        new UserReview("anegronjr", "Its so close!", 2.2M),
                        new UserReview("alexanderjalbright", "The carpets smell like urine.", 1.7M),
                        new UserReview("khanishvili", "The coffee has a peculiar taste.", 2.2M),
                        new UserReview("jen3ten", "The coffee has a peculiar taste.", 2.3M),
                        new UserReview("MaryMcGeary", "The coffee has a peculiar taste.", 2.0M),
                        new UserReview("mroyski", "The coffee has a peculiar taste.", 1.5M),
                        new UserReview("aldenmolina", "The coffee has a peculiar taste.", 3.0M),
                        new UserReview("JoeScheiman", "The coffee has a peculiar taste.", 3.0M)                        
                    }
                )
            };
        } 

        public int Count()
        {
            int count = reviewList.Count;

            return count;
        }

        public List<Review> GetAll()
        {
            return reviewList;
        }

        public Review GetById(int id)
        {
            Review review = new Review();

            foreach (Review eachOne in reviewList)
            {
                if(eachOne.Id == id)
                {
                    review = eachOne;
                }
            }

            return review;
        }
    }
}
