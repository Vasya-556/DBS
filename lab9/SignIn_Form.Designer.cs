namespace lab9
{
    partial class SignIn_Form
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
            this.SignIn_Button = new System.Windows.Forms.Button();
            this.Login_Textbox = new System.Windows.Forms.TextBox();
            this.SignUp_Button = new System.Windows.Forms.Button();
            this.Password_Textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // SignIn_Button
            // 
            this.SignIn_Button.Location = new System.Drawing.Point(15, 105);
            this.SignIn_Button.Name = "SignIn_Button";
            this.SignIn_Button.Size = new System.Drawing.Size(75, 23);
            this.SignIn_Button.TabIndex = 1;
            this.SignIn_Button.Text = "Sign in";
            this.SignIn_Button.UseVisualStyleBackColor = true;
            this.SignIn_Button.Click += new System.EventHandler(this.SignIn_Button_Click);
            // 
            // Login_Textbox
            // 
            this.Login_Textbox.Location = new System.Drawing.Point(15, 28);
            this.Login_Textbox.Name = "Login_Textbox";
            this.Login_Textbox.Size = new System.Drawing.Size(100, 22);
            this.Login_Textbox.TabIndex = 2;
            // 
            // SignUp_Button
            // 
            this.SignUp_Button.Location = new System.Drawing.Point(15, 134);
            this.SignUp_Button.Name = "SignUp_Button";
            this.SignUp_Button.Size = new System.Drawing.Size(75, 23);
            this.SignUp_Button.TabIndex = 3;
            this.SignUp_Button.Text = "Sign up";
            this.SignUp_Button.UseVisualStyleBackColor = true;
            this.SignUp_Button.Click += new System.EventHandler(this.SignUp_Button_Click);
            // 
            // Password_Textbox
            // 
            this.Password_Textbox.Location = new System.Drawing.Point(15, 77);
            this.Password_Textbox.Name = "Password_Textbox";
            this.Password_Textbox.PasswordChar = '*';
            this.Password_Textbox.Size = new System.Drawing.Size(100, 22);
            this.Password_Textbox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // SignIn_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 171);
            this.Controls.Add(this.Password_Textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SignUp_Button);
            this.Controls.Add(this.Login_Textbox);
            this.Controls.Add(this.SignIn_Button);
            this.Controls.Add(this.label1);
            this.Name = "SignIn_Form";
            this.Text = "Welcome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SignIn_Button;
        private System.Windows.Forms.TextBox Login_Textbox;
        private System.Windows.Forms.Button SignUp_Button;
        private System.Windows.Forms.TextBox Password_Textbox;
        private System.Windows.Forms.Label label2;
    }
}

