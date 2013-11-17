using System;
using System.Collections.Generic;

namespace SalesOrderProcessing.Service
{
	public interface ISalesOrderStatusService
	{
		List<SalesOrderStatus> FindAll();	
	}
}
