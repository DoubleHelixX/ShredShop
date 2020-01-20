namespace ShredShop
{
    partial class Confirmation
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
            this.thankyou = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logoPicBox = new System.Windows.Forms.PictureBox();
            this.ordernumLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // thankyou
            // 
            this.thankyou.AutoSize = true;
            this.thankyou.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.thankyou.Font = new System.Drawing.Font("Modi Thorson Italic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thankyou.ForeColor = System.Drawing.Color.White;
            this.thankyou.Image = global::ShredShop.Properties.Resources.aboutUs2;
            this.thankyou.Location = new System.Drawing.Point(434, 366);
            this.thankyou.Name = "thankyou";
            this.thankyou.Size = new System.Drawing.Size(209, 25);
            this.thankyou.TabIndex = 23;
            this.thankyou.Text = "You Rock ;)";
            this.thankyou.Click += new System.EventHandler(this.OrdernumLbl_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::ShredShop.Properties.Resources.ezgif_com_gif_maker__2_;
            this.pictureBox1.Location = new System.Drawing.Point(328, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(480, 270);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // logoPicBox
            // 
            this.logoPicBox.BackColor = System.Drawing.Color.Transparent;
            this.logoPicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logoPicBox.Image = global::ShredShop.Properties.Resources.logoMock1;
            this.logoPicBox.Location = new System.Drawing.Point(12, 125);
            this.logoPicBox.Name = "logoPicBox";
            this.logoPicBox.Size = new System.Drawing.Size(456, 211);
            this.logoPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPicBox.TabIndex = 26;
            this.logoPicBox.TabStop = false;
            // 
            // ordernumLbl
            // 
            this.ordernumLbl.AutoSize = true;
            this.ordernumLbl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ordernumLbl.Font = new System.Drawing.Font("Modi Thorson Italic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordernumLbl.ForeColor = System.Drawing.Color.White;
            this.ordernumLbl.Image = global::ShredShop.Properties.Resources.aboutUs2;
            this.ordernumLbl.Location = new System.Drawing.Point(269, 322);
            this.ordernumLbl.Name = "ordernumLbl";
            this.ordernumLbl.Size = new System.Drawing.Size(539, 25);
            this.ordernumLbl.TabIndex = 27;
            this.ordernumLbl.Text = "Order Number: efwegw334rfr";
            this.ordernumLbl.Click += new System.EventHandler(this.OrdernumLbl_Click_1);
            // 
            // Confirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ShredShop.Properties.Resources.backgroundGradient3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1013, 589);
            this.Controls.Add(this.ordernumLbl);
            this.Controls.Add(this.logoPicBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.thankyou);
            this.DoubleBuffered = true;
            this.Name = "Confirmation";
            this.Text = "Confirmation";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label thankyou;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox logoPicBox;
        private System.Windows.Forms.Label ordernumLbl;
    }
}