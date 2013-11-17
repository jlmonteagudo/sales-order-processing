/*
 * Created by SharpDevelop.
 * User: jlm
 * Date: 17/11/2013
 * Time: 8:47
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace SalesOrderProcessing.Forms.Orders
{
	partial class FormSalesOrdersManagement
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSalesOrdersManagement));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.ButtonEdit = new System.Windows.Forms.Button();
			this.ButtonAdd = new System.Windows.Forms.Button();
			this.DgSalesOrders = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.ButtonExit = new System.Windows.Forms.Button();
			this.ColumnSalesOrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnSalesOrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnSalesPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.DgSalesOrders)).BeginInit();
			this.SuspendLayout();
			// 
			// ButtonEdit
			// 
			this.ButtonEdit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonEdit.Image = ((System.Drawing.Image)(resources.GetObject("ButtonEdit.Image")));
			this.ButtonEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.ButtonEdit.Location = new System.Drawing.Point(884, 492);
			this.ButtonEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.ButtonEdit.Name = "ButtonEdit";
			this.ButtonEdit.Size = new System.Drawing.Size(108, 45);
			this.ButtonEdit.TabIndex = 11;
			this.ButtonEdit.Text = "Edit";
			this.ButtonEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.ButtonEdit.UseVisualStyleBackColor = true;
			// 
			// ButtonAdd
			// 
			this.ButtonAdd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonAdd.Image = ((System.Drawing.Image)(resources.GetObject("ButtonAdd.Image")));
			this.ButtonAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.ButtonAdd.Location = new System.Drawing.Point(998, 492);
			this.ButtonAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.ButtonAdd.Name = "ButtonAdd";
			this.ButtonAdd.Size = new System.Drawing.Size(108, 45);
			this.ButtonAdd.TabIndex = 10;
			this.ButtonAdd.Text = "Add";
			this.ButtonAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.ButtonAdd.UseVisualStyleBackColor = true;
			this.ButtonAdd.Click += new System.EventHandler(this.ButtonAddClick);
			// 
			// DgSalesOrders
			// 
			this.DgSalesOrders.AllowUserToAddRows = false;
			this.DgSalesOrders.AllowUserToDeleteRows = false;
			this.DgSalesOrders.AllowUserToResizeColumns = false;
			this.DgSalesOrders.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.DgSalesOrders.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.DgSalesOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DgSalesOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.ColumnSalesOrderId,
									this.ColumnSalesOrderDate,
									this.ColumnCustomer,
									this.ColumnProduct,
									this.ColumnQuantity,
									this.ColumnSalesPrice,
									this.ColumnAmount,
									this.ColumnStatus});
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.DgSalesOrders.DefaultCellStyle = dataGridViewCellStyle5;
			this.DgSalesOrders.Location = new System.Drawing.Point(12, 75);
			this.DgSalesOrders.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.DgSalesOrders.Name = "DgSalesOrders";
			this.DgSalesOrders.ReadOnly = true;
			this.DgSalesOrders.RowHeadersVisible = false;
			this.DgSalesOrders.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DgSalesOrders.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.DgSalesOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.DgSalesOrders.Size = new System.Drawing.Size(1094, 398);
			this.DgSalesOrders.TabIndex = 9;
			this.DgSalesOrders.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DgSalesOrdersCellFormatting);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = System.Drawing.Color.Green;
			this.label1.Location = new System.Drawing.Point(12, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(1094, 45);
			this.label1.TabIndex = 8;
			this.label1.Text = "Sales Orders Management";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ButtonExit
			// 
			this.ButtonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.ButtonExit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonExit.Image = ((System.Drawing.Image)(resources.GetObject("ButtonExit.Image")));
			this.ButtonExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.ButtonExit.Location = new System.Drawing.Point(12, 492);
			this.ButtonExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.ButtonExit.Name = "ButtonExit";
			this.ButtonExit.Size = new System.Drawing.Size(108, 45);
			this.ButtonExit.TabIndex = 7;
			this.ButtonExit.Text = "Exit";
			this.ButtonExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.ButtonExit.UseVisualStyleBackColor = true;
			this.ButtonExit.Click += new System.EventHandler(this.ButtonExitClick);
			// 
			// ColumnSalesOrderId
			// 
			this.ColumnSalesOrderId.DataPropertyName = "id";
			this.ColumnSalesOrderId.HeaderText = "Sales Number";
			this.ColumnSalesOrderId.Name = "ColumnSalesOrderId";
			this.ColumnSalesOrderId.ReadOnly = true;
			// 
			// ColumnSalesOrderDate
			// 
			this.ColumnSalesOrderDate.DataPropertyName = "salesOrderDate";
			this.ColumnSalesOrderDate.HeaderText = "Order Date";
			this.ColumnSalesOrderDate.Name = "ColumnSalesOrderDate";
			this.ColumnSalesOrderDate.ReadOnly = true;
			// 
			// ColumnCustomer
			// 
			this.ColumnCustomer.DataPropertyName = "customer";
			this.ColumnCustomer.HeaderText = "Customer";
			this.ColumnCustomer.Name = "ColumnCustomer";
			this.ColumnCustomer.ReadOnly = true;
			this.ColumnCustomer.Width = 200;
			// 
			// ColumnProduct
			// 
			this.ColumnProduct.DataPropertyName = "product";
			this.ColumnProduct.HeaderText = "Product";
			this.ColumnProduct.Name = "ColumnProduct";
			this.ColumnProduct.ReadOnly = true;
			this.ColumnProduct.Width = 220;
			// 
			// ColumnQuantity
			// 
			this.ColumnQuantity.DataPropertyName = "quantity";
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle2.Format = "N0";
			dataGridViewCellStyle2.NullValue = "0";
			this.ColumnQuantity.DefaultCellStyle = dataGridViewCellStyle2;
			this.ColumnQuantity.HeaderText = "Quantity";
			this.ColumnQuantity.Name = "ColumnQuantity";
			this.ColumnQuantity.ReadOnly = true;
			// 
			// ColumnSalesPrice
			// 
			this.ColumnSalesPrice.DataPropertyName = "salesPrice";
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle3.Format = "N2";
			dataGridViewCellStyle3.NullValue = "0";
			this.ColumnSalesPrice.DefaultCellStyle = dataGridViewCellStyle3;
			this.ColumnSalesPrice.HeaderText = "Sales Price";
			this.ColumnSalesPrice.Name = "ColumnSalesPrice";
			this.ColumnSalesPrice.ReadOnly = true;
			// 
			// ColumnAmount
			// 
			this.ColumnAmount.DataPropertyName = "amount";
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle4.Format = "N2";
			dataGridViewCellStyle4.NullValue = "0";
			this.ColumnAmount.DefaultCellStyle = dataGridViewCellStyle4;
			this.ColumnAmount.HeaderText = "Amount";
			this.ColumnAmount.Name = "ColumnAmount";
			this.ColumnAmount.ReadOnly = true;
			// 
			// ColumnStatus
			// 
			this.ColumnStatus.DataPropertyName = "status";
			this.ColumnStatus.HeaderText = "Status";
			this.ColumnStatus.Name = "ColumnStatus";
			this.ColumnStatus.ReadOnly = true;
			this.ColumnStatus.Width = 150;
			// 
			// FormSalesOrdersManagement
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.ButtonExit;
			this.ClientSize = new System.Drawing.Size(1118, 549);
			this.Controls.Add(this.ButtonEdit);
			this.Controls.Add(this.ButtonAdd);
			this.Controls.Add(this.DgSalesOrders);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.ButtonExit);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "FormSalesOrdersManagement";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Sales Orders Management";
			this.Load += new System.EventHandler(this.FormSalesOrdersManagementLoad);
			((System.ComponentModel.ISupportInitialize)(this.DgSalesOrders)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStatus;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAmount;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSalesPrice;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnQuantity;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProduct;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSalesOrderDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCustomer;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSalesOrderId;
		private System.Windows.Forms.Button ButtonExit;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView DgSalesOrders;
		private System.Windows.Forms.Button ButtonAdd;
		private System.Windows.Forms.Button ButtonEdit;
	}
}
