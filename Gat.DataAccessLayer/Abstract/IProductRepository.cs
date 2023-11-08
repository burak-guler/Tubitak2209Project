﻿using Gat.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gat.DataAccessLayer.Abstract
{
    public interface IProductRepository : IGenericRepository<Product>
    {
		List<Product> GetProductsByUserId(int id);
	}
}
