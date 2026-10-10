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
    public class DiscountManager : IDiscountService
    {
        private readonly IDiscountDal _discountDal;
        public DiscountManager(IDiscountDal discountDal)
        { 
            _discountDal = discountDal;
        }
        public Discount GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void TAdd(Discount entitiy)
        {
            _discountDal.Add(entitiy);
        }

        public void TDelete(Discount entitiy)
        {
            _discountDal.Delete(entitiy);
        }

        public Discount TGetByID(int id)
        {
            return _discountDal.GetByID(id);
        }

        public List<Discount> TGetListAll()
        {
            return _discountDal.GetListAll();
        }

        public void TUpdate(Discount entitiy)
        {
            _discountDal.Update(entitiy);
        }
    

   
    }
}
