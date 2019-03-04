using Microsoft.AspNetCore.Mvc;
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
            int count = db.Courses.Count();

            return count;
        }

        public IEnumerable<Course> GetAll()
        {
            return db.Courses.ToList();
        }

        public Course GetById(int id)
        {

            return db.Courses.Single(review => review.CourseId == id);
        }

 
        public void CreateUserReview(UserReview review)
        {
            db.UserReviews.Add(review);
            db.SaveChanges();
        }
        public void DeleteUserReview(UserReview review)
        {
            db.UserReviews.Remove(review);
            db.SaveChanges();
        }

        public void EditUserReview(UserReview review)
        {
            db.UserReviews.Update(review);
            db.SaveChanges();
        }
    }
}
