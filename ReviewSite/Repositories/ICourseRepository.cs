using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ReviewSite.Models;
namespace ReviewSite.Repositories
{
  public  interface ICourseRepository
    {
        int Count();
        IEnumerable<Course> GetAll();
        Course GetById(int id);
        void CreateUserReview(UserReview review); 
        void DeleteUserReview(UserReview review);
        void EditUserReview(List<UserReview> reviews);
    }
}
