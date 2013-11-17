using System;
using System.Drawing;
using System.Windows.Forms;
using SalesOrderProcessing.Service;

namespace SalesOrderProcessing.Forms.Customers
{
	public partial class FormCustomerSearch : Form
	{
		
		ICustomerService customerService = new CustomerService();
		
 		private Customer selectedCustomer; 
    	
 		public Customer SelectedCustomer
    	{
        	get
        	{
            	return selectedCustomer;
        	}
    	}
		
		
		public FormCustomerSearch()
		{
			InitializeComponent();
		}
		
		void ButtonExitClick(object sender, EventArgs e)
		{
			this.Dispose();
		}
		
		void ButtonSelectClick(object sender, EventArgs e)
		{
			if (DgCustomers.CurrentRow == null) return;
			selectedCustomer = (Customer)DgCustomers.CurrentRow.DataBoundItem;
			this.Close();
			
		}
		
		void FormCustomerSearchLoad(object sender, EventArgs e)
		{
			DgCustomers.AutoGenerateColumns = false;
			LoadCustomersData();
		}
		
		void LoadCustomersData() {
			DgCustomers.DataSource = customerService.FindAll();
		}
		
		
		void DgCustomersCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			ButtonSelect.PerformClick();
		}
	}
}
