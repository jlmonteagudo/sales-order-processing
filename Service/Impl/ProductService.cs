using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;

namespace SalesOrderProcessing.Service
{
	public class ProductService : IProductService
	{
		
		private SalesOrderProcessingObjectContext context = ContextSingleton.Instance;
		
		public ProductService()
		{
		}
		
		public List<Product> FindAll() 
		{
			return context.Product.ToList();
		}
		
		public void Add(Product product) 
		{
			context.Product.AddObject(product);
			context.SaveChanges();
		}
		
		public void Save()
		{
			context.SaveChanges();
		}
		
	}
}
