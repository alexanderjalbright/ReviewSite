using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewSite.Models
{
    public class CourseAndUserReview
    {

        public Course Course { get; set; }
        
        public UserReview NewUserReview { get; set; }

        public CourseAndUserReview()
        {
            NewUserReview = new UserReview();
        }

    }
}
