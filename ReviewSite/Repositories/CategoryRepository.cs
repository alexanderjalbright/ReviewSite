using ReviewSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewSite.Repositories
{
    public class CategoryRepository
    {
        ReviewContext db;

        public CategoryRepository(ReviewContext db)
        {
            this.db = db;
        }

        public int Count()
        {
            int count = db.Categories.Count();

            return count;
        }

        public IEnumerable<Category> GetAll()
        {
            return db.Categories.ToList();
        }

        public Category GetById(int id)
        {
            return db.Categories.Single(category => category.CategoryId == id);
        }
    }
}
