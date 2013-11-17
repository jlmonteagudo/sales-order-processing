using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using SalesOrderProcessing.Forms.Customers;
using SalesOrderProcessing.Forms.Products;
using SalesOrderProcessing.Forms.Orders;

namespace SalesOrderProcessing
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		
		void ButtonExitClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		void ButtonCustomersClick(object sender, EventArgs e)
		{
			FormCustomersManagement form = new FormCustomersManagement();
			form.ShowDialog();
		}
		
		void ButtonProductsClick(object sender, EventArgs e)
		{
			FormProductsManagement form = new FormProductsManagement();
			form.ShowDialog();
		}
		
		void ButtonOrdersClick(object sender, EventArgs e)
		{
			FormSalesOrdersManagement form = new FormSalesOrdersManagement();
			form.ShowDialog();
		}
	}
}
