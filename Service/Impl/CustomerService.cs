using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;


namespace SalesOrderProcessing.Service
{
	public class CustomerService : ICustomerService
	{
		
		private SalesOrderProcessingObjectContext context = ContextSingleton.Instance;
		
		public CustomerService()
		{
		}
		
		public List<Customer> FindAll() 
		{
			return context.Customer.ToList();
		}
		
		public void Add(Customer customer) 
		{
			context.Customer.AddObject(customer);
			context.SaveChanges();
		}
		
		public void Save()
		{
			context.SaveChanges();
		}
		
	}
}
