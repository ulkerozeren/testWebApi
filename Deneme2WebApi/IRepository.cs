using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Deneme2WebApi
{
    public interface IRepository
    {
        void Insert(Ulker ulker);
        void Update(Ulker ulker);
        void Delete(int id);
        List<Ulker> List();
    }
}
