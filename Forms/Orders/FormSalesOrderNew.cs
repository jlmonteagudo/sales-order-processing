using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using SalesOrderProcessing.Service;

namespace SalesOrderProcessing.Forms.Orders
{
	public partial class FormSalesOrderNew : Form
	{
		
		private List<SalesOrderLine> salesOrderLines = new List<SalesOrderLine>();
		private Customer selectedCustomer;
		private ISalesOrderService salesOrderService = new SalesOrderService();
		
		public FormSalesOrderNew()
		{
			InitializeComponent();
		}
		
		void ButtonExitClick(object sender, EventArgs e)
		{
			this.Dispose();
		}
		
		void ButtonSearchCustomerClick(object sender, EventArgs e)
		{
			
			Customers.FormCustomerSearch form = new Customers.FormCustomerSearch();
			form.ShowDialog();
			
			selectedCustomer = form.SelectedCustomer;
			if (selectedCustomer != null) {
				TBCustomerCode.Text = selectedCustomer.id.ToString();
				LabelCustomerName.Text = selectedCustomer.name;
			}
			
		}
		
		void TBCustomerCodeTextChanged(object sender, EventArgs e)
		{
			LabelCustomerName.Text = "---";			
		}
		
		void ButtonAddClick(object sender, EventArgs e)
		{
			FormSalesOrderLineNew form = new FormSalesOrderLineNew();
			form.ShowDialog();
			if (form.SalesOrderLine != null) salesOrderLines.Add(form.SalesOrderLine);
			DisplaySalesOrderLines();
		}
		
		void FormSalesOrderNewLoad(object sender, EventArgs e)
		{
			DgSalesOrderLines.AutoGenerateColumns = false;
		}
		
		void DisplaySalesOrderLines() {
			DgSalesOrderLines.DataBindings.Clear();
			DgSalesOrderLines.DataSource = null;
			DgSalesOrderLines.DataMember = null;
			DgSalesOrderLines.DataSource = salesOrderLines;
		}
		
		
		void DgSalesOrderLinesCellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{

			SalesOrderLine salesOrderLine = (SalesOrderLine)DgSalesOrderLines.Rows[e.RowIndex].DataBoundItem;
			
			switch (DgSalesOrderLines.Columns[e.ColumnIndex].DataPropertyName) {
					
				case "product" :
					e.Value = salesOrderLine.Product.description;
					break;
					
				case "salesOrderStatus" :
					e.Value = salesOrderLine.SalesOrderStatus.description;
					break;
					
			}
		}
		
		void ButtonSaveClick(object sender, EventArgs e)
		{

			try {
				
				ValidateForm();
				
				SalesOrder salesOrder = GetSalesOrderFromForm();
				salesOrderService.Add(salesOrder);
				
				MessageBox.Show("Sales Order saved successfully.","",MessageBoxButtons.OK,MessageBoxIcon.Information);
				this.Dispose();
				
			} catch (Exception ex) {
				MessageBox.Show(ex.Message,"",MessageBoxButtons.OK,MessageBoxIcon.Error);			
			}
			
		}
		
		
		SalesOrder GetSalesOrderFromForm() {
			SalesOrder salesOrder = new SalesOrder { Customer = selectedCustomer, salesOrderDate = DateTime.Today};
			
			foreach (SalesOrderLine salesOrderLine in salesOrderLines) {
				salesOrder.SalesOrderLine.Add(salesOrderLine);
			}
			
			return salesOrder;
		}
		
		void ValidateForm() {
			if (selectedCustomer == null) throw new Exception("Invalid Customer");
			if (DgSalesOrderLines.RowCount <= 0) throw new Exception("There aren't lines for the sales order");
		}
		
	}
}
