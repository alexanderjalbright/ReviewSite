using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ReviewSite.Models;
namespace ReviewSite.Repositories
{
  public  interface ICategoryRepository
    {
        int Count();
        IEnumerable<Category> GetAll();
        Category GetById(int id);
        void CreateCategory(Category category);
        void DeleteCategory(Category category);
        void EditCategory(Category category);
    }
}
