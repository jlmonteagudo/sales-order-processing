using System;
using System.Drawing;
using System.Windows.Forms;
using SalesOrderProcessing.Service;


namespace SalesOrderProcessing.Forms.Customers
{
	public partial class FormCustomersManagement : Form
	{
		
		ICustomerService customerService = new CustomerService();
		
		
		public FormCustomersManagement()
		{
			InitializeComponent();
		}
		
		void ButtonExitClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void FormCustomersManagementLoad(object sender, EventArgs e)
		{
			DgCustomers.AutoGenerateColumns = false;
			LoadCustomersData();
		}
		
		void LoadCustomersData() {
			DgCustomers.DataSource = customerService.FindAll();
		}
		
		void ButtonAddClick(object sender, EventArgs e)
		{
			FormCustomerNew form = new FormCustomerNew();
			form.ShowDialog();
			LoadCustomersData();
		}
		
		
		
		void ButtonEditClick(object sender, EventArgs e)
		{
			if (DgCustomers.CurrentRow == null) return;
			Customer customer = (Customer)DgCustomers.CurrentRow.DataBoundItem;
			
			FormCustomerEdit form = new FormCustomerEdit();
			form.Customer = customer;
			form.ShowDialog();
			
		}
	}
}
