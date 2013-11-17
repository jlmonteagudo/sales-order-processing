/*
 * Created by SharpDevelop.
 * User: jlm
 * Date: 16/11/2013
 * Time: 12:09
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace SalesOrderProcessing
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.ButtonExit = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.labelTitle = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.ButtonStatistics = new System.Windows.Forms.Button();
			this.ButtonOrders = new System.Windows.Forms.Button();
			this.ButtonProducts = new System.Windows.Forms.Button();
			this.ButtonCustomers = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// ButtonExit
			// 
			this.ButtonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.ButtonExit.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.ButtonExit.Image = ((System.Drawing.Image)(resources.GetObject("ButtonExit.Image")));
			this.ButtonExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.ButtonExit.Location = new System.Drawing.Point(31, 441);
			this.ButtonExit.Name = "ButtonExit";
			this.ButtonExit.Size = new System.Drawing.Size(186, 70);
			this.ButtonExit.TabIndex = 1;
			this.ButtonExit.Text = "Exit";
			this.ButtonExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.ButtonExit.UseVisualStyleBackColor = true;
			this.ButtonExit.Click += new System.EventHandler(this.ButtonExitClick);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.labelTitle);
			this.groupBox1.Controls.Add(this.pictureBox1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(415, 200);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			// 
			// labelTitle
			// 
			this.labelTitle.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTitle.ForeColor = System.Drawing.Color.Gray;
			this.labelTitle.Location = new System.Drawing.Point(19, 137);
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Size = new System.Drawing.Size(378, 36);
			this.labelTitle.TabIndex = 2;
			this.labelTitle.Text = "Sales Order Processing";
			this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
			this.pictureBox1.Location = new System.Drawing.Point(19, 19);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(378, 103);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.ButtonStatistics);
			this.groupBox2.Controls.Add(this.ButtonOrders);
			this.groupBox2.Controls.Add(this.ButtonProducts);
			this.groupBox2.Controls.Add(this.ButtonCustomers);
			this.groupBox2.Location = new System.Drawing.Point(12, 236);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(415, 184);
			this.groupBox2.TabIndex = 7;
			this.groupBox2.TabStop = false;
			// 
			// ButtonStatistics
			// 
			this.ButtonStatistics.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonStatistics.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.ButtonStatistics.Image = ((System.Drawing.Image)(resources.GetObject("ButtonStatistics.Image")));
			this.ButtonStatistics.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.ButtonStatistics.Location = new System.Drawing.Point(211, 96);
			this.ButtonStatistics.Name = "ButtonStatistics";
			this.ButtonStatistics.Size = new System.Drawing.Size(186, 70);
			this.ButtonStatistics.TabIndex = 9;
			this.ButtonStatistics.Text = "Statistics";
			this.ButtonStatistics.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.ButtonStatistics.UseVisualStyleBackColor = true;
			// 
			// ButtonOrders
			// 
			this.ButtonOrders.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonOrders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.ButtonOrders.Image = ((System.Drawing.Image)(resources.GetObject("ButtonOrders.Image")));
			this.ButtonOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.ButtonOrders.Location = new System.Drawing.Point(211, 20);
			this.ButtonOrders.Name = "ButtonOrders";
			this.ButtonOrders.Size = new System.Drawing.Size(186, 70);
			this.ButtonOrders.TabIndex = 8;
			this.ButtonOrders.Text = "Sales Orders";
			this.ButtonOrders.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.ButtonOrders.UseVisualStyleBackColor = true;
			this.ButtonOrders.Click += new System.EventHandler(this.ButtonOrdersClick);
			// 
			// ButtonProducts
			// 
			this.ButtonProducts.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonProducts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.ButtonProducts.Image = ((System.Drawing.Image)(resources.GetObject("ButtonProducts.Image")));
			this.ButtonProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.ButtonProducts.Location = new System.Drawing.Point(19, 96);
			this.ButtonProducts.Name = "ButtonProducts";
			this.ButtonProducts.Size = new System.Drawing.Size(186, 70);
			this.ButtonProducts.TabIndex = 7;
			this.ButtonProducts.Text = "Products";
			this.ButtonProducts.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.ButtonProducts.UseVisualStyleBackColor = true;
			this.ButtonProducts.Click += new System.EventHandler(this.ButtonProductsClick);
			// 
			// ButtonCustomers
			// 
			this.ButtonCustomers.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonCustomers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.ButtonCustomers.Image = ((System.Drawing.Image)(resources.GetObject("ButtonCustomers.Image")));
			this.ButtonCustomers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.ButtonCustomers.Location = new System.Drawing.Point(19, 20);
			this.ButtonCustomers.Name = "ButtonCustomers";
			this.ButtonCustomers.Size = new System.Drawing.Size(186, 70);
			this.ButtonCustomers.TabIndex = 6;
			this.ButtonCustomers.Text = "Customers";
			this.ButtonCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.ButtonCustomers.UseVisualStyleBackColor = true;
			this.ButtonCustomers.Click += new System.EventHandler(this.ButtonCustomersClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.ButtonExit;
			this.ClientSize = new System.Drawing.Size(447, 538);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.ButtonExit);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Sales Order Processing";
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label labelTitle;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button ButtonStatistics;
		private System.Windows.Forms.Button ButtonOrders;
		private System.Windows.Forms.Button ButtonProducts;
		private System.Windows.Forms.Button ButtonCustomers;
		private System.Windows.Forms.Button ButtonExit;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}
