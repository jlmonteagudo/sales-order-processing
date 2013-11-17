using System;
using System.Collections.Generic;


namespace SalesOrderProcessing.Service
{
	public interface ISalesOrderService
	{
		List<SalesOrderLine> FindAllSalesOrderLines();
		void Add(SalesOrder salesOrder);
	}
}
