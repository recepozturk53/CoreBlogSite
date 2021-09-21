using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Abstract
{
    public interface ICommentDal : IGenericDal<Comment>
    {
        /*
        List<Comment> ListAllComment();
        void UpdateComment(Comment p);
        void AddComment(Comment p);
        void DeleteComment(Comment p);
        Comment GetById(int id);
        */
    }
}
