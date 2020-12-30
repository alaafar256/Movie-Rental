namespace WindowsFormsApp1
{
    partial class LoginForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.Email_login_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Password_Login_textbox = new System.Windows.Forms.TextBox();
            this.Login_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SignUpLogin_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "E-mail";
            this.label1.Click += new System.EventHandler(this.Label1_Click_1);
            // 
            // Email_login_textbox
            // 
            this.Email_login_textbox.Location = new System.Drawing.Point(154, 106);
            this.Email_login_textbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Email_login_textbox.Name = "Email_login_textbox";
            this.Email_login_textbox.Size = new System.Drawing.Size(116, 24);
            this.Email_login_textbox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // Password_Login_textbox
            // 
            this.Password_Login_textbox.Location = new System.Drawing.Point(154, 159);
            this.Password_Login_textbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Password_Login_textbox.Name = "Password_Login_textbox";
            this.Password_Login_textbox.Size = new System.Drawing.Size(116, 24);
            this.Password_Login_textbox.TabIndex = 3;
            // 
            // Login_button
            // 
            this.Login_button.Location = new System.Drawing.Point(154, 209);
            this.Login_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Login_button.Name = "Login_button";
            this.Login_button.Size = new System.Drawing.Size(87, 28);
            this.Login_button.TabIndex = 4;
            this.Login_button.Text = "Login";
            this.Login_button.UseVisualStyleBackColor = true;
            this.Login_button.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(154, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Don\'t have account?";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // SignUpLogin_button
            // 
            this.SignUpLogin_button.Location = new System.Drawing.Point(154, 292);
            this.SignUpLogin_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SignUpLogin_button.Name = "SignUpLogin_button";
            this.SignUpLogin_button.Size = new System.Drawing.Size(87, 28);
            this.SignUpLogin_button.TabIndex = 6;
            this.SignUpLogin_button.Text = "Sign up";
            this.SignUpLogin_button.UseVisualStyleBackColor = true;
            this.SignUpLogin_button.Click += new System.EventHandler(this.Button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "D:\\salma\\SecondYearSecondTerm\\WindowsFormsApp1";
            this.pictureBox1.Location = new System.Drawing.Point(376, 76);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(262, 277);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 447);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SignUpLogin_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Login_button);
            this.Controls.Add(this.Password_Login_textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Email_login_textbox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Email_login_textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Password_Login_textbox;
        private System.Windows.Forms.Button Login_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SignUpLogin_button;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

