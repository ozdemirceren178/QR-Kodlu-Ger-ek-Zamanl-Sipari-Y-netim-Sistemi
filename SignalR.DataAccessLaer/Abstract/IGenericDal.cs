using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DataAccessLaer.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        void Add(T entitiy);
        void Delete(T entitiy);
        void Update(T entitiy);
        T GetByID(int id);
        List<T> GetListAll();


    }
}
