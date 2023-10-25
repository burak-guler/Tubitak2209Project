using Gat.Core.Entity;
using Gat.DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gat.DataAccessLayer.Concrete
{
    public class ProductOperationsRepository : GenericRepository<ProductOperations>, IProductOperationsRepository
    {
        public void Add(ProductOperations item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public ProductOperations Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<ProductOperations> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(ProductOperations item)
        {
            throw new NotImplementedException();
        }
    }
}
