using System;
using System.Collections.Generic;

namespace SalesOrderProcessing.Service
{
	public interface ICustomerService
	{
		List<Customer> FindAll();
		void Add(Customer customer);
		void Save();
	}
}
