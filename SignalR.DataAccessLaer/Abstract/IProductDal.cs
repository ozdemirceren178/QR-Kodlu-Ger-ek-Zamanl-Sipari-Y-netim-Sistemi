using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DataAccessLaer.Abstract
{
    public interface IProductDal:IGenericDal<Product>
    {
        //ürün kategorisiyle birlikte gelsin istediğimiz için burası özelleştirilicek
        List<Product> GetProductsWithCategories();
        public int ProductCount();
        int ProductCountByCategoryNameHamburger();
        int ProductCountByCategoryNameDrink();
        decimal ProductPriceAvg();
        string ProductNameByMaxPrice();
        string ProductNameByMinPrice();
        decimal ProductAvgPriceByHamburger();
    }
}
 