using ReviewSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewSite.Repositories
{
    public class CourseRepository
    {
        ReviewContext db;

        public CourseRepository(ReviewContext db)
        {
            this.db = db;
        } 

        public int Count()
        {
            int count = db.Reviews.Count();

            return count;
        }

        public IEnumerable<Course> GetAll()
        {
            return db.Reviews.ToList();
        }

        public CourseAndUserReview GetById(int id)
        {
            var model = new CourseAndUserReview();

            model.Course = db.Reviews.Single(review => review.CourseId == id);

            return model;
        }
    }
}
