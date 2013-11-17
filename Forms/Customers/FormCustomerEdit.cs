using System;
using System.Drawing;
using System.Windows.Forms;
using SalesOrderProcessing.Service;

namespace SalesOrderProcessing.Forms.Customers
{
	public partial class FormCustomerEdit : Form
	{
		
		ICustomerService customerService = new CustomerService();

		public Customer Customer{get; set;}
		
		public FormCustomerEdit()
		{
			InitializeComponent();
		}
		
		void FormCustomerEditLoad(object sender, EventArgs e)
		{
			if (Customer == null) this.Dispose();
			
			TBName.Text = Customer.name;
			TBAddress.Text = Customer.address;
			TBCity.Text = Customer.city;
			
		}
		
		
		
		void ButtonSaveClick(object sender, EventArgs e)
		{

			try {
				ValidateForm();
				
				SetupCustomerFromForm();
				customerService.Save();
				
				MessageBox.Show("Customer saved successfully.","",MessageBoxButtons.OK,MessageBoxIcon.Information);
				this.Dispose();
			}
			catch(Exception ex) {
				MessageBox.Show(ex.Message,"",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			
		}
		
		
		void SetupCustomerFromForm() {
			Customer.name = TBName.Text;
			Customer.address = TBAddress.Text;
			Customer.city = TBCity.Text;
		}
		
		void ValidateForm() {
			if (TBName.Text.Trim().Equals("")) throw new Exception("Invalid Name");
			if (TBAddress.Text.Trim().Equals("")) throw new Exception("Invalid Address");
			if (TBCity.Text.Trim().Equals("")) throw new Exception("Invalid City");
		}

		
	}
}
