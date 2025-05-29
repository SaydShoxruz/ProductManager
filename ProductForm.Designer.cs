namespace ProductManager
{
    partial class ProductForm
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
            buttonAddOrUpdate = new Button();
            textBoxProductName = new TextBox();
            textBoxProductDescription = new TextBox();
            textBoxProductPrice = new TextBox();
            labelProductName = new Label();
            labelProductDescription = new Label();
            labelProductPrice = new Label();
            buttonCancel = new Button();
            SuspendLayout();
            // 
            // buttonAddOrUpdate
            // 
            buttonAddOrUpdate.Location = new Point(124, 371);
            buttonAddOrUpdate.Name = "buttonAddOrUpdate";
            buttonAddOrUpdate.Size = new Size(112, 34);
            buttonAddOrUpdate.TabIndex = 0;
            buttonAddOrUpdate.Text = "Готово";
            buttonAddOrUpdate.UseVisualStyleBackColor = true;
            buttonAddOrUpdate.Click += buttonAddOrUpdate_Click;
            // 
            // textBoxProductName
            // 
            textBoxProductName.Location = new Point(246, 94);
            textBoxProductName.Name = "textBoxProductName";
            textBoxProductName.Size = new Size(150, 31);
            textBoxProductName.TabIndex = 1;
            // 
            // textBoxProductDescription
            // 
            textBoxProductDescription.Location = new Point(246, 174);
            textBoxProductDescription.Name = "textBoxProductDescription";
            textBoxProductDescription.Size = new Size(150, 31);
            textBoxProductDescription.TabIndex = 2;
            // 
            // textBoxProductPrice
            // 
            textBoxProductPrice.Location = new Point(246, 254);
            textBoxProductPrice.Name = "textBoxProductPrice";
            textBoxProductPrice.Size = new Size(150, 31);
            textBoxProductPrice.TabIndex = 3;
            // 
            // labelProductName
            // 
            labelProductName.AutoSize = true;
            labelProductName.Location = new Point(130, 97);
            labelProductName.Name = "labelProductName";
            labelProductName.Size = new Size(63, 25);
            labelProductName.TabIndex = 4;
            labelProductName.Text = "Name:";
            // 
            // labelProductDescription
            // 
            labelProductDescription.AutoSize = true;
            labelProductDescription.Location = new Point(130, 177);
            labelProductDescription.Name = "labelProductDescription";
            labelProductDescription.Size = new Size(106, 25);
            labelProductDescription.TabIndex = 5;
            labelProductDescription.Text = "Description:";
            // 
            // labelProductPrice
            // 
            labelProductPrice.AutoSize = true;
            labelProductPrice.Location = new Point(130, 257);
            labelProductPrice.Name = "labelProductPrice";
            labelProductPrice.Size = new Size(97, 25);
            labelProductPrice.TabIndex = 6;
            labelProductPrice.Text = "Price(sum):";
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(263, 371);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(112, 34);
            buttonCancel.TabIndex = 7;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(539, 426);
            Controls.Add(buttonCancel);
            Controls.Add(labelProductPrice);
            Controls.Add(labelProductDescription);
            Controls.Add(labelProductName);
            Controls.Add(textBoxProductPrice);
            Controls.Add(textBoxProductDescription);
            Controls.Add(textBoxProductName);
            Controls.Add(buttonAddOrUpdate);
            Name = "ProductForm";
            Text = "ProductForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAddOrUpdate;
        private TextBox textBoxProductName;
        private TextBox textBoxProductDescription;
        private TextBox textBoxProductPrice;
        private Label labelProductName;
        private Label labelProductDescription;
        private Label labelProductPrice;
        private Button buttonCancel;
    }
}