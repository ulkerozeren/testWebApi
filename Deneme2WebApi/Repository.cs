using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Deneme2WebApi
{
    public class Repository : IRepository
    {
        private DataContext _context;
        public Repository(DataContext context)
        {
            _context = context;
        }

        public Ulker Find(int id)
        {
            Ulker ulker=_context.Ulkers.Find(id) ;
            return ulker;
        }

        public void Delete(int id)
        {
            Ulker ulker = Find(id);
            _context.Ulkers.Remove(ulker);
            _context.SaveChanges();
        }

        public void Insert(Ulker ulker)
        {
            _context.Ulkers.Add(ulker);
            _context.SaveChanges();
        }

        public void Update(Ulker ulker)
        {
            _context.Ulkers.Update(ulker);
            _context.SaveChanges();
        }

        public List<Ulker> List()
        {
            List<Ulker> ulkers= _context.Ulkers.ToList();
            return ulkers;
        }
    }
}
