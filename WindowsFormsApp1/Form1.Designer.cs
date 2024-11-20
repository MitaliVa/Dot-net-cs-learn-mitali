namespace WindowsFormsApp1
{
    partial class Form1
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
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.btnFetchAllEmployees = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.empFirstName = new System.Windows.Forms.TextBox();
            this.empLastName = new System.Windows.Forms.TextBox();
            this.addEmpData = new System.Windows.Forms.Button();
            this.joiningDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvEmployees.Location = new System.Drawing.Point(12, 12);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.RowHeadersWidth = 51;
            this.dgvEmployees.Size = new System.Drawing.Size(504, 162);
            this.dgvEmployees.TabIndex = 0;
            // 
            // btnFetchAllEmployees
            // 
            this.btnFetchAllEmployees.Location = new System.Drawing.Point(12, 180);
            this.btnFetchAllEmployees.Name = "btnFetchAllEmployees";
            this.btnFetchAllEmployees.Size = new System.Drawing.Size(200, 30);
            this.btnFetchAllEmployees.TabIndex = 1;
            this.btnFetchAllEmployees.Text = "Fetch All Employees";
            this.btnFetchAllEmployees.UseVisualStyleBackColor = true;
            this.btnFetchAllEmployees.Click += new System.EventHandler(this.btnFetchAllEmployees_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // empFirstName
            // 
            this.empFirstName.AccessibleName = "empName";
            this.empFirstName.BackColor = System.Drawing.SystemColors.Highlight;
            this.empFirstName.ForeColor = System.Drawing.SystemColors.Info;
            this.empFirstName.Location = new System.Drawing.Point(12, 228);
            this.empFirstName.Name = "empFirstName";
            this.empFirstName.Size = new System.Drawing.Size(163, 22);
            this.empFirstName.TabIndex = 4;
            this.empFirstName.Text = "First Name";
            this.empFirstName.Click += new System.EventHandler(this.textBox1_TextChanged);
            this.empFirstName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // empLastName
            // 
            this.empLastName.BackColor = System.Drawing.SystemColors.Highlight;
            this.empLastName.ForeColor = System.Drawing.SystemColors.Info;
            this.empLastName.Location = new System.Drawing.Point(181, 228);
            this.empLastName.Name = "empLastName";
            this.empLastName.Size = new System.Drawing.Size(163, 22);
            this.empLastName.TabIndex = 7;
            this.empLastName.Text = "Last Name";
            this.empLastName.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // addEmpData
            // 
            this.addEmpData.BackColor = System.Drawing.Color.SkyBlue;
            this.addEmpData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addEmpData.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.addEmpData.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.addEmpData.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.addEmpData.Location = new System.Drawing.Point(12, 256);
            this.addEmpData.Name = "addEmpData";
            this.addEmpData.Size = new System.Drawing.Size(163, 48);
            this.addEmpData.TabIndex = 8;
            this.addEmpData.Text = "Add Data";
            this.addEmpData.UseVisualStyleBackColor = false;
            this.addEmpData.Click += new System.EventHandler(this.addEmpData_Click);
            // 
            // joiningDate
            // 
            this.joiningDate.CalendarForeColor = System.Drawing.SystemColors.ButtonFace;
            this.joiningDate.CalendarMonthBackground = System.Drawing.SystemColors.Highlight;
            this.joiningDate.Location = new System.Drawing.Point(350, 228);
            this.joiningDate.Name = "joiningDate";
            this.joiningDate.Size = new System.Drawing.Size(166, 22);
            this.joiningDate.TabIndex = 9;
            this.joiningDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1265, 551);
            this.Controls.Add(this.joiningDate);
            this.Controls.Add(this.addEmpData);
            this.Controls.Add(this.empLastName);
            this.Controls.Add(this.empFirstName);
            this.Controls.Add(this.btnFetchAllEmployees);
            this.Controls.Add(this.dgvEmployees);
            this.Name = "Form1";
            this.Text = "Employee List";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        // Remove the unnecessary button and listView definitions:
        private System.Windows.Forms.DataGridView dgvEmployees; // DataGridView for displaying employee data
        private System.Windows.Forms.Button btnFetchAllEmployees; // Button to trigger fetching employee data
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.TextBox empFirstName;
        private System.Windows.Forms.TextBox empLastName;
        private System.Windows.Forms.Button addEmpData;
        private System.Windows.Forms.DateTimePicker joiningDate;
    }
}
