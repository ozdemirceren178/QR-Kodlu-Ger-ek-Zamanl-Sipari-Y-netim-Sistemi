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
    public class OrderDetailManager : IOrderDetailService
    {
        private readonly IOrderDetailDal _orderDetailDal;

        public OrderDetailManager(IOrderDetailDal orderDetailDal)
        {
            _orderDetailDal = orderDetailDal;
        }

        public OrderDetail GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void TAdd(OrderDetail entitiy)
        {
            throw new NotImplementedException();
        }

        public void TDelete(OrderDetail entitiy)
        {
            throw new NotImplementedException();
        }

        public OrderDetail TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<OrderDetail> TGetListAll()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(OrderDetail entitiy)
        {
            throw new NotImplementedException();
        }
    }
}
