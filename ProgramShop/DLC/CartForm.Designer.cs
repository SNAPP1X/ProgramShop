namespace ProgramShop.DLC
{
    partial class CartForm
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
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.cartListView1 = new System.Windows.Forms.ListView();
            this.totalPriceLabel1 = new System.Windows.Forms.Label();
            this.removeFromCartBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(64, 64);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // cartListView1
            // 
            this.cartListView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.cartListView1.HideSelection = false;
            this.cartListView1.LargeImageList = this.imageList1;
            this.cartListView1.Location = new System.Drawing.Point(0, 0);
            this.cartListView1.Name = "cartListView1";
            this.cartListView1.Size = new System.Drawing.Size(654, 300);
            this.cartListView1.TabIndex = 0;
            this.cartListView1.UseCompatibleStateImageBehavior = false;
            // 
            // totalPriceLabel1
            // 
            this.totalPriceLabel1.AutoSize = true;
            this.totalPriceLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.totalPriceLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalPriceLabel1.Location = new System.Drawing.Point(0, 300);
            this.totalPriceLabel1.Name = "totalPriceLabel1";
            this.totalPriceLabel1.Size = new System.Drawing.Size(104, 20);
            this.totalPriceLabel1.TabIndex = 1;
            this.totalPriceLabel1.Text = "Total: $0.00";
            // 
            // removeFromCartBtn
            // 
            this.removeFromCartBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.removeFromCartBtn.Location = new System.Drawing.Point(0, 320);
            this.removeFromCartBtn.Name = "removeFromCartBtn";
            this.removeFromCartBtn.Size = new System.Drawing.Size(654, 23);
            this.removeFromCartBtn.TabIndex = 2;
            this.removeFromCartBtn.Text = "Remove from Cart";
            this.removeFromCartBtn.UseVisualStyleBackColor = true;
            this.removeFromCartBtn.Click += new System.EventHandler(this.RemoveFromCartButton_Click);
            // 
            // CartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(241)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(654, 487);
            this.Controls.Add(this.removeFromCartBtn);
            this.Controls.Add(this.totalPriceLabel1);
            this.Controls.Add(this.cartListView1);
            this.Name = "CartForm";
            this.Text = "Корзина";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListView cartListView1;
        private System.Windows.Forms.Label totalPriceLabel1;
        private System.Windows.Forms.Button removeFromCartBtn;
    }
}