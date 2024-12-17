namespace DBMS.SQL.EmployeeSales
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvEmployee = new DataGridView();
            dgvOrderList = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrderList).BeginInit();
            SuspendLayout();
            // 
            // dgvEmployee
            // 
            dgvEmployee.BackgroundColor = SystemColors.ControlLight;
            dgvEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployee.Location = new Point(31, 72);
            dgvEmployee.Margin = new Padding(3, 4, 3, 4);
            dgvEmployee.Name = "dgvEmployee";
            dgvEmployee.RowHeadersWidth = 51;
            dgvEmployee.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmployee.Size = new Size(977, 227);
            dgvEmployee.TabIndex = 0;
            dgvEmployee.CellMouseUp += dgvEmployee_CellMouseUp;
            // 
            // dgvOrderList
            // 
            dgvOrderList.BackgroundColor = SystemColors.ControlLight;
            dgvOrderList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderList.Location = new Point(31, 376);
            dgvOrderList.Margin = new Padding(3, 4, 3, 4);
            dgvOrderList.Name = "dgvOrderList";
            dgvOrderList.RowHeadersWidth = 51;
            dgvOrderList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrderList.Size = new Size(1185, 335);
            dgvOrderList.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(31, 33);
            label1.Name = "label1";
            label1.Size = new Size(141, 28);
            label1.TabIndex = 2;
            label1.Text = "ยอดขายพนักงาน";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(31, 337);
            label2.Name = "label2";
            label2.Size = new Size(159, 28);
            label2.TabIndex = 3;
            label2.Text = "รายละเอียดคำสั่งซื้อ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1242, 743);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvOrderList);
            Controls.Add(dgvEmployee);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "ยอดขายพนักงาน";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrderList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvEmployee;
        private DataGridView dgvOrderList;
        private Label label1;
        private Label label2;
    }
}
