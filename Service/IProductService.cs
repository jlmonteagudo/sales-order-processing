using System;
using System.Collections.Generic;

namespace SalesOrderProcessing.Service
{
	public interface IProductService
	{
		List<Product> FindAll();
		void Add(Product product);
		void Save();
	}
}
