using SignalR.BusinessLayer.Abstract;
using SignalR.DataAccessLaer.Abstract;
using SignalR.DataAccessLaer.EntityFramework;
using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BusinessLayer.Concrete
{
    public class BookingManager : IBookingService
    {
        private readonly IBookingDal _bookingDal;
        public BookingManager(IBookingDal bookingDal)
        {
            _bookingDal = bookingDal;
        }

        public Booking GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void TAdd(Booking entitiy)
        {
            _bookingDal.Add(entitiy);
        }

        public void TDelete(Booking entitiy)
        {
            _bookingDal.Delete(entitiy);
        }

        public Booking TGetByID(int id)
        {
            return _bookingDal.GetByID(id);
        }

        public List<Booking> TGetListAll()
        {
            return _bookingDal.GetListAll();
        }

        public void TUpdate(Booking entitiy)
        {
            _bookingDal.Update(entitiy);
        }
    }
}
