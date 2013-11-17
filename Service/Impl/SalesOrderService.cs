using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;


namespace SalesOrderProcessing.Service
{
	public class SalesOrderService : ISalesOrderService
	{
		
		private SalesOrderProcessingObjectContext context = ContextSingleton.Instance;
		
		public SalesOrderService()
		{
		}
		
		public List<SalesOrderLine> FindAllSalesOrderLines()
		{
			return context.SalesOrderLine
							.Include("SalesOrder")
							.Include("SalesOrder.Customer")
							.Include("Product")
							.Include("SalesOrderStatus")
							.ToList();
			
		}
		
		public void Add(SalesOrder salesOrder) 
		{
			context.SalesOrder.AddObject(salesOrder);
			context.SaveChanges();
		}
		
	}
}
