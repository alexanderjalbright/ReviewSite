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
                new Review("Machine Learning", 1, "C#", "./images/MachineLearning.jpg", "It was really awesome", "It awesome"),
                new Review("Python For Everybody", 2, "Python", "./images/PythonForEveryone.jpg", "It really is for everybody!", "Er'body can!"),
                new Review("Web Applications For Everybody", 3, "MVC", "./images/WebAppsForEveryone.jpg", "It definitely not for everybody!", "Some people can!")
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
