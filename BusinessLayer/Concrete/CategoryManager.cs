using BusinessLayer.Abstract;
using DataAccesLayer.Abstract;
using DataAccesLayer.EntityFramework;
using DataAccesLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public void CategoryAdd(Category p)
        {
            _categoryDal.Insert(p);
        }

        public void CategoryDelete(Category p)
        {
            _categoryDal.Delete(p);
        }

        public void CategoryUpdate(Category p)
        {
            _categoryDal.Update(p);
        }

        public Category GetById(int id)
        {
           return _categoryDal.GetByID(id);
        }

        public List<Category> GetList()
        {
          return _categoryDal.GetListAll();
        }
    }
}
