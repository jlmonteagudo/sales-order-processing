/*
 * Created by SharpDevelop.
 * User: jlm
 * Date: 17/11/2013
 * Time: 9:44
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace SalesOrderProcessing.Forms.Orders
{
	partial class FormSalesOrderLineNew
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSalesOrderLineNew));
			this.ButtonSave = new System.Windows.Forms.Button();
			this.ButtonExit = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.ComboSalesOrderStatus = new System.Windows.Forms.ComboBox();
			this.ButtonSearchCustomer = new System.Windows.Forms.Button();
			this.TBProductDescrition = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.TBAmount = new System.Windows.Forms.TextBox();
			this.TBSalesPrice = new System.Windows.Forms.TextBox();
			this.TBQuantity = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// ButtonSave
			// 
			this.ButtonSave.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonSave.Image = ((System.Drawing.Image)(resources.GetObject("ButtonSave.Image")));
			this.ButtonSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.ButtonSave.Location = new System.Drawing.Point(263, 277);
			this.ButtonSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.ButtonSave.Name = "ButtonSave";
			this.ButtonSave.Size = new System.Drawing.Size(108, 39);
			this.ButtonSave.TabIndex = 7;
			this.ButtonSave.Text = "Save";
			this.ButtonSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.ButtonSave.UseVisualStyleBackColor = true;
			this.ButtonSave.Click += new System.EventHandler(this.ButtonSaveClick);
			// 
			// ButtonExit
			// 
			this.ButtonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.ButtonExit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonExit.Image = ((System.Drawing.Image)(resources.GetObject("ButtonExit.Image")));
			this.ButtonExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.ButtonExit.Location = new System.Drawing.Point(12, 277);
			this.ButtonExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.ButtonExit.Name = "ButtonExit";
			this.ButtonExit.Size = new System.Drawing.Size(108, 39);
			this.ButtonExit.TabIndex = 8;
			this.ButtonExit.Text = "Exit";
			this.ButtonExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.ButtonExit.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.ComboSalesOrderStatus);
			this.groupBox1.Controls.Add(this.ButtonSearchCustomer);
			this.groupBox1.Controls.Add(this.TBProductDescrition);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.TBAmount);
			this.groupBox1.Controls.Add(this.TBSalesPrice);
			this.groupBox1.Controls.Add(this.TBQuantity);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(12, 68);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox1.Size = new System.Drawing.Size(359, 186);
			this.groupBox1.TabIndex = 9;
			this.groupBox1.TabStop = false;
			// 
			// ComboSalesOrderStatus
			// 
			this.ComboSalesOrderStatus.DisplayMember = "description";
			this.ComboSalesOrderStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ComboSalesOrderStatus.FormattingEnabled = true;
			this.ComboSalesOrderStatus.Location = new System.Drawing.Point(107, 136);
			this.ComboSalesOrderStatus.Name = "ComboSalesOrderStatus";
			this.ComboSalesOrderStatus.Size = new System.Drawing.Size(180, 21);
			this.ComboSalesOrderStatus.TabIndex = 6;
			// 
			// ButtonSearchCustomer
			// 
			this.ButtonSearchCustomer.Location = new System.Drawing.Point(293, 29);
			this.ButtonSearchCustomer.Name = "ButtonSearchCustomer";
			this.ButtonSearchCustomer.Size = new System.Drawing.Size(29, 23);
			this.ButtonSearchCustomer.TabIndex = 2;
			this.ButtonSearchCustomer.Text = "?";
			this.ButtonSearchCustomer.UseVisualStyleBackColor = true;
			this.ButtonSearchCustomer.Click += new System.EventHandler(this.ButtonSearchCustomerClick);
			// 
			// TBProductDescrition
			// 
			this.TBProductDescrition.Enabled = false;
			this.TBProductDescrition.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TBProductDescrition.Location = new System.Drawing.Point(107, 29);
			this.TBProductDescrition.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TBProductDescrition.MaxLength = 50;
			this.TBProductDescrition.Name = "TBProductDescrition";
			this.TBProductDescrition.Size = new System.Drawing.Size(180, 22);
			this.TBProductDescrition.TabIndex = 1;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(24, 29);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(77, 22);
			this.label5.TabIndex = 13;
			this.label5.Text = "Product:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// TBAmount
			// 
			this.TBAmount.Enabled = false;
			this.TBAmount.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TBAmount.Location = new System.Drawing.Point(107, 109);
			this.TBAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TBAmount.MaxLength = 6;
			this.TBAmount.Name = "TBAmount";
			this.TBAmount.Size = new System.Drawing.Size(180, 22);
			this.TBAmount.TabIndex = 5;
			// 
			// TBSalesPrice
			// 
			this.TBSalesPrice.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TBSalesPrice.Location = new System.Drawing.Point(107, 83);
			this.TBSalesPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TBSalesPrice.MaxLength = 6;
			this.TBSalesPrice.Name = "TBSalesPrice";
			this.TBSalesPrice.Size = new System.Drawing.Size(180, 22);
			this.TBSalesPrice.TabIndex = 4;
			this.TBSalesPrice.TextChanged += new System.EventHandler(this.TBSalesPriceTextChanged);
			// 
			// TBQuantity
			// 
			this.TBQuantity.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TBQuantity.Location = new System.Drawing.Point(107, 57);
			this.TBQuantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TBQuantity.MaxLength = 4;
			this.TBQuantity.Name = "TBQuantity";
			this.TBQuantity.Size = new System.Drawing.Size(180, 22);
			this.TBQuantity.TabIndex = 3;
			this.TBQuantity.Text = "1";
			this.TBQuantity.TextChanged += new System.EventHandler(this.TBQuantityTextChanged);
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(24, 107);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(77, 24);
			this.label4.TabIndex = 2;
			this.label4.Text = "Amount:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(6, 83);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(95, 22);
			this.label3.TabIndex = 1;
			this.label3.Text = "Sales Price:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(24, 57);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(77, 22);
			this.label2.TabIndex = 0;
			this.label2.Text = "Quantity:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Green;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(359, 38);
			this.label1.TabIndex = 6;
			this.label1.Text = "New Sales Order Line";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(24, 136);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(77, 24);
			this.label6.TabIndex = 15;
			this.label6.Text = "Status:";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// FormSalesOrderLineNew
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.ButtonExit;
			this.ClientSize = new System.Drawing.Size(393, 327);
			this.Controls.Add(this.ButtonSave);
			this.Controls.Add(this.ButtonExit);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "FormSalesOrderLineNew";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "New Sales Order Line";
			this.Load += new System.EventHandler(this.FormSalesOrderLineNewLoad);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox ComboSalesOrderStatus;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox TBProductDescrition;
		private System.Windows.Forms.Button ButtonSearchCustomer;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox TBQuantity;
		private System.Windows.Forms.TextBox TBSalesPrice;
		private System.Windows.Forms.TextBox TBAmount;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button ButtonExit;
		private System.Windows.Forms.Button ButtonSave;
	}
}
