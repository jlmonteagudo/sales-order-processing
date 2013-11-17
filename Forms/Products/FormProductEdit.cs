using System;
using System.Drawing;
using System.Windows.Forms;
using SalesOrderProcessing.Service;

namespace SalesOrderProcessing.Forms.Products
{
	public partial class FormProductEdit : Form
	{
		
		IProductService productService = new ProductService();
		
		public Product Product{get; set;}
		
		public FormProductEdit()
		{
			InitializeComponent();
		}
		
		void ButtonSaveClick(object sender, EventArgs e)
		{
			try {
				ValidateForm();
				
				SetupProductFromForm();
				productService.Save();
				
				MessageBox.Show("Product saved successfully.","",MessageBoxButtons.OK,MessageBoxIcon.Information);
				this.Dispose();
			}
			catch(Exception ex) {
				MessageBox.Show(ex.Message,"",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			
		}
		
		void FormProductEditLoad(object sender, EventArgs e)
		{
			if (Product == null) this.Dispose();
			
			TBDescription.Text = Product.description;
			TBCost.Text = Product.cost.ToString();
			TBSalesPrice.Text = Product.salesPrice.ToString();
		}
		
		void SetupProductFromForm() {
			Product.description = TBDescription.Text;
			Product.cost= double.Parse(TBCost.Text);
			Product.salesPrice = double.Parse(TBSalesPrice.Text);
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
