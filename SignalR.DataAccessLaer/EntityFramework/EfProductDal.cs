using Microsoft.EntityFrameworkCore;
using SignalR.DataAccessLaer.Abstract;
using SignalR.DataAccessLaer.Concrete;
using SignalR.DataAccessLaer.Repositoris;
using SignalR.DtoLayer.ProductDto;
using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DataAccessLaer.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        public EfProductDal(SignalRContext context) : base(context)
        {
        }

        public List<Product> GetProductsWithCategories()
        {
            var context = new SignalRContext();
            var values = context.Products.Include(x => x.Category).ToList();
            
            return values;
        }

        public int ProductCount()
        {
            using var context = new SignalRContext();
            return context.Products.Count();
        }

        public int ProductCountByCategoryNameDrink()
        {
            using var context = new SignalRContext();
            return context.Products.Where(x=>x.CategoryID==
            (context.Categories.Where(y=>y.CategoryName=="İçecek").Select(z=>z.CategoryID)
            .FirstOrDefault())).Count();
        }

        public int ProductCountByCategoryNameHamburger()
        {
            using var context = new SignalRContext();
            return context.Products.Where(x => x.CategoryID ==
            (context.Categories.Where(y => y.CategoryName == "Hamburger").Select(z => z.CategoryID)
            .FirstOrDefault())).Count();
        }

        public string ProductNameByMaxPrice()
        {
            using var context = new SignalRContext();
            return context.Products.Where(x => x.Price == (context.Products.Max(y => y.Price)))
                .Select(z => z.ProductName).FirstOrDefault();

        }

        public string ProductNameByMinPrice()
        {
            using var context = new SignalRContext();
            return context.Products.Where(x => x.Price == (context.Products.Min(y => y.Price)))
                .Select(z => z.ProductName).FirstOrDefault();

        }

        public decimal ProductPriceAvg()
        {
            using var context = new SignalRContext();
            return context.Products.Average(x=>x.Price);

        }

        public decimal ProducAvgPriceByHamburger()
        {
            using var context = new SignalRContext();
            return context.Products.Where(x => x.CategoryID == (context.Categories
            .Where(y => y.CategoryName == "Hamburger")
            .Select(z => z.CategoryID).FirstOrDefault())).Average(w => w.Price);
        }

        public decimal ProductAvgPriceByHamburger()
        {
            throw new NotImplementedException();
        }
    }
}
