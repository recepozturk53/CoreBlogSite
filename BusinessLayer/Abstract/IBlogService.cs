using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
   public  interface IBlogService
    {
        void BlogAdd(Blog p);
        void BlogDelete(Blog p);
        void BlogUpdate(Blog p);
        List<Blog> GetList();
        Blog GetById(int id);

    }
}
