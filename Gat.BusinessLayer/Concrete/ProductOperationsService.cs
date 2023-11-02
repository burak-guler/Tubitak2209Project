using Gat.BusinessLayer.Abstract;
using Gat.Core.Entity;
using Gat.DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gat.BusinessLayer.Concrete
{
    public class ProductOperationsService : IProductOperationsService
    {
        private IProductOperationsRepository _productOperationsRepository;

        public ProductOperationsService(IProductOperationsRepository productOperationsRepository)
        {
            _productOperationsRepository = productOperationsRepository;
        }

		public void Add(ProductOperations item)
		{
			throw new NotImplementedException();
		}

		public void Delete(int id)
		{
			throw new NotImplementedException();
		}

		public ProductOperations GetByID(int id)
		{
			throw new NotImplementedException();
		}

		public List<ProductOperations> GetList()
		{
			throw new NotImplementedException();
		}

		public void Update(ProductOperations item)
		{
			throw new NotImplementedException();
		}
	}
}
