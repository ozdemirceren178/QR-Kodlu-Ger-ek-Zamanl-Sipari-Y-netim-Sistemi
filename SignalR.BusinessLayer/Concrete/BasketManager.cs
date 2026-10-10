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
    public class BasketManager : IBasketService
    {
        private readonly IBasketDal _basketDal;
        public BasketManager(IBasketDal basketDal)
        {
            _basketDal = basketDal;
        }

        public void TAdd(Basket entitiy)
        {
            _basketDal.Add(entitiy);
        }

        public void TDelete(Basket entitiy)
        {
            _basketDal.Delete(entitiy);
                }

        public List<Basket> TGetBasketByMenuTableNumber(int id)
        {
            return _basketDal.GetBasketByMenuTableNumber(id);
        }
        public Basket TGeyByID(int id)
        {
            return _basketDal.GetByID(id);
        }

        public List<Basket> TGetListAll()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Basket entitiy)
        {
            throw new NotImplementedException();
        }

        public Basket TGetByID(int id)
        {
            throw new NotImplementedException();
        }
    }
}
