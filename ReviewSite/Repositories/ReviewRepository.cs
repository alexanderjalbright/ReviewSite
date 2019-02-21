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
                new Review("Machine Learning", 1),
                new Review("Python For Everybody", 2),
                new Review("Web Applications For Everybody", 3)
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
