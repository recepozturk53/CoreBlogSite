using DataAccesLayer.Abstract;
using DataAccesLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Repositories
{
    public class BlogRepository : IBlogDal
    {
        Context c = new Context();

        public void AddBlog(Blog p)
        {
            c.Add(p);
            c.SaveChanges();
        }

        public void Delete(Blog t)
        {
            throw new NotImplementedException();
        }

        public void DeleteBlog(Blog p)
        {
            c.Remove(p);
            c.SaveChanges();
        }

        public Blog GetById(int id)
        {
            return c.Blogs.Find(id);
        }

        public Blog GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Blog> GetListAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(Blog t)
        {
            throw new NotImplementedException();
        }

        public List<Blog> ListAllBlog()
        {
            return c.Blogs.ToList();
        }

        public void Update(Blog t)
        {
            throw new NotImplementedException();
        }

        public void UpdateBlog(Blog p)
        {
            c.Update(p);
            c.SaveChanges();
        }
    }
}
