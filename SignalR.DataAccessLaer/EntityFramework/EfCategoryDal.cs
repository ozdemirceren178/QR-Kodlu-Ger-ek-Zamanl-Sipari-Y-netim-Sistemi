using SignalR.DataAccessLaer.Abstract;
using SignalR.DataAccessLaer.Concrete;
using SignalR.DataAccessLaer.Repositoris;
using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DataAccessLaer.EntityFramework
{
    public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
    {
        public EfCategoryDal(SignalRContext context) : base(context)
        {
        }

        public int ActiveCategoryCount()
        {
            using var context = new SignalRContext();
            return context.Categories.Where(x => x.Status == true).Count();
        }

        public int CategoryCount()
        {
            using var context=new SignalRContext();
            return context.Categories.Count();
        }

        public int PassiveCategoryCount()
        {
            using var context = new SignalRContext();
            return context.Categories.Where(x => x.Status == false).Count();
        }
    }
}
