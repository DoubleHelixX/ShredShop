namespace ShredShop
{
    partial class SignIn
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
            this.signUpLbl = new System.Windows.Forms.Label();
            this.logInBtn = new System.Windows.Forms.Button();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.usernameLbl = new System.Windows.Forms.Label();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.usernameTxt = new System.Windows.Forms.TextBox();
            this.logoPicBox = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.forgotPassLbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.volPicBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // signUpLbl
            // 
            this.signUpLbl.AutoSize = true;
            this.signUpLbl.BackColor = System.Drawing.Color.Transparent;
            this.signUpLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.signUpLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpLbl.ForeColor = System.Drawing.Color.White;
            this.signUpLbl.Location = new System.Drawing.Point(683, 444);
            this.signUpLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.signUpLbl.Name = "signUpLbl";
            this.signUpLbl.Size = new System.Drawing.Size(79, 26);
            this.signUpLbl.TabIndex = 14;
            this.signUpLbl.Text = "Sign Up";
            this.signUpLbl.Click += new System.EventHandler(this.SignUpLbl_Click);
            // 
            // logInBtn
            // 
            this.logInBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInBtn.ForeColor = System.Drawing.Color.Transparent;
            this.logInBtn.Image = global::ShredShop.Properties.Resources.s_c_background;
            this.logInBtn.Location = new System.Drawing.Point(581, 406);
            this.logInBtn.Margin = new System.Windows.Forms.Padding(4);
            this.logInBtn.Name = "logInBtn";
            this.logInBtn.Size = new System.Drawing.Size(171, 34);
            this.logInBtn.TabIndex = 13;
            this.logInBtn.Text = "Log In";
            this.logInBtn.UseVisualStyleBackColor = true;
            this.logInBtn.Click += new System.EventHandler(this.LogInBtn_Click);
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.passwordLbl.Image = global::ShredShop.Properties.Resources.s_c_background;
            this.passwordLbl.Location = new System.Drawing.Point(444, 336);
            this.passwordLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(126, 29);
            this.passwordLbl.TabIndex = 11;
            this.passwordLbl.Text = "Password:";
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.usernameLbl.Image = global::ShredShop.Properties.Resources.s_c_background;
            this.usernameLbl.Location = new System.Drawing.Point(451, 304);
            this.usernameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(135, 29);
            this.usernameLbl.TabIndex = 10;
            this.usernameLbl.Text = "UserName:";
            this.usernameLbl.Click += new System.EventHandler(this.usernameLbl_Click);
            // 
            // passwordTxt
            // 
            this.passwordTxt.Location = new System.Drawing.Point(667, 334);
            this.passwordTxt.Margin = new System.Windows.Forms.Padding(4);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(197, 22);
            this.passwordTxt.TabIndex = 9;
            // 
            // usernameTxt
            // 
            this.usernameTxt.Location = new System.Drawing.Point(667, 302);
            this.usernameTxt.Margin = new System.Windows.Forms.Padding(4);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(197, 22);
            this.usernameTxt.TabIndex = 8;
            this.usernameTxt.TextChanged += new System.EventHandler(this.usernameTxt_TextChanged);
            // 
            // logoPicBox
            // 
            this.logoPicBox.BackColor = System.Drawing.Color.Transparent;
            this.logoPicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logoPicBox.Image = global::ShredShop.Properties.Resources.logoMock1;
            this.logoPicBox.Location = new System.Drawing.Point(333, 41);
            this.logoPicBox.Margin = new System.Windows.Forms.Padding(4);
            this.logoPicBox.Name = "logoPicBox";
            this.logoPicBox.Size = new System.Drawing.Size(608, 260);
            this.logoPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPicBox.TabIndex = 12;
            this.logoPicBox.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::ShredShop.Properties.Resources.grind_for_life2;
            this.pictureBox2.Location = new System.Drawing.Point(796, 185);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(261, 116);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // forgotPassLbl
            // 
            this.forgotPassLbl.AutoSize = true;
            this.forgotPassLbl.BackColor = System.Drawing.Color.Transparent;
            this.forgotPassLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.forgotPassLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgotPassLbl.ForeColor = System.Drawing.Color.White;
            this.forgotPassLbl.Location = new System.Drawing.Point(539, 382);
            this.forgotPassLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.forgotPassLbl.Name = "forgotPassLbl";
            this.forgotPassLbl.Size = new System.Drawing.Size(154, 26);
            this.forgotPassLbl.TabIndex = 17;
            this.forgotPassLbl.Text = "Forgot Password";
            this.forgotPassLbl.Click += new System.EventHandler(this.ForgotPassLbl_Click);
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
            this.volPicBox.Location = new System.Drawing.Point(161, 119);
            this.volPicBox.Margin = new System.Windows.Forms.Padding(4);
            this.volPicBox.Name = "volPicBox";
            this.volPicBox.Size = new System.Drawing.Size(51, 42);
            this.volPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.volPicBox.TabIndex = 19;
            this.volPicBox.TabStop = false;
            this.volPicBox.Click += new System.EventHandler(this.volPicBox_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Image = global::ShredShop.Properties.Resources.s_c_background;
            this.button1.Location = new System.Drawing.Point(697, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 34);
            this.button1.TabIndex = 20;
            this.button1.Text = "payment page";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Image = global::ShredShop.Properties.Resources.s_c_background;
            this.button2.Location = new System.Drawing.Point(876, 15);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(227, 34);
            this.button2.TabIndex = 21;
            this.button2.Text = "confirmation page";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Transparent;
            this.button3.Image = global::ShredShop.Properties.Resources.s_c_background;
            this.button3.Location = new System.Drawing.Point(1111, 15);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(171, 34);
            this.button3.TabIndex = 22;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ShredShop.Properties.Resources.backgroundGradient3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1331, 704);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.volPicBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.forgotPassLbl);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.signUpLbl);
            this.Controls.Add(this.logInBtn);
            this.Controls.Add(this.logoPicBox);
            this.Controls.Add(this.passwordLbl);
            this.Controls.Add(this.usernameLbl);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.usernameTxt);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SignIn";
            this.Text = "Sign In";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label signUpLbl;
        private System.Windows.Forms.Button logInBtn;
        private System.Windows.Forms.PictureBox logoPicBox;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.Label usernameLbl;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.TextBox usernameTxt;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label forgotPassLbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox volPicBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

