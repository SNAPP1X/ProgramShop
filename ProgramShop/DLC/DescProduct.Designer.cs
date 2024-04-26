namespace ProgramShop.DLC
{
    partial class DescProduct
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
            this.buy_btn = new System.Windows.Forms.Button();
            this.info_lb = new System.Windows.Forms.Label();
            this.name_lb = new System.Windows.Forms.Label();
            this.pic_prod = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_prod)).BeginInit();
            this.SuspendLayout();
            // 
            // buy_btn
            // 
            this.buy_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buy_btn.Font = new System.Drawing.Font("Garamond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buy_btn.Location = new System.Drawing.Point(216, 94);
            this.buy_btn.Name = "buy_btn";
            this.buy_btn.Size = new System.Drawing.Size(97, 39);
            this.buy_btn.TabIndex = 11;
            this.buy_btn.Text = "Buy";
            this.buy_btn.UseVisualStyleBackColor = false;
            // 
            // info_lb
            // 
            this.info_lb.AutoSize = true;
            this.info_lb.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.info_lb.Location = new System.Drawing.Point(13, 162);
            this.info_lb.Name = "info_lb";
            this.info_lb.Size = new System.Drawing.Size(108, 24);
            this.info_lb.TabIndex = 10;
            this.info_lb.Text = "Description";
            // 
            // name_lb
            // 
            this.name_lb.AutoSize = true;
            this.name_lb.Font = new System.Drawing.Font("Garamond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_lb.Location = new System.Drawing.Point(211, 13);
            this.name_lb.Name = "name_lb";
            this.name_lb.Size = new System.Drawing.Size(70, 27);
            this.name_lb.TabIndex = 9;
            this.name_lb.Text = "Name";
            // 
            // pic_prod
            // 
            this.pic_prod.Location = new System.Drawing.Point(12, 12);
            this.pic_prod.Name = "pic_prod";
            this.pic_prod.Size = new System.Drawing.Size(138, 121);
            this.pic_prod.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_prod.TabIndex = 8;
            this.pic_prod.TabStop = false;
            // 
            // DescProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(241)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(638, 448);
            this.Controls.Add(this.buy_btn);
            this.Controls.Add(this.info_lb);
            this.Controls.Add(this.name_lb);
            this.Controls.Add(this.pic_prod);
            this.Name = "DescProduct";
            this.Text = "DescProduct";
            ((System.ComponentModel.ISupportInitialize)(this.pic_prod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buy_btn;
        private System.Windows.Forms.Label info_lb;
        private System.Windows.Forms.Label name_lb;
        private System.Windows.Forms.PictureBox pic_prod;
    }
}