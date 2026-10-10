using SignalR.DataAccessLaer.Abstract;
using SignalR.DataAccessLaer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DataAccessLaer.Repositoris
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        //Crud işlemlerini tekrar etmesin, jeneril bir yapı üzerinde olsun.
        private readonly SignalRContext _context;

        public GenericRepository(SignalRContext context)
        {
            _context = context;
        }
        public void Add(T entitiy)
        {
            _context.Add(entitiy);
            _context.SaveChanges();
        }

        public void Delete(T entitiy)
        {
            _context.Remove(entitiy);
            _context.SaveChanges();
        }

        public T GetByID(int id)
        {
            return _context.Set<T>().Find(id); //null dönerse diye

        }

        public List<T> GetListAll()
        {
            return _context.Set<T>().ToList();
        }

        public void Update(T entitiy)
        {
            _context.Update(entitiy);
            _context.SaveChanges();
        }
    }
}
