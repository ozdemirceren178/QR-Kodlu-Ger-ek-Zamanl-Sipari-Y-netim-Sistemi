using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BusinessLayer.Abstract
{
    public interface IGenericService<T> where T : class
    {
        void TAdd(T entitiy);
        void TDelete(T entitiy);
        void TUpdate(T entitiy);
        T  TGetByID(int id);
        List<T> TGetListAll();

    }
}
