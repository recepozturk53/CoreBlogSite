using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Abstract
{
    public interface IContactDal : IGenericDal<Contact>
    {
        /*
        List<Contact> ListAllContact();
        void UpdateContact(Contact p);
        void AddContact(Contact p);
        void DeleteContact(Contact p);
        Contact GetById(int id);
        */
    }
}
