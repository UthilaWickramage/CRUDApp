namespace FridayProject
{
    partial class ProductRegistration
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
            components = new System.ComponentModel.Container();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            nameTxt = new TextBox();
            descTxt = new TextBox();
            priceTxt = new TextBox();
            discountTxt = new TextBox();
            qtyTxt = new TextBox();
            groupBox1 = new GroupBox();
            updateBtn = new Button();
            label1 = new Label();
            categoryTxt = new TextBox();
            dataGridView1 = new DataGridView();
            productBindingSource = new BindingSource(components);
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            discountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            qtyDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categoryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Delete = new DataGridViewButtonColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(18, 86);
            label2.Name = "label2";
            label2.Size = new Size(147, 28);
            label2.TabIndex = 1;
            label2.Text = "Product Name :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(18, 147);
            label3.Name = "label3";
            label3.Size = new Size(190, 28);
            label3.TabIndex = 2;
            label3.Text = "Product Description:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(18, 215);
            label4.Name = "label4";
            label4.Size = new Size(63, 28);
            label4.TabIndex = 3;
            label4.Text = "Price :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(18, 280);
            label5.Name = "label5";
            label5.Size = new Size(98, 28);
            label5.TabIndex = 4;
            label5.Text = "Discount :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(18, 343);
            label6.Name = "label6";
            label6.Size = new Size(97, 28);
            label6.TabIndex = 5;
            label6.Text = "Quantity :";
            // 
            // nameTxt
            // 
            nameTxt.Font = new Font("Segoe UI", 12F);
            nameTxt.Location = new Point(284, 80);
            nameTxt.Name = "nameTxt";
            nameTxt.Size = new Size(386, 34);
            nameTxt.TabIndex = 6;
            // 
            // descTxt
            // 
            descTxt.Font = new Font("Segoe UI", 12F);
            descTxt.Location = new Point(284, 141);
            descTxt.Name = "descTxt";
            descTxt.Size = new Size(386, 34);
            descTxt.TabIndex = 7;
            // 
            // priceTxt
            // 
            priceTxt.Font = new Font("Segoe UI", 12F);
            priceTxt.Location = new Point(284, 209);
            priceTxt.Name = "priceTxt";
            priceTxt.Size = new Size(386, 34);
            priceTxt.TabIndex = 8;
            // 
            // discountTxt
            // 
            discountTxt.Font = new Font("Segoe UI", 12F);
            discountTxt.Location = new Point(284, 274);
            discountTxt.Name = "discountTxt";
            discountTxt.Size = new Size(386, 34);
            discountTxt.TabIndex = 9;
            // 
            // qtyTxt
            // 
            qtyTxt.Font = new Font("Segoe UI", 12F);
            qtyTxt.Location = new Point(284, 337);
            qtyTxt.Name = "qtyTxt";
            qtyTxt.Size = new Size(386, 34);
            qtyTxt.TabIndex = 10;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(updateBtn);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(categoryTxt);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(qtyTxt);
            groupBox1.Controls.Add(discountTxt);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(priceTxt);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(descTxt);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(nameTxt);
            groupBox1.Font = new Font("Segoe UI", 20F);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(734, 562);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Product Registration";
            // 
            // updateBtn
            // 
            updateBtn.Font = new Font("Segoe UI", 12F);
            updateBtn.Location = new Point(473, 479);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(197, 55);
            updateBtn.TabIndex = 14;
            updateBtn.Text = "Save Product";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(18, 411);
            label1.Name = "label1";
            label1.Size = new Size(101, 28);
            label1.TabIndex = 12;
            label1.Text = "Category :";
            // 
            // categoryTxt
            // 
            categoryTxt.Font = new Font("Segoe UI", 12F);
            categoryTxt.Location = new Point(284, 405);
            categoryTxt.Name = "categoryTxt";
            categoryTxt.Size = new Size(386, 34);
            categoryTxt.TabIndex = 13;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, discountDataGridViewTextBoxColumn, qtyDataGridViewTextBoxColumn, categoryDataGridViewTextBoxColumn, Delete });
            dataGridView1.DataSource = productBindingSource;
            dataGridView1.Location = new Point(752, 32);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(713, 542);
            dataGridView1.TabIndex = 13;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(Model.Product);
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            descriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.HeaderText = "Price";
            priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            priceDataGridViewTextBoxColumn.ReadOnly = true;
            priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // discountDataGridViewTextBoxColumn
            // 
            discountDataGridViewTextBoxColumn.DataPropertyName = "Discount";
            discountDataGridViewTextBoxColumn.HeaderText = "Discount";
            discountDataGridViewTextBoxColumn.MinimumWidth = 6;
            discountDataGridViewTextBoxColumn.Name = "discountDataGridViewTextBoxColumn";
            discountDataGridViewTextBoxColumn.ReadOnly = true;
            discountDataGridViewTextBoxColumn.Width = 125;
            // 
            // qtyDataGridViewTextBoxColumn
            // 
            qtyDataGridViewTextBoxColumn.DataPropertyName = "Qty";
            qtyDataGridViewTextBoxColumn.HeaderText = "Qty";
            qtyDataGridViewTextBoxColumn.MinimumWidth = 6;
            qtyDataGridViewTextBoxColumn.Name = "qtyDataGridViewTextBoxColumn";
            qtyDataGridViewTextBoxColumn.ReadOnly = true;
            qtyDataGridViewTextBoxColumn.Width = 125;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            categoryDataGridViewTextBoxColumn.MinimumWidth = 6;
            categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            categoryDataGridViewTextBoxColumn.ReadOnly = true;
            categoryDataGridViewTextBoxColumn.Width = 125;
            // 
            // Delete
            // 
            Delete.DataPropertyName = "Id";
            Delete.HeaderText = "Delete";
            Delete.MinimumWidth = 6;
            Delete.Name = "Delete";
            Delete.ReadOnly = true;
            Delete.Text = "Delete";
            Delete.UseColumnTextForButtonValue = true;
            Delete.Width = 125;
            // 
            // ProductRegistration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1477, 620);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Name = "ProductRegistration";
            Text = "Product Registration";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox nameTxt;
        private TextBox descTxt;
        private TextBox priceTxt;
        private TextBox discountTxt;
        private TextBox qtyTxt;
        private GroupBox groupBox1;
        private Label label1;
        private TextBox categoryTxt;
        private DataGridView dataGridView1;
        private BindingSource productBindingSource;
        private Button updateBtn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn discountDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private DataGridViewButtonColumn Delete;
    }
}
