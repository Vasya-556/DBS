namespace lab9
{
    partial class SignUp_Form
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
            this.Password1_Textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Login_Textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SignUp_Button = new System.Windows.Forms.Button();
            this.Back_Button = new System.Windows.Forms.Button();
            this.Email_Textbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Address_Textbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Password2_Textbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Password1_Textbox
            // 
            this.Password1_Textbox.Location = new System.Drawing.Point(15, 72);
            this.Password1_Textbox.Name = "Password1_Textbox";
            this.Password1_Textbox.PasswordChar = '*';
            this.Password1_Textbox.Size = new System.Drawing.Size(100, 22);
            this.Password1_Textbox.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Password";
            // 
            // Login_Textbox
            // 
            this.Login_Textbox.Location = new System.Drawing.Point(15, 28);
            this.Login_Textbox.Name = "Login_Textbox";
            this.Login_Textbox.Size = new System.Drawing.Size(100, 22);
            this.Login_Textbox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Login";
            // 
            // SignUp_Button
            // 
            this.SignUp_Button.Location = new System.Drawing.Point(15, 236);
            this.SignUp_Button.Name = "SignUp_Button";
            this.SignUp_Button.Size = new System.Drawing.Size(75, 23);
            this.SignUp_Button.TabIndex = 10;
            this.SignUp_Button.Text = "Sign up";
            this.SignUp_Button.UseVisualStyleBackColor = true;
            this.SignUp_Button.Click += new System.EventHandler(this.SignUp_Button_Click);
            // 
            // Back_Button
            // 
            this.Back_Button.Location = new System.Drawing.Point(15, 265);
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.Size = new System.Drawing.Size(75, 23);
            this.Back_Button.TabIndex = 11;
            this.Back_Button.Text = "Button";
            this.Back_Button.UseVisualStyleBackColor = true;
            this.Back_Button.Click += new System.EventHandler(this.Back_Button_Click);
            // 
            // Email_Textbox
            // 
            this.Email_Textbox.Location = new System.Drawing.Point(15, 163);
            this.Email_Textbox.Name = "Email_Textbox";
            this.Email_Textbox.Size = new System.Drawing.Size(100, 22);
            this.Email_Textbox.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Email";
            // 
            // Address_Textbox
            // 
            this.Address_Textbox.Location = new System.Drawing.Point(15, 208);
            this.Address_Textbox.Name = "Address_Textbox";
            this.Address_Textbox.Size = new System.Drawing.Size(100, 22);
            this.Address_Textbox.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Address";
            // 
            // Password2_Textbox
            // 
            this.Password2_Textbox.Location = new System.Drawing.Point(15, 116);
            this.Password2_Textbox.Name = "Password2_Textbox";
            this.Password2_Textbox.PasswordChar = '*';
            this.Password2_Textbox.Size = new System.Drawing.Size(100, 22);
            this.Password2_Textbox.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Repeat password";
            // 
            // SignUp_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 294);
            this.Controls.Add(this.Password2_Textbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Address_Textbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Email_Textbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Back_Button);
            this.Controls.Add(this.SignUp_Button);
            this.Controls.Add(this.Password1_Textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Login_Textbox);
            this.Controls.Add(this.label1);
            this.Name = "SignUp_Form";
            this.Text = "Welcome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Password1_Textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Login_Textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SignUp_Button;
        private System.Windows.Forms.Button Back_Button;
        private System.Windows.Forms.TextBox Email_Textbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Address_Textbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Password2_Textbox;
        private System.Windows.Forms.Label label5;
    }
}