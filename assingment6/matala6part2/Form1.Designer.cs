namespace matala6part2
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
            dataGridView1 = new DataGridView();
            txtFilter = new TextBox();
            btnFilter = new Button();
            btnCancelFilter = new Button();
            label1 = new Label();
            label2 = new Label();
            btnUpdateDB = new Button();
            txtCode = new TextBox();
            txtPrice = new TextBox();
            txtDesc = new TextBox();
            txtName = new TextBox();
            btnDelete = new Button();
            btnInsert = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(814, 303);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtFilter
            // 
            txtFilter.Location = new Point(860, 39);
            txtFilter.Name = "txtFilter";
            txtFilter.Size = new Size(214, 27);
            txtFilter.TabIndex = 1;
            txtFilter.Text = "Above the price for filtering";
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(973, 97);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(101, 59);
            btnFilter.TabIndex = 2;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click_1;
            // 
            // btnCancelFilter
            // 
            btnCancelFilter.Location = new Point(860, 97);
            btnCancelFilter.Name = "btnCancelFilter";
            btnCancelFilter.Size = new Size(96, 59);
            btnCancelFilter.TabIndex = 3;
            btnCancelFilter.Text = "Cancel Filter";
            btnCancelFilter.UseVisualStyleBackColor = true;
            btnCancelFilter.Click += btnCancelFilter_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 355);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 4;
            label1.Text = "Delete Item";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(410, 355);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 5;
            label2.Text = "Insert Item";
            // 
            // btnUpdateDB
            // 
            btnUpdateDB.Location = new Point(886, 250);
            btnUpdateDB.Name = "btnUpdateDB";
            btnUpdateDB.Size = new Size(175, 70);
            btnUpdateDB.TabIndex = 12;
            btnUpdateDB.Text = "Update Data Base";
            btnUpdateDB.UseVisualStyleBackColor = true;
            btnUpdateDB.Click += btnUpdateDB_Click_1;
            // 
            // txtCode
            // 
            txtCode.Location = new Point(95, 392);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(125, 27);
            txtCode.TabIndex = 13;
            txtCode.Text = "Code";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(723, 392);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(125, 27);
            txtPrice.TabIndex = 14;
            txtPrice.Text = "Price";
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(573, 392);
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(125, 27);
            txtDesc.TabIndex = 15;
            txtDesc.Text = "Description";
            // 
            // txtName
            // 
            txtName.Location = new Point(410, 392);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 16;
            txtName.Text = "Name";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(112, 446);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 17;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click_1;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(582, 446);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(94, 29);
            btnInsert.TabIndex = 18;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1117, 510);
            Controls.Add(btnInsert);
            Controls.Add(btnDelete);
            Controls.Add(txtName);
            Controls.Add(txtDesc);
            Controls.Add(txtPrice);
            Controls.Add(txtCode);
            Controls.Add(btnUpdateDB);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancelFilter);
            Controls.Add(btnFilter);
            Controls.Add(txtFilter);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox txtFilter;
        private Button btnFilter;
        private Button btnCancelFilter;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button1;
        private Button button2;
        private Button btnUpdateDB;
        private TextBox txtCode;
        private TextBox txtPrice;
        private TextBox txtDesc;
        private TextBox txtName;
        private Button btnDelete;
        private Button btnInsert;
    }
}
