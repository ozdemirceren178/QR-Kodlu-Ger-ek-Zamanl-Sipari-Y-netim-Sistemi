using Microsoft.EntityFrameworkCore;
using SignalR.DataAccessLaer.Abstract;
using SignalR.DataAccessLaer.Concrete;
using SignalR.DataAccessLaer.Repositoris;
using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DataAccessLaer.EntityFramework
{
    public class EfBasketDal : GenericRepository<Basket>, IBasketDal
    {
        public EfBasketDal(SignalRContext context) : base(context)
        {
        }

        public List<Basket> GetBasketByMenuTableNumber(int id)
        {
            using var context = new SignalRContext();
            var values = context.Baskets.Where(
                x=>x.MenuTableID==id
                ).Include(y=>y.Product).ToList()
                .ToList();
            return values;
        }

       
    }
}
