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
    public class MoneyCaseManager : IMoneyCaseService
    {
        private readonly IMoneyCaseDal _moneyCaseDal;

        public MoneyCaseManager(IMoneyCaseDal moneyCaseDal)
        {
            _moneyCaseDal = moneyCaseDal;
        }

        public MoneyCase GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void TAdd(MoneyCase entitiy)
        {
            throw new NotImplementedException();
        }

        public void TDelete(MoneyCase entitiy)
        {
            throw new NotImplementedException();
        }

        public MoneyCase TGetByID(int id)
        {
            return _moneyCaseDal.GetByID(id);
        }

        public List<MoneyCase> TGetListAll()
        {
            throw new NotImplementedException();
        }

        public decimal TTotalMoneyCaseAmount()
        {
            return _moneyCaseDal.TotalMoneyCaseAmount();
        }

        public void TUpdate(MoneyCase entitiy)
        {
            throw new NotImplementedException();
        }
    }
}
