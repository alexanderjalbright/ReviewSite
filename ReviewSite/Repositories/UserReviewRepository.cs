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
        public void CreateReview(UserReview review) //Creates UserReview
        {
            db.Add(review);
            db.SaveChanges();
        }
        public void EditReview(UserReview review)
        {
            db.Update(review);
            db.SaveChanges();
        }
        public void Delete(UserReview review)
        {
            db.Remove(review);
            db.SaveChanges();
        }
    }
}
