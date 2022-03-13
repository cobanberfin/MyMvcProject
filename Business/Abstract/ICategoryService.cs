using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
  public  interface ICategoryService
    {
        List<Category> GetList();
        Category GetById(int id);
        void CategoryAdd(Category category);

        void Delete(Category category);

        void CategoryUpdate(Category category);
    }
}
