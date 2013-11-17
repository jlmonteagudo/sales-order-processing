using System;
using System.Drawing;
using System.Windows.Forms;
using SalesOrderProcessing.Service;


namespace SalesOrderProcessing.Forms.Customers
{
	public partial class FormCustomerNew : Form
	{
		
		ICustomerService customerService = new CustomerService();
		
		public FormCustomerNew()
		{
			InitializeComponent();
		}
		
		void ButtonSaveClick(object sender, EventArgs e)
		{

			try {
				ValidateForm();
				customerService.Add(GetCustomerFromForm());
				
				MessageBox.Show("Customer saved successfully.","",MessageBoxButtons.OK,MessageBoxIcon.Information);
				this.Dispose();
			}
			catch(Exception ex) {
				MessageBox.Show(ex.Message,"",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			
		}
		
		
		Customer GetCustomerFromForm() {
			Customer customer = new Customer { name = TBName.Text, address = TBAddress.Text, city = TBCity.Text };
			return customer;
		}
		
		void ValidateForm() {
			if (TBName.Text.Trim().Equals("")) throw new Exception("Invalid Name");
			if (TBAddress.Text.Trim().Equals("")) throw new Exception("Invalid Address");
			if (TBCity.Text.Trim().Equals("")) throw new Exception("Invalid City");
		}
		
	}
}
