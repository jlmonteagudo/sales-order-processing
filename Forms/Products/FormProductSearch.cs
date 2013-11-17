using System;
using System.Drawing;
using System.Windows.Forms;
using SalesOrderProcessing.Service;


namespace SalesOrderProcessing.Forms.Products
{
	public partial class FormProductSearch : Form
	{
		
		IProductService productService = new ProductService();
		
 		private Product selectedProduct; 
    	
 		public Product SelectedProduct
    	{
        	get
        	{
            	return selectedProduct;
        	}
    	}
		
		public FormProductSearch()
		{
			InitializeComponent();
		}
		
		void FormProductSearchLoad(object sender, EventArgs e)
		{
			DgProducts.AutoGenerateColumns = false;
			LoadProductsData();
		}
		
		void LoadProductsData() {
			DgProducts.DataSource = productService.FindAll();
		}
		
		void ButtonExitClick(object sender, EventArgs e)
		{
			this.Dispose();
		}
		
		void ButtonSelectClick(object sender, EventArgs e)
		{
			if (DgProducts.CurrentRow == null) return;
			selectedProduct = (Product)DgProducts.CurrentRow.DataBoundItem;
			this.Close();
		}
		
		void DgProductsCellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			ButtonSelect.PerformClick();
		}
	}
}
