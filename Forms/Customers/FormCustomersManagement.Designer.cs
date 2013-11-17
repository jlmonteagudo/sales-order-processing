/*
 * Created by SharpDevelop.
 * User: jlm
 * Date: 16/11/2013
 * Time: 12:44
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace SalesOrderProcessing.Forms.Customers
{
	partial class FormCustomersManagement
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCustomersManagement));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.ButtonExit = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.DgCustomers = new System.Windows.Forms.DataGridView();
			this.ColumnCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ButtonAdd = new System.Windows.Forms.Button();
			this.ButtonEdit = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.DgCustomers)).BeginInit();
			this.SuspendLayout();
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
			this.ButtonExit.TabIndex = 2;
			this.ButtonExit.Text = "Exit";
			this.ButtonExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.ButtonExit.UseVisualStyleBackColor = true;
			this.ButtonExit.Click += new System.EventHandler(this.ButtonExitClick);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = System.Drawing.Color.Green;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(604, 45);
			this.label1.TabIndex = 3;
			this.label1.Text = "Customer Management";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// DgCustomers
			// 
			this.DgCustomers.AllowUserToAddRows = false;
			this.DgCustomers.AllowUserToDeleteRows = false;
			this.DgCustomers.AllowUserToResizeColumns = false;
			this.DgCustomers.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.DgCustomers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.DgCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DgCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.ColumnCode,
									this.ColumnName,
									this.ColumnAddress,
									this.ColumnCity});
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.DgCustomers.DefaultCellStyle = dataGridViewCellStyle2;
			this.DgCustomers.Location = new System.Drawing.Point(12, 72);
			this.DgCustomers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.DgCustomers.Name = "DgCustomers";
			this.DgCustomers.ReadOnly = true;
			this.DgCustomers.RowHeadersVisible = false;
			this.DgCustomers.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DgCustomers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.DgCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.DgCustomers.Size = new System.Drawing.Size(604, 398);
			this.DgCustomers.TabIndex = 4;
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
			this.ColumnName.DataPropertyName = "name";
			this.ColumnName.HeaderText = "Name";
			this.ColumnName.Name = "ColumnName";
			this.ColumnName.ReadOnly = true;
			this.ColumnName.Width = 200;
			// 
			// ColumnAddress
			// 
			this.ColumnAddress.DataPropertyName = "address";
			this.ColumnAddress.HeaderText = "Address";
			this.ColumnAddress.Name = "ColumnAddress";
			this.ColumnAddress.ReadOnly = true;
			this.ColumnAddress.Width = 180;
			// 
			// ColumnCity
			// 
			this.ColumnCity.DataPropertyName = "city";
			this.ColumnCity.HeaderText = "City";
			this.ColumnCity.Name = "ColumnCity";
			this.ColumnCity.ReadOnly = true;
			this.ColumnCity.Width = 120;
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
			this.ButtonAdd.TabIndex = 5;
			this.ButtonAdd.Text = "Add";
			this.ButtonAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.ButtonAdd.UseVisualStyleBackColor = true;
			this.ButtonAdd.Click += new System.EventHandler(this.ButtonAddClick);
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
			this.ButtonEdit.TabIndex = 6;
			this.ButtonEdit.Text = "Edit";
			this.ButtonEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.ButtonEdit.UseVisualStyleBackColor = true;
			this.ButtonEdit.Click += new System.EventHandler(this.ButtonEditClick);
			// 
			// FormCustomersManagement
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.ButtonExit;
			this.ClientSize = new System.Drawing.Size(628, 545);
			this.Controls.Add(this.ButtonEdit);
			this.Controls.Add(this.ButtonAdd);
			this.Controls.Add(this.DgCustomers);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.ButtonExit);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "FormCustomersManagement";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Customer Management";
			this.Load += new System.EventHandler(this.FormCustomersManagementLoad);
			((System.ComponentModel.ISupportInitialize)(this.DgCustomers)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button ButtonEdit;
		private System.Windows.Forms.Button ButtonAdd;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCity;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAddress;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCode;
		private System.Windows.Forms.DataGridView DgCustomers;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button ButtonExit;
	}
}
