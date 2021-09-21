using BusinessLayer.Abstract;
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
        EfCategoryRepository efCategoryRepository;

        public CategoryManager()
        {
            efCategoryRepository = new EfCategoryRepository();
        }
        public void CategoryAdd(Category p)
        {
            efCategoryRepository.Insert(p);
        }

        public void CategoryDelete(Category p)
        {
            efCategoryRepository.Delete(p);
        }

        public void CategoryUpdate(Category p)
        {
            efCategoryRepository.Update(p);
        }

        public Category GetById(int id)
        {
           return efCategoryRepository.GetByID(id);
        }

        public List<Category> GetList()
        {
          return efCategoryRepository.GetListAll();
        }
    }
}
