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
                new Review("Machine Learning", 1, "Algorithms", "/Images/machinelearning.jpg", "Learn to use machine learning to your advantage.", "Learn Machine learning.", new List<string>() { "Its free!", "You get what you pay for and it's free.", "The instructors are racist." }),
                new Review("Python For Everybody", 2, "Python", "/Images/pythonforeveryone.jpg", "It really is for everybody!", "Er'body can!", new List<string>() { "Its so close!", "The carpets smell like urine.", "The coffee has a peculiar taste." }),
                new Review("WWKD?", 3, "What would Kyle do?", "/Images/wwkd.jpg", "It's definitely not for everybody!", "Some people can!", new List<string>() { "The instructors love you like their own family!", "If I could experience Groundhog Day here, I'd still never get enough.", "This place attracts weirdos." })
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
