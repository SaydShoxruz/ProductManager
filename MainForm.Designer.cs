namespace ProductManager
{
    partial class MainForm
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
            dataGridViewProducts = new DataGridView();
            textBoxSearchProducts = new TextBox();
            searchProduct = new Button();
            addProduct = new Button();
            updateProduct = new Button();
            deleteProduct = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewProducts
            // 
            dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProducts.Location = new Point(44, 156);
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewProducts.RowHeadersWidth = 62;
            dataGridViewProducts.Size = new Size(658, 395);
            dataGridViewProducts.TabIndex = 0;
            // 
            // textBoxSearchProducts
            // 
            textBoxSearchProducts.Location = new Point(44, 99);
            textBoxSearchProducts.Name = "textBoxSearchProducts";
            textBoxSearchProducts.Size = new Size(425, 31);
            textBoxSearchProducts.TabIndex = 1;
            // 
            // searchProduct
            // 
            searchProduct.Location = new Point(484, 97);
            searchProduct.Name = "searchProduct";
            searchProduct.Size = new Size(187, 34);
            searchProduct.TabIndex = 2;
            searchProduct.Text = "Поиск по названии";
            searchProduct.UseVisualStyleBackColor = true;
            searchProduct.Click += searchProduct_Click;
            // 
            // addProduct
            // 
            addProduct.Location = new Point(774, 194);
            addProduct.Name = "addProduct";
            addProduct.Size = new Size(131, 59);
            addProduct.TabIndex = 3;
            addProduct.Text = "Добавить";
            addProduct.UseVisualStyleBackColor = true;
            addProduct.Click += addProduct_Click;
            // 
            // updateProduct
            // 
            updateProduct.Location = new Point(774, 319);
            updateProduct.Name = "updateProduct";
            updateProduct.Size = new Size(131, 59);
            updateProduct.TabIndex = 4;
            updateProduct.Text = "Изменить";
            updateProduct.UseVisualStyleBackColor = true;
            updateProduct.Click += updateProduct_Click;
            // 
            // deleteProduct
            // 
            deleteProduct.DialogResult = DialogResult.Yes;
            deleteProduct.Location = new Point(774, 450);
            deleteProduct.Name = "deleteProduct";
            deleteProduct.Size = new Size(131, 59);
            deleteProduct.TabIndex = 5;
            deleteProduct.Text = "Удалить";
            deleteProduct.UseVisualStyleBackColor = true;
            deleteProduct.Click += deleteProduct_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(958, 618);
            Controls.Add(deleteProduct);
            Controls.Add(updateProduct);
            Controls.Add(addProduct);
            Controls.Add(searchProduct);
            Controls.Add(textBoxSearchProducts);
            Controls.Add(dataGridViewProducts);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewProducts;
        private TextBox textBoxSearchProducts;
        private Button searchProduct;
        private Button addProduct;
        private Button updateProduct;
        private Button deleteProduct;
    }
}
