/*
 * Created by SharpDevelop.
 * User: jlm
 * Date: 17/11/2013
 * Time: 8:57
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace SalesOrderProcessing.Forms.Orders
{
	partial class FormSalesOrderNew
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSalesOrderNew));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			this.label1 = new System.Windows.Forms.Label();
			this.TBCustomerCode = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.ButtonSearchCustomer = new System.Windows.Forms.Button();
			this.ButtonExit = new System.Windows.Forms.Button();
			this.LabelCustomerName = new System.Windows.Forms.Label();
			this.ButtonAdd = new System.Windows.Forms.Button();
			this.DgSalesOrderLines = new System.Windows.Forms.DataGridView();
			this.ButtonSave = new System.Windows.Forms.Button();
			this.ColumnCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnSalesPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.DgSalesOrderLines)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = System.Drawing.Color.Green;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(645, 45);
			this.label1.TabIndex = 9;
			this.label1.Text = "New Sales Order";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// TBCustomerCode
			// 
			this.TBCustomerCode.Enabled = false;
			this.TBCustomerCode.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TBCustomerCode.Location = new System.Drawing.Point(91, 79);
			this.TBCustomerCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TBCustomerCode.MaxLength = 50;
			this.TBCustomerCode.Name = "TBCustomerCode";
			this.TBCustomerCode.Size = new System.Drawing.Size(84, 22);
			this.TBCustomerCode.TabIndex = 1;
			this.TBCustomerCode.TextChanged += new System.EventHandler(this.TBCustomerCodeTextChanged);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(8, 79);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(77, 22);
			this.label2.TabIndex = 10;
			this.label2.Text = "Customer:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// ButtonSearchCustomer
			// 
			this.ButtonSearchCustomer.Location = new System.Drawing.Point(181, 78);
			this.ButtonSearchCustomer.Name = "ButtonSearchCustomer";
			this.ButtonSearchCustomer.Size = new System.Drawing.Size(29, 23);
			this.ButtonSearchCustomer.TabIndex = 2;
			this.ButtonSearchCustomer.Text = "?";
			this.ButtonSearchCustomer.UseVisualStyleBackColor = true;
			this.ButtonSearchCustomer.Click += new System.EventHandler(this.ButtonSearchCustomerClick);
			// 
			// ButtonExit
			// 
			this.ButtonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.ButtonExit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonExit.Image = ((System.Drawing.Image)(resources.GetObject("ButtonExit.Image")));
			this.ButtonExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.ButtonExit.Location = new System.Drawing.Point(12, 327);
			this.ButtonExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.ButtonExit.Name = "ButtonExit";
			this.ButtonExit.Size = new System.Drawing.Size(108, 39);
			this.ButtonExit.TabIndex = 6;
			this.ButtonExit.Text = "Exit";
			this.ButtonExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.ButtonExit.UseVisualStyleBackColor = true;
			this.ButtonExit.Click += new System.EventHandler(this.ButtonExitClick);
			// 
			// LabelCustomerName
			// 
			this.LabelCustomerName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LabelCustomerName.Location = new System.Drawing.Point(233, 78);
			this.LabelCustomerName.Name = "LabelCustomerName";
			this.LabelCustomerName.Size = new System.Drawing.Size(382, 22);
			this.LabelCustomerName.TabIndex = 15;
			this.LabelCustomerName.Text = "---";
			this.LabelCustomerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// ButtonAdd
			// 
			this.ButtonAdd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonAdd.Image = ((System.Drawing.Image)(resources.GetObject("ButtonAdd.Image")));
			this.ButtonAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.ButtonAdd.Location = new System.Drawing.Point(538, 327);
			this.ButtonAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.ButtonAdd.Name = "ButtonAdd";
			this.ButtonAdd.Size = new System.Drawing.Size(117, 39);
			this.ButtonAdd.TabIndex = 4;
			this.ButtonAdd.Text = "New Line";
			this.ButtonAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.ButtonAdd.UseVisualStyleBackColor = true;
			this.ButtonAdd.Click += new System.EventHandler(this.ButtonAddClick);
			// 
			// DgSalesOrderLines
			// 
			this.DgSalesOrderLines.AllowUserToAddRows = false;
			this.DgSalesOrderLines.AllowUserToDeleteRows = false;
			this.DgSalesOrderLines.AllowUserToResizeColumns = false;
			this.DgSalesOrderLines.AllowUserToResizeRows = false;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.DgSalesOrderLines.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
			this.DgSalesOrderLines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DgSalesOrderLines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.ColumnCode,
									this.ColumnQuantity,
									this.ColumnSalesPrice,
									this.ColumnAmount,
									this.ColumnStatus});
			dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.DgSalesOrderLines.DefaultCellStyle = dataGridViewCellStyle10;
			this.DgSalesOrderLines.Location = new System.Drawing.Point(12, 115);
			this.DgSalesOrderLines.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.DgSalesOrderLines.Name = "DgSalesOrderLines";
			this.DgSalesOrderLines.ReadOnly = true;
			this.DgSalesOrderLines.RowHeadersVisible = false;
			this.DgSalesOrderLines.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DgSalesOrderLines.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.DgSalesOrderLines.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.DgSalesOrderLines.Size = new System.Drawing.Size(645, 200);
			this.DgSalesOrderLines.TabIndex = 3;
			this.DgSalesOrderLines.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DgSalesOrderLinesCellFormatting);
			// 
			// ButtonSave
			// 
			this.ButtonSave.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonSave.Image = ((System.Drawing.Image)(resources.GetObject("ButtonSave.Image")));
			this.ButtonSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.ButtonSave.Location = new System.Drawing.Point(398, 327);
			this.ButtonSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.ButtonSave.Name = "ButtonSave";
			this.ButtonSave.Size = new System.Drawing.Size(134, 39);
			this.ButtonSave.TabIndex = 5;
			this.ButtonSave.Text = "Save Order";
			this.ButtonSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.ButtonSave.UseVisualStyleBackColor = true;
			this.ButtonSave.Click += new System.EventHandler(this.ButtonSaveClick);
			// 
			// ColumnCode
			// 
			this.ColumnCode.DataPropertyName = "product";
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle7.NullValue = "0";
			this.ColumnCode.DefaultCellStyle = dataGridViewCellStyle7;
			this.ColumnCode.HeaderText = "Product";
			this.ColumnCode.Name = "ColumnCode";
			this.ColumnCode.ReadOnly = true;
			this.ColumnCode.Width = 220;
			// 
			// ColumnQuantity
			// 
			this.ColumnQuantity.DataPropertyName = "quantity";
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle8.Format = "N0";
			dataGridViewCellStyle8.NullValue = "0";
			this.ColumnQuantity.DefaultCellStyle = dataGridViewCellStyle8;
			this.ColumnQuantity.HeaderText = "Quantity";
			this.ColumnQuantity.Name = "ColumnQuantity";
			this.ColumnQuantity.ReadOnly = true;
			// 
			// ColumnSalesPrice
			// 
			this.ColumnSalesPrice.DataPropertyName = "salesPrice";
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle9.Format = "N2";
			dataGridViewCellStyle9.NullValue = "0";
			this.ColumnSalesPrice.DefaultCellStyle = dataGridViewCellStyle9;
			this.ColumnSalesPrice.HeaderText = "Sales Price";
			this.ColumnSalesPrice.Name = "ColumnSalesPrice";
			this.ColumnSalesPrice.ReadOnly = true;
			// 
			// ColumnAmount
			// 
			this.ColumnAmount.DataPropertyName = "amount";
			this.ColumnAmount.HeaderText = "Amount";
			this.ColumnAmount.Name = "ColumnAmount";
			this.ColumnAmount.ReadOnly = true;
			// 
			// ColumnStatus
			// 
			this.ColumnStatus.DataPropertyName = "salesOrderStatus";
			this.ColumnStatus.HeaderText = "Status";
			this.ColumnStatus.Name = "ColumnStatus";
			this.ColumnStatus.ReadOnly = true;
			// 
			// FormSalesOrderNew
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.ButtonExit;
			this.ClientSize = new System.Drawing.Size(669, 383);
			this.Controls.Add(this.ButtonSave);
			this.Controls.Add(this.DgSalesOrderLines);
			this.Controls.Add(this.ButtonAdd);
			this.Controls.Add(this.LabelCustomerName);
			this.Controls.Add(this.ButtonExit);
			this.Controls.Add(this.ButtonSearchCustomer);
			this.Controls.Add(this.TBCustomerCode);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "FormSalesOrderNew";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "New Sales Order";
			this.Load += new System.EventHandler(this.FormSalesOrderNewLoad);
			((System.ComponentModel.ISupportInitialize)(this.DgSalesOrderLines)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button ButtonSave;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStatus;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAmount;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSalesPrice;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnQuantity;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCode;
		private System.Windows.Forms.DataGridView DgSalesOrderLines;
		private System.Windows.Forms.Button ButtonAdd;
		private System.Windows.Forms.Label LabelCustomerName;
		private System.Windows.Forms.Button ButtonExit;
		private System.Windows.Forms.Button ButtonSearchCustomer;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox TBCustomerCode;
		private System.Windows.Forms.Label label1;
	}
}
