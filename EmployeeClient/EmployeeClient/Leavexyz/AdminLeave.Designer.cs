namespace EmployeeClient.Admin
{
	partial class AdminLeave
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.status = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.des = new System.Windows.Forms.Label();
			this.type = new System.Windows.Forms.Label();
			this.leaveBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.leaveIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.employeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Update = new System.Windows.Forms.DataGridViewButtonColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.leaveBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.leaveIdDataGridViewTextBoxColumn,
            this.employeeDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.Update});
			this.dataGridView1.DataSource = this.leaveBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(86, 139);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(1039, 199);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(244, 375);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 17);
			this.label1.TabIndex = 1;
			this.label1.Text = "Type";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(244, 444);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 17);
			this.label2.TabIndex = 2;
			this.label2.Text = "Status";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(244, 522);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(79, 17);
			this.label3.TabIndex = 3;
			this.label3.Text = "Description";
			// 
			// status
			// 
			this.status.Location = new System.Drawing.Point(586, 441);
			this.status.Name = "status";
			this.status.Size = new System.Drawing.Size(292, 22);
			this.status.TabIndex = 5;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(513, 626);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 7;
			this.button1.Text = "Update";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(524, 683);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(46, 17);
			this.label4.TabIndex = 8;
			this.label4.Text = "label4";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(86, 71);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 9;
			this.button2.Text = "Back";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// des
			// 
			this.des.AutoSize = true;
			this.des.Location = new System.Drawing.Point(583, 522);
			this.des.Name = "des";
			this.des.Size = new System.Drawing.Size(46, 17);
			this.des.TabIndex = 10;
			this.des.Text = "label5";
			// 
			// type
			// 
			this.type.AutoSize = true;
			this.type.Location = new System.Drawing.Point(583, 375);
			this.type.Name = "type";
			this.type.Size = new System.Drawing.Size(46, 17);
			this.type.TabIndex = 11;
			this.type.Text = "label5";
			// 
			// leaveBindingSource
			// 
			this.leaveBindingSource.DataSource = typeof(EmployeeClient.ServiceReference1.Leave);
			// 
			// leaveIdDataGridViewTextBoxColumn
			// 
			this.leaveIdDataGridViewTextBoxColumn.DataPropertyName = "LeaveId";
			this.leaveIdDataGridViewTextBoxColumn.HeaderText = "LeaveId";
			this.leaveIdDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.leaveIdDataGridViewTextBoxColumn.Name = "leaveIdDataGridViewTextBoxColumn";
			this.leaveIdDataGridViewTextBoxColumn.Width = 125;
			// 
			// employeeDataGridViewTextBoxColumn
			// 
			this.employeeDataGridViewTextBoxColumn.DataPropertyName = "Employee";
			this.employeeDataGridViewTextBoxColumn.HeaderText = "Employee";
			this.employeeDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.employeeDataGridViewTextBoxColumn.Name = "employeeDataGridViewTextBoxColumn";
			this.employeeDataGridViewTextBoxColumn.Width = 125;
			// 
			// descriptionDataGridViewTextBoxColumn
			// 
			this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
			this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
			this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
			this.descriptionDataGridViewTextBoxColumn.Width = 125;
			// 
			// statusDataGridViewTextBoxColumn
			// 
			this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
			this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
			this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
			this.statusDataGridViewTextBoxColumn.Width = 125;
			// 
			// typeDataGridViewTextBoxColumn
			// 
			this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
			this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
			this.typeDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
			this.typeDataGridViewTextBoxColumn.Width = 125;
			// 
			// Update
			// 
			this.Update.HeaderText = "Update";
			this.Update.MinimumWidth = 6;
			this.Update.Name = "Update";
			this.Update.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.Update.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.Update.Text = "Update";
			this.Update.UseColumnTextForButtonValue = true;
			this.Update.Width = 125;
			// 
			// AdminLeave
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1137, 751);
			this.Controls.Add(this.type);
			this.Controls.Add(this.des);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.status);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataGridView1);
			this.Name = "AdminLeave";
			this.Text = "Leave";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.AdminLeave_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.leaveBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox status;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.BindingSource leaveBindingSource;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label des;
		private System.Windows.Forms.Label type;
		private System.Windows.Forms.DataGridViewTextBoxColumn leaveIdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn employeeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewButtonColumn Update;
	}
}