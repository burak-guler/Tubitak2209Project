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
    public class AdressService : IAdressService
    {
        private IAdressRepository _adresRepository;

        public AdressService(IAdressRepository adresRepository)
        {
            _adresRepository = adresRepository;
        }

        public void Add(Adress item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Adress GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Adress> GetList()
        {
            throw new NotImplementedException();
        }

        public void Update(Adress item)
        {
            throw new NotImplementedException();
        }
    }
}
