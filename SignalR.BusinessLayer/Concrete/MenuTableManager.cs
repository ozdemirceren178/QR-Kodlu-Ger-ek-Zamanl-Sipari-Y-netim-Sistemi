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
    public class MenuTableManager: IMenuTableService
    {
        private readonly IMenuTableDal _menuTableDal;
        public MenuTableManager(IMenuTableDal menuTableDal)
        {
            _menuTableDal = menuTableDal;
        }
        public void TAdd(MenuTable entitiy)
        {
            _menuTableDal.Add(entitiy);
        }

        public void TDelete(MenuTable entitiy)
        {
             _menuTableDal.Delete(entitiy);
        }

        public MenuTable TGetByID(int id)
        {
            return _menuTableDal.GetByID(id);
        }

        public List<MenuTable> TGetListAll()
        {
            return _menuTableDal.GetListAll();
        }

        public int TMenuTableCount()
        {
            return _menuTableDal.MenuTableCount();
        }

        public void TUpdate(MenuTable entitiy)
        {
            _menuTableDal.Update(entitiy);
        }
    }
}
