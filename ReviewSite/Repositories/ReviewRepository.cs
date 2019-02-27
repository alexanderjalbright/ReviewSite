using ReviewSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewSite.Repositories
{
    public class ReviewRepository
    {
        ReviewContext db;

        public ReviewRepository(ReviewContext db)
        {
            this.db = db;
        } 

        public int Count()
        {
            int count = db.Reviews.Count();

            return count;
        }

        public IEnumerable<Review> GetAll()
        {
            return db.Reviews.ToList();
        }

        public Review GetById(int id)
        {            
            return db.Reviews.Single(review => review.Id == id);
        }
    }
}
