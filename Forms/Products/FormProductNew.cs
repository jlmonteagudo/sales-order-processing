using System;
using System.Drawing;
using System.Windows.Forms;
using SalesOrderProcessing.Service;

namespace SalesOrderProcessing.Forms.Products
{
	public partial class FormProductNew : Form
	{
		IProductService productService = new ProductService();
		
		public FormProductNew()
		{
			InitializeComponent();
		}
		
		void ButtonSaveClick(object sender, EventArgs e)
		{
			
			try {
				ValidateForm();
				productService.Add(GetProductFromForm());
				
				MessageBox.Show("Product saved successfully.","",MessageBoxButtons.OK,MessageBoxIcon.Information);
				this.Dispose();
			}
			catch(Exception ex) {
				MessageBox.Show(ex.Message,"",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			
		}
		
		Product GetProductFromForm() {
			Product product = new Product { description = TBDescription.Text, cost = double.Parse(TBCost.Text), salesPrice = double.Parse(TBSalesPrice.Text) };
			return product;
		}
		
		void ValidateForm() {
			if (TBDescription.Text.Trim().Equals("")) throw new Exception("Invalid Descrition");
			double cost = double.Parse(TBCost.Text);
			if (cost <= 0) throw new Exception("Invalid Cost");
			double salesPrice = double.Parse(TBSalesPrice.Text);
			if (salesPrice <= 0) throw new Exception("Invalid Sales Price");
		}
		
		
	}
}
