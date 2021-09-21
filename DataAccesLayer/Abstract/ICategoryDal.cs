using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Abstract
{
    public interface ICategoryDal : IGenericDal<Category>
    {
        /*
        List<Category> ListAllCategory();
        void UpdateCategory(Category p);
        void AddCategory(Category p);
        void DeleteCategory(Category p);
        Category GetById(int id);
        */
    }
}
