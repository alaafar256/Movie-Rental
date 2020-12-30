namespace WindowsFormsApp1
{
    partial class UserInterface
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
            this.Table_UserInterface = new System.Windows.Forms.DataGridView();
            this.Browse_UserInterface_button = new System.Windows.Forms.Button();
            this.Rent_UserInterface_button = new System.Windows.Forms.Button();
            this.RentedMovie_UserInterface_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Year_UserInterface_button = new System.Windows.Forms.Button();
            this.Filter_UserInterface_textbox = new System.Windows.Forms.TextBox();
            this.Name_UserInterface_button = new System.Windows.Forms.Button();
            this.Category_UserInterface_button = new System.Windows.Forms.Button();
            this.Rate_UserInterface_button = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.MyProfile_UserInterface_button = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.CreditCard_UserInterface_radiobutton = new System.Windows.Forms.RadioButton();
            this.PayPal_UserInterface_radiobutton = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.Date_UserInterface = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Table_UserInterface)).BeginInit();
            this.SuspendLayout();
            // 
            // Table_UserInterface
            // 
            this.Table_UserInterface.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table_UserInterface.Location = new System.Drawing.Point(394, 9);
            this.Table_UserInterface.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Table_UserInterface.Name = "Table_UserInterface";
            this.Table_UserInterface.Size = new System.Drawing.Size(541, 596);
            this.Table_UserInterface.TabIndex = 0;
            // 
            // Browse_UserInterface_button
            // 
            this.Browse_UserInterface_button.Location = new System.Drawing.Point(61, 63);
            this.Browse_UserInterface_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Browse_UserInterface_button.Name = "Browse_UserInterface_button";
            this.Browse_UserInterface_button.Size = new System.Drawing.Size(192, 28);
            this.Browse_UserInterface_button.TabIndex = 1;
            this.Browse_UserInterface_button.Text = "Browse";
            this.Browse_UserInterface_button.UseVisualStyleBackColor = true;
            this.Browse_UserInterface_button.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Rent_UserInterface_button
            // 
            this.Rent_UserInterface_button.Location = new System.Drawing.Point(59, 324);
            this.Rent_UserInterface_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Rent_UserInterface_button.Name = "Rent_UserInterface_button";
            this.Rent_UserInterface_button.Size = new System.Drawing.Size(87, 28);
            this.Rent_UserInterface_button.TabIndex = 2;
            this.Rent_UserInterface_button.Text = "Rent";
            this.Rent_UserInterface_button.UseVisualStyleBackColor = true;
            // 
            // RentedMovie_UserInterface_textbox
            // 
            this.RentedMovie_UserInterface_textbox.Location = new System.Drawing.Point(59, 162);
            this.RentedMovie_UserInterface_textbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RentedMovie_UserInterface_textbox.Name = "RentedMovie_UserInterface_textbox";
            this.RentedMovie_UserInterface_textbox.Size = new System.Drawing.Size(192, 24);
            this.RentedMovie_UserInterface_textbox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter Movie you want to rent :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "------------------------------------------------------";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 356);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(278, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "------------------------------------------------------";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(278, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "------------------------------------------------------";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 383);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Enter filter:";
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // Year_UserInterface_button
            // 
            this.Year_UserInterface_button.Location = new System.Drawing.Point(64, 465);
            this.Year_UserInterface_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Year_UserInterface_button.Name = "Year_UserInterface_button";
            this.Year_UserInterface_button.Size = new System.Drawing.Size(85, 28);
            this.Year_UserInterface_button.TabIndex = 10;
            this.Year_UserInterface_button.Text = "Year";
            this.Year_UserInterface_button.UseVisualStyleBackColor = true;
            this.Year_UserInterface_button.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Filter_UserInterface_textbox
            // 
            this.Filter_UserInterface_textbox.Location = new System.Drawing.Point(62, 402);
            this.Filter_UserInterface_textbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Filter_UserInterface_textbox.Name = "Filter_UserInterface_textbox";
            this.Filter_UserInterface_textbox.Size = new System.Drawing.Size(189, 24);
            this.Filter_UserInterface_textbox.TabIndex = 11;
            this.Filter_UserInterface_textbox.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // Name_UserInterface_button
            // 
            this.Name_UserInterface_button.Location = new System.Drawing.Point(161, 465);
            this.Name_UserInterface_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name_UserInterface_button.Name = "Name_UserInterface_button";
            this.Name_UserInterface_button.Size = new System.Drawing.Size(93, 28);
            this.Name_UserInterface_button.TabIndex = 12;
            this.Name_UserInterface_button.Text = "Name";
            this.Name_UserInterface_button.UseVisualStyleBackColor = true;
            // 
            // Category_UserInterface_button
            // 
            this.Category_UserInterface_button.Location = new System.Drawing.Point(64, 512);
            this.Category_UserInterface_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Category_UserInterface_button.Name = "Category_UserInterface_button";
            this.Category_UserInterface_button.Size = new System.Drawing.Size(85, 28);
            this.Category_UserInterface_button.TabIndex = 13;
            this.Category_UserInterface_button.Text = "Category";
            this.Category_UserInterface_button.UseVisualStyleBackColor = true;
            // 
            // Rate_UserInterface_button
            // 
            this.Rate_UserInterface_button.Location = new System.Drawing.Point(161, 512);
            this.Rate_UserInterface_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Rate_UserInterface_button.Name = "Rate_UserInterface_button";
            this.Rate_UserInterface_button.Size = new System.Drawing.Size(93, 28);
            this.Rate_UserInterface_button.TabIndex = 14;
            this.Rate_UserInterface_button.Text = "Rate";
            this.Rate_UserInterface_button.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 431);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Filter by";
            this.label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(61, 544);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(278, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "------------------------------------------------------";
            // 
            // MyProfile_UserInterface_button
            // 
            this.MyProfile_UserInterface_button.Location = new System.Drawing.Point(64, 577);
            this.MyProfile_UserInterface_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MyProfile_UserInterface_button.Name = "MyProfile_UserInterface_button";
            this.MyProfile_UserInterface_button.Size = new System.Drawing.Size(192, 28);
            this.MyProfile_UserInterface_button.TabIndex = 17;
            this.MyProfile_UserInterface_button.Text = "My Profile";
            this.MyProfile_UserInterface_button.UseVisualStyleBackColor = true;
            this.MyProfile_UserInterface_button.Click += new System.EventHandler(this.Button7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(61, 609);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(278, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "------------------------------------------------------";
            // 
            // CreditCard_UserInterface_radiobutton
            // 
            this.CreditCard_UserInterface_radiobutton.AutoSize = true;
            this.CreditCard_UserInterface_radiobutton.Location = new System.Drawing.Point(61, 210);
            this.CreditCard_UserInterface_radiobutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CreditCard_UserInterface_radiobutton.Name = "CreditCard_UserInterface_radiobutton";
            this.CreditCard_UserInterface_radiobutton.Size = new System.Drawing.Size(98, 21);
            this.CreditCard_UserInterface_radiobutton.TabIndex = 19;
            this.CreditCard_UserInterface_radiobutton.TabStop = true;
            this.CreditCard_UserInterface_radiobutton.Text = "Credit Card";
            this.CreditCard_UserInterface_radiobutton.UseVisualStyleBackColor = true;
            // 
            // PayPal_UserInterface_radiobutton
            // 
            this.PayPal_UserInterface_radiobutton.AutoSize = true;
            this.PayPal_UserInterface_radiobutton.Location = new System.Drawing.Point(61, 240);
            this.PayPal_UserInterface_radiobutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PayPal_UserInterface_radiobutton.Name = "PayPal_UserInterface_radiobutton";
            this.PayPal_UserInterface_radiobutton.Size = new System.Drawing.Size(69, 21);
            this.PayPal_UserInterface_radiobutton.TabIndex = 20;
            this.PayPal_UserInterface_radiobutton.TabStop = true;
            this.PayPal_UserInterface_radiobutton.Text = "PayPal";
            this.PayPal_UserInterface_radiobutton.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(57, 191);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(188, 17);
            this.label9.TabIndex = 22;
            this.label9.Text = "Choose Method of Payment :";
            // 
            // Date_UserInterface
            // 
            this.Date_UserInterface.Location = new System.Drawing.Point(59, 289);
            this.Date_UserInterface.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Date_UserInterface.Name = "Date_UserInterface";
            this.Date_UserInterface.Size = new System.Drawing.Size(192, 24);
            this.Date_UserInterface.TabIndex = 23;
            this.Date_UserInterface.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(61, 270);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 17);
            this.label10.TabIndex = 24;
            this.label10.Text = "Time :";
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 651);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Date_UserInterface);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.PayPal_UserInterface_radiobutton);
            this.Controls.Add(this.CreditCard_UserInterface_radiobutton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.MyProfile_UserInterface_button);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Rate_UserInterface_button);
            this.Controls.Add(this.Category_UserInterface_button);
            this.Controls.Add(this.Name_UserInterface_button);
            this.Controls.Add(this.Filter_UserInterface_textbox);
            this.Controls.Add(this.Year_UserInterface_button);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RentedMovie_UserInterface_textbox);
            this.Controls.Add(this.Rent_UserInterface_button);
            this.Controls.Add(this.Browse_UserInterface_button);
            this.Controls.Add(this.Table_UserInterface);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UserInterface";
            this.Text = "UserInterface";
            ((System.ComponentModel.ISupportInitialize)(this.Table_UserInterface)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Table_UserInterface;
        private System.Windows.Forms.Button Browse_UserInterface_button;
        private System.Windows.Forms.Button Rent_UserInterface_button;
        private System.Windows.Forms.TextBox RentedMovie_UserInterface_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Year_UserInterface_button;
        private System.Windows.Forms.TextBox Filter_UserInterface_textbox;
        private System.Windows.Forms.Button Name_UserInterface_button;
        private System.Windows.Forms.Button Category_UserInterface_button;
        private System.Windows.Forms.Button Rate_UserInterface_button;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button MyProfile_UserInterface_button;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton CreditCard_UserInterface_radiobutton;
        private System.Windows.Forms.RadioButton PayPal_UserInterface_radiobutton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker Date_UserInterface;
        private System.Windows.Forms.Label label10;
    }
}