using System;
using System.Drawing;
using System.Windows.Forms;
using SalesOrderProcessing.Service;

namespace SalesOrderProcessing.Forms.Orders
{
	public partial class FormSalesOrdersManagement : Form
	{
		
		ISalesOrderService salesOrderService = new SalesOrderService();
		
		public FormSalesOrdersManagement()
		{
			InitializeComponent();
		}
		
		void ButtonExitClick(object sender, EventArgs e)
		{
			this.Dispose();
		}
		
		void ButtonAddClick(object sender, EventArgs e)
		{
			this.Visible=false;
			FormSalesOrderNew form = new FormSalesOrderNew();
			form.ShowDialog();
			this.Visible=true;
			LoadSalesOrdersData();
		}
		
		void FormSalesOrdersManagementLoad(object sender, EventArgs e)
		{
			DgSalesOrders.AutoGenerateColumns = false;
			LoadSalesOrdersData();
		}
		
		void LoadSalesOrdersData() {
			DgSalesOrders.DataSource = salesOrderService.FindAllSalesOrderLines();
		}

		
		
		void DgSalesOrdersCellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			
			SalesOrderLine salesOrderLine = (SalesOrderLine)DgSalesOrders.Rows[e.RowIndex].DataBoundItem;
			
			switch (DgSalesOrders.Columns[e.ColumnIndex].DataPropertyName) {
				
				case "customer" :
					e.Value = salesOrderLine.SalesOrder.Customer.name;
					break;

				case "salesOrderDate" :
					e.Value = string.Format( "{0:dd/MM/yyyy}", salesOrderLine.SalesOrder.salesOrderDate);
					break;
					
				case "product" :
					e.Value = salesOrderLine.Product.description;
					break;

				case "status" :
					e.Value = salesOrderLine.SalesOrderStatus.description;
					e.CellStyle.BackColor = GetStatusColor(salesOrderLine.SalesOrderStatus);
					break;
					
			}
			
		}
		
		Color GetStatusColor(SalesOrderStatus status) 
		{
			switch (status.description) {
				
				case "Pending" :
					return Color.Orange;
				case "In Process" :
					return Color.Yellow;
				case "Shipped" :
					return Color.Cyan;
				case "Closed" :
					return Color.Green;
				case "Canceled":
					return Color.Red;
				default :
					return Color.White;
					
			}	
			
		}
		
	}
}
