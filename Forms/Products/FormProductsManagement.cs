using System;
using System.Drawing;
using System.Windows.Forms;
using SalesOrderProcessing.Service;

namespace SalesOrderProcessing.Forms.Products
{
	public partial class FormProductsManagement : Form
	{
		
		IProductService productService = new ProductService();
		
		public FormProductsManagement()
		{
			InitializeComponent();
		}
		
		void FormProductsManagementLoad(object sender, EventArgs e)
		{
			DgProducts.AutoGenerateColumns = false;
			LoadProductsData();

		}
		
		void ButtonExitClick(object sender, EventArgs e)
		{
			this.Close();			
		}
		
		void LoadProductsData() {
			DgProducts.DataSource = productService.FindAll();
		}
		
		
		void ButtonAddClick(object sender, EventArgs e)
		{
			FormProductNew form = new FormProductNew();
			form.ShowDialog();
			LoadProductsData();
		}
		
		void ButtonEditClick(object sender, EventArgs e)
		{
			if (DgProducts.CurrentRow == null) return;
			Product product = (Product)DgProducts.CurrentRow.DataBoundItem;
			
			FormProductEdit form = new FormProductEdit();
			form.Product = product;
			form.ShowDialog();
		}
	}
}
