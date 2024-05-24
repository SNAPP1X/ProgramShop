namespace ProgramShop.DLC
{
    partial class ProductsForm
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.addToCart = new System.Windows.Forms.Button();
            this.productPanel = new System.Windows.Forms.Panel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.desc = new System.Windows.Forms.Label();
            this.manuf = new System.Windows.Forms.Label();
            this.productPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(197, 10);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(62, 24);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "name";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceLabel.Location = new System.Drawing.Point(478, 10);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(57, 24);
            this.priceLabel.TabIndex = 2;
            this.priceLabel.Text = "price";
            // 
            // addToCart
            // 
            this.addToCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addToCart.Location = new System.Drawing.Point(482, 71);
            this.addToCart.Name = "addToCart";
            this.addToCart.Size = new System.Drawing.Size(113, 34);
            this.addToCart.TabIndex = 3;
            this.addToCart.Tag = "product";
            this.addToCart.Text = "Add to Cart";
            this.addToCart.UseVisualStyleBackColor = true;
            this.addToCart.Click += new System.EventHandler(this.AddToCartButton_Click);
            // 
            // productPanel
            // 
            this.productPanel.AutoSize = true;
            this.productPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.productPanel.Controls.Add(this.manuf);
            this.productPanel.Controls.Add(this.pictureBox);
            this.productPanel.Controls.Add(this.desc);
            this.productPanel.Controls.Add(this.addToCart);
            this.productPanel.Controls.Add(this.priceLabel);
            this.productPanel.Controls.Add(this.nameLabel);
            this.productPanel.Location = new System.Drawing.Point(10, 10);
            this.productPanel.Name = "productPanel";
            this.productPanel.Size = new System.Drawing.Size(632, 465);
            this.productPanel.TabIndex = 0;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(10, 10);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(150, 150);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 6;
            this.pictureBox.TabStop = false;
            // 
            // desc
            // 
            this.desc.AutoSize = true;
            this.desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.desc.Location = new System.Drawing.Point(6, 195);
            this.desc.Name = "desc";
            this.desc.Size = new System.Drawing.Size(60, 24);
            this.desc.TabIndex = 4;
            this.desc.Text = "label1";
            // 
            // manuf
            // 
            this.manuf.AutoSize = true;
            this.manuf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.manuf.Location = new System.Drawing.Point(197, 71);
            this.manuf.Name = "manuf";
            this.manuf.Size = new System.Drawing.Size(62, 24);
            this.manuf.TabIndex = 7;
            this.manuf.Text = "manuf";
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(241)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(654, 487);
            this.Controls.Add(this.productPanel);
            this.Name = "ProductsForm";
            this.Text = "ProductsForm";
            this.productPanel.ResumeLayout(false);
            this.productPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Button addToCart;
        private System.Windows.Forms.Panel productPanel;
        private System.Windows.Forms.Label desc;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label manuf;
    }
}