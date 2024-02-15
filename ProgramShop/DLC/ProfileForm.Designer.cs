namespace ProgramShop
{
    partial class ProfileForm
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
            this.name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lvl_lb = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bought_lb = new System.Windows.Forms.Label();
            this.avatar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.Location = new System.Drawing.Point(180, 103);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(60, 24);
            this.name.TabIndex = 1;
            this.name.Text = "Name";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(398, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Profile level";
            // 
            // lvl_lb
            // 
            this.lvl_lb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lvl_lb.AutoSize = true;
            this.lvl_lb.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lvl_lb.Location = new System.Drawing.Point(513, 103);
            this.lvl_lb.Name = "lvl_lb";
            this.lvl_lb.Size = new System.Drawing.Size(20, 24);
            this.lvl_lb.TabIndex = 3;
            this.lvl_lb.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(180, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Bought";
            // 
            // bought_lb
            // 
            this.bought_lb.AutoSize = true;
            this.bought_lb.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bought_lb.Location = new System.Drawing.Point(256, 152);
            this.bought_lb.Name = "bought_lb";
            this.bought_lb.Size = new System.Drawing.Size(20, 24);
            this.bought_lb.TabIndex = 6;
            this.bought_lb.Text = "0";
            // 
            // avatar
            // 
            this.avatar.Location = new System.Drawing.Point(68, 103);
            this.avatar.Name = "avatar";
            this.avatar.Size = new System.Drawing.Size(90, 90);
            this.avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avatar.TabIndex = 7;
            this.avatar.TabStop = false;
            this.avatar.Click += new System.EventHandler(this.avatar_Click);
            this.avatar.MouseEnter += new System.EventHandler(this.avatar_MouseEnter);
            this.avatar.MouseLeave += new System.EventHandler(this.avatar_MouseLeave);
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(241)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(670, 526);
            this.Controls.Add(this.avatar);
            this.Controls.Add(this.bought_lb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lvl_lb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProfileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProfileForm";
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lvl_lb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label bought_lb;
        private System.Windows.Forms.PictureBox avatar;
    }
}