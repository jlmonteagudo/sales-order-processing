using System;

namespace SalesOrderProcessing.Service
{
	public sealed class ContextSingleton
	{
		private static SalesOrderProcessingObjectContext instance = new SalesOrderProcessingObjectContext();
		
		public static SalesOrderProcessingObjectContext Instance {
			get {
				return instance;
			}
		}
		
		private ContextSingleton()
		{
		}
	}
}
