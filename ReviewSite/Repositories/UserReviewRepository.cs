using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ReviewSite.Models;
namespace ReviewSite.Repositories
{
    public class UserReviewRepository
    {
        ReviewContext db;
 
        public UserReviewRepository(ReviewContext db)
        {
            this.db = db;
        }
        public void Create(UserReview userreview) //Creates UserReview
        {
            db.Add(userreview);
            db.SaveChanges();
        }
        public void Edit(UserReview userreview)
        {
            db.Update(userreview);
            db.SaveChanges();
        }
        public void Delete(UserReview userreview)
        {
            db.Remove(userreview);
            db.SaveChanges();
        }
        public IEnumerable<UserReview> GetAll()
        {
            return db.UserReviews.ToList();
        }
        public UserReview GetById(int id)
        {
            return db.UserReviews.Single(userreview => userreview.UserReviewId == id);
        }
    }
}
