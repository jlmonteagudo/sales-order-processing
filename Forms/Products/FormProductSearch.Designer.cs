/*
 * Created by SharpDevelop.
 * User: jlm
 * Date: 17/11/2013
 * Time: 9:52
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace SalesOrderProcessing.Forms.Products
{
	partial class FormProductSearch
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProductSearch));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.ButtonSelect = new System.Windows.Forms.Button();
			this.ButtonExit = new System.Windows.Forms.Button();
			this.DgProducts = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.ColumnCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.DgProducts)).BeginInit();
			this.SuspendLayout();
			// 
			// ButtonSelect
			// 
			this.ButtonSelect.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonSelect.Image = ((System.Drawing.Image)(resources.GetObject("ButtonSelect.Image")));
			this.ButtonSelect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.ButtonSelect.Location = new System.Drawing.Point(248, 392);
			this.ButtonSelect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.ButtonSelect.Name = "ButtonSelect";
			this.ButtonSelect.Size = new System.Drawing.Size(108, 39);
			this.ButtonSelect.TabIndex = 12;
			this.ButtonSelect.Text = "Select";
			this.ButtonSelect.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.ButtonSelect.UseVisualStyleBackColor = true;
			this.ButtonSelect.Click += new System.EventHandler(this.ButtonSelectClick);
			// 
			// ButtonExit
			// 
			this.ButtonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.ButtonExit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonExit.Image = ((System.Drawing.Image)(resources.GetObject("ButtonExit.Image")));
			this.ButtonExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.ButtonExit.Location = new System.Drawing.Point(12, 392);
			this.ButtonExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.ButtonExit.Name = "ButtonExit";
			this.ButtonExit.Size = new System.Drawing.Size(108, 39);
			this.ButtonExit.TabIndex = 11;
			this.ButtonExit.Text = "Exit";
			this.ButtonExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.ButtonExit.UseVisualStyleBackColor = true;
			this.ButtonExit.Click += new System.EventHandler(this.ButtonExitClick);
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
									this.ColumnName});
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.DgProducts.DefaultCellStyle = dataGridViewCellStyle2;
			this.DgProducts.Location = new System.Drawing.Point(12, 64);
			this.DgProducts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.DgProducts.Name = "DgProducts";
			this.DgProducts.ReadOnly = true;
			this.DgProducts.RowHeadersVisible = false;
			this.DgProducts.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DgProducts.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.DgProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.DgProducts.Size = new System.Drawing.Size(344, 311);
			this.DgProducts.TabIndex = 10;
			this.DgProducts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgProductsCellDoubleClick);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Green;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(344, 38);
			this.label1.TabIndex = 9;
			this.label1.Text = "Search Customer";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
			this.ColumnName.Width = 240;
			// 
			// FormProductSearch
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(373, 444);
			this.Controls.Add(this.ButtonSelect);
			this.Controls.Add(this.ButtonExit);
			this.Controls.Add(this.DgProducts);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "FormProductSearch";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Product Search";
			this.Load += new System.EventHandler(this.FormProductSearchLoad);
			((System.ComponentModel.ISupportInitialize)(this.DgProducts)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCode;
		private System.Windows.Forms.DataGridView DgProducts;
		private System.Windows.Forms.Button ButtonExit;
		private System.Windows.Forms.Button ButtonSelect;
	}
}
