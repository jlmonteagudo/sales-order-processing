/*
 * Created by SharpDevelop.
 * User: jlm
 * Date: 16/11/2013
 * Time: 22:17
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace SalesOrderProcessing.Forms.Products
{
	partial class FormProductEdit
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProductEdit));
			this.ButtonSave = new System.Windows.Forms.Button();
			this.ButtonExit = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.TBSalesPrice = new System.Windows.Forms.TextBox();
			this.TBCost = new System.Windows.Forms.TextBox();
			this.TBDescription = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// ButtonSave
			// 
			this.ButtonSave.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonSave.Image = ((System.Drawing.Image)(resources.GetObject("ButtonSave.Image")));
			this.ButtonSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.ButtonSave.Location = new System.Drawing.Point(263, 206);
			this.ButtonSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.ButtonSave.Name = "ButtonSave";
			this.ButtonSave.Size = new System.Drawing.Size(108, 39);
			this.ButtonSave.TabIndex = 11;
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
			this.ButtonExit.Location = new System.Drawing.Point(12, 206);
			this.ButtonExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.ButtonExit.Name = "ButtonExit";
			this.ButtonExit.Size = new System.Drawing.Size(108, 39);
			this.ButtonExit.TabIndex = 12;
			this.ButtonExit.Text = "Exit";
			this.ButtonExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.ButtonExit.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.TBSalesPrice);
			this.groupBox1.Controls.Add(this.TBCost);
			this.groupBox1.Controls.Add(this.TBDescription);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(12, 63);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox1.Size = new System.Drawing.Size(359, 129);
			this.groupBox1.TabIndex = 13;
			this.groupBox1.TabStop = false;
			// 
			// TBSalesPrice
			// 
			this.TBSalesPrice.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TBSalesPrice.Location = new System.Drawing.Point(115, 77);
			this.TBSalesPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TBSalesPrice.MaxLength = 7;
			this.TBSalesPrice.Name = "TBSalesPrice";
			this.TBSalesPrice.Size = new System.Drawing.Size(215, 22);
			this.TBSalesPrice.TabIndex = 3;
			// 
			// TBCost
			// 
			this.TBCost.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TBCost.Location = new System.Drawing.Point(115, 51);
			this.TBCost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TBCost.MaxLength = 7;
			this.TBCost.Name = "TBCost";
			this.TBCost.Size = new System.Drawing.Size(215, 22);
			this.TBCost.TabIndex = 2;
			// 
			// TBDescription
			// 
			this.TBDescription.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TBDescription.Location = new System.Drawing.Point(115, 25);
			this.TBDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TBDescription.MaxLength = 50;
			this.TBDescription.Name = "TBDescription";
			this.TBDescription.Size = new System.Drawing.Size(215, 22);
			this.TBDescription.TabIndex = 1;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(6, 75);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(103, 24);
			this.label4.TabIndex = 2;
			this.label4.Text = "Sales Price:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(32, 51);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(77, 22);
			this.label3.TabIndex = 1;
			this.label3.Text = "Cost:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(32, 25);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(77, 22);
			this.label2.TabIndex = 0;
			this.label2.Text = "Description:";
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
			this.label1.TabIndex = 10;
			this.label1.Text = "Edit Product";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// FormProductEdit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.ButtonExit;
			this.ClientSize = new System.Drawing.Size(388, 260);
			this.Controls.Add(this.ButtonSave);
			this.Controls.Add(this.ButtonExit);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "FormProductEdit";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Edit Product";
			this.Load += new System.EventHandler(this.FormProductEditLoad);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox TBDescription;
		private System.Windows.Forms.TextBox TBCost;
		private System.Windows.Forms.TextBox TBSalesPrice;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button ButtonExit;
		private System.Windows.Forms.Button ButtonSave;
	}
}
