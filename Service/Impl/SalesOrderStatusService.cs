using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;

namespace SalesOrderProcessing.Service
{
	public class SalesOrderStatusService : ISalesOrderStatusService
	{
		
		private SalesOrderProcessingObjectContext context = ContextSingleton.Instance;
		
		public SalesOrderStatusService()
		{
		}
		
		public List<SalesOrderStatus> FindAll() 
		{
			return context.SalesOrderStatus.ToList();		
		}
		
	}
}
