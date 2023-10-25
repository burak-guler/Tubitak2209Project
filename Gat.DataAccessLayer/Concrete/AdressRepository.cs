using Gat.Core.Entity;
using Gat.DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gat.DataAccessLayer.Concrete
{
    public class AdressRepository :GenericRepository<Adress>, IAdressRepository
    {
        public void Add(Adress item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Adress Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Adress> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Adress item)
        {
            throw new NotImplementedException();
        }
    }
}
