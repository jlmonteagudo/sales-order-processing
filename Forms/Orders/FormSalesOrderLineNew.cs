using System;
using System.Drawing;
using System.Windows.Forms;
using SalesOrderProcessing.Service;

namespace SalesOrderProcessing.Forms.Orders
{
	public partial class FormSalesOrderLineNew : Form
	{
		
		ISalesOrderStatusService salesOrderStatusService = new SalesOrderStatusService();
		
		private Product selectedProduct;
 		private SalesOrderLine salesOrderLine; 
    	
 		public SalesOrderLine SalesOrderLine
    	{
        	get
        	{
            	return salesOrderLine;
        	}
    	}
		
		
		public FormSalesOrderLineNew()
		{
			InitializeComponent();
		}
		
		void ButtonSearchCustomerClick(object sender, EventArgs e)
		{
			
			Products.FormProductSearch form = new Products.FormProductSearch();
			form.ShowDialog();
			
			selectedProduct = form.SelectedProduct;
			TBProductDescrition.Text = selectedProduct.description;
			TBSalesPrice.Text = selectedProduct.salesPrice.ToString();
			form.Dispose();
			
		}
		
		
		double GetAmount() {
			double quantity;
			double salesPrice;
			
			if (!(double.TryParse(TBQuantity.Text, out quantity) && double.TryParse(TBSalesPrice.Text, out salesPrice))) return 0;
			return quantity * salesPrice;
		}
		
		
		
		
		void TBQuantityTextChanged(object sender, EventArgs e)
		{
			TBAmount.Text = GetAmount().ToString();
		}
		
		void TBSalesPriceTextChanged(object sender, EventArgs e)
		{
			TBAmount.Text = GetAmount().ToString();			
		}
		
		void ButtonSaveClick(object sender, EventArgs e)
		{
			try {
				
				ValidateForm();
				salesOrderLine = GetSalesOrderLineFromForm();
				this.Close();
				
			} catch (Exception ex) {
				MessageBox.Show(ex.Message,"",MessageBoxButtons.OK,MessageBoxIcon.Error);			
			} 
				
		}
		
		
		SalesOrderLine GetSalesOrderLineFromForm() {
			SalesOrderLine salesOrderLine = new SalesOrderLine { Product = selectedProduct, quantity = int.Parse(TBQuantity.Text), salesPrice = double.Parse(TBSalesPrice.Text), amount = double.Parse(TBAmount.Text), SalesOrderStatus = (SalesOrderStatus)ComboSalesOrderStatus.SelectedItem };
			return salesOrderLine;
		}
		
		void ValidateForm() {
			double amount;
			
			if (!double.TryParse(TBAmount.Text, out amount)) throw new Exception("Invalid Amount");
			if (amount <=0) throw new Exception("Invalid Amount");
			
			if (selectedProduct == null) throw new Exception("Invalid Product");
			
		}
		
		void FormSalesOrderLineNewLoad(object sender, EventArgs e)
		{
			ComboSalesOrderStatus.DataSource = salesOrderStatusService.FindAll();
		}
	}
}
