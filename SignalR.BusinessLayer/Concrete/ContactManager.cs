using SignalR.BusinessLayer.Abstract;
using SignalR.DataAccessLaer.Abstract;
using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BusinessLayer.Concrete
{
    public class ContactManager : IConctactService
    {
        private readonly IContactDal _contactDal;
        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public Contact GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void TAdd(Contact entitiy)
        {
            _contactDal.Add(entitiy);
        }

        public void TDelete(Contact entitiy)
        {
             _contactDal.Delete(entitiy);
        }

        public Contact TGetByID(int id)
        {
            return _contactDal.GetByID(id);
        }

        public List<Contact> TGetListAll()
        {
          return  _contactDal.GetListAll();
        }

        public void TUpdate(Contact entitiy)
        {
            _contactDal.Update(entitiy);
        }
    }
}
