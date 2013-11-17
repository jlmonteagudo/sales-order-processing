/*
 * Created by SharpDevelop.
 * User: jlm
 * Date: 16/11/2013
 * Time: 21:53
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace SalesOrderProcessing.Forms.Products
{
	partial class FormProductsManagement
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProductsManagement));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.ButtonEdit = new System.Windows.Forms.Button();
			this.ButtonAdd = new System.Windows.Forms.Button();
			this.DgProducts = new System.Windows.Forms.DataGridView();
			this.ColumnCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label1 = new System.Windows.Forms.Label();
			this.ButtonExit = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.DgProducts)).BeginInit();
			this.SuspendLayout();
			// 
			// ButtonEdit
			// 
			this.ButtonEdit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonEdit.Image = ((System.Drawing.Image)(resources.GetObject("ButtonEdit.Image")));
			this.ButtonEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.ButtonEdit.Location = new System.Drawing.Point(394, 489);
			this.ButtonEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.ButtonEdit.Name = "ButtonEdit";
			this.ButtonEdit.Size = new System.Drawing.Size(108, 45);
			this.ButtonEdit.TabIndex = 11;
			this.ButtonEdit.Text = "Edit";
			this.ButtonEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.ButtonEdit.UseVisualStyleBackColor = true;
			this.ButtonEdit.Click += new System.EventHandler(this.ButtonEditClick);
			// 
			// ButtonAdd
			// 
			this.ButtonAdd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonAdd.Image = ((System.Drawing.Image)(resources.GetObject("ButtonAdd.Image")));
			this.ButtonAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.ButtonAdd.Location = new System.Drawing.Point(508, 489);
			this.ButtonAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.ButtonAdd.Name = "ButtonAdd";
			this.ButtonAdd.Size = new System.Drawing.Size(108, 45);
			this.ButtonAdd.TabIndex = 10;
			this.ButtonAdd.Text = "Add";
			this.ButtonAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.ButtonAdd.UseVisualStyleBackColor = true;
			this.ButtonAdd.Click += new System.EventHandler(this.ButtonAddClick);
			// 
			// DgProducts
			// 
			this.DgProducts.AllowUserToAddRows = false;
			this.DgProducts.AllowUserToDeleteRows = false;
			this.DgProducts.AllowUserToResizeColumns = false;
			this.DgProducts.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.DgProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.DgProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DgProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.ColumnCode,
									this.ColumnName,
									this.ColumnAddress,
									this.ColumnCity});
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.DgProducts.DefaultCellStyle = dataGridViewCellStyle4;
			this.DgProducts.Location = new System.Drawing.Point(12, 72);
			this.DgProducts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.DgProducts.Name = "DgProducts";
			this.DgProducts.ReadOnly = true;
			this.DgProducts.RowHeadersVisible = false;
			this.DgProducts.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DgProducts.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.DgProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.DgProducts.Size = new System.Drawing.Size(604, 398);
			this.DgProducts.TabIndex = 9;
			// 
			// ColumnCode
			// 
			this.ColumnCode.DataPropertyName = "id";
			this.ColumnCode.HeaderText = "Code";
			this.ColumnCode.Name = "ColumnCode";
			this.ColumnCode.ReadOnly = true;
			this.ColumnCode.Width = 80;
			// 
			// ColumnName
			// 
			this.ColumnName.DataPropertyName = "description";
			this.ColumnName.HeaderText = "Description";
			this.ColumnName.Name = "ColumnName";
			this.ColumnName.ReadOnly = true;
			this.ColumnName.Width = 340;
			// 
			// ColumnAddress
			// 
			this.ColumnAddress.DataPropertyName = "cost";
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle2.Format = "N2";
			dataGridViewCellStyle2.NullValue = "0";
			this.ColumnAddress.DefaultCellStyle = dataGridViewCellStyle2;
			this.ColumnAddress.HeaderText = "Cost";
			this.ColumnAddress.Name = "ColumnAddress";
			this.ColumnAddress.ReadOnly = true;
			this.ColumnAddress.Width = 80;
			// 
			// ColumnCity
			// 
			this.ColumnCity.DataPropertyName = "salesPrice";
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle3.Format = "N2";
			dataGridViewCellStyle3.NullValue = "0";
			this.ColumnCity.DefaultCellStyle = dataGridViewCellStyle3;
			this.ColumnCity.HeaderText = "Sales Price";
			this.ColumnCity.Name = "ColumnCity";
			this.ColumnCity.ReadOnly = true;
			this.ColumnCity.Width = 80;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = System.Drawing.Color.Green;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(604, 45);
			this.label1.TabIndex = 8;
			this.label1.Text = "Products Management";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ButtonExit
			// 
			this.ButtonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.ButtonExit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonExit.Image = ((System.Drawing.Image)(resources.GetObject("ButtonExit.Image")));
			this.ButtonExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.ButtonExit.Location = new System.Drawing.Point(12, 489);
			this.ButtonExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.ButtonExit.Name = "ButtonExit";
			this.ButtonExit.Size = new System.Drawing.Size(108, 45);
			this.ButtonExit.TabIndex = 7;
			this.ButtonExit.Text = "Exit";
			this.ButtonExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.ButtonExit.UseVisualStyleBackColor = true;
			this.ButtonExit.Click += new System.EventHandler(this.ButtonExitClick);
			// 
			// FormProductsManagement
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.ButtonExit;
			this.ClientSize = new System.Drawing.Size(633, 553);
			this.Controls.Add(this.ButtonEdit);
			this.Controls.Add(this.ButtonAdd);
			this.Controls.Add(this.DgProducts);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.ButtonExit);
			this.Name = "FormProductsManagement";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Products Management";
			this.Load += new System.EventHandler(this.FormProductsManagementLoad);
			((System.ComponentModel.ISupportInitialize)(this.DgProducts)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button ButtonExit;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCity;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAddress;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCode;
		private System.Windows.Forms.DataGridView DgProducts;
		private System.Windows.Forms.Button ButtonAdd;
		private System.Windows.Forms.Button ButtonEdit;
	}
}
