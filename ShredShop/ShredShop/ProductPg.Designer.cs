namespace ShredShop
{
    partial class ProductPg
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
            this.logoPicBox = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.volPicBox = new System.Windows.Forms.PictureBox();
            this.signInBtn = new System.Windows.Forms.Label();
            this.registerBtn = new System.Windows.Forms.Label();
            this.panels = new System.Windows.Forms.Panel[12];
            for(int i = 0; i < 12; i++)
            {
                this.panels[i] = new System.Windows.Forms.Panel();
            }
            ((System.ComponentModel.ISupportInitialize)(this.logoPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volPicBox)).BeginInit();
            foreach (System.Windows.Forms.Panel panel in panels)
            {
                panel.SuspendLayout();
            }
            this.SuspendLayout();
            // 
            // logoPicBox
            // 
            this.logoPicBox.BackColor = System.Drawing.Color.Transparent;
            this.logoPicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logoPicBox.Image = global::ShredShop.Properties.Resources.logoMock1;
            this.logoPicBox.Location = new System.Drawing.Point(-112, -23);
            this.logoPicBox.Margin = new System.Windows.Forms.Padding(4);
            this.logoPicBox.Name = "logoPicBox";
            this.logoPicBox.Size = new System.Drawing.Size(434, 184);
            this.logoPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPicBox.TabIndex = 12;
            this.logoPicBox.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::ShredShop.Properties.Resources.grind_for_life2;
            this.pictureBox2.Location = new System.Drawing.Point(175, 1);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(261, 116);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-31, -57);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 62);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // volPicBox
            // 
            this.volPicBox.BackColor = System.Drawing.Color.Transparent;
            this.volPicBox.Image = global::ShredShop.Properties.Resources.volOn;
            this.volPicBox.Location = new System.Drawing.Point(4, 169);
            this.volPicBox.Margin = new System.Windows.Forms.Padding(4);
            this.volPicBox.Name = "volPicBox";
            this.volPicBox.Size = new System.Drawing.Size(51, 42);
            this.volPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.volPicBox.TabIndex = 19;
            this.volPicBox.TabStop = false;
            this.volPicBox.Click += new System.EventHandler(this.volPicBox_Click);
            // 
            // signInBtn
            // 
            this.signInBtn.AutoSize = true;
            this.signInBtn.BackColor = System.Drawing.Color.Transparent;
            this.signInBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.signInBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signInBtn.ForeColor = System.Drawing.Color.White;
            this.signInBtn.Location = new System.Drawing.Point(892, 43);
            this.signInBtn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.signInBtn.Name = "signInBtn";
            this.signInBtn.Size = new System.Drawing.Size(70, 26);
            this.signInBtn.TabIndex = 22;
            this.signInBtn.Text = "Sign In";
            this.signInBtn.Click += new System.EventHandler(this.signInBtn_Click);
            // 
            // registerBtn
            // 
            this.registerBtn.AutoSize = true;
            this.registerBtn.BackColor = System.Drawing.Color.Transparent;
            this.registerBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.registerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerBtn.ForeColor = System.Drawing.Color.White;
            this.registerBtn.Location = new System.Drawing.Point(970, 43);
            this.registerBtn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(81, 26);
            this.registerBtn.TabIndex = 23;
            this.registerBtn.Text = "Register";
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // panel1
            // 
            for (int i = 0; i < 12; i++)
            {
                int x = i % 4;
                int y = i / 4;
                System.Windows.Forms.Panel panel = this.panels[i];
                System.Windows.Forms.Label catogoryLbl = new System.Windows.Forms.Label();
                System.Windows.Forms.Label itemNameLbl = new System.Windows.Forms.Label();
                System.Windows.Forms.Label dollarSignLbl = new System.Windows.Forms.Label();
                System.Windows.Forms.Label priceLbl = new System.Windows.Forms.Label();
                string[] product = database.GetProduct(i + 1);

                panel.BackColor = System.Drawing.Color.FromArgb(0, 0, 0, 0);
                panel.Controls.Add(priceLbl);
                panel.Controls.Add(dollarSignLbl);
                panel.Controls.Add(catogoryLbl);
                panel.Controls.Add(itemNameLbl);
                panel.Location = new System.Drawing.Point(169 + 248 * x, 130 + 150 * y);
                panel.Name = "panel1";
                panel.Size = new System.Drawing.Size(246, 148);
                panel.TabIndex = 24;
                // 
                // catogoryLbl
                // 
                catogoryLbl.AutoSize = true;
                catogoryLbl.ForeColor = System.Drawing.SystemColors.GrayText;
                catogoryLbl.Location = new System.Drawing.Point(137, 130);
                catogoryLbl.Name = "catogoryLbl";
                catogoryLbl.Size = new System.Drawing.Size(73, 17);
                catogoryLbl.TabIndex = 1;
                catogoryLbl.Text = product[1];
                // 
                // itemNameLbl
                // 
                itemNameLbl.AutoSize = true;
                itemNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                itemNameLbl.Location = new System.Drawing.Point(20, 14);
                itemNameLbl.Name = "itemNameLbl";
                itemNameLbl.Size = new System.Drawing.Size(116, 24);
                itemNameLbl.MaximumSize = new System.Drawing.Size(170, 0);
                itemNameLbl.AutoSize = true;
                itemNameLbl.TabIndex = 0;
                itemNameLbl.Text = product[0];
                // 
                // dollarSignLbl
                // 
                dollarSignLbl.AutoSize = true;
                dollarSignLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                dollarSignLbl.ForeColor = System.Drawing.Color.Red;
                dollarSignLbl.Location = new System.Drawing.Point(6, 109);
                dollarSignLbl.Name = "dollarSignLbl";
                dollarSignLbl.Size = new System.Drawing.Size(18, 20);
                dollarSignLbl.TabIndex = 2;
                dollarSignLbl.Text = "$";
                // 
                // priceLbl
                // 
                priceLbl.AutoSize = true;
                priceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                priceLbl.Location = new System.Drawing.Point(24, 109);
                priceLbl.Name = "priceLbl";
                priceLbl.Size = new System.Drawing.Size(48, 17);
                priceLbl.TabIndex = 3;
                priceLbl.Text = product[2];
            }
            // 
            // ProductPg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ShredShop.Properties.Resources.backgroundGradient3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1331, 704);
            foreach (System.Windows.Forms.Panel panel in panels)
            {
                this.Controls.Add(panel);
            }
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.signInBtn);
            this.Controls.Add(this.volPicBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.logoPicBox);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProductPg";
            this.Text = "Our Products";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volPicBox)).EndInit();
            foreach(System.Windows.Forms.Panel panel in panels)
            {
                panel.ResumeLayout(false);
                panel.PerformLayout();
            }
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoPicBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox volPicBox;
        private System.Windows.Forms.Label signInBtn;
        private System.Windows.Forms.Label registerBtn;
        private System.Windows.Forms.Panel[] panels;
    }
}

