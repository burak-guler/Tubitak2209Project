using Gat.Core.Entity;
using Gat.DataAccessLayer.Abstract;
using Gat.DataAccessLayer.Concrete.GatContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gat.DataAccessLayer.Concrete
{
    public class JobRepository : GenericRepository<Job>, IJobRepository
    {
        private Context _context;

		public JobRepository(Context context)
		{
			_context = context;
		}

		public void Add(Job item)
        {
            _context.Jobs.Add(item);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var job = _context.Jobs.Find(id);
            _context.Jobs.Remove(job);
            _context.SaveChanges();
        }

        public Job Get(int id)
        {
            var job = _context.Jobs.Find(id);
            return job;
        }

        public List<Job> GetAll()
        {
            var joblist = _context.Jobs.ToList();   
            return joblist;
        }

        public void Update(Job item)
        {
            _context.Jobs.Update(item);
            _context.SaveChanges();
        }
    }
}
