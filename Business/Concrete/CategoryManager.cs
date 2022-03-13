using Business.Abstract;
using DataAcess.Abstract;
using DataAcess.Concrete.Repository;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal; //dependecy
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;

        }

        public void CategoryAdd(Category category)
        {
            _categoryDal.Insert(category);
        }

        public void CategoryUpdate(Category category)
        {
            _categoryDal.Update(category);
        }

        public void Delete(Category category)
        {

            _categoryDal.Delete(category);
        }

        public Category GetById(int id)
        {
           return  _categoryDal.Get(x=>x.CategoryID==id);
        }

        public List<Category> GetList()
        {
            return _categoryDal.List();
        }
    }
}
